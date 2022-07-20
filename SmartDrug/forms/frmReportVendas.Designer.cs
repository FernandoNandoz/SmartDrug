namespace SmartDrug.forms
{
    partial class frmReportVendas
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
            System.Windows.Forms.Label labelDataFinal;
            System.Windows.Forms.Label labelDataInicial;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportVendas));
            System.Windows.Forms.Label labTitulo;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.RelacaoVendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.dataFinalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataInicialMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.relacaoVendasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter();
            this.panelCentral = new System.Windows.Forms.Panel();
            labelDataFinal = new System.Windows.Forms.Label();
            labelDataInicial = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDataFinal.Location = new System.Drawing.Point(191, 19);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new System.Drawing.Size(86, 20);
            labelDataFinal.TabIndex = 330;
            labelDataFinal.Text = "Data Final:";
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.BackColor = System.Drawing.Color.Transparent;
            labelDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDataInicial.Location = new System.Drawing.Point(43, 19);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new System.Drawing.Size(92, 20);
            labelDataInicial.TabIndex = 328;
            labelDataInicial.Text = "Data Inicial:";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1097, 57);
            panelTop.TabIndex = 617;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 77;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labTitulo.Location = new System.Drawing.Point(392, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(315, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Relatório de  Vendas";
            // 
            // RelacaoVendasBindingSource
            // 
            this.RelacaoVendasBindingSource.DataMember = "RelacaoVendas";
            this.RelacaoVendasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RelacaoVendas";
            reportDataSource1.Value = this.RelacaoVendasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartDrug.Reports.ReportVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1038, 965);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReportVendas_KeyDown);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(324, 42);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 26);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 331;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataFinalMaskedTextBox
            // 
            this.dataFinalMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataFinalMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataFinalMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalMaskedTextBox.Location = new System.Drawing.Point(195, 42);
            this.dataFinalMaskedTextBox.Mask = "00/00/0000";
            this.dataFinalMaskedTextBox.Name = "dataFinalMaskedTextBox";
            this.dataFinalMaskedTextBox.Size = new System.Drawing.Size(123, 26);
            this.dataFinalMaskedTextBox.TabIndex = 326;
            this.dataFinalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataFinalMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReportVendas_KeyDown);
            // 
            // dataInicialMaskedTextBox
            // 
            this.dataInicialMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataInicialMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataInicialMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicialMaskedTextBox.Location = new System.Drawing.Point(47, 42);
            this.dataInicialMaskedTextBox.Mask = "00/00/0000";
            this.dataInicialMaskedTextBox.Name = "dataInicialMaskedTextBox";
            this.dataInicialMaskedTextBox.Size = new System.Drawing.Size(124, 26);
            this.dataInicialMaskedTextBox.TabIndex = 325;
            this.dataInicialMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataInicialMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReportVendas_KeyDown);
            // 
            // relacaoVendasTableAdapter
            // 
            this.relacaoVendasTableAdapter.ClearBeforeFill = true;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.reportViewer1);
            this.panelCentral.Controls.Add(this.dataInicialMaskedTextBox);
            this.panelCentral.Controls.Add(this.btnPesquisar);
            this.panelCentral.Controls.Add(labelDataInicial);
            this.panelCentral.Controls.Add(labelDataFinal);
            this.panelCentral.Controls.Add(this.dataFinalMaskedTextBox);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCentral.Location = new System.Drawing.Point(0, 57);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1097, 1108);
            this.panelCentral.TabIndex = 618;
            // 
            // frmReportVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1114, 665);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Vendas";
            this.Load += new System.EventHandler(this.frmReportVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReportVendas_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoVendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.MaskedTextBox dataFinalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataInicialMaskedTextBox;
        private System.Windows.Forms.BindingSource RelacaoVendasBindingSource;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoVendasTableAdapter relacaoVendasTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panelCentral;
    }
}