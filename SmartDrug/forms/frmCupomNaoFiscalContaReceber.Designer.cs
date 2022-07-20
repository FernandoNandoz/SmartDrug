namespace SmartDrug.forms
{
    partial class frmCupomNaoFiscalContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCupomNaoFiscalContaReceber));
            this.HaverContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.ListaContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableAdapterManager = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            this.haverContasReceberTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.HaverContasReceberTableAdapter();
            this.listaContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HaverContasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaContasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HaverContasReceberBindingSource
            // 
            this.HaverContasReceberBindingSource.DataMember = "HaverContasReceber";
            this.HaverContasReceberBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListaContasBindingSource
            // 
            this.ListaContasBindingSource.DataMember = "ListaContas";
            this.ListaContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelacaoContas";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "HaverContasReceber";
            reportDataSource2.Value = this.HaverContasReceberBindingSource;
            reportDataSource3.Name = "ListaContas";
            reportDataSource3.Value = this.ListaContasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.forms.ReportCupomNaoFiscalContasReceber.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(364, 636);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // haverContasReceberTableAdapter
            // 
            this.haverContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // listaContasTableAdapter
            // 
            this.listaContasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCupomNaoFiscalContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 636);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCupomNaoFiscalContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento de Conta - Cupom Nao Fiscal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCupomNaoFiscalContaReceber_FormClosed);
            this.Load += new System.EventHandler(this.frmCupomNaoFiscalContaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HaverContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaContasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.BindingSource HaverContasReceberBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.HaverContasReceberTableAdapter haverContasReceberTableAdapter;
        private System.Windows.Forms.BindingSource ListaContasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter listaContasTableAdapter;
    }
}