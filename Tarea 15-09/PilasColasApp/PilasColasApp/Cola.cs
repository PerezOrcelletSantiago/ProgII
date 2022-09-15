using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp
{
    class Cola
    {
        private List<string> lista;

        public Cola()
        {
            lista = new List<string>();
        }

        public bool EstaVacia()
        {
            if (lista.Count == 0)
                return true;
            else
                return false;
        }

        public string Primero()
        {
            string cosa = null;
            if (!EstaVacia())
            {
                cosa = lista.First<string>();
            }
            return cosa;
        }

        public void Aniadir(string cosa)
        {  
            lista.Add(cosa);
        }

        public void Extraer()
        {
            lista.Remove(lista.First<string>());
        }

    }
}
