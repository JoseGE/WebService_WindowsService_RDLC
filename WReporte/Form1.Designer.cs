namespace WReporte
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.WebServDataSet = new WReporte.WebServDataSet();
            this.AparatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AparatosTableAdapter = new WReporte.WebServDataSetTableAdapters.AparatosTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.WebServDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AparatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WebServDataSet
            // 
            this.WebServDataSet.DataSetName = "WebServDataSet";
            this.WebServDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AparatosBindingSource
            // 
            this.AparatosBindingSource.DataMember = "Aparatos";
            this.AparatosBindingSource.DataSource = this.WebServDataSet;
            // 
            // AparatosTableAdapter
            // 
            this.AparatosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AparatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WReporte.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebServDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AparatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource AparatosBindingSource;
        private WebServDataSet WebServDataSet;
        private WebServDataSetTableAdapters.AparatosTableAdapter AparatosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

