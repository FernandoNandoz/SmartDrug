namespace SmartDrug.forms
{
    partial class frmCadFornecedor
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFornecedor));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.labelTipoAcao = new System.Windows.Forms.Label();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskInscricaoM = new System.Windows.Forms.MaskedTextBox();
            this.maskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nome_RazaoTextBox = new System.Windows.Forms.TextBox();
            this.nome_FantasiaTextBox = new System.Windows.Forms.TextBox();
            this.maskInscricaoE = new System.Windows.Forms.MaskedTextBox();
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelButoes = new System.Windows.Forms.Panel();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnAlterarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.FornecedoresTableAdapter();
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
            label4 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
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
            observacaoLabel.Location = new System.Drawing.Point(302, 474);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(98, 20);
            observacaoLabel.TabIndex = 27;
            observacaoLabel.Text = "Observacao:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel.Location = new System.Drawing.Point(302, 420);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.BackColor = System.Drawing.Color.Transparent;
            paisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            paisLabel.Location = new System.Drawing.Point(642, 315);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(43, 20);
            paisLabel.TabIndex = 22;
            paisLabel.Text = "Pais:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            estadoLabel.Location = new System.Drawing.Point(470, 315);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(64, 20);
            estadoLabel.TabIndex = 21;
            estadoLabel.Text = "Estado:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.BackColor = System.Drawing.Color.Transparent;
            cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cidadeLabel.Location = new System.Drawing.Point(302, 315);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 20;
            cidadeLabel.Text = "Cidade:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            enderecoLabel.Location = new System.Drawing.Point(302, 261);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(231, 20);
            enderecoLabel.TabIndex = 19;
            enderecoLabel.Text = "Endereco - Ex: Rua, Nº - Bairro:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            telefoneLabel.Location = new System.Drawing.Point(302, 368);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(75, 20);
            telefoneLabel.TabIndex = 23;
            telefoneLabel.Text = "Telefone:";
            // 
            // tipo_clienteLabel
            // 
            tipo_clienteLabel.AutoSize = true;
            tipo_clienteLabel.BackColor = System.Drawing.Color.Transparent;
            tipo_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            tipo_clienteLabel.Location = new System.Drawing.Point(642, 194);
            tipo_clienteLabel.Name = "tipo_clienteLabel";
            tipo_clienteLabel.Size = new System.Drawing.Size(144, 20);
            tipo_clienteLabel.TabIndex = 18;
            tipo_clienteLabel.Text = "Inscrição Estadual:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.Color.Transparent;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            cpfLabel.Location = new System.Drawing.Point(474, 194);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(147, 20);
            cpfLabel.TabIndex = 17;
            cpfLabel.Text = "Inscrição Municipal:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.Color.Transparent;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            rgLabel.Location = new System.Drawing.Point(302, 194);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(53, 20);
            rgLabel.TabIndex = 16;
            rgLabel.Text = "CNPJ:";
            // 
            // nome_completoLabel
            // 
            nome_completoLabel.AutoSize = true;
            nome_completoLabel.BackColor = System.Drawing.Color.Transparent;
            nome_completoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_completoLabel.Location = new System.Drawing.Point(302, 85);
            nome_completoLabel.Name = "nome_completoLabel";
            nome_completoLabel.Size = new System.Drawing.Size(153, 20);
            nome_completoLabel.TabIndex = 14;
            nome_completoLabel.Text = "Nome/Razão Social:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(302, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 20);
            label2.TabIndex = 15;
            label2.Text = "Nome Fantasia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label3.Location = new System.Drawing.Point(470, 366);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(160, 20);
            label3.TabIndex = 24;
            label3.Text = "Telefone Secundario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label4.Location = new System.Drawing.Point(642, 366);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(116, 20);
            label4.TabIndex = 25;
            label4.Text = "Nome Contato:";
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
            panelTop.TabIndex = 152;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 34;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labTitulo.Location = new System.Drawing.Point(402, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(332, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastrar Fornecedor";
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
            label8.Location = new System.Drawing.Point(686, 172);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 20);
            label8.TabIndex = 674;
            label8.Text = "Alterado por:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(216, 172);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(123, 20);
            label5.TabIndex = 671;
            label5.Text = "Cadastrado por:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(216, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(127, 20);
            label6.TabIndex = 670;
            label6.Text = "Nome Completo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label7.Location = new System.Drawing.Point(302, 18);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 20);
            label7.TabIndex = 116;
            label7.Text = "Vendedor:";
            // 
            // labelTipoAcao
            // 
            this.labelTipoAcao.AutoSize = true;
            this.labelTipoAcao.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAcao.Location = new System.Drawing.Point(194, 111);
            this.labelTipoAcao.Name = "labelTipoAcao";
            this.labelTipoAcao.Size = new System.Drawing.Size(129, 20);
            this.labelTipoAcao.TabIndex = 654;
            this.labelTipoAcao.Text = "Alterar Cadastro:";
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "pais", true));
            this.paisComboBox.DataSource = this.paisBindingSource;
            this.paisComboBox.DisplayMember = "Pais";
            this.paisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(646, 337);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(153, 24);
            this.paisComboBox.TabIndex = 10;
            this.paisComboBox.ValueMember = "idPais";
            this.paisComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.drogariaParanaDataSet;
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
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "estado", true));
            this.estadoComboBox.DataSource = this.estadoBindingSource;
            this.estadoComboBox.DisplayMember = "Estado";
            this.estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(474, 337);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(162, 24);
            this.estadoComboBox.TabIndex = 9;
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
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cidade", true));
            this.cidadeComboBox.DataSource = this.cidadeBindingSource;
            this.cidadeComboBox.DisplayMember = "Cidade";
            this.cidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(306, 337);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(163, 24);
            this.cidadeComboBox.TabIndex = 8;
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
            this.btnSair.Location = new System.Drawing.Point(545, 559);
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
            this.btnSalvar.Location = new System.Drawing.Point(424, 559);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 111;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // maskTelefone
            // 
            this.maskTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.maskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "telefone", true));
            this.maskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTelefone.Location = new System.Drawing.Point(307, 389);
            this.maskTelefone.Mask = " (00) 0 0000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(162, 26);
            this.maskTelefone.TabIndex = 11;
            this.maskTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskInscricaoM
            // 
            this.maskInscricaoM.BackColor = System.Drawing.SystemColors.Window;
            this.maskInscricaoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskInscricaoM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "inscricaoMunicipal", true));
            this.maskInscricaoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskInscricaoM.Location = new System.Drawing.Point(478, 217);
            this.maskInscricaoM.Mask = " 000.000.000-00";
            this.maskInscricaoM.Name = "maskInscricaoM";
            this.maskInscricaoM.Size = new System.Drawing.Size(162, 26);
            this.maskInscricaoM.TabIndex = 5;
            this.maskInscricaoM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskCNPJ
            // 
            this.maskCNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.maskCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskCNPJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cnpj", true));
            this.maskCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskCNPJ.Location = new System.Drawing.Point(307, 217);
            this.maskCNPJ.Name = "maskCNPJ";
            this.maskCNPJ.Size = new System.Drawing.Size(166, 26);
            this.maskCNPJ.TabIndex = 4;
            this.maskCNPJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.observacaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "observacao", true));
            this.observacaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.observacaoTextBox.Location = new System.Drawing.Point(307, 498);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(490, 38);
            this.observacaoTextBox.TabIndex = 15;
            this.observacaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.observacaoTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(307, 444);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(490, 25);
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enderecoTextBox.Location = new System.Drawing.Point(307, 285);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(490, 25);
            this.enderecoTextBox.TabIndex = 7;
            this.enderecoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // nome_RazaoTextBox
            // 
            this.nome_RazaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nome_RazaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_RazaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_RazaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeRazao", true));
            this.nome_RazaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_RazaoTextBox.Location = new System.Drawing.Point(307, 108);
            this.nome_RazaoTextBox.Multiline = true;
            this.nome_RazaoTextBox.Name = "nome_RazaoTextBox";
            this.nome_RazaoTextBox.Size = new System.Drawing.Size(490, 25);
            this.nome_RazaoTextBox.TabIndex = 2;
            this.nome_RazaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // nome_FantasiaTextBox
            // 
            this.nome_FantasiaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nome_FantasiaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_FantasiaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_FantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeFantasia", true));
            this.nome_FantasiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_FantasiaTextBox.Location = new System.Drawing.Point(307, 162);
            this.nome_FantasiaTextBox.Multiline = true;
            this.nome_FantasiaTextBox.Name = "nome_FantasiaTextBox";
            this.nome_FantasiaTextBox.Size = new System.Drawing.Size(489, 25);
            this.nome_FantasiaTextBox.TabIndex = 3;
            this.nome_FantasiaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskInscricaoE
            // 
            this.maskInscricaoE.BackColor = System.Drawing.SystemColors.Window;
            this.maskInscricaoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskInscricaoE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "inscricaoEstadual", true));
            this.maskInscricaoE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskInscricaoE.Location = new System.Drawing.Point(646, 217);
            this.maskInscricaoE.Mask = " 000.000.000-00";
            this.maskInscricaoE.Name = "maskInscricaoE";
            this.maskInscricaoE.Size = new System.Drawing.Size(150, 26);
            this.maskInscricaoE.TabIndex = 6;
            this.maskInscricaoE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // maskTelefone2
            // 
            this.maskTelefone2.BackColor = System.Drawing.SystemColors.Window;
            this.maskTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskTelefone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "telefone2", true));
            this.maskTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskTelefone2.Location = new System.Drawing.Point(474, 389);
            this.maskTelefone2.Mask = " (00) 0 0000-0000";
            this.maskTelefone2.Name = "maskTelefone2";
            this.maskTelefone2.Size = new System.Drawing.Size(163, 26);
            this.maskTelefone2.TabIndex = 12;
            this.maskTelefone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Evento_KeyDown);
            // 
            // textNomeContato
            // 
            this.textNomeContato.BackColor = System.Drawing.SystemColors.Window;
            this.textNomeContato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNomeContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNomeContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeContato", true));
            this.textNomeContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textNomeContato.Location = new System.Drawing.Point(646, 389);
            this.textNomeContato.Multiline = true;
            this.textNomeContato.Name = "textNomeContato";
            this.textNomeContato.Size = new System.Drawing.Size(150, 25);
            this.textNomeContato.TabIndex = 13;
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
            this.panelAlterar.Controls.Add(label5);
            this.panelAlterar.Controls.Add(label6);
            this.panelAlterar.Controls.Add(label14);
            this.panelAlterar.Controls.Add(this.idTextBox);
            this.panelAlterar.Controls.Add(label13);
            this.panelAlterar.Controls.Add(this.labelTipoAcao);
            this.panelAlterar.Controls.Add(this.btnPesquisar);
            this.panelAlterar.Controls.Add(label1);
            this.panelAlterar.Controls.Add(this.PesquisarTextBox);
            this.panelAlterar.Controls.Add(this.shapeContainer1);
            this.panelAlterar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlterar.Location = new System.Drawing.Point(0, 100);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(1140, 204);
            this.panelAlterar.TabIndex = 202;
            this.panelAlterar.Visible = false;
            // 
            // labelVendedorAlteracao
            // 
            this.labelVendedorAlteracao.AutoSize = true;
            this.labelVendedorAlteracao.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedorAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "vendedorAlteracao", true));
            this.labelVendedorAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedorAlteracao.Location = new System.Drawing.Point(787, 172);
            this.labelVendedorAlteracao.Name = "labelVendedorAlteracao";
            this.labelVendedorAlteracao.Size = new System.Drawing.Size(0, 20);
            this.labelVendedorAlteracao.TabIndex = 675;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "vendedor", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(340, 172);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(0, 20);
            this.labelVendedor.TabIndex = 673;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeRazao", true));
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(344, 142);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(0, 20);
            this.labelNomeCompleto.TabIndex = 672;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "idFornecedor", true));
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1140, 204);
            this.shapeContainer1.TabIndex = 253;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 196;
            this.lineShape3.X2 = 953;
            this.lineShape3.Y1 = 197;
            this.lineShape3.Y2 = 197;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 196;
            this.lineShape1.X2 = 953;
            this.lineShape1.Y1 = 136;
            this.lineShape1.Y2 = 136;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 197;
            this.lineShape2.X2 = 953;
            this.lineShape2.Y1 = 24;
            this.lineShape2.Y2 = 24;
            // 
            // panelButoes
            // 
            this.panelButoes.Controls.Add(this.btnExcluirCadastro);
            this.panelButoes.Controls.Add(this.btnAlterarCadastro);
            this.panelButoes.Controls.Add(this.btnCadastrar);
            this.panelButoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButoes.Location = new System.Drawing.Point(0, 57);
            this.panelButoes.Name = "panelButoes";
            this.panelButoes.Size = new System.Drawing.Size(1140, 43);
            this.panelButoes.TabIndex = 201;
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
            this.panelCadastrar.Controls.Add(label7);
            this.panelCadastrar.Controls.Add(this.nome_RazaoTextBox);
            this.panelCadastrar.Controls.Add(nome_completoLabel);
            this.panelCadastrar.Controls.Add(rgLabel);
            this.panelCadastrar.Controls.Add(cpfLabel);
            this.panelCadastrar.Controls.Add(label4);
            this.panelCadastrar.Controls.Add(tipo_clienteLabel);
            this.panelCadastrar.Controls.Add(this.emailTextBox);
            this.panelCadastrar.Controls.Add(telefoneLabel);
            this.panelCadastrar.Controls.Add(emailLabel);
            this.panelCadastrar.Controls.Add(this.enderecoTextBox);
            this.panelCadastrar.Controls.Add(label3);
            this.panelCadastrar.Controls.Add(enderecoLabel);
            this.panelCadastrar.Controls.Add(this.textNomeContato);
            this.panelCadastrar.Controls.Add(cidadeLabel);
            this.panelCadastrar.Controls.Add(this.maskTelefone2);
            this.panelCadastrar.Controls.Add(estadoLabel);
            this.panelCadastrar.Controls.Add(this.maskInscricaoE);
            this.panelCadastrar.Controls.Add(paisLabel);
            this.panelCadastrar.Controls.Add(label2);
            this.panelCadastrar.Controls.Add(this.observacaoTextBox);
            this.panelCadastrar.Controls.Add(this.nome_FantasiaTextBox);
            this.panelCadastrar.Controls.Add(observacaoLabel);
            this.panelCadastrar.Controls.Add(this.paisComboBox);
            this.panelCadastrar.Controls.Add(this.maskCNPJ);
            this.panelCadastrar.Controls.Add(this.estadoComboBox);
            this.panelCadastrar.Controls.Add(this.maskInscricaoM);
            this.panelCadastrar.Controls.Add(this.cidadeComboBox);
            this.panelCadastrar.Controls.Add(this.maskTelefone);
            this.panelCadastrar.Controls.Add(this.btnSair);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 304);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(1140, 635);
            this.panelCadastrar.TabIndex = 203;
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
            this.comboBoxVendedor.Location = new System.Drawing.Point(306, 41);
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
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1157, 688);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.panelButoes);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadFornecedor";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadFornecedor_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.MaskedTextBox maskInscricaoM;
        private System.Windows.Forms.MaskedTextBox maskCNPJ;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nome_RazaoTextBox;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.TextBox nome_FantasiaTextBox;
        private System.Windows.Forms.MaskedTextBox maskInscricaoE;
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panelButoes;
        private System.Windows.Forms.Button btnAlterarCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Label labelTipoAcao;
        private System.Windows.Forms.Label labelVendedorAlteracao;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelNomeCompleto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
    }
}