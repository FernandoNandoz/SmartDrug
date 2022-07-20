namespace SmartDrug.forms
{
    partial class frmCupomMensalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCupomMensalidade));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.RelacaoMensalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacaoMensalidadeTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoMensalidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoMensalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelacaoMensalidade";
            reportDataSource1.Value = this.RelacaoMensalidadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.forms.ReportCupomMensalidade.rdlc";
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
            // RelacaoMensalidadeBindingSource
            // 
            this.RelacaoMensalidadeBindingSource.DataMember = "RelacaoMensalidade";
            this.RelacaoMensalidadeBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // relacaoMensalidadeTableAdapter
            // 
            this.relacaoMensalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // frmCupomMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 636);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCupomMensalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apartamentos - Cupom Mensalidade";
            this.Load += new System.EventHandler(this.frmCupomMensalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoMensalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource RelacaoMensalidadeBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoMensalidadeTableAdapter relacaoMensalidadeTableAdapter;
    }
}