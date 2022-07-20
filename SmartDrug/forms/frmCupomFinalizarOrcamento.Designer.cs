namespace SmartDrug.forms
{
    partial class frmCupomFinalizarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCupomFinalizarOrcamento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.bancoTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.BancoTableAdapter();
            this.RelacaoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelacaoVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacaoContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter();
            this.relacaoVendasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelacaoContas";
            reportDataSource1.Value = this.RelacaoContasBindingSource;
            reportDataSource2.Name = "RelacaoVendas";
            reportDataSource2.Value = this.RelacaoVendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.forms.ReportCupomNaoFiscal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(364, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoTableAdapter
            // 
            this.bancoTableAdapter.ClearBeforeFill = true;
            // 
            // RelacaoContasBindingSource
            // 
            this.RelacaoContasBindingSource.DataMember = "RelacaoContas";
            this.RelacaoContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // RelacaoVendasBindingSource
            // 
            this.RelacaoVendasBindingSource.DataMember = "RelacaoVendas";
            this.RelacaoVendasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // relacaoContasTableAdapter
            // 
            this.relacaoContasTableAdapter.ClearBeforeFill = true;
            // 
            // relacaoVendasTableAdapter
            // 
            this.relacaoVendasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCupomFinalizarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 636);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCupomFinalizarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cupom Finalizar Orcamento";
            this.Load += new System.EventHandler(this.frmCupomFinalizarOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RelacaoContasBindingSource;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource RelacaoVendasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.BancoTableAdapter bancoTableAdapter;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter relacaoContasTableAdapter;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter relacaoVendasTableAdapter;
    }
}