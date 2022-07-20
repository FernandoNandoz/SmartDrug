namespace SmartDrug.forms
{
    partial class frmCadCliente
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label tipo_clienteLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label nome_completoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCliente));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.labelTipoAcao = new System.Windows.Forms.Label();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.combTipoCliente = new System.Windows.Forms.ComboBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskRG_inscricaoEstad = new System.Windows.Forms.MaskedTextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nome_completoTextBox = new System.Windows.Forms.TextBox();
            this.maskTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.textNomeContato = new System.Windows.Forms.TextBox();
            this.cidadeTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.CidadeTableAdapter();
            this.estadoTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.EstadoTableAdapter();
            this.paisTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.PaisTableAdapter();
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
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            observacaoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            tipo_clienteLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            nome_completoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
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
            observacaoLabel.Location = new System.Drawing.Point(311, 413);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(98, 20);
            observacaoLabel.TabIndex = 25;
            observacaoLabel.Text = "Observacao:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(311, 358);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.BackColor = System.Drawing.Color.Transparent;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            paisLabel.Location = new System.Drawing.Point(648, 249);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(43, 20);
            paisLabel.TabIndex = 20;
            paisLabel.Text = "Pais:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            estadoLabel.Location = new System.Drawing.Point(482, 249);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(64, 20);
            estadoLabel.TabIndex = 19;
            estadoLabel.Text = "Estado:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cidadeLabel.Location = new System.Drawing.Point(311, 249);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 18;
            cidadeLabel.Text = "Cidade:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(311, 195);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(231, 20);
            enderecoLabel.TabIndex = 17;
            enderecoLabel.Text = "Endereco - Ex: Rua, Nº - Bairro:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            telefoneLabel.Location = new System.Drawing.Point(311, 304);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 21;
            telefoneLabel.Text = "Telefone:";
            // 
            // tipo_clienteLabel
            // 
            tipo_clienteLabel.AutoSize = true;
            tipo_clienteLabel.BackColor = System.Drawing.Color.Transparent;
            tipo_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            tipo_clienteLabel.Location = new System.Drawing.Point(648, 139);
            tipo_clienteLabel.Name = "tipo_clienteLabel";
            tipo_clienteLabel.Size = new System.Drawing.Size(96, 20);
            tipo_clienteLabel.TabIndex = 16;
            tipo_clienteLabel.Text = "Tipo Cliente:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.Color.Transparent;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cpfLabel.Location = new System.Drawing.Point(481, 138);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(88, 20);
            cpfLabel.TabIndex = 15;
            cpfLabel.Text = "CPF/CNPJ:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.Color.Transparent;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            rgLabel.Location = new System.Drawing.Point(311, 138);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(156, 20);
            rgLabel.TabIndex = 14;
            rgLabel.Text = "RG/ Inscrição Estad:";
            // 
            // nome_completoLabel
            // 
            nome_completoLabel.AutoSize = true;
            nome_completoLabel.BackColor = System.Drawing.Color.Transparent;
            nome_completoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_completoLabel.Location = new System.Drawing.Point(311, 82);
            nome_completoLabel.Name = "nome_completoLabel";
            nome_completoLabel.Size = new System.Drawing.Size(127, 20);
            nome_completoLabel.TabIndex = 13;
            nome_completoLabel.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(480, 303);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 20);
            label2.TabIndex = 22;
            label2.Text = "Telefone Secundario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(648, 303);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 20);
            label3.TabIndex = 23;
            label3.Text = "Nome do Contato:";
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
            panelTop.TabIndex = 134;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 32;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labTitulo.Location = new System.Drawing.Point(410, 12);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(266, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastrar Cliente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label14.Location = new System.Drawing.Point(239, 38);
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
            label13.Location = new System.Drawing.Point(194, 0);
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
            label1.Location = new System.Drawing.Point(303, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(180, 20);
            label1.TabIndex = 251;
            label1.Text = "Pesquisar Nome/Razão:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(684, 175);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 20);
            label8.TabIndex = 668;
            label8.Text = "Alterado por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(213, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 20);
            label4.TabIndex = 665;
            label4.Text = "Cadastrado por:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(213, 145);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(127, 20);
            label5.TabIndex = 664;
            label5.Text = "Nome Completo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label6.Location = new System.Drawing.Point(311, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 114;
            label6.Text = "Vendedor:";
            // 
            // labelTipoAcao
            // 
            this.labelTipoAcao.AutoSize = true;
            this.labelTipoAcao.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAcao.Location = new System.Drawing.Point(194, 114);
            this.labelTipoAcao.Name = "labelTipoAcao";
            this.labelTipoAcao.Size = new System.Drawing.Size(129, 20);
            this.labelTipoAcao.TabIndex = 654;
            this.labelTipoAcao.Text = "Alterar Cadastro:";
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "pais", true));
            this.paisComboBox.DataSource = this.paisBindingSource;
            this.paisComboBox.DisplayMember = "Pais";
            this.paisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(652, 271);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(156, 24);
            this.paisComboBox.TabIndex = 9;
            this.paisComboBox.ValueMember = "idPais";
            this.paisComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "estado", true));
            this.estadoComboBox.DataSource = this.estadoBindingSource;
            this.estadoComboBox.DisplayMember = "Estado";
            this.estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(485, 272);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(162, 24);
            this.estadoComboBox.TabIndex = 8;
            this.estadoComboBox.ValueMember = "idEstado";
            this.estadoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cidade", true));
            this.cidadeComboBox.DataSource = this.cidadeBindingSource;
            this.cidadeComboBox.DisplayMember = "Cidade";
            this.cidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(315, 272);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(165, 24);
            this.cidadeComboBox.TabIndex = 7;
            this.cidadeComboBox.ValueMember = "idCidade";
            this.cidadeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(556, 492);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 112;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(435, 492);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 111;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // combTipoCliente
            // 
            this.combTipoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.combTipoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "tipoCliente", true));
            this.combTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combTipoCliente.FormattingEnabled = true;
            this.combTipoCliente.Items.AddRange(new object[] {
            "FÍSICA",
            "JURIDICA"});
            this.combTipoCliente.Location = new System.Drawing.Point(652, 162);
            this.combTipoCliente.Name = "combTipoCliente";
            this.combTipoCliente.Size = new System.Drawing.Size(156, 24);
            this.combTipoCliente.TabIndex = 5;
            this.combTipoCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskTelefone
            // 
            this.maskTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.maskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefone", true));
            this.maskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTelefone.Location = new System.Drawing.Point(315, 327);
            this.maskTelefone.Mask = " (00) 0 0000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(164, 26);
            this.maskTelefone.TabIndex = 10;
            this.maskTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskCPF_CNPJ
            // 
            this.maskCPF_CNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.maskCPF_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskCPF_CNPJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cpf_cnpj", true));
            this.maskCPF_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskCPF_CNPJ.Location = new System.Drawing.Point(485, 162);
            this.maskCPF_CNPJ.Mask = " 000.000.000-00";
            this.maskCPF_CNPJ.Name = "maskCPF_CNPJ";
            this.maskCPF_CNPJ.Size = new System.Drawing.Size(161, 26);
            this.maskCPF_CNPJ.TabIndex = 4;
            this.maskCPF_CNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskRG_inscricaoEstad
            // 
            this.maskRG_inscricaoEstad.BackColor = System.Drawing.SystemColors.Window;
            this.maskRG_inscricaoEstad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskRG_inscricaoEstad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "rg_inscricaoEstadual", true));
            this.maskRG_inscricaoEstad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskRG_inscricaoEstad.Location = new System.Drawing.Point(315, 162);
            this.maskRG_inscricaoEstad.Name = "maskRG_inscricaoEstad";
            this.maskRG_inscricaoEstad.Size = new System.Drawing.Size(166, 26);
            this.maskRG_inscricaoEstad.TabIndex = 3;
            this.maskRG_inscricaoEstad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.observacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "observacao", true));
            this.observacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.observacaoTextBox.Location = new System.Drawing.Point(315, 436);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(490, 35);
            this.observacaoTextBox.TabIndex = 14;
            this.observacaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.observacaoTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(315, 381);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(491, 25);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enderecoTextBox.Location = new System.Drawing.Point(315, 219);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(491, 25);
            this.enderecoTextBox.TabIndex = 6;
            this.enderecoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // nome_completoTextBox
            // 
            this.nome_completoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nome_completoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_completoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_completoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.nome_completoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_completoTextBox.Location = new System.Drawing.Point(315, 106);
            this.nome_completoTextBox.Multiline = true;
            this.nome_completoTextBox.Name = "nome_completoTextBox";
            this.nome_completoTextBox.Size = new System.Drawing.Size(493, 25);
            this.nome_completoTextBox.TabIndex = 2;
            this.nome_completoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskTelefone2
            // 
            this.maskTelefone2.BackColor = System.Drawing.SystemColors.Window;
            this.maskTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTelefone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefone2", true));
            this.maskTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTelefone2.Location = new System.Drawing.Point(484, 327);
            this.maskTelefone2.Mask = " (00) 0 0000-0000";
            this.maskTelefone2.Name = "maskTelefone2";
            this.maskTelefone2.Size = new System.Drawing.Size(162, 26);
            this.maskTelefone2.TabIndex = 11;
            this.maskTelefone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // textNomeContato
            // 
            this.textNomeContato.BackColor = System.Drawing.SystemColors.Window;
            this.textNomeContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNomeContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nomeContato", true));
            this.textNomeContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textNomeContato.Location = new System.Drawing.Point(652, 327);
            this.textNomeContato.Multiline = true;
            this.textNomeContato.Name = "textNomeContato";
            this.textNomeContato.Size = new System.Drawing.Size(154, 25);
            this.textNomeContato.TabIndex = 12;
            this.textNomeContato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.labelVendedorAlteracao);
            this.panelAlterar.Controls.Add(label8);
            this.panelAlterar.Controls.Add(this.labelVendedor);
            this.panelAlterar.Controls.Add(this.labelNomeCompleto);
            this.panelAlterar.Controls.Add(label4);
            this.panelAlterar.Controls.Add(label5);
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
            this.panelAlterar.TabIndex = 204;
            this.panelAlterar.Visible = false;
            // 
            // labelVendedorAlteracao
            // 
            this.labelVendedorAlteracao.AutoSize = true;
            this.labelVendedorAlteracao.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedorAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "vendedorAlteracao", true));
            this.labelVendedorAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedorAlteracao.Location = new System.Drawing.Point(784, 175);
            this.labelVendedorAlteracao.Name = "labelVendedorAlteracao";
            this.labelVendedorAlteracao.Size = new System.Drawing.Size(0, 20);
            this.labelVendedorAlteracao.TabIndex = 669;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "vendedor", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(337, 175);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(0, 20);
            this.labelVendedor.TabIndex = 667;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(341, 145);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(0, 20);
            this.labelNomeCompleto.TabIndex = 666;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "idCliente", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(242, 61);
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
            this.btnPesquisar.Location = new System.Drawing.Point(795, 61);
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
            this.PesquisarTextBox.Location = new System.Drawing.Point(307, 61);
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
            this.panelButoes.TabIndex = 203;
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
            this.panelCadastrar.Controls.Add(this.comboBoxVendedor);
            this.panelCadastrar.Controls.Add(label6);
            this.panelCadastrar.Controls.Add(this.nome_completoTextBox);
            this.panelCadastrar.Controls.Add(this.observacaoTextBox);
            this.panelCadastrar.Controls.Add(telefoneLabel);
            this.panelCadastrar.Controls.Add(nome_completoLabel);
            this.panelCadastrar.Controls.Add(this.enderecoTextBox);
            this.panelCadastrar.Controls.Add(enderecoLabel);
            this.panelCadastrar.Controls.Add(rgLabel);
            this.panelCadastrar.Controls.Add(cidadeLabel);
            this.panelCadastrar.Controls.Add(estadoLabel);
            this.panelCadastrar.Controls.Add(cpfLabel);
            this.panelCadastrar.Controls.Add(paisLabel);
            this.panelCadastrar.Controls.Add(label3);
            this.panelCadastrar.Controls.Add(this.emailTextBox);
            this.panelCadastrar.Controls.Add(tipo_clienteLabel);
            this.panelCadastrar.Controls.Add(emailLabel);
            this.panelCadastrar.Controls.Add(this.textNomeContato);
            this.panelCadastrar.Controls.Add(observacaoLabel);
            this.panelCadastrar.Controls.Add(this.maskRG_inscricaoEstad);
            this.panelCadastrar.Controls.Add(this.maskTelefone);
            this.panelCadastrar.Controls.Add(this.maskTelefone2);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Controls.Add(this.maskCPF_CNPJ);
            this.panelCadastrar.Controls.Add(this.btnSair);
            this.panelCadastrar.Controls.Add(label2);
            this.panelCadastrar.Controls.Add(this.cidadeComboBox);
            this.panelCadastrar.Controls.Add(this.combTipoCliente);
            this.panelCadastrar.Controls.Add(this.estadoComboBox);
            this.panelCadastrar.Controls.Add(this.paisComboBox);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 304);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(1123, 559);
            this.panelCadastrar.TabIndex = 205;
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
            this.comboBoxVendedor.Location = new System.Drawing.Point(315, 38);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadCliente
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
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadCliente_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
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

        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.ComboBox combTipoCliente;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.MaskedTextBox maskCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox maskRG_inscricaoEstad;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nome_completoTextBox;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.MaskedTextBox maskTelefone2;
        private System.Windows.Forms.TextBox textNomeContato;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox PesquisarTextBox;
       
        private System.Windows.Forms.Panel panelButoes;
        private System.Windows.Forms.Button btnAlterarCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label labelTipoAcao;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Label labelVendedorAlteracao;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelNomeCompleto;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
    }
}