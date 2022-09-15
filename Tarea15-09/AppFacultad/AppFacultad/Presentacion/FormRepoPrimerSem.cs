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
    public partial class FormRepoPrimerSem : Form
    {
        public FormRepoPrimerSem()
        {
            InitializeComponent();
        }

        private void FormRepoPrimerSem_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'primerSemestreDataSet.SP_ReporteMateriasTUP' Puede moverla o quitarla según sea necesario.
            this.sP_ReporteMateriasTUPTableAdapter.Fill(this.primerSemestreDataSet.SP_ReporteMateriasTUP);
            this.reportViewer1.RefreshReport();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
