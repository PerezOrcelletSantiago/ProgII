
namespace AppFacultad
{
    partial class FormAlta
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
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodCarrera = new System.Windows.Forms.Label();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.txtCodigoCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.LblEncabezado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colIdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAsignaturas = new System.Windows.Forms.Label();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(28, 117);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(136, 20);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Nombre Carrera";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(111, 157);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(53, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblCodCarrera
            // 
            this.lblCodCarrera.AutoSize = true;
            this.lblCodCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCarrera.Location = new System.Drawing.Point(34, 77);
            this.lblCodCarrera.Name = "lblCodCarrera";
            this.lblCodCarrera.Size = new System.Drawing.Size(130, 20);
            this.lblCodCarrera.TabIndex = 2;
            this.lblCodCarrera.Text = "Código Carrera";
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioCursado.Location = new System.Drawing.Point(51, 310);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(113, 20);
            this.lblAnioCursado.TabIndex = 3;
            this.lblAnioCursado.Text = "Año Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatrimestre.Location = new System.Drawing.Point(52, 349);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(112, 20);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignatura.Location = new System.Drawing.Point(68, 268);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(96, 20);
            this.lblAsignatura.TabIndex = 5;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // txtCodigoCarrera
            // 
            this.txtCodigoCarrera.Location = new System.Drawing.Point(180, 79);
            this.txtCodigoCarrera.Name = "txtCodigoCarrera";
            this.txtCodigoCarrera.Size = new System.Drawing.Size(92, 20);
            this.txtCodigoCarrera.TabIndex = 0;
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(180, 119);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(274, 20);
            this.txtNombreCarrera.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(180, 159);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(274, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(181, 310);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(39, 20);
            this.txtAnioCursado.TabIndex = 4;
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(181, 349);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(60, 17);
            this.rbtPrimero.TabIndex = 5;
            this.rbtPrimero.TabStop = true;
            this.rbtPrimero.Text = "Primero";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(181, 381);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(68, 17);
            this.rbtSegundo.TabIndex = 6;
            this.rbtSegundo.TabStop = true;
            this.rbtSegundo.Text = "Segundo";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(610, 433);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(104, 38);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // LblEncabezado
            // 
            this.LblEncabezado.AutoSize = true;
            this.LblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEncabezado.Location = new System.Drawing.Point(170, 18);
            this.LblEncabezado.Name = "LblEncabezado";
            this.LblEncabezado.Size = new System.Drawing.Size(182, 29);
            this.LblEncabezado.TabIndex = 15;
            this.LblEncabezado.Text = "Nueva Carrera";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(790, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(333, 379);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 28);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.dgvDetalles.Location = new System.Drawing.Point(478, 77);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(590, 330);
            this.dgvDetalles.TabIndex = 18;
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
            // lblAsignaturas
            // 
            this.lblAsignaturas.AutoSize = true;
            this.lblAsignaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignaturas.Location = new System.Drawing.Point(170, 216);
            this.lblAsignaturas.Name = "lblAsignaturas";
            this.lblAsignaturas.Size = new System.Drawing.Size(149, 29);
            this.lblAsignaturas.TabIndex = 19;
            this.lblAsignaturas.Text = "Asignaturas";
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(181, 268);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(171, 21);
            this.cboAsignatura.TabIndex = 3;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 488);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.lblAsignaturas);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.LblEncabezado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.txtCodigoCarrera);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.lblCodCarrera);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarrera);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodCarrera;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.TextBox txtCodigoCarrera;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label LblEncabezado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblAsignaturas;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}