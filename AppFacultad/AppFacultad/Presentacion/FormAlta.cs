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
    public partial class FormAlta : Form
    {
        Carreraa nvaCarrera;
        public FormAlta()
        {
            InitializeComponent();
            nvaCarrera = new Carreraa();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cboAsignatura.SelectedIndex = -1;
            txtCodigoCarrera.Focus();
        }

        private void CargarCombo()
        {
            DataTable tabla = AccesoDatos.ObtenerInstancia().selectSQL("SP_ComboAsignaturas");
            cboAsignatura.DataSource = tabla;
            cboAsignatura.DisplayMember = "nombre";
            cboAsignatura.ValueMember = "cod_materia";
            cboAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Agregar()
        {
            if (cboAsignatura.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Seleccionar una Asignatura", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            if (txtAnioCursado.Text==string.Empty || !int.TryParse(txtAnioCursado.Text, out _))
            {
                MessageBox.Show("Debe ingresar un año valido", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!rbtPrimero.Checked && !rbtSegundo.Checked)
            {
                MessageBox.Show("Debe seleccionar un cuatrimestre", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["colAsignatura"].Value.ToString().Equals(cboAsignatura.Text))
                {
                    MessageBox.Show("Asignatura: "+cboAsignatura.Text+" ya fue ingresada", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Asignatura a = new Asignatura();
            a.pCodigo = Convert.ToInt32(cboAsignatura.SelectedValue);
            a.pNombre = cboAsignatura.Text;
            int anioCursado = Convert.ToInt32(txtAnioCursado.Text);
            string cuatrimestre = "Primero";
            if (rbtSegundo.Checked)
            {
                cuatrimestre = "Segundo";
            }
            DetalleCarrera d = new DetalleCarrera(anioCursado, cuatrimestre, a);
            nvaCarrera.AgregarDetalle(d);
            dgvDetalles.Rows.Add(a.pCodigo, a.pNombre, anioCursado, cuatrimestre);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            cboAsignatura.SelectedIndex = -1;
            txtAnioCursado.Text = "";
            rbtPrimero.Checked = false;
            rbtSegundo.Checked = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCarrera.Text=="" || !int.TryParse(txtCodigoCarrera.Text, out _))
            {
                MessageBox.Show("Debe ingresar un codigo de carrera valido", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNombreCarrera.Text==string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre de carrera", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Debe ingresar un titulo", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nvaCarrera.pCodigo = Convert.ToInt32(txtCodigoCarrera.Text);
            nvaCarrera.pNombre = Convert.ToString(txtNombreCarrera.Text);
            nvaCarrera.pTitulo = Convert.ToString(txtTitulo.Text);
            
            AccesoDatos.ObtenerInstancia().InsetCarreraDetalle("SP_InsertarMaestro","SP_InsertarDetalle", nvaCarrera);
            MessageBox.Show("Carrera insertada", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nvaCarrera.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }

        //private void btnDeshabilitar_Click(object sender, EventArgs e)
        //{
        //    nvaCarrera.pCodigo = Convert.ToInt32(txtCodigoCarrera.Text);
        //    oDB.UpdateCarreraEstado("SP_BajaLogica", nvaCarrera);
        //    nvaCarrera.pDisponible = false;
        //    if (nvaCarrera.pDisponible == false)
        //    {
        //        MessageBox.Show("Carrera " + nvaCarrera.pNombre + ", Deshabilitada", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
