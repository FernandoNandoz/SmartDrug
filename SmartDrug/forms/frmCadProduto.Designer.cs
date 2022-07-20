namespace SmartDrug.forms
{
    partial class frmCadProduto
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
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label nome_produtoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProduto));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.labelTipoAcao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.nome_produtoTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.composicaoTextBox = new System.Windows.Forms.TextBox();
            this.tipoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.NCMtextBox = new System.Windows.Forms.TextBox();
            this.CTLtextBox = new System.Windows.Forms.TextBox();
            this.produtoTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.labelVendedorAlteracao = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelNomeCompleto = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.PesquisarTextBox = new System.Windows.Forms.TextBox();
            this.panelButoes = new System.Windows.Forms.Panel();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnAlterarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.btnLimparValores = new System.Windows.Forms.Button();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            observacaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.panelButoes.SuspendLayout();
            this.panelCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.BackColor = System.Drawing.Color.Transparent;
            observacaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            observacaoLabel.Location = new System.Drawing.Point(311, 311);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(98, 20);
            observacaoLabel.TabIndex = 19;
            observacaoLabel.Text = "Observacao:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            quantidadeLabel.Location = new System.Drawing.Point(311, 202);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(106, 20);
            quantidadeLabel.TabIndex = 12;
            quantidadeLabel.Text = "Quantidade: *";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.BackColor = System.Drawing.Color.Transparent;
            nome_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_produtoLabel.Location = new System.Drawing.Point(472, 92);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(125, 20);
            nome_produtoLabel.TabIndex = 11;
            nome_produtoLabel.Text = "Nome Produto: *";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.BackColor = System.Drawing.Color.Transparent;
            codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            codigoLabel.Location = new System.Drawing.Point(312, 92);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(73, 20);
            codigoLabel.TabIndex = 10;
            codigoLabel.Text = "Codigo: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label4.Location = new System.Drawing.Point(472, 255);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 20);
            label4.TabIndex = 15;
            label4.Text = "Composição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label5.Location = new System.Drawing.Point(638, 147);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 20);
            label5.TabIndex = 14;
            label5.Text = "Tipo Produto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label7.Location = new System.Drawing.Point(311, 255);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 20);
            label7.TabIndex = 16;
            label7.Text = "Preco: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(472, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(166, 20);
            label2.TabIndex = 13;
            label2.Text = "Descrição do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(472, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 20);
            label3.TabIndex = 118;
            label3.Text = "NCM:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label6.Location = new System.Drawing.Point(311, 147);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 20);
            label6.TabIndex = 121;
            label6.Text = "CTL:";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1123, 57);
            panelTop.TabIndex = 123;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 28;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labTitulo.Location = new System.Drawing.Point(419, 12);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(281, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastrar Produto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label14.Location = new System.Drawing.Point(239, 44);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(30, 20);
            label14.TabIndex = 657;
            label14.Text = "ID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(194, 6);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(83, 20);
            label13.TabIndex = 655;
            label13.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label1.Location = new System.Drawing.Point(303, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 20);
            label1.TabIndex = 251;
            label1.Text = "Pesquisar Produto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(679, 172);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(100, 20);
            label12.TabIndex = 686;
            label12.Text = "Alterado por:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(209, 172);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(123, 20);
            label15.TabIndex = 683;
            label15.Text = "Cadastrado por:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(217, 140);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(115, 20);
            label16.TabIndex = 682;
            label16.Text = "Nome Produto:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label17.Location = new System.Drawing.Point(312, 20);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(83, 20);
            label17.TabIndex = 276;
            label17.Text = "Vendedor:";
            // 
            // labelTipoAcao
            // 
            this.labelTipoAcao.AutoSize = true;
            this.labelTipoAcao.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAcao.Location = new System.Drawing.Point(194, 108);
            this.labelTipoAcao.Name = "labelTipoAcao";
            this.labelTipoAcao.Size = new System.Drawing.Size(129, 20);
            this.labelTipoAcao.TabIndex = 654;
            this.labelTipoAcao.Text = "Alterar Cadastro:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(576, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 89;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(455, 408);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 88;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.observacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "observacao", true));
            this.observacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.observacaoTextBox.Location = new System.Drawing.Point(315, 335);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(520, 36);
            this.observacaoTextBox.TabIndex = 11;
            this.observacaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.observacaoTextBox_KeyDown);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // precoTextBox
            // 
            this.precoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.precoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco", true));
            this.precoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precoTextBox.Location = new System.Drawing.Point(315, 279);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(150, 26);
            this.precoTextBox.TabIndex = 9;
            this.precoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.quantidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "quantidade", true));
            this.quantidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantidadeTextBox.Location = new System.Drawing.Point(315, 225);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(150, 26);
            this.quantidadeTextBox.TabIndex = 7;
            this.quantidadeTextBox.Text = "0";
            this.quantidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // nome_produtoTextBox
            // 
            this.nome_produtoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nome_produtoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_produtoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.nome_produtoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_produtoTextBox.Location = new System.Drawing.Point(476, 116);
            this.nome_produtoTextBox.Name = "nome_produtoTextBox";
            this.nome_produtoTextBox.Size = new System.Drawing.Size(359, 26);
            this.nome_produtoTextBox.TabIndex = 3;
            this.nome_produtoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "codigoBarra", true));
            this.codigoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigoTextBox.Location = new System.Drawing.Point(315, 116);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(150, 26);
            this.codigoTextBox.TabIndex = 2;
            this.codigoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigoTextBox_KeyDown);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descricaoTextBox.Location = new System.Drawing.Point(476, 225);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(358, 26);
            this.descricaoTextBox.TabIndex = 8;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // composicaoTextBox
            // 
            this.composicaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.composicaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.composicaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.composicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "composicao", true));
            this.composicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.composicaoTextBox.Location = new System.Drawing.Point(477, 279);
            this.composicaoTextBox.Name = "composicaoTextBox";
            this.composicaoTextBox.Size = new System.Drawing.Size(358, 26);
            this.composicaoTextBox.TabIndex = 10;
            this.composicaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // tipoProdutoTextBox
            // 
            this.tipoProdutoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.tipoProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoProdutoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "tipoProduto", true));
            this.tipoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tipoProdutoTextBox.Location = new System.Drawing.Point(641, 170);
            this.tipoProdutoTextBox.Name = "tipoProdutoTextBox";
            this.tipoProdutoTextBox.Size = new System.Drawing.Size(194, 26);
            this.tipoProdutoTextBox.TabIndex = 6;
            this.tipoProdutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // NCMtextBox
            // 
            this.NCMtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NCMtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NCMtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NCMtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "NCM", true));
            this.NCMtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NCMtextBox.Location = new System.Drawing.Point(476, 170);
            this.NCMtextBox.Name = "NCMtextBox";
            this.NCMtextBox.Size = new System.Drawing.Size(154, 26);
            this.NCMtextBox.TabIndex = 5;
            this.NCMtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // CTLtextBox
            // 
            this.CTLtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CTLtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTLtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CTLtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "CTL", true));
            this.CTLtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CTLtextBox.Location = new System.Drawing.Point(315, 170);
            this.CTLtextBox.Name = "CTLtextBox";
            this.CTLtextBox.Size = new System.Drawing.Size(150, 26);
            this.CTLtextBox.TabIndex = 4;
            this.CTLtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.labelVendedorAlteracao);
            this.panelAlterar.Controls.Add(label12);
            this.panelAlterar.Controls.Add(this.labelVendedor);
            this.panelAlterar.Controls.Add(this.labelNomeCompleto);
            this.panelAlterar.Controls.Add(label15);
            this.panelAlterar.Controls.Add(label16);
            this.panelAlterar.Controls.Add(label14);
            this.panelAlterar.Controls.Add(this.idTextBox);
            this.panelAlterar.Controls.Add(label13);
            this.panelAlterar.Controls.Add(this.labelTipoAcao);
            this.panelAlterar.Controls.Add(this.btnPesquisar);
            this.panelAlterar.Controls.Add(label1);
            this.panelAlterar.Controls.Add(this.PesquisarTextBox);
            this.panelAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlterar.Location = new System.Drawing.Point(0, 100);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(1123, 204);
            this.panelAlterar.TabIndex = 206;
            this.panelAlterar.Visible = false;
            // 
            // labelVendedorAlteracao
            // 
            this.labelVendedorAlteracao.AutoSize = true;
            this.labelVendedorAlteracao.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedorAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "vendedorAlteracao", true));
            this.labelVendedorAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedorAlteracao.Location = new System.Drawing.Point(780, 172);
            this.labelVendedorAlteracao.Name = "labelVendedorAlteracao";
            this.labelVendedorAlteracao.Size = new System.Drawing.Size(0, 20);
            this.labelVendedorAlteracao.TabIndex = 687;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "vendedor", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(333, 172);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(0, 20);
            this.labelVendedor.TabIndex = 685;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(337, 140);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(0, 20);
            this.labelNomeCompleto.TabIndex = 684;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "idProduto", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(242, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(59, 26);
            this.idTextBox.TabIndex = 656;
            this.idTextBox.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(795, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 26);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 252;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // PesquisarTextBox
            // 
            this.PesquisarTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesquisarTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PesquisarTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PesquisarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisarTextBox.Location = new System.Drawing.Point(307, 67);
            this.PesquisarTextBox.Name = "PesquisarTextBox";
            this.PesquisarTextBox.Size = new System.Drawing.Size(482, 26);
            this.PesquisarTextBox.TabIndex = 0;
            this.PesquisarTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PesquisarTextBox_KeyDown);
            // 
            // panelButoes
            // 
            this.panelButoes.Controls.Add(this.btnExcluirCadastro);
            this.panelButoes.Controls.Add(this.btnAlterarCadastro);
            this.panelButoes.Controls.Add(this.btnCadastrar);
            this.panelButoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButoes.Location = new System.Drawing.Point(0, 57);
            this.panelButoes.Name = "panelButoes";
            this.panelButoes.Size = new System.Drawing.Size(1123, 43);
            this.panelButoes.TabIndex = 205;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnExcluirCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(760, 0);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(380, 43);
            this.btnExcluirCadastro.TabIndex = 198;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // btnAlterarCadastro
            // 
            this.btnAlterarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAlterarCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlterarCadastro.FlatAppearance.BorderSize = 0;
            this.btnAlterarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlterarCadastro.Location = new System.Drawing.Point(380, 0);
            this.btnAlterarCadastro.Name = "btnAlterarCadastro";
            this.btnAlterarCadastro.Size = new System.Drawing.Size(380, 43);
            this.btnAlterarCadastro.TabIndex = 197;
            this.btnAlterarCadastro.Text = "Alterar Cadastro";
            this.btnAlterarCadastro.UseVisualStyleBackColor = false;
            this.btnAlterarCadastro.Click += new System.EventHandler(this.btnAlterarCadastro_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(380, 43);
            this.btnCadastrar.TabIndex = 196;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.Controls.Add(this.btnLimparValores);
            this.panelCadastrar.Controls.Add(this.comboBoxVendedor);
            this.panelCadastrar.Controls.Add(label17);
            this.panelCadastrar.Controls.Add(this.nome_produtoTextBox);
            this.panelCadastrar.Controls.Add(this.codigoTextBox);
            this.panelCadastrar.Controls.Add(codigoLabel);
            this.panelCadastrar.Controls.Add(nome_produtoLabel);
            this.panelCadastrar.Controls.Add(this.CTLtextBox);
            this.panelCadastrar.Controls.Add(this.precoTextBox);
            this.panelCadastrar.Controls.Add(label6);
            this.panelCadastrar.Controls.Add(this.observacaoTextBox);
            this.panelCadastrar.Controls.Add(this.NCMtextBox);
            this.panelCadastrar.Controls.Add(observacaoLabel);
            this.panelCadastrar.Controls.Add(label3);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Controls.Add(label7);
            this.panelCadastrar.Controls.Add(this.btnSair);
            this.panelCadastrar.Controls.Add(this.tipoProdutoTextBox);
            this.panelCadastrar.Controls.Add(this.descricaoTextBox);
            this.panelCadastrar.Controls.Add(label5);
            this.panelCadastrar.Controls.Add(label2);
            this.panelCadastrar.Controls.Add(this.quantidadeTextBox);
            this.panelCadastrar.Controls.Add(label4);
            this.panelCadastrar.Controls.Add(quantidadeLabel);
            this.panelCadastrar.Controls.Add(this.composicaoTextBox);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 304);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(1123, 507);
            this.panelCadastrar.TabIndex = 207;
            // 
            // btnLimparValores
            // 
            this.btnLimparValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLimparValores.FlatAppearance.BorderSize = 0;
            this.btnLimparValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimparValores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimparValores.Location = new System.Drawing.Point(696, 43);
            this.btnLimparValores.Name = "btnLimparValores";
            this.btnLimparValores.Size = new System.Drawing.Size(138, 26);
            this.btnLimparValores.TabIndex = 340;
            this.btnLimparValores.Text = "Limpar Valores";
            this.btnLimparValores.UseVisualStyleBackColor = false;
            this.btnLimparValores.Visible = false;
            this.btnLimparValores.Click += new System.EventHandler(this.btnLimparValores_Click);
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxVendedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxVendedor.DataSource = this.vendedorBindingSource;
            this.comboBoxVendedor.DisplayMember = "nome";
            this.comboBoxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(316, 43);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(190, 24);
            this.comboBoxVendedor.TabIndex = 1;
            this.comboBoxVendedor.ValueMember = "idVendedor";
            this.comboBoxVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVendedor_KeyDown);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1140, 688);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.panelButoes);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadProduto";
            this.Load += new System.EventHandler(this.frmCadProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadProduto_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.panelButoes.ResumeLayout(false);
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox nome_produtoTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox composicaoTextBox;
        private System.Windows.Forms.TextBox tipoProdutoTextBox;
        private System.Windows.Forms.TextBox NCMtextBox;
        private System.Windows.Forms.TextBox CTLtextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox PesquisarTextBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panelButoes;
        private System.Windows.Forms.Button btnAlterarCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.Label labelTipoAcao;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Label labelVendedorAlteracao;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelNomeCompleto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.Button btnLimparValores;
    }
}