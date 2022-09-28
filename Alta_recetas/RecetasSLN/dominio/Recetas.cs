using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Recetas
    {
        List<DetalleRecetas> detalleReceta;

        private int recetaNro;

        public int RecetaNro
        {
            get { return recetaNro; }
            set { recetaNro = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int tipoReceta;

        public int TipoReceta
        {
            get { return tipoReceta; }
            set { tipoReceta = value; }
        }

        private string cheff;

        public string Cheff
        {
            get { return cheff; }
            set { cheff = value; }
        }

        internal List<DetalleRecetas> DetalleReceta { get => detalleReceta; set => detalleReceta = value; }

        public Recetas()
        {
            recetaNro = 0;
            nombre = "";
            tipoReceta = 0;
            cheff = "";
            DetalleReceta = new List<DetalleRecetas>();
        }

        public Recetas(int recetaNro, string nombre,int tipoReceta, string cheff, List<DetalleRecetas> detalleRecetas)
        {
            this.recetaNro = recetaNro;
            this.nombre = nombre;
            this.tipoReceta = tipoReceta;
            this.cheff = cheff;
            this.detalleReceta = new List<DetalleRecetas>();
        }

        public void AgregarDetalle(DetalleRecetas detalle)
        {
            DetalleReceta.Add(detalle);
        }

        public void QuitarDetalle(int index)
        {
            DetalleReceta.RemoveAt(index);
        }
    }
}
