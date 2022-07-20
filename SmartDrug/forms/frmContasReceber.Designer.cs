namespace SmartDrug.forms
{
    partial class frmContasReceber
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
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasReceber));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRelacaoHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.btnReceber = new System.Windows.Forms.PictureBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.joinContasReceberTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1140, 57);
            panelTop.TabIndex = 339;
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
            labTitulo.Location = new System.Drawing.Point(434, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(273, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Contas a Receber";
            // 
            // contasReceberDataGridView
            // 
            this.contasReceberDataGridView.AllowUserToAddRows = false;
            this.contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.contasReceberDataGridView.AllowUserToResizeColumns = false;
            this.contasReceberDataGridView.AllowUserToResizeRows = false;
            this.contasReceberDataGridView.AutoGenerateColumns = false;
            this.contasReceberDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.contasReceberDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contasReceberDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contasReceberDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contasReceberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.ultimaCompra,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.situacaoContaDataGridViewTextBoxColumn,
            this.idRelacaoHaverDataGridViewTextBoxColumn,
            this.idSituacaoContaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn});
            this.contasReceberDataGridView.DataSource = this.joinContasReceberBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contasReceberDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.contasReceberDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.contasReceberDataGridView.Location = new System.Drawing.Point(45, 102);
            this.contasReceberDataGridView.MultiSelect = false;
            this.contasReceberDataGridView.Name = "contasReceberDataGridView";
            this.contasReceberDataGridView.ReadOnly = true;
            this.contasReceberDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contasReceberDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.contasReceberDataGridView.RowHeadersVisible = false;
            this.contasReceberDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.contasReceberDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contasReceberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contasReceberDataGridView.Size = new System.Drawing.Size(1043, 430);
            this.contasReceberDataGridView.TabIndex = 101;
            this.contasReceberDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.contasReceberDataGridView_CellFormatting);
            this.contasReceberDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contasReceberDataGridView_KeyDown);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 500;
            // 
            // ultimaCompra
            // 
            this.ultimaCompra.DataPropertyName = "ultimaCompra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            this.ultimaCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.ultimaCompra.HeaderText = "Ultima Compra";
            this.ultimaCompra.Name = "ultimaCompra";
            this.ultimaCompra.ReadOnly = true;
            this.ultimaCompra.Visible = false;
            this.ultimaCompra.Width = 240;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ultimoHaver";
            dataGridViewCellStyle3.Format = "g";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ultimo Haver";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "valorHaver";
            dataGridViewCellStyle4.Format = "C2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Valor Pago R$";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // situacaoContaDataGridViewTextBoxColumn
            // 
            this.situacaoContaDataGridViewTextBoxColumn.DataPropertyName = "SituacaoConta";
            this.situacaoContaDataGridViewTextBoxColumn.HeaderText = "Situação da Conta";
            this.situacaoContaDataGridViewTextBoxColumn.Name = "situacaoContaDataGridViewTextBoxColumn";
            this.situacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoContaDataGridViewTextBoxColumn.Width = 203;
            // 
            // idRelacaoHaverDataGridViewTextBoxColumn
            // 
            this.idRelacaoHaverDataGridViewTextBoxColumn.DataPropertyName = "idRelacaoHaver";
            this.idRelacaoHaverDataGridViewTextBoxColumn.HeaderText = "idRelacaoHaver";
            this.idRelacaoHaverDataGridViewTextBoxColumn.Name = "idRelacaoHaverDataGridViewTextBoxColumn";
            this.idRelacaoHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRelacaoHaverDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoContaDataGridViewTextBoxColumn
            // 
            this.idSituacaoContaDataGridViewTextBoxColumn.DataPropertyName = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.HeaderText = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.Name = "idSituacaoContaDataGridViewTextBoxColumn";
            this.idSituacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoContaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // joinContasReceberBindingSource
            // 
            this.joinContasReceberBindingSource.DataMember = "JoinContasReceber";
            this.joinContasReceberBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(541, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 25);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 104;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Transparent;
            this.btnReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnReceber.Image")));
            this.btnReceber.Location = new System.Drawing.Point(503, 567);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(125, 35);
            this.btnReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReceber.TabIndex = 106;
            this.btnReceber.TabStop = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // textDescricao
            // 
            this.textDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescricao.Location = new System.Drawing.Point(45, 58);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(489, 26);
            this.textDescricao.TabIndex = 0;
            this.textDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDescricao_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Pesquisar:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(634, 567);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 35);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 105;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(367, 567);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 35);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 110;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.contasReceberDataGridView);
            this.panelCentral.Controls.Add(this.btnSair);
            this.panelCentral.Controls.Add(this.btnAtualizar);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.textDescricao);
            this.panelCentral.Controls.Add(this.btnPesquisar);
            this.panelCentral.Controls.Add(this.btnReceber);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 57);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1140, 631);
            this.panelCentral.TabIndex = 340;
            // 
            // joinContasReceberTableAdapter
            // 
            this.joinContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // frmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 688);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContasReceber";
            this.Load += new System.EventHandler(this.FrmContasReceber_Load);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.PictureBox btnReceber;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaRecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView contasReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao2DataGridViewTextBoxColumn;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource joinContasReceberBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter joinContasReceberTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRelacaoHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
    }
}