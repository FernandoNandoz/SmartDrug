namespace SmartDrug.forms
{
    partial class frmHospedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHospedes));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnNovoHospede = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.btnReceber = new System.Windows.Forms.PictureBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.hospedesDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPagamenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.hospedesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.HospedesTableAdapter();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnExcluirHospede = new System.Windows.Forms.Button();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoHospede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
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
            panelTop.Margin = new System.Windows.Forms.Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1507, 64);
            panelTop.TabIndex = 616;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(13, 14);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(57, 37);
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
            labTitulo.Location = new System.Drawing.Point(559, 12);
            labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(405, 46);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Contole de Hospedes";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(482, 731);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(167, 43);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 119;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnNovoHospede
            // 
            this.btnNovoHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoHospede.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoHospede.Image")));
            this.btnNovoHospede.Location = new System.Drawing.Point(656, 731);
            this.btnNovoHospede.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoHospede.Name = "btnNovoHospede";
            this.btnNovoHospede.Size = new System.Drawing.Size(167, 43);
            this.btnNovoHospede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNovoHospede.TabIndex = 118;
            this.btnNovoHospede.TabStop = false;
            this.btnNovoHospede.Click += new System.EventHandler(this.btnNovoHospede_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(707, 66);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(131, 31);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 114;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Transparent;
            this.btnReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnReceber.Image")));
            this.btnReceber.Location = new System.Drawing.Point(832, 731);
            this.btnReceber.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(167, 43);
            this.btnReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReceber.TabIndex = 116;
            this.btnReceber.TabStop = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // textDescricao
            // 
            this.textDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescricao.Location = new System.Drawing.Point(53, 66);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(645, 30);
            this.textDescricao.TabIndex = 0;
            this.textDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textDescricao_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nome Hospede:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1007, 731);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 43);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 115;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // hospedesDataGridView
            // 
            this.hospedesDataGridView.AllowUserToAddRows = false;
            this.hospedesDataGridView.AllowUserToDeleteRows = false;
            this.hospedesDataGridView.AllowUserToResizeColumns = false;
            this.hospedesDataGridView.AllowUserToResizeRows = false;
            this.hospedesDataGridView.AutoGenerateColumns = false;
            this.hospedesDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.hospedesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hospedesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hospedesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hospedesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.hospedesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hospedesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.parcelaDataGridViewTextBoxColumn,
            this.ultimoPagamentoDataGridViewTextBoxColumn,
            this.valorPagamenoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.idCliente,
            this.idNomeDataGridViewTextBoxColumn});
            this.hospedesDataGridView.DataSource = this.hospedesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hospedesDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.hospedesDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.hospedesDataGridView.Location = new System.Drawing.Point(53, 118);
            this.hospedesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.hospedesDataGridView.MultiSelect = false;
            this.hospedesDataGridView.Name = "hospedesDataGridView";
            this.hospedesDataGridView.ReadOnly = true;
            this.hospedesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hospedesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.hospedesDataGridView.RowHeadersVisible = false;
            this.hospedesDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hospedesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hospedesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hospedesDataGridView.Size = new System.Drawing.Size(1401, 576);
            this.hospedesDataGridView.TabIndex = 111;
            this.hospedesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hospedesDataGridView_CellFormatting);
            this.hospedesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hospedesDataGridView_KeyDown);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Hospede/Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 431;
            // 
            // parcelaDataGridViewTextBoxColumn
            // 
            this.parcelaDataGridViewTextBoxColumn.DataPropertyName = "parcela";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcelaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.parcelaDataGridViewTextBoxColumn.HeaderText = "Parcela";
            this.parcelaDataGridViewTextBoxColumn.Name = "parcelaDataGridViewTextBoxColumn";
            this.parcelaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimoPagamentoDataGridViewTextBoxColumn
            // 
            this.ultimoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagamento";
            this.ultimoPagamentoDataGridViewTextBoxColumn.HeaderText = "Ultimo Pagamento";
            this.ultimoPagamentoDataGridViewTextBoxColumn.Name = "ultimoPagamentoDataGridViewTextBoxColumn";
            this.ultimoPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoPagamentoDataGridViewTextBoxColumn.Width = 180;
            // 
            // valorPagamenoDataGridViewTextBoxColumn
            // 
            this.valorPagamenoDataGridViewTextBoxColumn.DataPropertyName = "valorPagameno";
            this.valorPagamenoDataGridViewTextBoxColumn.HeaderText = "Valor Pagamento";
            this.valorPagamenoDataGridViewTextBoxColumn.Name = "valorPagamenoDataGridViewTextBoxColumn";
            this.valorPagamenoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorPagamenoDataGridViewTextBoxColumn.Width = 180;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 160;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "idCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // idNomeDataGridViewTextBoxColumn
            // 
            this.idNomeDataGridViewTextBoxColumn.DataPropertyName = "idNome";
            this.idNomeDataGridViewTextBoxColumn.HeaderText = "idNome";
            this.idNomeDataGridViewTextBoxColumn.Name = "idNomeDataGridViewTextBoxColumn";
            this.idNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNomeDataGridViewTextBoxColumn.Visible = false;
            // 
            // hospedesBindingSource
            // 
            this.hospedesBindingSource.DataMember = "Hospedes";
            this.hospedesBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospedesTableAdapter
            // 
            this.hospedesTableAdapter.ClearBeforeFill = true;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.btnExcluirHospede);
            this.panelCentral.Controls.Add(this.hospedesDataGridView);
            this.panelCentral.Controls.Add(this.btnSair);
            this.panelCentral.Controls.Add(this.btnAtualizar);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Controls.Add(this.btnNovoHospede);
            this.panelCentral.Controls.Add(this.textDescricao);
            this.panelCentral.Controls.Add(this.btnPesquisar);
            this.panelCentral.Controls.Add(this.btnReceber);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 64);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(4);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1507, 802);
            this.panelCentral.TabIndex = 617;
            // 
            // btnExcluirHospede
            // 
            this.btnExcluirHospede.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirHospede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirHospede.BackgroundImage")));
            this.btnExcluirHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirHospede.FlatAppearance.BorderSize = 0;
            this.btnExcluirHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirHospede.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnExcluirHospede.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluirHospede.Location = new System.Drawing.Point(318, 731);
            this.btnExcluirHospede.Name = "btnExcluirHospede";
            this.btnExcluirHospede.Size = new System.Drawing.Size(157, 43);
            this.btnExcluirHospede.TabIndex = 121;
            this.btnExcluirHospede.UseVisualStyleBackColor = false;
            this.btnExcluirHospede.Click += new System.EventHandler(this.btnExcluirHospede_Click);
            // 
            // frmHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 866);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHospedes";
            this.Load += new System.EventHandler(this.frmHospedes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHospedes_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNovoHospede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnNovoHospede;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.PictureBox btnReceber;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSair;
        public System.Windows.Forms.DataGridView hospedesDataGridView;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource hospedesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.HospedesTableAdapter hospedesTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPagamenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluirHospede;
    }
}