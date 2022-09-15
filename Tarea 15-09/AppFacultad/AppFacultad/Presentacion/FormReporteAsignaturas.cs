using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacultad.Presentacion
{
    public partial class FormReporteAsignaturas : Form
    {
        public FormReporteAsignaturas()
        {
            InitializeComponent();
        }

        private void FormReporteAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asignaturasDataSet.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.asignaturasDataSet.Asignatura);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
