using RecetasSLN.datos;
using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmAlta : Form
    {
        private Recetas nueva;
        private HelperDAO gestor;

        public FrmAlta()
        {
            InitializeComponent();
            nueva = new Recetas();
            gestor = new HelperDAO();
            ConsultarUltimaReceta();
        }

        private void ConsultarUltimaReceta()
        {
            label1.Text = "RECETA NRO: " + gestor.ProximaReceta();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            DataTable tabla = gestor.ConsultarIng();
            cboIngredientes.DataSource = tabla;
            cboIngredientes.ValueMember = tabla.Columns[0].ColumnName;
            cboIngredientes.DisplayMember = tabla.Columns[1].ColumnName;
            cboIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtCheff.Text = string.Empty;
            cboTipo.Text = string.Empty;
            dgvDetalles.Rows.Clear();
            label5.Text = "Total de ingredientes:";
            ConsultarUltimaReceta();
        }

        private void ActualizarTotales()
        {
            label5.Text = "Total de ingredientes:" + dgvDetalles.Rows.Count;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboIngredientes.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un ingrediente", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(nud.Text) || !int.TryParse(nud.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["Ingrediente"].Value.ToString().Equals(cboIngredientes.Text))
                {
                    MessageBox.Show("Este ingrediente ya está cargado.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboIngredientes.SelectedItem;
            int ingr = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();

            Ingredientes i = new Ingredientes();
            i.Nombre = nom;
            i.IngredienteID = ingr;
            int cant = Convert.ToInt32(nud.Value);
            DetalleRecetas detalle = new DetalleRecetas(i, cant);
            nueva.AgregarDetalle(detalle);
            dgvDetalles.Rows.Add(i.IngredienteID, i.Nombre, detalle.Cantidad);
            ActualizarTotales();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCheff.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Chef", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCheff.Focus();
                return;
            }

            if (dgvDetalles.Rows.Count < 3)
            {
                MessageBox.Show("Debe ingresar 3 ingredientes como mínimo", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIngredientes.Focus();
                return;

            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un Nombre", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            nueva.RecetaNro = gestor.ProximaReceta();
            nueva.Nombre = txtNombre.Text;
            nueva.Cheff = txtCheff.Text;
            nueva.TipoReceta = Convert.ToInt32(cboTipo.SelectedIndex);
            if (gestor.Insertar(nueva))
            {
                MessageBox.Show("Receta guardada");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Receta NO guardada");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();

            }
            else
            {
                return;
            }
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 3)
            {
                nueva.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }
        }
    }
}
