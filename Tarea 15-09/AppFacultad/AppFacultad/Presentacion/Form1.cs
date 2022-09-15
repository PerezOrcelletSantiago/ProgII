using AppFacultad.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacultad
{

    public partial class Carrera : Form
    {
        AccesoDatos oDB;
        public Carrera()
        {
            InitializeComponent();
            oDB = new AccesoDatos();
        }

        private void Carrera_Load(object sender, EventArgs e)
        {
            CargarLista(Lst1);
            CargarLista2(lst2);
            CargarDgv1();
        }

        private void CargarDgv1()
        {
            DataTable tabla = oDB.selectSQL("SP_TUP_SegundoCuatrimestre");
            dgv1.DataSource = tabla;
        }
        private void CargarLista2(ListBox Lista)
        {
            Lista.Items.Clear();
            DataTable tabla = oDB.selectSQL("SP_TUP_SegundoCuatrimestre");
            foreach (DataRow filaDB in tabla.Rows)
            {
                DetalleCarrera d = new DetalleCarrera();
                d.pAnioCursado = Convert.ToInt32(filaDB["Año Cursado"]);
                d.pCuatrimestre = Convert.ToString(filaDB["cuatrimestre"]);
                Lista.Items.Add(d);
            }
        }

        private void CargarLista(ListBox Lista)
        {
            Lista.Items.Clear();
            DataTable tabla = oDB.selectSQL("SP_TUP_SegundoCuatrimestre");
            foreach (DataRow filaDB in tabla.Rows)
            {
                Asignatura a = new Asignatura();
                a.pNombre = Convert.ToString(filaDB["Asignatura"]);
                Lista.Items.Add(a);
            }

        }

        private void Lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FormAlta Alta = new FormAlta();
        //    Alta.ShowDialog();
        //}

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlta Alta = new FormAlta();
            Alta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificar Modificar = new FormModificar();
            Modificar.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteAsignaturas Reporte = new FormReporteAsignaturas();
            Reporte.ShowDialog();
        }

        private void asignaturasTUP1erSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepoPrimerSem Reporte = new FormRepoPrimerSem();
            Reporte.ShowDialog();
        }
    }
}
