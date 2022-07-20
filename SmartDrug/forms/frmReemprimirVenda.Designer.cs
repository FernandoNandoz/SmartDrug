namespace SmartDrug.forms
{
    partial class frmReemprimirVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReemprimirVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewReemprimirVendas = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            this.radDataCompra = new System.Windows.Forms.RadioButton();
            this.radDescricaoCompra = new System.Windows.Forms.RadioButton();
            this.dataFinalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataInicialMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.ndocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPacelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContasReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCupomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacaoContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.relacaoContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReemprimirVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
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
            panelTop.TabIndex = 351;
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            labTitulo.Location = new System.Drawing.Point(435, 5);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(238, 31);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Reemprimir Venda";
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
            this.btnPesquisar.Location = new System.Drawing.Point(560, 101);
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
            this.textPesquisa.Location = new System.Drawing.Point(41, 101);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(513, 26);
            this.textPesquisa.TabIndex = 302;
            this.textPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisa_KeyDown);
            // 
            // dataGridViewReemprimirVendas
            // 
            this.dataGridViewReemprimirVendas.AllowUserToAddRows = false;
            this.dataGridViewReemprimirVendas.AllowUserToDeleteRows = false;
            this.dataGridViewReemprimirVendas.AllowUserToResizeColumns = false;
            this.dataGridViewReemprimirVendas.AllowUserToResizeRows = false;
            this.dataGridViewReemprimirVendas.AutoGenerateColumns = false;
            this.dataGridViewReemprimirVendas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewReemprimirVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReemprimirVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewReemprimirVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReemprimirVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewReemprimirVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReemprimirVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndocumentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataCompraDataGridViewTextBoxColumn,
            this.parcelaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.vendedorHaverDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idSituacaoDataGridViewTextBoxColumn,
            this.idVendedorDataGridViewTextBoxColumn,
            this.nomeVendedorDataGridViewTextBoxColumn,
            this.valorPacelaDataGridViewTextBoxColumn,
            this.idContasReceberDataGridViewTextBoxColumn,
            this.situacaoClienteDataGridViewTextBoxColumn,
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn,
            this.ultimoHaverDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.idSituacaoContaDataGridViewTextBoxColumn,
            this.situacaoContaDataGridViewTextBoxColumn,
            this.dataCupomDataGridViewTextBoxColumn});
            this.dataGridViewReemprimirVendas.DataSource = this.relacaoContasBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReemprimirVendas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewReemprimirVendas.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReemprimirVendas.Location = new System.Drawing.Point(41, 145);
            this.dataGridViewReemprimirVendas.MultiSelect = false;
            this.dataGridViewReemprimirVendas.Name = "dataGridViewReemprimirVendas";
            this.dataGridViewReemprimirVendas.ReadOnly = true;
            this.dataGridViewReemprimirVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReemprimirVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewReemprimirVendas.RowHeadersVisible = false;
            this.dataGridViewReemprimirVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReemprimirVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReemprimirVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReemprimirVendas.Size = new System.Drawing.Size(1047, 406);
            this.dataGridViewReemprimirVendas.TabIndex = 306;
            this.dataGridViewReemprimirVendas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewReemprimirVendas_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(628, 580);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 35);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 337;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(497, 580);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(125, 35);
            this.btnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImprimir.TabIndex = 336;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // radDataCompra
            // 
            this.radDataCompra.AutoSize = true;
            this.radDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDataCompra.Location = new System.Drawing.Point(227, 76);
            this.radDataCompra.Name = "radDataCompra";
            this.radDataCompra.Size = new System.Drawing.Size(144, 24);
            this.radDataCompra.TabIndex = 346;
            this.radDataCompra.Text = "Data da Compra";
            this.radDataCompra.UseVisualStyleBackColor = true;
            this.radDataCompra.CheckedChanged += new System.EventHandler(this.radDataCompra_CheckedChanged);
            // 
            // radDescricaoCompra
            // 
            this.radDescricaoCompra.AutoSize = true;
            this.radDescricaoCompra.Checked = true;
            this.radDescricaoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDescricaoCompra.Location = new System.Drawing.Point(41, 76);
            this.radDescricaoCompra.Name = "radDescricaoCompra";
            this.radDescricaoCompra.Size = new System.Drawing.Size(180, 24);
            this.radDescricaoCompra.TabIndex = 345;
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
            this.dataFinalMaskedTextBox.Location = new System.Drawing.Point(227, 101);
            this.dataFinalMaskedTextBox.Mask = "00/00/0000";
            this.dataFinalMaskedTextBox.Name = "dataFinalMaskedTextBox";
            this.dataFinalMaskedTextBox.Size = new System.Drawing.Size(171, 26);
            this.dataFinalMaskedTextBox.TabIndex = 350;
            this.dataFinalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataFinalMaskedTextBox.Visible = false;
            // 
            // dataInicialMaskedTextBox
            // 
            this.dataInicialMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataInicialMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataInicialMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicialMaskedTextBox.Location = new System.Drawing.Point(41, 101);
            this.dataInicialMaskedTextBox.Mask = "00/00/0000";
            this.dataInicialMaskedTextBox.Name = "dataInicialMaskedTextBox";
            this.dataInicialMaskedTextBox.Size = new System.Drawing.Size(171, 26);
            this.dataInicialMaskedTextBox.TabIndex = 349;
            this.dataInicialMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataInicialMaskedTextBox.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(365, 580);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 35);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 335;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição da Venda";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 255;
            // 
            // dataCompraDataGridViewTextBoxColumn
            // 
            this.dataCompraDataGridViewTextBoxColumn.DataPropertyName = "dataCompra";
            dataGridViewCellStyle12.Format = "g";
            this.dataCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataCompraDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataCompraDataGridViewTextBoxColumn.Name = "dataCompraDataGridViewTextBoxColumn";
            this.dataCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCompraDataGridViewTextBoxColumn.Width = 115;
            // 
            // parcelaDataGridViewTextBoxColumn
            // 
            this.parcelaDataGridViewTextBoxColumn.DataPropertyName = "parcela";
            this.parcelaDataGridViewTextBoxColumn.HeaderText = "parcela";
            this.parcelaDataGridViewTextBoxColumn.Name = "parcelaDataGridViewTextBoxColumn";
            this.parcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcelaDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle13.Format = "C2";
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 130;
            // 
            // vendedorHaverDataGridViewTextBoxColumn
            // 
            this.vendedorHaverDataGridViewTextBoxColumn.DataPropertyName = "vendedorHaver";
            this.vendedorHaverDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorHaverDataGridViewTextBoxColumn.Name = "vendedorHaverDataGridViewTextBoxColumn";
            this.vendedorHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorHaverDataGridViewTextBoxColumn.Width = 132;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoDataGridViewTextBoxColumn
            // 
            this.idSituacaoDataGridViewTextBoxColumn.DataPropertyName = "idSituacao";
            this.idSituacaoDataGridViewTextBoxColumn.HeaderText = "idSituacao";
            this.idSituacaoDataGridViewTextBoxColumn.Name = "idSituacaoDataGridViewTextBoxColumn";
            this.idSituacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idVendedorDataGridViewTextBoxColumn
            // 
            this.idVendedorDataGridViewTextBoxColumn.DataPropertyName = "idVendedor";
            this.idVendedorDataGridViewTextBoxColumn.HeaderText = "idVendedor";
            this.idVendedorDataGridViewTextBoxColumn.Name = "idVendedorDataGridViewTextBoxColumn";
            this.idVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeVendedorDataGridViewTextBoxColumn
            // 
            this.nomeVendedorDataGridViewTextBoxColumn.DataPropertyName = "nomeVendedor";
            this.nomeVendedorDataGridViewTextBoxColumn.HeaderText = "nomeVendedor";
            this.nomeVendedorDataGridViewTextBoxColumn.Name = "nomeVendedorDataGridViewTextBoxColumn";
            this.nomeVendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeVendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorPacelaDataGridViewTextBoxColumn
            // 
            this.valorPacelaDataGridViewTextBoxColumn.DataPropertyName = "valorPacela";
            this.valorPacelaDataGridViewTextBoxColumn.HeaderText = "valorPacela";
            this.valorPacelaDataGridViewTextBoxColumn.Name = "valorPacelaDataGridViewTextBoxColumn";
            this.valorPacelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorPacelaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idContasReceberDataGridViewTextBoxColumn
            // 
            this.idContasReceberDataGridViewTextBoxColumn.DataPropertyName = "idContasReceber";
            this.idContasReceberDataGridViewTextBoxColumn.HeaderText = "idContasReceber";
            this.idContasReceberDataGridViewTextBoxColumn.Name = "idContasReceberDataGridViewTextBoxColumn";
            this.idContasReceberDataGridViewTextBoxColumn.ReadOnly = true;
            this.idContasReceberDataGridViewTextBoxColumn.Visible = false;
            // 
            // situacaoClienteDataGridViewTextBoxColumn
            // 
            this.situacaoClienteDataGridViewTextBoxColumn.DataPropertyName = "SituacaoCliente";
            this.situacaoClienteDataGridViewTextBoxColumn.HeaderText = "SituacaoCliente";
            this.situacaoClienteDataGridViewTextBoxColumn.Name = "situacaoClienteDataGridViewTextBoxColumn";
            this.situacaoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoSituacaoReceberDataGridViewTextBoxColumn
            // 
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn.DataPropertyName = "descricaoSituacaoReceber";
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn.HeaderText = "descricaoSituacaoReceber";
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn.Name = "descricaoSituacaoReceberDataGridViewTextBoxColumn";
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoSituacaoReceberDataGridViewTextBoxColumn.Visible = false;
            // 
            // ultimoHaverDataGridViewTextBoxColumn
            // 
            this.ultimoHaverDataGridViewTextBoxColumn.DataPropertyName = "ultimoHaver";
            this.ultimoHaverDataGridViewTextBoxColumn.HeaderText = "ultimoHaver";
            this.ultimoHaverDataGridViewTextBoxColumn.Name = "ultimoHaverDataGridViewTextBoxColumn";
            this.ultimoHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoHaverDataGridViewTextBoxColumn.Visible = false;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoContaDataGridViewTextBoxColumn
            // 
            this.idSituacaoContaDataGridViewTextBoxColumn.DataPropertyName = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.HeaderText = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.Name = "idSituacaoContaDataGridViewTextBoxColumn";
            this.idSituacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoContaDataGridViewTextBoxColumn.Visible = false;
            // 
            // situacaoContaDataGridViewTextBoxColumn
            // 
            this.situacaoContaDataGridViewTextBoxColumn.DataPropertyName = "SituacaoConta";
            this.situacaoContaDataGridViewTextBoxColumn.HeaderText = "SituacaoConta";
            this.situacaoContaDataGridViewTextBoxColumn.Name = "situacaoContaDataGridViewTextBoxColumn";
            this.situacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoContaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataCupomDataGridViewTextBoxColumn
            // 
            this.dataCupomDataGridViewTextBoxColumn.DataPropertyName = "dataCupom";
            this.dataCupomDataGridViewTextBoxColumn.HeaderText = "dataCupom";
            this.dataCupomDataGridViewTextBoxColumn.Name = "dataCupomDataGridViewTextBoxColumn";
            this.dataCupomDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCupomDataGridViewTextBoxColumn.Visible = false;
            // 
            // relacaoContasBindingSource
            // 
            this.relacaoContasBindingSource.DataMember = "RelacaoContas";
            this.relacaoContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relacaoContasTableAdapter
            // 
            this.relacaoContasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReemprimirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridViewReemprimirVendas);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.dataFinalMaskedTextBox);
            this.Controls.Add(this.dataInicialMaskedTextBox);
            this.Controls.Add(this.radDataCompra);
            this.Controls.Add(this.radDescricaoCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReemprimirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReemprimirVenda";
            this.Load += new System.EventHandler(this.frmReemprimirVenda_Load);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReemprimirVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox textPesquisa;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource relacaoContasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoContasTableAdapter relacaoContasTableAdapter;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnImprimir;
        private System.Windows.Forms.RadioButton radDataCompra;
        private System.Windows.Forms.RadioButton radDescricaoCompra;
        private System.Windows.Forms.MaskedTextBox dataFinalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataInicialMaskedTextBox;
        public System.Windows.Forms.DataGridView dataGridViewReemprimirVendas;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaRecebimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPacelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContasReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoSituacaoReceberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCupomDataGridViewTextBoxColumn;

    }
}