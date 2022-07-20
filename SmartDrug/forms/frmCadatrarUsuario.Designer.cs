namespace SmartDrug
{
    partial class frmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUsuario));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label perfilLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label nome_completoLabel;
            System.Windows.Forms.Label labRepetirSenha;
            System.Windows.Forms.Label labEmail;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.labelTipoAcao = new System.Windows.Forms.Label();
            this.combPerfil = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.textRepetirSenha = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nome_completoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
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
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelButoes = new System.Windows.Forms.Panel();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnAlterarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.usuarioTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.UsuarioTableAdapter();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            this.labelAvisoSenha = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            perfilLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            nome_completoLabel = new System.Windows.Forms.Label();
            labRepetirSenha = new System.Windows.Forms.Label();
            labEmail = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            this.panelButoes.SuspendLayout();
            this.panelCadastrar.SuspendLayout();
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
            panelTop.TabIndex = 30;
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
            labTitulo.Location = new System.Drawing.Point(427, 12);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(279, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastrar Usuário";
            // 
            // perfilLabel
            // 
            perfilLabel.AutoSize = true;
            perfilLabel.BackColor = System.Drawing.Color.Transparent;
            perfilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            perfilLabel.Location = new System.Drawing.Point(556, 132);
            perfilLabel.Name = "perfilLabel";
            perfilLabel.Size = new System.Drawing.Size(48, 20);
            perfilLabel.TabIndex = 7;
            perfilLabel.Text = "Perfil:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            senhaLabel.Location = new System.Drawing.Point(361, 185);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(60, 20);
            senhaLabel.TabIndex = 8;
            senhaLabel.Text = "Senha:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = System.Drawing.Color.Transparent;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            loginLabel.Location = new System.Drawing.Point(361, 131);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(52, 20);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Login:";
            // 
            // nome_completoLabel
            // 
            nome_completoLabel.AutoSize = true;
            nome_completoLabel.BackColor = System.Drawing.Color.Transparent;
            nome_completoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nome_completoLabel.Location = new System.Drawing.Point(361, 80);
            nome_completoLabel.Name = "nome_completoLabel";
            nome_completoLabel.Size = new System.Drawing.Size(127, 20);
            nome_completoLabel.TabIndex = 5;
            nome_completoLabel.Text = "Nome Completo:";
            // 
            // labRepetirSenha
            // 
            labRepetirSenha.AutoSize = true;
            labRepetirSenha.BackColor = System.Drawing.Color.Transparent;
            labRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labRepetirSenha.Location = new System.Drawing.Point(557, 185);
            labRepetirSenha.Name = "labRepetirSenha";
            labRepetirSenha.Size = new System.Drawing.Size(116, 20);
            labRepetirSenha.TabIndex = 9;
            labRepetirSenha.Text = "Repetir Senha:";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.BackColor = System.Drawing.Color.Transparent;
            labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labEmail.Location = new System.Drawing.Point(361, 239);
            labEmail.Name = "labEmail";
            labEmail.Size = new System.Drawing.Size(48, 20);
            labEmail.TabIndex = 80;
            labEmail.Text = "Email";
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
            label1.Size = new System.Drawing.Size(129, 20);
            label1.TabIndex = 251;
            label1.Text = "Pesquisar Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label2.Location = new System.Drawing.Point(360, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 82;
            label2.Text = "Vendedor:";
            // 
            // labelTipoAcao
            // 
            this.labelTipoAcao.AutoSize = true;
            this.labelTipoAcao.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoAcao.Location = new System.Drawing.Point(194, 106);
            this.labelTipoAcao.Name = "labelTipoAcao";
            this.labelTipoAcao.Size = new System.Drawing.Size(129, 20);
            this.labelTipoAcao.TabIndex = 654;
            this.labelTipoAcao.Text = "Alterar Cadastro:";
            // 
            // combPerfil
            // 
            this.combPerfil.BackColor = System.Drawing.SystemColors.Window;
            this.combPerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.combPerfil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "perfil", true));
            this.combPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.combPerfil.FormattingEnabled = true;
            this.combPerfil.Items.AddRange(new object[] {
            "VENDEDOR",
            "ADMINISTRADOR",
            "DESENVOLVEDOR"});
            this.combPerfil.Location = new System.Drawing.Point(560, 155);
            this.combPerfil.Name = "combPerfil";
            this.combPerfil.Size = new System.Drawing.Size(186, 24);
            this.combPerfil.TabIndex = 4;
            this.combPerfil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combPerfil_KeyDown);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(439, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(560, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 70;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textRepetirSenha
            // 
            this.textRepetirSenha.BackColor = System.Drawing.SystemColors.Window;
            this.textRepetirSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRepetirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textRepetirSenha.Location = new System.Drawing.Point(561, 209);
            this.textRepetirSenha.Multiline = true;
            this.textRepetirSenha.Name = "textRepetirSenha";
            this.textRepetirSenha.Size = new System.Drawing.Size(186, 25);
            this.textRepetirSenha.TabIndex = 6;
            this.textRepetirSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_completoTextBox_KeyDown);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha", true));
            this.senhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.senhaTextBox.Location = new System.Drawing.Point(364, 209);
            this.senhaTextBox.Multiline = true;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(191, 25);
            this.senhaTextBox.TabIndex = 5;
            this.senhaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_completoTextBox_KeyDown);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "login", true));
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(364, 155);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(190, 25);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // nome_completoTextBox
            // 
            this.nome_completoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nome_completoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_completoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_completoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nome", true));
            this.nome_completoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nome_completoTextBox.Location = new System.Drawing.Point(364, 103);
            this.nome_completoTextBox.Multiline = true;
            this.nome_completoTextBox.Name = "nome_completoTextBox";
            this.nome_completoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nome_completoTextBox.Size = new System.Drawing.Size(382, 25);
            this.nome_completoTextBox.TabIndex = 2;
            this.nome_completoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_completoTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(364, 263);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTextBox.Size = new System.Drawing.Size(382, 25);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.labelVendedorAlteracao);
            this.panelAlterar.Controls.Add(label8);
            this.panelAlterar.Controls.Add(this.labelVendedor);
            this.panelAlterar.Controls.Add(this.labelNomeCompleto);
            this.panelAlterar.Controls.Add(label4);
            this.panelAlterar.Controls.Add(label3);
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
            this.panelAlterar.Size = new System.Drawing.Size(1140, 203);
            this.panelAlterar.TabIndex = 206;
            this.panelAlterar.Visible = false;
            // 
            // labelVendedorAlteracao
            // 
            this.labelVendedorAlteracao.AutoSize = true;
            this.labelVendedorAlteracao.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedorAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "vendedorAlteracao", true));
            this.labelVendedorAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedorAlteracao.Location = new System.Drawing.Point(798, 170);
            this.labelVendedorAlteracao.Name = "labelVendedorAlteracao";
            this.labelVendedorAlteracao.Size = new System.Drawing.Size(0, 20);
            this.labelVendedorAlteracao.TabIndex = 663;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(698, 170);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(100, 20);
            label8.TabIndex = 662;
            label8.Text = "Alterado por:";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Vendedor", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(331, 170);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(0, 20);
            this.labelVendedor.TabIndex = 661;
            // 
            // labelNomeCompleto
            // 
            this.labelNomeCompleto.AutoSize = true;
            this.labelNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCompleto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nome", true));
            this.labelNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCompleto.Location = new System.Drawing.Point(335, 140);
            this.labelNomeCompleto.Name = "labelNomeCompleto";
            this.labelNomeCompleto.Size = new System.Drawing.Size(0, 20);
            this.labelNomeCompleto.TabIndex = 660;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(207, 170);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 20);
            label4.TabIndex = 659;
            label4.Text = "Cadastrado por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(207, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 20);
            label3.TabIndex = 658;
            label3.Text = "Nome Completo:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "idUsuario", true));
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
            this.shapeContainer1.Size = new System.Drawing.Size(1140, 203);
            this.shapeContainer1.TabIndex = 253;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 197;
            this.lineShape3.X2 = 954;
            this.lineShape3.Y1 = 196;
            this.lineShape3.Y2 = 196;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 196;
            this.lineShape1.X2 = 953;
            this.lineShape1.Y1 = 131;
            this.lineShape1.Y2 = 131;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 197;
            this.lineShape2.X2 = 953;
            this.lineShape2.Y1 = 24;
            this.lineShape2.Y2 = 24;
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.drogariaParanaDataSet;
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
            this.panelCadastrar.Controls.Add(this.labelAvisoSenha);
            this.panelCadastrar.Controls.Add(this.comboBoxVendedor);
            this.panelCadastrar.Controls.Add(label2);
            this.panelCadastrar.Controls.Add(this.nome_completoTextBox);
            this.panelCadastrar.Controls.Add(nome_completoLabel);
            this.panelCadastrar.Controls.Add(this.loginTextBox);
            this.panelCadastrar.Controls.Add(labEmail);
            this.panelCadastrar.Controls.Add(loginLabel);
            this.panelCadastrar.Controls.Add(this.emailTextBox);
            this.panelCadastrar.Controls.Add(this.senhaTextBox);
            this.panelCadastrar.Controls.Add(this.combPerfil);
            this.panelCadastrar.Controls.Add(senhaLabel);
            this.panelCadastrar.Controls.Add(this.btnSalvar);
            this.panelCadastrar.Controls.Add(perfilLabel);
            this.panelCadastrar.Controls.Add(this.btnSair);
            this.panelCadastrar.Controls.Add(labRepetirSenha);
            this.panelCadastrar.Controls.Add(this.textRepetirSenha);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 303);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(1140, 452);
            this.panelCadastrar.TabIndex = 207;
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
            this.comboBoxVendedor.Location = new System.Drawing.Point(364, 42);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(190, 24);
            this.comboBoxVendedor.TabIndex = 1;
            this.comboBoxVendedor.ValueMember = "idVendedor";
            this.comboBoxVendedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxVendedor_KeyDown);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // labelAvisoSenha
            // 
            this.labelAvisoSenha.AutoSize = true;
            this.labelAvisoSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelAvisoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAvisoSenha.ForeColor = System.Drawing.Color.Red;
            this.labelAvisoSenha.Location = new System.Drawing.Point(679, 186);
            this.labelAvisoSenha.Name = "labelAvisoSenha";
            this.labelAvisoSenha.Size = new System.Drawing.Size(248, 17);
            this.labelAvisoSenha.TabIndex = 83;
            this.labelAvisoSenha.Text = "* Não se esqueça de Repetir a senha!";
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 688);
            this.Controls.Add(this.panelCadastrar);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.panelButoes);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.frmCadUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadUsuario_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            this.panelButoes.ResumeLayout(false);
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.ComboBox combPerfil;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.TextBox textRepetirSenha;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nome_completoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
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
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Label labelTipoAcao;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelNomeCompleto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label labelVendedorAlteracao;
        private System.Windows.Forms.Label labelAvisoSenha;
    }
}