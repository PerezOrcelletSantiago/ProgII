using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Ingredientes
    {
        public int IngredienteID { get; set; }
        public string Nombre { get; set; }
        public int Unidad { get; set; }

        public Ingredientes()
        {
            IngredienteID = 0;
            Nombre = "";
            Unidad = 0;
        }

        public Ingredientes(int IngredienteID, string Nombre, int Unidad)
        {
            this.IngredienteID = IngredienteID;
            this.Nombre = Nombre;
            this.Unidad = Unidad;
        }

        public override string ToString()
        {
            return " Nombre:  " + Nombre;
        }
    }
}
