namespace SmartDrug.forms
{
    partial class frmCupomReemprimirVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCupomReemprimirVenda));
            this.RelacaoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.RelacaoVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelacaoNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relacaoContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter();
            this.relacaoNotasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter();
            this.tableAdapterManager = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager();
            this.relacaoVendasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoNotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RelacaoContasBindingSource
            // 
            this.RelacaoContasBindingSource.DataMember = "RelacaoContas";
            this.RelacaoContasBindingSource.DataSource = this.drogariaParanaDataSet;
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
            // RelacaoNotasBindingSource
            // 
            this.RelacaoNotasBindingSource.DataMember = "RelacaoNotas";
            this.RelacaoNotasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelacaoContas";
            reportDataSource1.Value = this.RelacaoContasBindingSource;
            reportDataSource2.Name = "RelacaoVendas";
            reportDataSource2.Value = this.RelacaoVendasBindingSource;
            reportDataSource3.Name = "RelacaoNotas";
            reportDataSource3.Value = this.RelacaoNotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.forms.ReportCupomFiscal_2Via.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(364, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // relacaoContasTableAdapter
            // 
            this.relacaoContasTableAdapter.ClearBeforeFill = true;
            // 
            // relacaoNotasTableAdapter
            // 
            this.relacaoNotasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.itensVendidosTableAdapter = null;
            this.tableAdapterManager.NotaFiscalTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.RelacaoHaverTableAdapter = null;
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
            // relacaoVendasTableAdapter
            // 
            this.relacaoVendasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCupomReemprimirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 636);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCupomReemprimirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reemprimir Venda - 2ª Via";
            this.Load += new System.EventHandler(this.frmCupomReemprimirVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoNotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter relacaoContasTableAdapter;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter relacaoNotasTableAdapter;
        private System.Windows.Forms.BindingSource RelacaoContasBindingSource;
        private System.Windows.Forms.BindingSource RelacaoVendasBindingSource;
        private System.Windows.Forms.BindingSource RelacaoNotasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter relacaoVendasTableAdapter;
    }
}