using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasApp
{
    interface ICollection
    {
        bool EstaVacia();

        string Primero();

        string Extraer();

        bool Aniadir(string cosa);
    }
}
