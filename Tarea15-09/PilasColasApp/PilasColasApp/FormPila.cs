using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasColasApp
{
    public partial class FormPila : Form
    {
        private ICollection c;
        public FormPila()
        {
            InitializeComponent();
            c = new Pila(10);
            txtCosa.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCosa.Text != "")
            {
                string cosa = txtCosa.Text;
                if(c.Aniadir(cosa))
                {
                    lstPila.Items.Add(cosa);
                    MessageBox.Show("Cosa añadida correctamente a la Pila", "INFORMACION",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("La Pila esta llena", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cosa valida :| ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEstaVacia_Click(object sender, EventArgs e)
        {
            if (c.EstaVacia())
            {
                MessageBox.Show("La Pila esta vacía!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La Pila tiene cosas...", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!c.EstaVacia())
            {
                MessageBox.Show("La primer cosa de la Pila es " + c.Primero(), "INFORMACION", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            string cosa = c.Extraer();
            lstPila.Items.Remove(cosa);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
