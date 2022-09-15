
namespace AppFacultad.Presentacion
{
    partial class FormModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.LblEncabezado = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colIdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarDetalles = new System.Windows.Forms.Button();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(166, 235);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(171, 21);
            this.cboAsignatura.TabIndex = 20;
            // 
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaturas.Location = new System.Drawing.Point(160, 177);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(249, 29);
            this.lblAsignaturas.TabIndex = 28;
            this.lblAsignaturas.Text = "Agregar Asignaturas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(318, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 28);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(166, 348);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(68, 17);
            this.rbtSegundo.TabIndex = 26;
            this.rbtSegundo.TabStop = true;
            this.rbtSegundo.Text = "Segundo";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(166, 316);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(60, 17);
            this.rbtPrimero.TabIndex = 24;
            this.rbtPrimero.TabStop = true;
            this.rbtPrimero.Text = "Primero";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(166, 277);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(39, 20);
            this.txtAnioCursado.TabIndex = 22;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.Location = new System.Drawing.Point(53, 235);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(96, 20);
            this.lblAsignatura.TabIndex = 25;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatrimestre.Location = new System.Drawing.Point(37, 316);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(112, 20);
            this.lblCuatrimestre.TabIndex = 23;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioCursado.Location = new System.Drawing.Point(36, 277);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(113, 20);
            this.lblAnioCursado.TabIndex = 21;
            this.lblAnioCursado.Text = "Año Cursado";
            // 
            // LblEncabezado
            // 
            this.LblEncabezado.AutoSize = true;
            this.LblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncabezado.Location = new System.Drawing.Point(160, 36);
            this.LblEncabezado.Name = "LblEncabezado";
            this.LblEncabezado.Size = new System.Drawing.Size(216, 29);
            this.LblEncabezado.TabIndex = 30;
            this.LblEncabezado.Text = "Modificar Carrera";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAsignatura,
            this.colAsignatura,
            this.colAnioCursado,
            this.colCuatrimestre,
            this.colDelete});
            this.dgvDetalles.Location = new System.Drawing.Point(488, 61);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(585, 347);
            this.dgvDetalles.TabIndex = 31;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // colIdAsignatura
            // 
            this.colIdAsignatura.HeaderText = "IDAsig";
            this.colIdAsignatura.Name = "colIdAsignatura";
            this.colIdAsignatura.ReadOnly = true;
            this.colIdAsignatura.Visible = false;
            this.colIdAsignatura.Width = 50;
            // 
            // colAsignatura
            // 
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.ReadOnly = true;
            this.colAsignatura.Width = 200;
            // 
            // colAnioCursado
            // 
            this.colAnioCursado.HeaderText = "Año Cursado";
            this.colAnioCursado.Name = "colAnioCursado";
            this.colAnioCursado.ReadOnly = true;
            // 
            // colCuatrimestre
            // 
            this.colCuatrimestre.HeaderText = "Cuatrimestre";
            this.colCuatrimestre.Name = "colCuatrimestre";
            this.colCuatrimestre.ReadOnly = true;
            this.colCuatrimestre.Width = 150;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Baja";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Eliminar";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 90;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(842, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 38);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarDetalles
            // 
            this.btnGuardarDetalles.Location = new System.Drawing.Point(665, 428);
            this.btnGuardarDetalles.Name = "btnGuardarDetalles";
            this.btnGuardarDetalles.Size = new System.Drawing.Size(104, 38);
            this.btnGuardarDetalles.TabIndex = 32;
            this.btnGuardarDetalles.Text = "Guardar Detalles";
            this.btnGuardarDetalles.UseVisualStyleBackColor = true;
            this.btnGuardarDetalles.Click += new System.EventHandler(this.btnGuardarDetalles_Click);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(80, 96);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(69, 20);
            this.lblCarrera.TabIndex = 34;
            this.lblCarrera.Text = "Carrera";
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(166, 94);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(210, 21);
            this.cboCarrera.TabIndex = 35;
            this.cboCarrera.SelectedIndexChanged += new System.EventHandler(this.cboCarrera_SelectedIndexChanged);
            this.cboCarrera.SelectionChangeCommitted += new System.EventHandler(this.cboCarrera_SelectionChangeCommitted);
            this.cboCarrera.SelectedValueChanged += new System.EventHandler(this.cboCarrera_SelectedValueChanged);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 488);
            this.Controls.Add(this.cboCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarDetalles);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.LblEncabezado);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnioCursado);
            this.Name = "FormModificar";
            this.Text = "FormModificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Label LblEncabezado;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarDetalles;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cboCarrera;
    }
}