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
    public partial class FormModificar : Form
    {
        Carreraa unaCarrera;
        public FormModificar()
        {
            InitializeComponent();
            unaCarrera = new Carreraa();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            CargarComboAsg();
            CargarComboCar();
            cboAsignatura.SelectedIndex = -1;
            cboCarrera.SelectedIndex = -1;
        }

        private void CargarDgvDetalles(int x)
        {
            dgvDetalles.Rows.Clear();
            DataTable tabla = AccesoDatos.ObtenerInstancia().selectSQL2("SP_CargarDetalles",x);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvDetalles.Rows.Add(fila["id"], fila["asignatura"], fila["anio_cursado"], fila["cuatrimestre"]);
                Asignatura a = new Asignatura();
                a.pCodigo = Convert.ToInt32(fila["id"]);
                a.pNombre = Convert.ToString(fila["asignatura"]);
                DetalleCarrera d = new DetalleCarrera();
                d.pAsignatura = a;
                d.pAnioCursado = Convert.ToInt32(fila["anio_cursado"]);
                d.pCuatrimestre = Convert.ToString(fila["cuatrimestre"]);
                unaCarrera.AgregarDetalle(d);
            }
            tabla.Clear();
        }

        private void CargarComboCar()
        {
            DataTable tabla = AccesoDatos.ObtenerInstancia().selectSQL("SP_ComboCarreras");
            cboCarrera.DataSource = tabla;
            cboCarrera.DisplayMember = "nombre";
            cboCarrera.ValueMember = "cod_carrera";
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboAsg()
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
            if (txtAnioCursado.Text == string.Empty || !int.TryParse(txtAnioCursado.Text, out _))
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
                    MessageBox.Show("Asignatura: " + cboAsignatura.Text + " ya fue ingresada", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            unaCarrera.AgregarDetalle(d);
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

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                unaCarrera.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }

        private void cboCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDgvDetalles(Convert.ToInt32(cboCarrera.SelectedValue));
        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e)
        {
            unaCarrera.pCodigo = Convert.ToInt32(cboCarrera.SelectedValue);
            AccesoDatos.ObtenerInstancia().UpdateDetalle(unaCarrera, "SP_DeleteDetalle", "SP_InsertarDetalle");
            MessageBox.Show("Detalles modificados exitosamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos sin usar...

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCarrera_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
