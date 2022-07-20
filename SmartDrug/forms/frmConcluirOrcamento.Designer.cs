namespace SmartDrug.forms
{
    partial class frmConcluirOrcamento
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
            System.Windows.Forms.Label labTitulo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConcluirOrcamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewOrcamentos = new System.Windows.Forms.DataGridView();
            this.ndocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProdutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacaoNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnFaturarOrcamento = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.radDataCompra = new System.Windows.Forms.RadioButton();
            this.radDescricaoCompra = new System.Windows.Forms.RadioButton();
            this.dataFinalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataInicialMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.relacaoNotasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrcamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturarOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            panelTop.Controls.Add(labTitulo);
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.ForeColor = System.Drawing.Color.Gainsboro;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1130, 41);
            panelTop.TabIndex = 18;
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            labTitulo.Location = new System.Drawing.Point(488, 4);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(162, 31);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Orçamentos";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 231;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(565, 102);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 25);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 304;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(46, 101);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(513, 26);
            this.textPesquisa.TabIndex = 0;
            this.textPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisa_KeyDown);
            // 
            // dataGridViewOrcamentos
            // 
            this.dataGridViewOrcamentos.AllowUserToAddRows = false;
            this.dataGridViewOrcamentos.AllowUserToDeleteRows = false;
            this.dataGridViewOrcamentos.AllowUserToResizeColumns = false;
            this.dataGridViewOrcamentos.AllowUserToResizeRows = false;
            this.dataGridViewOrcamentos.AutoGenerateColumns = false;
            this.dataGridViewOrcamentos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewOrcamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrcamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOrcamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrcamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrcamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndocumentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoVendaDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.nomeVendedorDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.parcelaDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.idVendedorDataGridViewTextBoxColumn,
            this.idFormaPagamentoDataGridViewTextBoxColumn,
            this.idSituacaoDataGridViewTextBoxColumn,
            this.idSituacaoClienteDataGridViewTextBoxColumn,
            this.idVendasDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.quantidadeProdutosDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridViewOrcamentos.DataSource = this.relacaoNotasBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrcamentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrcamentos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrcamentos.Location = new System.Drawing.Point(46, 146);
            this.dataGridViewOrcamentos.MultiSelect = false;
            this.dataGridViewOrcamentos.Name = "dataGridViewOrcamentos";
            this.dataGridViewOrcamentos.ReadOnly = true;
            this.dataGridViewOrcamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrcamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrcamentos.RowHeadersVisible = false;
            this.dataGridViewOrcamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrcamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOrcamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrcamentos.Size = new System.Drawing.Size(1042, 394);
            this.dataGridViewOrcamentos.TabIndex = 306;
            this.dataGridViewOrcamentos.TabStop = false;
            this.dataGridViewOrcamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOrcamentos_KeyDown);
            // 
            // ndocumentoDataGridViewTextBoxColumn
            // 
            this.ndocumentoDataGridViewTextBoxColumn.DataPropertyName = "Ndocumento";
            this.ndocumentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.ndocumentoDataGridViewTextBoxColumn.Name = "ndocumentoDataGridViewTextBoxColumn";
            this.ndocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndocumentoDataGridViewTextBoxColumn.Width = 115;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // descricaoVendaDataGridViewTextBoxColumn
            // 
            this.descricaoVendaDataGridViewTextBoxColumn.DataPropertyName = "descricaoVenda";
            this.descricaoVendaDataGridViewTextBoxColumn.HeaderText = "descricaoVenda";
            this.descricaoVendaDataGridViewTextBoxColumn.Name = "descricaoVendaDataGridViewTextBoxColumn";
            this.descricaoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoVendaDataGridViewTextBoxColumn.Width = 270;
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "dataEmissao";
            dataGridViewCellStyle2.Format = "g";
            this.dataEmissaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            this.dataEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEmissaoDataGridViewTextBoxColumn.Width = 107;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            dataGridViewCellStyle3.Format = "C2";
            this.valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 110;
            // 
            // nomeVendedorDataGridViewTextBoxColumn
            // 
            this.nomeVendedorDataGridViewTextBoxColumn.DataPropertyName = "nomeVendedor";
            this.nomeVendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.nomeVendedorDataGridViewTextBoxColumn.Name = "nomeVendedorDataGridViewTextBoxColumn";
            this.nomeVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeVendedorDataGridViewTextBoxColumn.Width = 140;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "desconto";
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Visible = false;
            // 
            // parcelaDataGridViewTextBoxColumn
            // 
            this.parcelaDataGridViewTextBoxColumn.DataPropertyName = "parcela";
            this.parcelaDataGridViewTextBoxColumn.HeaderText = "parcela";
            this.parcelaDataGridViewTextBoxColumn.Name = "parcelaDataGridViewTextBoxColumn";
            this.parcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcelaDataGridViewTextBoxColumn.Visible = false;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            this.jurosDataGridViewTextBoxColumn.Visible = false;
            // 
            // idVendedorDataGridViewTextBoxColumn
            // 
            this.idVendedorDataGridViewTextBoxColumn.DataPropertyName = "idVendedor";
            this.idVendedorDataGridViewTextBoxColumn.HeaderText = "idVendedor";
            this.idVendedorDataGridViewTextBoxColumn.Name = "idVendedorDataGridViewTextBoxColumn";
            this.idVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.idFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "idFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "idFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.Name = "idFormaPagamentoDataGridViewTextBoxColumn";
            this.idFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFormaPagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoDataGridViewTextBoxColumn
            // 
            this.idSituacaoDataGridViewTextBoxColumn.DataPropertyName = "idSituacao";
            this.idSituacaoDataGridViewTextBoxColumn.HeaderText = "idSituacao";
            this.idSituacaoDataGridViewTextBoxColumn.Name = "idSituacaoDataGridViewTextBoxColumn";
            this.idSituacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoClienteDataGridViewTextBoxColumn
            // 
            this.idSituacaoClienteDataGridViewTextBoxColumn.DataPropertyName = "idSituacaoCliente";
            this.idSituacaoClienteDataGridViewTextBoxColumn.HeaderText = "idSituacaoCliente";
            this.idSituacaoClienteDataGridViewTextBoxColumn.Name = "idSituacaoClienteDataGridViewTextBoxColumn";
            this.idSituacaoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idVendasDataGridViewTextBoxColumn
            // 
            this.idVendasDataGridViewTextBoxColumn.DataPropertyName = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.HeaderText = "idVendas";
            this.idVendasDataGridViewTextBoxColumn.Name = "idVendasDataGridViewTextBoxColumn";
            this.idVendasDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendasDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantidadeProdutosDataGridViewTextBoxColumn
            // 
            this.quantidadeProdutosDataGridViewTextBoxColumn.DataPropertyName = "quantidadeProdutos";
            this.quantidadeProdutosDataGridViewTextBoxColumn.HeaderText = "quantidadeProdutos";
            this.quantidadeProdutosDataGridViewTextBoxColumn.Name = "quantidadeProdutosDataGridViewTextBoxColumn";
            this.quantidadeProdutosDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeProdutosDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // relacaoNotasBindingSource
            // 
            this.relacaoNotasBindingSource.DataMember = "RelacaoNotas";
            this.relacaoNotasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(656, 573);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 38);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 334;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFaturarOrcamento
            // 
            this.btnFaturarOrcamento.BackColor = System.Drawing.Color.Transparent;
            this.btnFaturarOrcamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaturarOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturarOrcamento.Image")));
            this.btnFaturarOrcamento.Location = new System.Drawing.Point(505, 573);
            this.btnFaturarOrcamento.Name = "btnFaturarOrcamento";
            this.btnFaturarOrcamento.Size = new System.Drawing.Size(145, 38);
            this.btnFaturarOrcamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFaturarOrcamento.TabIndex = 333;
            this.btnFaturarOrcamento.TabStop = false;
            this.btnFaturarOrcamento.Click += new System.EventHandler(this.btnConcluirOrcamento_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(374, 573);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 38);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 332;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // radDataCompra
            // 
            this.radDataCompra.AutoSize = true;
            this.radDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDataCompra.Location = new System.Drawing.Point(232, 74);
            this.radDataCompra.Name = "radDataCompra";
            this.radDataCompra.Size = new System.Drawing.Size(144, 24);
            this.radDataCompra.TabIndex = 338;
            this.radDataCompra.Text = "Data da Compra";
            this.radDataCompra.UseVisualStyleBackColor = true;
            this.radDataCompra.CheckedChanged += new System.EventHandler(this.radDataCompra_CheckedChanged);
            // 
            // radDescricaoCompra
            // 
            this.radDescricaoCompra.AutoSize = true;
            this.radDescricaoCompra.Checked = true;
            this.radDescricaoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDescricaoCompra.Location = new System.Drawing.Point(46, 74);
            this.radDescricaoCompra.Name = "radDescricaoCompra";
            this.radDescricaoCompra.Size = new System.Drawing.Size(180, 24);
            this.radDescricaoCompra.TabIndex = 337;
            this.radDescricaoCompra.TabStop = true;
            this.radDescricaoCompra.Text = "Descrição da Compra";
            this.radDescricaoCompra.UseVisualStyleBackColor = true;
            this.radDescricaoCompra.CheckedChanged += new System.EventHandler(this.radDescricaoCompra_CheckedChanged);
            // 
            // dataFinalMaskedTextBox
            // 
            this.dataFinalMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataFinalMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataFinalMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalMaskedTextBox.Location = new System.Drawing.Point(232, 101);
            this.dataFinalMaskedTextBox.Mask = "00/00/0000";
            this.dataFinalMaskedTextBox.Name = "dataFinalMaskedTextBox";
            this.dataFinalMaskedTextBox.Size = new System.Drawing.Size(169, 26);
            this.dataFinalMaskedTextBox.TabIndex = 340;
            this.dataFinalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataFinalMaskedTextBox.Visible = false;
            // 
            // dataInicialMaskedTextBox
            // 
            this.dataInicialMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataInicialMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataInicialMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicialMaskedTextBox.Location = new System.Drawing.Point(46, 101);
            this.dataInicialMaskedTextBox.Mask = "00/00/0000";
            this.dataInicialMaskedTextBox.Name = "dataInicialMaskedTextBox";
            this.dataInicialMaskedTextBox.Size = new System.Drawing.Size(169, 26);
            this.dataInicialMaskedTextBox.TabIndex = 339;
            this.dataInicialMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataInicialMaskedTextBox.Visible = false;
            // 
            // relacaoNotasTableAdapter
            // 
            this.relacaoNotasTableAdapter.ClearBeforeFill = true;
            // 
            // frmConcluirOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(this.dataGridViewOrcamentos);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.dataInicialMaskedTextBox);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataFinalMaskedTextBox);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnFaturarOrcamento);
            this.Controls.Add(this.radDescricaoCompra);
            this.Controls.Add(this.radDataCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConcluirOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConcluirOrcamento";
            this.Load += new System.EventHandler(this.frmConcluirOrcamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConcluirOrcamento_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrcamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFaturarOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisa;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnFaturarOrcamento;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.BindingSource relacaoNotasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoNotasTableAdapter relacaoNotasTableAdapter;
        private System.Windows.Forms.RadioButton radDataCompra;
        private System.Windows.Forms.RadioButton radDescricaoCompra;
        private System.Windows.Forms.MaskedTextBox dataFinalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataInicialMaskedTextBox;
        public System.Windows.Forms.DataGridView dataGridViewOrcamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnFechar;

    }
}