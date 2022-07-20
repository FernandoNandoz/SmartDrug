namespace SmartDrug
{
    partial class frmCadastrarNotaFiscal
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Panel panelTop;
            System.Windows.Forms.Label labTitulo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarNotaFiscal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.tableAdapterManager = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.fornecedorComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cfopComboBox = new System.Windows.Forms.ComboBox();
            this.dataEmissaoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataEntradaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.chaveAcessoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.baseCalculoIcmsTextBox = new System.Windows.Forms.TextBox();
            this.valorIcmsTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.produtosNotaFiscalDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_do_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ndocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.totalProdutosTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.notaFiscalTextBox = new System.Windows.Forms.TextBox();
            this.codigoBarraTextBox = new System.Windows.Forms.TextBox();
            this.fornecedoresTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.FornecedoresTableAdapter();
            this.produtoTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter();
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaFiscalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(904, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 18);
            label4.TabIndex = 176;
            label4.Text = "Valor Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(762, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 18);
            label3.TabIndex = 175;
            label3.Text = "Valor do ICMS:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(566, 79);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(50, 18);
            cidadeLabel.TabIndex = 171;
            cidadeLabel.Text = "CFOP";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(40, 141);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(128, 18);
            enderecoLabel.TabIndex = 170;
            enderecoLabel.Text = "Chave de Acesso:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(589, 143);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(161, 18);
            telefoneLabel.TabIndex = 174;
            telefoneLabel.Text = "Base de Calculo ICMS:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(40, 78);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(87, 18);
            quantidadeLabel.TabIndex = 192;
            quantidadeLabel.Text = "Nota Fiscal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(254, 80);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(126, 18);
            label5.TabIndex = 201;
            label5.Text = "Data de Emissão:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(412, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(118, 18);
            label6.TabIndex = 204;
            label6.Text = "Data de Entrada:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(638, 80);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(89, 18);
            label7.TabIndex = 207;
            label7.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(181, 216);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 18);
            label2.TabIndex = 215;
            label2.Text = "Nome do Produto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(39, 216);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 18);
            label8.TabIndex = 216;
            label8.Text = "Codigo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(905, 216);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 18);
            label9.TabIndex = 222;
            label9.Text = "Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(664, 214);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(101, 18);
            label10.TabIndex = 221;
            label10.Text = "Valor Unitário:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(589, 214);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(44, 18);
            label11.TabIndex = 220;
            label11.Text = "Qntd:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(797, 216);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(77, 18);
            label12.TabIndex = 233;
            label12.Text = "Desconto:";
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
            panelTop.TabIndex = 235;
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            labTitulo.Location = new System.Drawing.Point(432, 5);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(278, 31);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastrar Nota Fiscal";
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
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorTotalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valorTotalTextBox.ForeColor = System.Drawing.Color.Red;
            this.valorTotalTextBox.Location = new System.Drawing.Point(907, 164);
            this.valorTotalTextBox.Multiline = true;
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.ReadOnly = true;
            this.valorTotalTextBox.Size = new System.Drawing.Size(177, 25);
            this.valorTotalTextBox.TabIndex = 8;
            // 
            // fornecedorComboBox
            // 
            this.fornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.fornecedorComboBox.DisplayMember = "nomeRazao";
            this.fornecedorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fornecedorComboBox.FormattingEnabled = true;
            this.fornecedorComboBox.Location = new System.Drawing.Point(641, 101);
            this.fornecedorComboBox.Name = "fornecedorComboBox";
            this.fornecedorComboBox.Size = new System.Drawing.Size(443, 24);
            this.fornecedorComboBox.TabIndex = 4;
            this.fornecedorComboBox.ValueMember = "idFornecedor";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // cfopComboBox
            // 
            this.cfopComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cfopComboBox.FormattingEnabled = true;
            this.cfopComboBox.Items.AddRange(new object[] {
            "5102",
            "6201",
            "5404"});
            this.cfopComboBox.Location = new System.Drawing.Point(569, 101);
            this.cfopComboBox.Name = "cfopComboBox";
            this.cfopComboBox.Size = new System.Drawing.Size(66, 24);
            this.cfopComboBox.TabIndex = 3;
            // 
            // dataEmissaoMaskedTextBox
            // 
            this.dataEmissaoMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataEmissaoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataEmissaoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataEmissaoMaskedTextBox.Location = new System.Drawing.Point(257, 101);
            this.dataEmissaoMaskedTextBox.Mask = "00/00/0000";
            this.dataEmissaoMaskedTextBox.Name = "dataEmissaoMaskedTextBox";
            this.dataEmissaoMaskedTextBox.Size = new System.Drawing.Size(151, 26);
            this.dataEmissaoMaskedTextBox.TabIndex = 1;
            this.dataEmissaoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dataEntradaMaskedTextBox
            // 
            this.dataEntradaMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataEntradaMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataEntradaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataEntradaMaskedTextBox.Location = new System.Drawing.Point(415, 101);
            this.dataEntradaMaskedTextBox.Mask = "00/00/0000";
            this.dataEntradaMaskedTextBox.Name = "dataEntradaMaskedTextBox";
            this.dataEntradaMaskedTextBox.Size = new System.Drawing.Size(148, 26);
            this.dataEntradaMaskedTextBox.TabIndex = 2;
            this.dataEntradaMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // chaveAcessoMaskedTextBox
            // 
            this.chaveAcessoMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chaveAcessoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chaveAcessoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chaveAcessoMaskedTextBox.Location = new System.Drawing.Point(43, 163);
            this.chaveAcessoMaskedTextBox.Mask = "0000.0000.0000.0000.0000.0000.0000.0000.0000.0000.0000";
            this.chaveAcessoMaskedTextBox.Name = "chaveAcessoMaskedTextBox";
            this.chaveAcessoMaskedTextBox.Size = new System.Drawing.Size(543, 26);
            this.chaveAcessoMaskedTextBox.TabIndex = 5;
            this.chaveAcessoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // baseCalculoIcmsTextBox
            // 
            this.baseCalculoIcmsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.baseCalculoIcmsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseCalculoIcmsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.baseCalculoIcmsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baseCalculoIcmsTextBox.Location = new System.Drawing.Point(592, 164);
            this.baseCalculoIcmsTextBox.Multiline = true;
            this.baseCalculoIcmsTextBox.Name = "baseCalculoIcmsTextBox";
            this.baseCalculoIcmsTextBox.ReadOnly = true;
            this.baseCalculoIcmsTextBox.Size = new System.Drawing.Size(167, 25);
            this.baseCalculoIcmsTextBox.TabIndex = 6;
            // 
            // valorIcmsTextBox
            // 
            this.valorIcmsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorIcmsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorIcmsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorIcmsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valorIcmsTextBox.Location = new System.Drawing.Point(765, 164);
            this.valorIcmsTextBox.Multiline = true;
            this.valorIcmsTextBox.Name = "valorIcmsTextBox";
            this.valorIcmsTextBox.ReadOnly = true;
            this.valorIcmsTextBox.Size = new System.Drawing.Size(136, 25);
            this.valorIcmsTextBox.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(569, 600);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 211;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // produtosNotaFiscalDataGridView
            // 
            this.produtosNotaFiscalDataGridView.AllowUserToAddRows = false;
            this.produtosNotaFiscalDataGridView.AllowUserToDeleteRows = false;
            this.produtosNotaFiscalDataGridView.AllowUserToResizeColumns = false;
            this.produtosNotaFiscalDataGridView.AllowUserToResizeRows = false;
            this.produtosNotaFiscalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtosNotaFiscalDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.produtosNotaFiscalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtosNotaFiscalDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.produtosNotaFiscalDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosNotaFiscalDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.produtosNotaFiscalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosNotaFiscalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome_do_Produto,
            this.Valor_unitario,
            this.Total,
            this.Ndocumento,
            this.idProduto});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtosNotaFiscalDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.produtosNotaFiscalDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.produtosNotaFiscalDataGridView.Location = new System.Drawing.Point(42, 290);
            this.produtosNotaFiscalDataGridView.MultiSelect = false;
            this.produtosNotaFiscalDataGridView.Name = "produtosNotaFiscalDataGridView";
            this.produtosNotaFiscalDataGridView.ReadOnly = true;
            this.produtosNotaFiscalDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosNotaFiscalDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.produtosNotaFiscalDataGridView.RowHeadersVisible = false;
            this.produtosNotaFiscalDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.produtosNotaFiscalDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.produtosNotaFiscalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosNotaFiscalDataGridView.Size = new System.Drawing.Size(1042, 289);
            this.produtosNotaFiscalDataGridView.TabIndex = 144;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 170;
            // 
            // Nome_do_Produto
            // 
            this.Nome_do_Produto.HeaderText = "Nome do Produto";
            this.Nome_do_Produto.Name = "Nome_do_Produto";
            this.Nome_do_Produto.ReadOnly = true;
            this.Nome_do_Produto.Width = 522;
            // 
            // Valor_unitario
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.Valor_unitario.DefaultCellStyle = dataGridViewCellStyle7;
            this.Valor_unitario.HeaderText = "Valor Unitário";
            this.Valor_unitario.Name = "Valor_unitario";
            this.Valor_unitario.ReadOnly = true;
            this.Valor_unitario.Width = 165;
            // 
            // Total
            // 
            dataGridViewCellStyle8.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 185;
            // 
            // Ndocumento
            // 
            this.Ndocumento.HeaderText = "Ndocumento";
            this.Ndocumento.Name = "Ndocumento";
            this.Ndocumento.ReadOnly = true;
            this.Ndocumento.Visible = false;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
            // 
            // nomeProdutoComboBox
            // 
            this.nomeProdutoComboBox.DataSource = this.produtoBindingSource;
            this.nomeProdutoComboBox.DisplayMember = "nome";
            this.nomeProdutoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeProdutoComboBox.FormattingEnabled = true;
            this.nomeProdutoComboBox.Location = new System.Drawing.Point(184, 237);
            this.nomeProdutoComboBox.Name = "nomeProdutoComboBox";
            this.nomeProdutoComboBox.Size = new System.Drawing.Size(402, 24);
            this.nomeProdutoComboBox.TabIndex = 10;
            this.nomeProdutoComboBox.ValueMember = "idProduto";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // valorUnitarioTextBox
            // 
            this.valorUnitarioTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorUnitarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorUnitarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco", true));
            this.valorUnitarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valorUnitarioTextBox.Location = new System.Drawing.Point(667, 237);
            this.valorUnitarioTextBox.Multiline = true;
            this.valorUnitarioTextBox.Name = "valorUnitarioTextBox";
            this.valorUnitarioTextBox.ReadOnly = true;
            this.valorUnitarioTextBox.Size = new System.Drawing.Size(115, 25);
            this.valorUnitarioTextBox.TabIndex = 12;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.quantidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantidadeTextBox.Location = new System.Drawing.Point(592, 237);
            this.quantidadeTextBox.Multiline = true;
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(69, 25);
            this.quantidadeTextBox.TabIndex = 11;
            // 
            // totalProdutosTextBox
            // 
            this.totalProdutosTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.totalProdutosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalProdutosTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.totalProdutosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalProdutosTextBox.Location = new System.Drawing.Point(907, 236);
            this.totalProdutosTextBox.Multiline = true;
            this.totalProdutosTextBox.Name = "totalProdutosTextBox";
            this.totalProdutosTextBox.ReadOnly = true;
            this.totalProdutosTextBox.Size = new System.Drawing.Size(177, 25);
            this.totalProdutosTextBox.TabIndex = 14;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(448, 600);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 228;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // notaFiscalTextBox
            // 
            this.notaFiscalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.notaFiscalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notaFiscalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.notaFiscalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.notaFiscalTextBox.Location = new System.Drawing.Point(43, 101);
            this.notaFiscalTextBox.Multiline = true;
            this.notaFiscalTextBox.Name = "notaFiscalTextBox";
            this.notaFiscalTextBox.Size = new System.Drawing.Size(208, 25);
            this.notaFiscalTextBox.TabIndex = 0;
            this.notaFiscalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notaFiscalTextBox_KeyDown);
            // 
            // codigoBarraTextBox
            // 
            this.codigoBarraTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codigoBarraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoBarraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoBarraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "codigoBarra", true));
            this.codigoBarraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigoBarraTextBox.Location = new System.Drawing.Point(43, 237);
            this.codigoBarraTextBox.Multiline = true;
            this.codigoBarraTextBox.Name = "codigoBarraTextBox";
            this.codigoBarraTextBox.Size = new System.Drawing.Size(135, 25);
            this.codigoBarraTextBox.TabIndex = 9;
            this.codigoBarraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigoBarraTextBox_KeyDown);
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descontoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descontoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descontoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descontoTextBox.Location = new System.Drawing.Point(788, 237);
            this.descontoTextBox.Multiline = true;
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.Size = new System.Drawing.Size(113, 25);
            this.descontoTextBox.TabIndex = 13;
            this.descontoTextBox.TextChanged += new System.EventHandler(this.descontoTextBox_TextChanged);
            this.descontoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descontoTextBox_KeyDown);
            // 
            // frmCadastrarNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.descontoTextBox);
            this.Controls.Add(label12);
            this.Controls.Add(this.codigoBarraTextBox);
            this.Controls.Add(this.notaFiscalTextBox);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.valorUnitarioTextBox);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(label9);
            this.Controls.Add(label10);
            this.Controls.Add(this.totalProdutosTextBox);
            this.Controls.Add(label11);
            this.Controls.Add(label8);
            this.Controls.Add(this.nomeProdutoComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.produtosNotaFiscalDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.valorIcmsTextBox);
            this.Controls.Add(this.baseCalculoIcmsTextBox);
            this.Controls.Add(this.fornecedorComboBox);
            this.Controls.Add(label7);
            this.Controls.Add(this.chaveAcessoMaskedTextBox);
            this.Controls.Add(label6);
            this.Controls.Add(this.dataEntradaMaskedTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.dataEmissaoMaskedTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(this.cfopComboBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(telefoneLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadastrarNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarNotaFiscal";
            this.Load += new System.EventHandler(this.frmCadastrarNotaFiscal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastrarNotaFiscal_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosNotaFiscalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.ComboBox fornecedorComboBox;
        private System.Windows.Forms.ComboBox cfopComboBox;
        private System.Windows.Forms.MaskedTextBox dataEmissaoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataEntradaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox chaveAcessoMaskedTextBox;
        private System.Windows.Forms.TextBox baseCalculoIcmsTextBox;
        private System.Windows.Forms.TextBox valorIcmsTextBox;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.DataGridView produtosNotaFiscalDataGridView;
        private System.Windows.Forms.ComboBox nomeProdutoComboBox;
        private System.Windows.Forms.TextBox valorUnitarioTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox totalProdutosTextBox;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.TextBox notaFiscalTextBox;
        private System.Windows.Forms.TextBox codigoBarraTextBox;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_do_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ndocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
    }
}