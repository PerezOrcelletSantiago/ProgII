
namespace AppFacultad.Presentacion
{
    partial class FormRepoPrimerSem
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
            this.SP_ReporteMateriasTUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primerSemestreDataSet = new AppFacultad.PrimerSemestreDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAtras = new System.Windows.Forms.Button();
            this.primerSemestreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPReporteMateriasTUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ReporteMateriasTUPTableAdapter = new AppFacultad.PrimerSemestreDataSetTableAdapters.SP_ReporteMateriasTUPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReporteMateriasTUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerSemestreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerSemestreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteMateriasTUPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_ReporteMateriasTUPBindingSource
            // 
            this.SP_ReporteMateriasTUPBindingSource.DataMember = "SP_ReporteMateriasTUP";
            this.SP_ReporteMateriasTUPBindingSource.DataSource = this.primerSemestreDataSet;
            // 
            // primerSemestreDataSet
            // 
            this.primerSemestreDataSet.DataSetName = "PrimerSemestreDataSet";
            this.primerSemestreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TablaPrimerSem";
            reportDataSource1.Value = this.SP_ReporteMateriasTUPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppFacultad.RepoPrimerSem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(629, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(244, 461);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(183, 35);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // primerSemestreDataSetBindingSource
            // 
            this.primerSemestreDataSetBindingSource.DataSource = this.primerSemestreDataSet;
            this.primerSemestreDataSetBindingSource.Position = 0;
            // 
            // sPReporteMateriasTUPBindingSource
            // 
            this.sPReporteMateriasTUPBindingSource.DataMember = "SP_ReporteMateriasTUP";
            this.sPReporteMateriasTUPBindingSource.DataSource = this.primerSemestreDataSetBindingSource;
            // 
            // sP_ReporteMateriasTUPTableAdapter
            // 
            this.sP_ReporteMateriasTUPTableAdapter.ClearBeforeFill = true;
            // 
            // FormRepoPrimerSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 508);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRepoPrimerSem";
            this.Text = "FormRepoPrimerSem";
            this.Load += new System.EventHandler(this.FormRepoPrimerSem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ReporteMateriasTUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerSemestreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primerSemestreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPReporteMateriasTUPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnAtras;
        private PrimerSemestreDataSet primerSemestreDataSet;
        private System.Windows.Forms.BindingSource primerSemestreDataSetBindingSource;
        private System.Windows.Forms.BindingSource sPReporteMateriasTUPBindingSource;
        private PrimerSemestreDataSetTableAdapters.SP_ReporteMateriasTUPTableAdapter sP_ReporteMateriasTUPTableAdapter;
        private System.Windows.Forms.BindingSource SP_ReporteMateriasTUPBindingSource;
    }
}