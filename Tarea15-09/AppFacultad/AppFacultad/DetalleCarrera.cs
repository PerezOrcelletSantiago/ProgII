using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacultad
{
    class DetalleCarrera
    {
        private int anioCursado;

        public int pAnioCursado
        {
            get { return anioCursado; }
            set { anioCursado = value; }
        }

        private string cuatrimestre;

        public string pCuatrimestre
        {
            get { return cuatrimestre; }
            set { cuatrimestre = value; }
        }

        private Asignatura asignatura;

        public Asignatura pAsignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public DetalleCarrera()
        {
            anioCursado = 0;
            cuatrimestre = "";
            asignatura = new Asignatura();
        }

        public DetalleCarrera(int anioCursado, string cuatrimestre, Asignatura asignatura)
        {
            this.anioCursado = anioCursado;
            this.cuatrimestre = cuatrimestre;
            this.asignatura = asignatura;
        }

        public override string ToString()
        {
            return asignatura + " - " + anioCursado + " - " + cuatrimestre;
        }

    }
}
