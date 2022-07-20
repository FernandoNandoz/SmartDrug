namespace SmartDrug.forms
{
    partial class frmVendas
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.codigoBarraTextBox = new System.Windows.Forms.TextBox();
            this.valorUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalGeralTextBox = new System.Windows.Forms.TextBox();
            this.produtoTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.SituaçãoTextBox = new System.Windows.Forms.TextBox();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.pictuLogo = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIdProduto = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.numeroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutosId_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            this.panelImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictuLogo)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(573, 113);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 26);
            label8.TabIndex = 271;
            label8.Text = "Codigo:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(573, 310);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 26);
            label3.TabIndex = 254;
            label3.Text = "Valor Unitário:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(573, 215);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(130, 26);
            telefoneLabel.TabIndex = 253;
            telefoneLabel.Text = "Quantidade:";
            // 
            // label13
            // 
            label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(573, 408);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(122, 26);
            label13.TabIndex = 288;
            label13.Text = "Valor Total:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(39, 480);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(139, 29);
            label5.TabIndex = 294;
            label5.Text = "Total Geral:";
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
            panelTop.TabIndex = 615;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(13, 13);
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
            labTitulo.Location = new System.Drawing.Point(504, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(126, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Vendas";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(1005, 408);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(92, 26);
            label9.TabIndex = 618;
            label9.Text = "Subtotal";
            // 
            // label11
            // 
            label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(573, 480);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(112, 29);
            label11.TabIndex = 620;
            label11.Text = "Situação:";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(64, 584);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(165, 18);
            label12.TabIndex = 621;
            label12.Text = " F1 - Pesquisar Produto";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(911, 584);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(166, 18);
            label14.TabIndex = 622;
            label14.Text = " F10 - Cancelar Produto";
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(718, 584);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(142, 18);
            label15.TabIndex = 623;
            label15.Text = " F5 - Finalizar Venda";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(277, 584);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 18);
            label1.TabIndex = 626;
            label1.Text = " F2 - Reemprimir Venda";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(496, 584);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(176, 18);
            label2.TabIndex = 627;
            label2.Text = " F3 - Concluir Orçamento";
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
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(44, 36);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(1053, 50);
            this.textBoxNomeProduto.TabIndex = 611;
            this.textBoxNomeProduto.TabStop = false;
            this.textBoxNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeProduto_KeyDown);
            this.textBoxNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeProduto_KeyPress);
            // 
            // codigoBarraTextBox
            // 
            this.codigoBarraTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoBarraTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codigoBarraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoBarraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoBarraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "codigoBarra", true));
            this.codigoBarraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBarraTextBox.Location = new System.Drawing.Point(578, 142);
            this.codigoBarraTextBox.Name = "codigoBarraTextBox";
            this.codigoBarraTextBox.Size = new System.Drawing.Size(226, 35);
            this.codigoBarraTextBox.TabIndex = 3;
            this.codigoBarraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.codigoBarraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigoBarraTextBox_KeyDown);
            // 
            // valorUnitarioTextBox
            // 
            this.valorUnitarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorUnitarioTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorUnitarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorUnitarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco", true));
            this.valorUnitarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorUnitarioTextBox.Location = new System.Drawing.Point(578, 339);
            this.valorUnitarioTextBox.Name = "valorUnitarioTextBox";
            this.valorUnitarioTextBox.ReadOnly = true;
            this.valorUnitarioTextBox.Size = new System.Drawing.Size(226, 35);
            this.valorUnitarioTextBox.TabIndex = 5;
            this.valorUnitarioTextBox.TabStop = false;
            this.valorUnitarioTextBox.Text = "0,00";
            this.valorUnitarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorUnitarioTextBox.TextChanged += new System.EventHandler(this.valorUnitarioTextBox_TextChanged);
            this.valorUnitarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorUnitarioTextBox_KeyDown);
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.quantidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeTextBox.Location = new System.Drawing.Point(578, 244);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(226, 35);
            this.quantidadeTextBox.TabIndex = 4;
            this.quantidadeTextBox.Text = "0";
            this.quantidadeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            this.quantidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantidadeTextBox_KeyDown);
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorTotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorTotalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotalTextBox.Location = new System.Drawing.Point(578, 437);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.ReadOnly = true;
            this.valorTotalTextBox.Size = new System.Drawing.Size(226, 35);
            this.valorTotalTextBox.TabIndex = 600;
            this.valorTotalTextBox.TabStop = false;
            this.valorTotalTextBox.Text = "0,00";
            this.valorTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalGeralTextBox
            // 
            this.TotalGeralTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalGeralTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TotalGeralTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalGeralTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TotalGeralTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGeralTextBox.ForeColor = System.Drawing.Color.Red;
            this.TotalGeralTextBox.Location = new System.Drawing.Point(44, 512);
            this.TotalGeralTextBox.Name = "TotalGeralTextBox";
            this.TotalGeralTextBox.ReadOnly = true;
            this.TotalGeralTextBox.Size = new System.Drawing.Size(496, 44);
            this.TotalGeralTextBox.TabIndex = 10;
            this.TotalGeralTextBox.TabStop = false;
            this.TotalGeralTextBox.Text = "0,00";
            this.TotalGeralTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subTotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.subTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalTextBox.Location = new System.Drawing.Point(839, 437);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(258, 35);
            this.subTotalTextBox.TabIndex = 617;
            this.subTotalTextBox.Text = "0,00";
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SituaçãoTextBox
            // 
            this.SituaçãoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SituaçãoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SituaçãoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SituaçãoTextBox.Location = new System.Drawing.Point(578, 512);
            this.SituaçãoTextBox.Name = "SituaçãoTextBox";
            this.SituaçãoTextBox.ReadOnly = true;
            this.SituaçãoTextBox.Size = new System.Drawing.Size(519, 44);
            this.SituaçãoTextBox.TabIndex = 619;
            this.SituaçãoTextBox.Text = "...";
            this.SituaçãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelImagem
            // 
            this.panelImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelImagem.Controls.Add(this.pictuLogo);
            this.panelImagem.Location = new System.Drawing.Point(838, 132);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(259, 243);
            this.panelImagem.TabIndex = 625;
            // 
            // pictuLogo
            // 
            this.pictuLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictuLogo.Image")));
            this.pictuLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictuLogo.Location = new System.Drawing.Point(14, -5);
            this.pictuLogo.Name = "pictuLogo";
            this.pictuLogo.Size = new System.Drawing.Size(234, 237);
            this.pictuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictuLogo.TabIndex = 626;
            this.pictuLogo.TabStop = false;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.labelIdProduto);
            this.panelCentral.Controls.Add(this.grid);
            this.panelCentral.Controls.Add(this.textBoxNomeProduto);
            this.panelCentral.Controls.Add(label2);
            this.panelCentral.Controls.Add(telefoneLabel);
            this.panelCentral.Controls.Add(label1);
            this.panelCentral.Controls.Add(label3);
            this.panelCentral.Controls.Add(this.quantidadeTextBox);
            this.panelCentral.Controls.Add(label15);
            this.panelCentral.Controls.Add(this.valorUnitarioTextBox);
            this.panelCentral.Controls.Add(label14);
            this.panelCentral.Controls.Add(label8);
            this.panelCentral.Controls.Add(label12);
            this.panelCentral.Controls.Add(this.codigoBarraTextBox);
            this.panelCentral.Controls.Add(label11);
            this.panelCentral.Controls.Add(this.valorTotalTextBox);
            this.panelCentral.Controls.Add(this.SituaçãoTextBox);
            this.panelCentral.Controls.Add(label13);
            this.panelCentral.Controls.Add(label9);
            this.panelCentral.Controls.Add(this.subTotalTextBox);
            this.panelCentral.Controls.Add(label5);
            this.panelCentral.Controls.Add(this.TotalGeralTextBox);
            this.panelCentral.Controls.Add(this.panelImagem);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 57);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1140, 631);
            this.panelCentral.TabIndex = 628;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(44, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 43);
            this.panel1.TabIndex = 629;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(135, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de Produtos";
            // 
            // labelIdProduto
            // 
            this.labelIdProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdProduto.AutoSize = true;
            this.labelIdProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelIdProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "idProduto", true));
            this.labelIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdProduto.Location = new System.Drawing.Point(51, 121);
            this.labelIdProduto.Name = "labelIdProduto";
            this.labelIdProduto.Size = new System.Drawing.Size(105, 26);
            this.labelIdProduto.TabIndex = 630;
            this.labelIdProduto.Text = "idProduto";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroItem,
            this.ProdutosId_,
            this.Descricao,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal,
            this.Column1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.SystemColors.Control;
            this.grid.Location = new System.Drawing.Point(44, 153);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(496, 313);
            this.grid.TabIndex = 628;
            this.grid.TabStop = false;
            // 
            // numeroItem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            this.numeroItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.numeroItem.HeaderText = "N°";
            this.numeroItem.Name = "numeroItem";
            this.numeroItem.ReadOnly = true;
            this.numeroItem.Width = 40;
            // 
            // ProdutosId_
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.ProdutosId_.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProdutosId_.HeaderText = "Cod.";
            this.ProdutosId_.Name = "ProdutosId_";
            this.ProdutosId_.ReadOnly = true;
            this.ProdutosId_.Visible = false;
            this.ProdutosId_.Width = 90;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 40;
            // 
            // ValorUnitario
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorUnitario.HeaderText = "Preço";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            this.ValorUnitario.Width = 60;
            // 
            // ValorTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValorTotal.HeaderText = "Subtotal";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "idProduto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 688);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVendas_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.panelImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictuLogo)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox valorUnitarioTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        public System.Windows.Forms.TextBox TotalGeralTextBox;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.PictureBox pictuLogo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label labelIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutosId_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.TextBox codigoBarraTextBox;
        public System.Windows.Forms.TextBox subTotalTextBox;
        public System.Windows.Forms.TextBox SituaçãoTextBox;
    }
}