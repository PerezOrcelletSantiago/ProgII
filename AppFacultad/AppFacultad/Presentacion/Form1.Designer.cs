
namespace AppFacultad
{
    partial class Carrera
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
            this.Lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarFrom1 = new System.Windows.Forms.Button();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasTUP1erSemestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lst1
            // 
            this.Lst1.FormattingEnabled = true;
            this.Lst1.Location = new System.Drawing.Point(129, 184);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(119, 121);
            this.Lst1.TabIndex = 1;
            this.Lst1.SelectedIndexChanged += new System.EventHandler(this.Lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(20, 184);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(103, 121);
            this.lst2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materias de 1er año y segundo semestre de la TUP";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(307, 102);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(447, 203);
            this.dgv1.TabIndex = 4;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carreraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.cambiarEstadoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.carreraToolStripMenuItem.Text = "Carreras";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            this.cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            this.cambiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarEstadoToolStripMenuItem.Text = "Cambiar Estado";
            // 
            // btnCerrarFrom1
            // 
            this.btnCerrarFrom1.Location = new System.Drawing.Point(596, 331);
            this.btnCerrarFrom1.Name = "btnCerrarFrom1";
            this.btnCerrarFrom1.Size = new System.Drawing.Size(108, 43);
            this.btnCerrarFrom1.TabIndex = 7;
            this.btnCerrarFrom1.Text = "Salir";
            this.btnCerrarFrom1.UseVisualStyleBackColor = true;
            this.btnCerrarFrom1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoMateriasToolStripMenuItem,
            this.asignaturasTUP1erSemestreToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // listadoMateriasToolStripMenuItem
            // 
            this.listadoMateriasToolStripMenuItem.Name = "listadoMateriasToolStripMenuItem";
            this.listadoMateriasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listadoMateriasToolStripMenuItem.Text = "Listado Asignaturas";
            this.listadoMateriasToolStripMenuItem.Click += new System.EventHandler(this.listadoMateriasToolStripMenuItem_Click);
            // 
            // asignaturasTUP1erSemestreToolStripMenuItem
            // 
            this.asignaturasTUP1erSemestreToolStripMenuItem.Name = "asignaturasTUP1erSemestreToolStripMenuItem";
            this.asignaturasTUP1erSemestreToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.asignaturasTUP1erSemestreToolStripMenuItem.Text = "Asignaturas TUP 1er Semestre";
            this.asignaturasTUP1erSemestreToolStripMenuItem.Click += new System.EventHandler(this.asignaturasTUP1erSemestreToolStripMenuItem_Click);
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 398);
            this.Controls.Add(this.btnCerrarFrom1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.Lst1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Carrera";
            this.Text = "Facultad";
            this.Load += new System.EventHandler(this.Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.Button btnCerrarFrom1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasTUP1erSemestreToolStripMenuItem;
    }
}

