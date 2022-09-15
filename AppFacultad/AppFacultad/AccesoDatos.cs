using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppFacultad
{
    class AccesoDatos
    {
        string cadena = @"Data Source=NOTESANTI;Initial Catalog=Facultad;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;
        private static AccesoDatos instace;
        private AccesoDatos()
        {
            conexion = new SqlConnection(cadena);
            comando = new SqlCommand();
        }

        public static AccesoDatos ObtenerInstancia()
        {
            if (instace == null)
                instace = new AccesoDatos();
            return instace;
        }
        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
        }

        public void Desconectar()
        {
            conexion.Close();
        }
        
        public DataTable selectSQL(string SP)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public DataTable selectSQL2(string SP, int parm)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_carrera", parm);
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public int UpdateCarreraEstado(string SP, Carreraa upCar)
        {
            int flasAfectadas = 0;
            Conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_carrera", upCar.pCodigo);
            comando.ExecuteNonQuery();
            Desconectar();
            return flasAfectadas;
        }

        public bool InsetCarreraDetalle(string SPmaestro, string SPdetalle, Carreraa nvaCar)
        {
            bool correcto = true;
            SqlTransaction trs = null;
            int codNvaCarrera = 0;
            try
            {
                Conectar();
                trs = conexion.BeginTransaction();
                comando.Transaction = trs;
                comando.CommandText = SPmaestro;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cod_carrera", nvaCar.pCodigo);
                comando.Parameters.AddWithValue("@nombre", nvaCar.pNombre);
                comando.Parameters.AddWithValue("@titulo", nvaCar.pTitulo);
                SqlParameter parmS = new SqlParameter();
                parmS.Direction = ParameterDirection.Output;
                parmS.SqlDbType = SqlDbType.Int;
                parmS.ParameterName = "@cod_carrera_salida";
                comando.Parameters.Add(parmS);
                comando.ExecuteNonQuery();
                codNvaCarrera = Convert.ToInt32(parmS.Value);
                comando.CommandText = SPdetalle;
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < nvaCar.pDetalles.Count; i++)
                {
                    comando.Parameters.AddWithValue("@anio_cursado", nvaCar.pDetalles[i].pAnioCursado);
                    comando.Parameters.AddWithValue("@cuatrimestre", nvaCar.pDetalles[i].pCuatrimestre);
                    comando.Parameters.AddWithValue("@cod_materia", nvaCar.pDetalles[i].pAsignatura.pCodigo);
                    comando.Parameters.AddWithValue("@cod_carrera_salida", codNvaCarrera);
                    //comando.Parameters.AddWithValue("@cod_carrera_salida", nvaCar.pCodigo);
                    comando.ExecuteNonQuery();
                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                correcto = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return correcto;
        }

        public bool UpdateDetalle(Carreraa unaCarrera,string SPDelete, string SPInsert)
        {
            bool correcto = true;
            SqlTransaction trs = null;
            try
            {
                Conectar();
                trs = conexion.BeginTransaction();
                comando.Transaction = trs;
                comando.CommandText = SPDelete;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cod_carrera", unaCarrera.pCodigo);
                comando.ExecuteNonQuery();
                comando.CommandText = SPInsert;
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < unaCarrera.pDetalles.Count; i++)
                {
                    comando.Parameters.AddWithValue("@anio_cursado", unaCarrera.pDetalles[i].pAnioCursado);
                    comando.Parameters.AddWithValue("@cuatrimestre", unaCarrera.pDetalles[i].pCuatrimestre);
                    comando.Parameters.AddWithValue("@cod_materia", unaCarrera.pDetalles[i].pAsignatura.pCodigo);
                    comando.Parameters.AddWithValue("@cod_carrera_salida", unaCarrera.pCodigo);
                    comando.ExecuteNonQuery();
                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                correcto = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return correcto;
        }

        //METODOS SIN TRANSACCION...
        public int InsetCarrera(string SP, Carreraa nvaCar)
        {
            nvaCarrera = 0;
            Conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_carrera", nvaCar.pCodigo);
            comando.Parameters.AddWithValue("@nombre", nvaCar.pNombre);
            comando.Parameters.AddWithValue("@titulo", nvaCar.pTitulo);
            SqlParameter parmS = new SqlParameter();
            parmS.Direction = ParameterDirection.Output;
            parmS.SqlDbType = SqlDbType.Int;
            parmS.ParameterName = "@cod_carrera_salida";
            comando.Parameters.Add(parmS);
            comando.ExecuteNonQuery();
            nvaCarrera = Convert.ToInt32(parmS.Value);
            Desconectar();
            return nvaCarrera;
        }

        int nvaCarrera;
        public int InsertDetalle(string SP, Carreraa nvaCar)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < nvaCar.pDetalles.Count; i++)
            {
                comando.Parameters.AddWithValue("@anio_cursado", nvaCar.pDetalles[i].pAnioCursado);
                comando.Parameters.AddWithValue("@cuatrimestre", nvaCar.pDetalles[i].pCuatrimestre);
                comando.Parameters.AddWithValue("@cod_materia", nvaCar.pDetalles[i].pAsignatura.pCodigo);
                comando.Parameters.AddWithValue("@cod_carrera_salida", nvaCarrera);
                comando.ExecuteNonQuery();
            }
            //foreach (DetalleCarrera det in nvaCar.pDetalles)
            //{
            //    comando.Parameters.AddWithValue("@anio_cursado", det.pAnioCursado);
            //    comando.Parameters.AddWithValue("@cuatrimestre", det.pCuatrimestre);
            //    comando.Parameters.AddWithValue("@cod_materia", det.pAsignatura.pCodigo);
            //    comando.Parameters.AddWithValue("@cod_carrera_salida", nvaCarrera);
            //    comando.ExecuteNonQuery();
            //}
            Desconectar();
            return filasAfectadas;
        }
    }
}
