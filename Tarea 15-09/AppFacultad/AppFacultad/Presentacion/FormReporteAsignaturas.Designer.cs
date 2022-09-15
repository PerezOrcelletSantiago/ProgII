
namespace AppFacultad.Presentacion
{
    partial class FormReporteAsignaturas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnAtras = new System.Windows.Forms.Button();
            this.asignaturasDataSet = new AppFacultad.AsignaturasDataSet();
            this.asignaturasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AsignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.asignaturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new AppFacultad.AsignaturasDataSetTableAdapters.AsignaturaTableAdapter();
            this.asignaturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(339, 511);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(107, 35);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // asignaturasDataSet
            // 
            this.asignaturasDataSet.DataSetName = "AsignaturasDataSet";
            this.asignaturasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturasDataSetBindingSource
            // 
            this.asignaturasDataSetBindingSource.DataSource = this.asignaturasDataSet;
            this.asignaturasDataSetBindingSource.Position = 0;
            // 
            // AsignaturaBindingSource
            // 
            this.AsignaturaBindingSource.DataMember = "Asignatura";
            this.AsignaturaBindingSource.DataSource = this.asignaturasDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dtAsignaturas";
            reportDataSource1.Value = this.asignaturaBindingSource1;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.asignaturaBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppFacultad.Reporte1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(76, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(628, 503);
            this.reportViewer1.TabIndex = 2;
            // 
            // asignaturaBindingSource1
            // 
            this.asignaturaBindingSource1.DataMember = "Asignatura";
            this.asignaturaBindingSource1.DataSource = this.asignaturasDataSetBindingSource;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // asignaturaBindingSource2
            // 
            this.asignaturaBindingSource2.DataMember = "Asignatura";
            this.asignaturaBindingSource2.DataSource = this.asignaturasDataSetBindingSource;
            // 
            // FormReporteAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnAtras);
            this.Name = "FormReporteAsignaturas";
            this.Text = "Reporte Asignaturas";
            this.Load += new System.EventHandler(this.FormReporteAsignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource asignaturasDataSetBindingSource;
        private AsignaturasDataSet asignaturasDataSet;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource AsignaturaBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource asignaturaBindingSource1;
        private AsignaturasDataSetTableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.BindingSource asignaturaBindingSource2;
    }
}