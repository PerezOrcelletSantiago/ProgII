using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacultad
{
    class Carreraa
    {
        private List<DetalleCarrera> lDetalles;

        public List<DetalleCarrera> pDetalles
        {
            get { return lDetalles; }
            set { lDetalles = value; }
        }

        private string nombre;

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string titulo;

        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private int codigo;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private bool disponible;

        public bool pDisponible
        {
            get { return disponible; }
            set { disponible = value; }
        }
        
        public Carreraa()
        {
            nombre = "";
            titulo = "";
            codigo = 0;
            disponible = true;
            lDetalles = new List<DetalleCarrera>();
        }

        public Carreraa(string nombre, string titulo, int codigo, List<DetalleCarrera> lDetalles, bool disponible)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.lDetalles = lDetalles;
            this.titulo = titulo;
            this.disponible = disponible;
        }

        public void AgregarDetalle(DetalleCarrera detalle)
        {
            lDetalles.Add(detalle);
        }

        public void QuitarDetalle(int indiceDet)
        {
            lDetalles.RemoveAt(indiceDet);
        }
        public override string ToString()
        {
            return nombre + " - " + titulo;
        }

    }
}
