namespace SmartDrug.forms
{
    partial class frmCupomNaoFiscalA_Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCupomNaoFiscalA_Vista));
            this.RelacaoNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.RelacaoVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relacaoNotasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter();
            this.relacaoVendasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter();
            this.tableAdapterManager = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager();
            this.RelacaoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacaoContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelacaoNotasBindingSource
            // 
            this.RelacaoNotasBindingSource.DataMember = "RelacaoNotas";
            this.RelacaoNotasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelacaoVendasBindingSource
            // 
            this.RelacaoVendasBindingSource.DataMember = "RelacaoVendas";
            this.RelacaoVendasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelacaoNotas";
            reportDataSource1.Value = this.RelacaoNotasBindingSource;
            reportDataSource2.Name = "RelacaoVendas";
            reportDataSource2.Value = this.RelacaoVendasBindingSource;
            reportDataSource3.Name = "RelacaoContas";
            reportDataSource3.Value = this.RelacaoContasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.forms.ReportCupomNaoFiscalA_Vista.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(364, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // relacaoNotasTableAdapter
            // 
            this.relacaoNotasTableAdapter.ClearBeforeFill = true;
            // 
            // relacaoVendasTableAdapter
            // 
            this.relacaoVendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContasPagarTableAdapter = null;
            this.tableAdapterManager.ContasReceberTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.FluxoCaixaTableAdapter = null;
            this.tableAdapterManager.FormaPagamentoRecebimentoTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.HaverContasReceberTableAdapter = null;
            this.tableAdapterManager.itensVendidosTableAdapter = null;
            this.tableAdapterManager.MensalidadeTableAdapter = null;
            this.tableAdapterManager.NotaFiscalTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.RelacaoHaverTableAdapter = null;
            this.tableAdapterManager.RelacaoHospedesTableAdapter = null;
            this.tableAdapterManager.SituacaoClienteTableAdapter = null;
            this.tableAdapterManager.SituacaoContaTableAdapter = null;
            this.tableAdapterManager.SituacaoPagarTableAdapter = null;
            this.tableAdapterManager.SituacaoReceberTableAdapter = null;
            this.tableAdapterManager.SituacaoVendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VendasTableAdapter = null;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // RelacaoContasBindingSource
            // 
            this.RelacaoContasBindingSource.DataMember = "RelacaoContas";
            this.RelacaoContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // relacaoContasTableAdapter
            // 
            this.relacaoContasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCupomNaoFiscalA_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 636);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCupomNaoFiscalA_Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas - Cupom Nao Fiscal";
            this.Load += new System.EventHandler(this.frmCupomNaoFiscalA_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter relacaoNotasTableAdapter;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter relacaoVendasTableAdapter;
        private DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource RelacaoNotasBindingSource;
        private System.Windows.Forms.BindingSource RelacaoVendasBindingSource;
        private System.Windows.Forms.BindingSource RelacaoContasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter relacaoContasTableAdapter;
    }
}