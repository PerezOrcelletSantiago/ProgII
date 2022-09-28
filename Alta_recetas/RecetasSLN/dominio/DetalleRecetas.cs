using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class DetalleRecetas
    {
        private Ingredientes ingrediente;

        public Ingredientes Ingrediente
        {
            get { return ingrediente; }
            set { ingrediente = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public DetalleRecetas()
        {
            ingrediente = new Ingredientes();
            cantidad = 0;
        }

        public DetalleRecetas(Ingredientes ingrediente, int cantidad)
        {
            this.ingrediente = new Ingredientes();
            this.cantidad = cantidad;
        }
    }
}
