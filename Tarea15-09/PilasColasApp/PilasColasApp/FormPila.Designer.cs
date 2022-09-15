
namespace PilasColasApp
{
    partial class FormPila
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPila = new System.Windows.Forms.ListBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtCosa = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEstaVacia = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(425, 67);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(324, 264);
            this.lstPila.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(54, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 20);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cosa :";
            // 
            // txtCosa
            // 
            this.txtCosa.Location = new System.Drawing.Point(114, 67);
            this.txtCosa.Name = "txtCosa";
            this.txtCosa.Size = new System.Drawing.Size(233, 20);
            this.txtCosa.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 120);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 35);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEstaVacia
            // 
            this.btnEstaVacia.Location = new System.Drawing.Point(163, 175);
            this.btnEstaVacia.Name = "btnEstaVacia";
            this.btnEstaVacia.Size = new System.Drawing.Size(122, 35);
            this.btnEstaVacia.TabIndex = 4;
            this.btnEstaVacia.Text = "Esta Vacia?...";
            this.btnEstaVacia.UseVisualStyleBackColor = true;
            this.btnEstaVacia.Click += new System.EventHandler(this.btnEstaVacia_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(163, 230);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(122, 35);
            this.btnPrimero.TabIndex = 5;
            this.btnPrimero.Text = "Primero?...";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(163, 285);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(122, 35);
            this.btnExtraer.TabIndex = 6;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(293, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 64);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "¡ SALIR !";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "- PILA -";
            // 
            // FormPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnEstaVacia);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCosa);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lstPila);
            this.Name = "FormPila";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtCosa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEstaVacia;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

