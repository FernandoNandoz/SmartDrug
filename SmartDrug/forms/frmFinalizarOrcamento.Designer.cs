namespace SmartDrug.forms
{
    partial class frmFinalizarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarOrcamento));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.groupOpcoes = new System.Windows.Forms.GroupBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.vendedorComboBox = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.joinContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelObservacao = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.descontoTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.valorRestanteTextBox = new System.Windows.Forms.TextBox();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.clientesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            this.listaContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter();
            this.joinContasReceberTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.groupOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(911, 52);
            panelTop.TabIndex = 655;
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
            labTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            labTitulo.Location = new System.Drawing.Point(283, 9);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(350, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Finalizando Orçamento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(28, 13);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(90, 17);
            label12.TabIndex = 624;
            label12.Text = "01 - Dinheiro";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.Location = new System.Drawing.Point(476, 24);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(157, 18);
            label16.TabIndex = 630;
            label16.Text = " F1 - Pesquisar Cliente";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(128, 13);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(82, 17);
            label14.TabIndex = 625;
            label14.Text = "03 - Crédito";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(687, 24);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(142, 18);
            label13.TabIndex = 629;
            label13.Text = " F5 - Concluir Venda";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(28, 36);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(78, 17);
            label15.TabIndex = 626;
            label15.Text = "02 - Débito";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(127, 37);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(151, 17);
            label11.TabIndex = 628;
            label11.Text = "05 - Contas a Receber";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(238, 75);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(137, 20);
            enderecoLabel.TabIndex = 665;
            enderecoLabel.Text = "Descrição/Cliente:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(48, 76);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(83, 20);
            label8.TabIndex = 663;
            label8.Text = "Vendedor:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.Transparent;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label18.Location = new System.Drawing.Point(630, 163);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(100, 24);
            label18.TabIndex = 672;
            label18.Text = "Vendedor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label20.Location = new System.Drawing.Point(569, 196);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(162, 24);
            label20.TabIndex = 670;
            label20.Text = "Situacaoda Conta:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label17.Location = new System.Drawing.Point(46, 197);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(117, 24);
            label17.TabIndex = 667;
            label17.Text = "Observação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label2.Location = new System.Drawing.Point(46, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 24);
            label2.TabIndex = 666;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(37, 250);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 24);
            label3.TabIndex = 684;
            label3.Text = "Forma de pagamento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(667, 247);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 24);
            label1.TabIndex = 680;
            label1.Text = "Valor a Pagar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label7.Location = new System.Drawing.Point(448, 247);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 24);
            label7.TabIndex = 683;
            label7.Text = "Desconto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(448, 328);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 24);
            label5.TabIndex = 682;
            label5.Text = "Valor Pago:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(667, 328);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 24);
            label4.TabIndex = 681;
            label4.Text = "Valor Restante:";
            // 
            // groupOpcoes
            // 
            this.groupOpcoes.Controls.Add(label12);
            this.groupOpcoes.Controls.Add(label16);
            this.groupOpcoes.Controls.Add(label14);
            this.groupOpcoes.Controls.Add(label13);
            this.groupOpcoes.Controls.Add(label15);
            this.groupOpcoes.Controls.Add(label11);
            this.groupOpcoes.Location = new System.Drawing.Point(26, 409);
            this.groupOpcoes.Name = "groupOpcoes";
            this.groupOpcoes.Size = new System.Drawing.Size(863, 61);
            this.groupOpcoes.TabIndex = 656;
            this.groupOpcoes.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 28;
            this.lineShape1.X2 = 874;
            this.lineShape1.Y1 = 156;
            this.lineShape1.Y2 = 156;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(911, 479);
            this.shapeContainer1.TabIndex = 657;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 30;
            this.lineShape2.X2 = 876;
            this.lineShape2.Y1 = 227;
            this.lineShape2.Y2 = 227;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(242, 100);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(365, 29);
            this.descricaoTextBox.TabIndex = 2;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // vendedorComboBox
            // 
            this.vendedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vendedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vendedorComboBox.DataSource = this.vendedorBindingSource;
            this.vendedorComboBox.DisplayMember = "nome";
            this.vendedorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorComboBox.FormattingEnabled = true;
            this.vendedorComboBox.Location = new System.Drawing.Point(52, 101);
            this.vendedorComboBox.Name = "vendedorComboBox";
            this.vendedorComboBox.Size = new System.Drawing.Size(167, 28);
            this.vendedorComboBox.TabIndex = 1;
            this.vendedorComboBox.ValueMember = "idVendedor";
            this.vendedorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vendedorComboBox_KeyDown);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "nome", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVendedor.Location = new System.Drawing.Point(730, 165);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(75, 20);
            this.labelVendedor.TabIndex = 673;
            this.labelVendedor.Text = "vendedor";
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.BackColor = System.Drawing.Color.Transparent;
            this.labelSituacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "SituacaoConta", true));
            this.labelSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSituacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSituacao.Location = new System.Drawing.Point(730, 199);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(69, 20);
            this.labelSituacao.TabIndex = 671;
            this.labelSituacao.Text = "situacao";
            // 
            // joinContasReceberBindingSource
            // 
            this.joinContasReceberBindingSource.DataMember = "JoinContasReceber";
            this.joinContasReceberBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // listaContasBindingSource
            // 
            this.listaContasBindingSource.DataMember = "ListaContas";
            this.listaContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.BackColor = System.Drawing.Color.Transparent;
            this.labelObservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "observacao", true));
            this.labelObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelObservacao.Location = new System.Drawing.Point(162, 200);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(91, 20);
            this.labelObservacao.TabIndex = 668;
            this.labelObservacao.Text = "observação";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nome", true));
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNomeCliente.Location = new System.Drawing.Point(114, 166);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(49, 20);
            this.labelNomeCliente.TabIndex = 669;
            this.labelNomeCliente.Text = "nome";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.subtotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.subtotalTextBox.ForeColor = System.Drawing.Color.Red;
            this.subtotalTextBox.Location = new System.Drawing.Point(671, 276);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(195, 41);
            this.subtotalTextBox.TabIndex = 678;
            this.subtotalTextBox.TabStop = false;
            this.subtotalTextBox.Text = "0,00";
            // 
            // descontoTextBox
            // 
            this.descontoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.descontoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descontoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.descontoTextBox.Location = new System.Drawing.Point(452, 275);
            this.descontoTextBox.Name = "descontoTextBox";
            this.descontoTextBox.Size = new System.Drawing.Size(195, 41);
            this.descontoTextBox.TabIndex = 4;
            this.descontoTextBox.Text = "0,00";
            this.descontoTextBox.TextChanged += new System.EventHandler(this.descontoTextBox_TextChanged);
            this.descontoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descontoTextBox_KeyDown);
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.valorPagoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorPagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.valorPagoTextBox.Location = new System.Drawing.Point(452, 356);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(195, 41);
            this.valorPagoTextBox.TabIndex = 5;
            this.valorPagoTextBox.Text = "0,00";
            this.valorPagoTextBox.TextChanged += new System.EventHandler(this.valorPagoTextBox_TextChanged);
            this.valorPagoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorPagoTextBox_KeyDown);
            // 
            // valorRestanteTextBox
            // 
            this.valorRestanteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.valorRestanteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorRestanteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.valorRestanteTextBox.ForeColor = System.Drawing.Color.Red;
            this.valorRestanteTextBox.Location = new System.Drawing.Point(671, 356);
            this.valorRestanteTextBox.Name = "valorRestanteTextBox";
            this.valorRestanteTextBox.ReadOnly = true;
            this.valorRestanteTextBox.Size = new System.Drawing.Size(195, 41);
            this.valorRestanteTextBox.TabIndex = 679;
            this.valorRestanteTextBox.TabStop = false;
            this.valorRestanteTextBox.Text = "0,00";
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(41, 278);
            this.formaPagamentoTextBox.Multiline = true;
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.ReadOnly = true;
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(381, 119);
            this.formaPagamentoTextBox.TabIndex = 3;
            this.formaPagamentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // listaContasTableAdapter
            // 
            this.listaContasTableAdapter.ClearBeforeFill = true;
            // 
            // joinContasReceberTableAdapter
            // 
            this.joinContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // frmFinalizarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 479);
            this.Controls.Add(label3);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.descontoTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(label7);
            this.Controls.Add(this.valorPagoTextBox);
            this.Controls.Add(this.valorRestanteTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(label18);
            this.Controls.Add(this.labelSituacao);
            this.Controls.Add(label20);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(label17);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(label2);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(label8);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.vendedorComboBox);
            this.Controls.Add(this.groupOpcoes);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(350, 130);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinalizarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Finalizar Orçamento";
            this.Load += new System.EventHandler(this.frmFinalizarOrcamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinalizarOrcamento_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.groupOpcoes.ResumeLayout(false);
            this.groupOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.GroupBox groupOpcoes;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.TextBox descricaoTextBox;
        public System.Windows.Forms.ComboBox vendedorComboBox;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelSituacao;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox descontoTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox valorRestanteTextBox;
        public System.Windows.Forms.TextBox formaPagamentoTextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.BindingSource listaContasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter listaContasTableAdapter;
        private System.Windows.Forms.BindingSource joinContasReceberBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter joinContasReceberTableAdapter;
    }
}