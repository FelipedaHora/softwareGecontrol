namespace SoftwareFicticio
{
    partial class RelatorioVendas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new SoftwareFicticio.DataSet2();
            this.vendaterceirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendapadraoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendaTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendaTableAdapter();
            this.vendaterceirosTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendaterceirosTableAdapter();
            this.vendapadraoviewTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendapadraoviewTableAdapter();
            this.vendapadraoviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaterceirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaterceirosBindingSource
            // 
            this.vendaterceirosBindingSource.DataMember = "vendaterceiros";
            this.vendaterceirosBindingSource.DataSource = this.dataSet2;
            // 
            // vendapadraoviewBindingSource
            // 
            this.vendapadraoviewBindingSource.DataMember = "vendapadraoview";
            this.vendapadraoviewBindingSource.DataSource = this.dataSet2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Vendas";
            reportDataSource1.Value = this.vendaBindingSource;
            reportDataSource2.Name = "viewVendaTerceiros";
            reportDataSource2.Value = this.vendaterceirosBindingSource;
            reportDataSource3.Name = "vendaviewpadrao";
            reportDataSource3.Value = this.vendapadraoviewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftwareFicticio.RelatorioVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1064, 580);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // vendaterceirosTableAdapter
            // 
            this.vendaterceirosTableAdapter.ClearBeforeFill = true;
            // 
            // vendapadraoviewTableAdapter
            // 
            this.vendapadraoviewTableAdapter.ClearBeforeFill = true;
            // 
            // vendapadraoviewBindingSource1
            // 
            this.vendapadraoviewBindingSource1.DataMember = "vendapadraoview";
            this.vendapadraoviewBindingSource1.DataSource = this.dataSet2;
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioVendas";
            this.Text = "RelatorioVendas";
            this.Load += new System.EventHandler(this.RelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaterceirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource vendaterceirosBindingSource;
        private DataSet2TableAdapters.vendaterceirosTableAdapter vendaterceirosTableAdapter;
        private System.Windows.Forms.BindingSource vendapadraoviewBindingSource;
        private DataSet2TableAdapters.vendapadraoviewTableAdapter vendapadraoviewTableAdapter;
        private System.Windows.Forms.BindingSource vendapadraoviewBindingSource1;
    }
}