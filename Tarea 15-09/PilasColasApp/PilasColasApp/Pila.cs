using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp
{
    class Pila : ICollection
    {
        private int contador;
        private string[] array;

        public Pila(int cant)
        {
            contador = -1;
            array = new string[cant];
        }

        public bool EstaVacia()
        {
            if (contador == -1)
                return true;
            else
                return false;
        }

        public string Primero()
        {
            string cosa = null;
            if (!EstaVacia())
            {
                cosa = array[0];
            }
            return cosa;
        }
        public bool Aniadir(string cosa)
        {
            bool agregado = false;

            if (contador < array.Length)
            {
                array[++contador] = cosa;
                agregado = true;
            }

            return agregado;
        }

        public string Extraer()
        {
            string cosa = null;
            if (!EstaVacia())
            {
                cosa = array[contador];
                array[contador] = null;
                contador--;
            }
            return cosa;
        }

    }
}
