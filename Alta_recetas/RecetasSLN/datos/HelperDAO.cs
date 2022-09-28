using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    class HelperDAO
    {
        string cadena = @"Data Source=NOTESANTI;Initial Catalog = recetas_db; Integrated Security = True";
        SqlCommand cmd;
        SqlConnection conexion;
        private void Conectar()
        {
            conexion = new SqlConnection(cadena);
            cmd = new SqlCommand();
        }

        public DataTable ConsultarIng()
        {
            Conectar();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_INGREDIENTES";
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        public bool Insertar(Recetas receta)
        {
            SqlTransaction tran = null;
            bool ok = true;
            try
            {
                Conectar();
                tran = conexion.BeginTransaction();
                cmd.Connection = conexion;
                cmd.Transaction = tran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SP_INSERTAR_RECETA";
                cmd.Parameters.AddWithValue("@nombre", receta.Nombre);
                cmd.Parameters.AddWithValue("@cheff", receta.Cheff);
                cmd.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);
                cmd.ExecuteNonQuery();
                int contador = 1;
                foreach (DetalleRecetas detalle in receta.DetalleReceta)
                {
                    SqlCommand cmd2 = new SqlCommand("SP_INSERTAR_DETALLE", conexion, tran);
                    cmd2.Parameters.AddWithValue("@id_receta", receta.RecetaNro);
                    cmd2.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IngredienteID);
                    cmd2.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.ExecuteNonQuery();
                    contador++;
                }
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                ok = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return ok;
        }

        public int ProximaReceta()
        {
            int nroID;
            Conectar();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PROXIMO_ID";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id_proximo";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            nroID = Convert.ToInt32(param.Value);
            conexion.Close();
            return nroID;
        }
    }
}
