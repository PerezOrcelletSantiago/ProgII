using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacultad
{
    class Asignatura
    {
        private string nombre;

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int codigo;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Asignatura()
        {
            nombre = "";
            codigo = 0;
        }

        public Asignatura(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
