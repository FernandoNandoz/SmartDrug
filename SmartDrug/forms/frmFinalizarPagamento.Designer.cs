namespace SmartDrug.forms
{
    partial class frmFinalizarPagamento
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarPagamento));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.NOTAtextBox = new System.Windows.Forms.TextBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.linkLabelManual = new System.Windows.Forms.LinkLabel();
            this.textBoxPagaTudo = new System.Windows.Forms.TextBox();
            this.vendedorComboBox = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.valorRestanteTextBox = new System.Windows.Forms.TextBox();
            this.formaPagamentoTextBox = new System.Windows.Forms.TextBox();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            this.clientesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter();
            label2 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(59, 91);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 615;
            label2.Text = "Vendedor:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Location = new System.Drawing.Point(40, 31);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(106, 20);
            label12.TabIndex = 624;
            label12.Text = "01 - Dinheiro";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label14.Location = new System.Drawing.Point(391, 33);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(97, 20);
            label14.TabIndex = 625;
            label14.Text = "03 - Crédito";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Location = new System.Drawing.Point(745, 31);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(184, 24);
            label13.TabIndex = 629;
            label13.Text = " F5 - Concluir Venda";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(220, 32);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(92, 20);
            label15.TabIndex = 626;
            label15.Text = "02 - Débito";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1215, 64);
            panelTop.TabIndex = 655;
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
            labTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            labTitulo.Location = new System.Drawing.Point(373, 11);
            labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(439, 46);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Finalizando Pagamento";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoLabel.Location = new System.Drawing.Point(320, 91);
            enderecoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(172, 25);
            enderecoLabel.TabIndex = 659;
            enderecoLabel.Text = "Descrição/Cliente:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = System.Drawing.Color.Transparent;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label18.Location = new System.Drawing.Point(811, 198);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(125, 29);
            label18.TabIndex = 680;
            label18.Text = "Vendedor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label20.Location = new System.Drawing.Point(729, 239);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(208, 29);
            label20.TabIndex = 678;
            label20.Text = "Situacaoda Conta:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.Transparent;
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label17.Location = new System.Drawing.Point(59, 240);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(149, 29);
            label17.TabIndex = 675;
            label17.Text = "Observação:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(59, 198);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 29);
            label1.TabIndex = 674;
            label1.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(55, 306);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(250, 29);
            label3.TabIndex = 694;
            label3.Text = "Forma de pagamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(889, 303);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(164, 29);
            label4.TabIndex = 690;
            label4.Text = "Valor a Pagar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(601, 304);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(138, 29);
            label5.TabIndex = 692;
            label5.Text = "Valor Pago:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(889, 402);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(176, 29);
            label6.TabIndex = 691;
            label6.Text = "Valor Restante:";
            // 
            // NOTAtextBox
            // 
            this.NOTAtextBox.Location = new System.Drawing.Point(423, 378);
            this.NOTAtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NOTAtextBox.Name = "NOTAtextBox";
            this.NOTAtextBox.Size = new System.Drawing.Size(132, 22);
            this.NOTAtextBox.TabIndex = 356;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(423, 427);
            this.textBoxIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(132, 22);
            this.textBoxIdCliente.TabIndex = 357;
            // 
            // linkLabelManual
            // 
            this.linkLabelManual.Location = new System.Drawing.Point(0, 0);
            this.linkLabelManual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelManual.Name = "linkLabelManual";
            this.linkLabelManual.Size = new System.Drawing.Size(133, 28);
            this.linkLabelManual.TabIndex = 695;
            // 
            // textBoxPagaTudo
            // 
            this.textBoxPagaTudo.Location = new System.Drawing.Point(72, 427);
            this.textBoxPagaTudo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPagaTudo.Name = "textBoxPagaTudo";
            this.textBoxPagaTudo.Size = new System.Drawing.Size(132, 22);
            this.textBoxPagaTudo.TabIndex = 613;
            // 
            // vendedorComboBox
            // 
            this.vendedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.vendedorComboBox.DataSource = this.vendedorBindingSource;
            this.vendedorComboBox.DisplayMember = "nome";
            this.vendedorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorComboBox.FormattingEnabled = true;
            this.vendedorComboBox.Location = new System.Drawing.Point(64, 119);
            this.vendedorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.vendedorComboBox.Name = "vendedorComboBox";
            this.vendedorComboBox.Size = new System.Drawing.Size(239, 33);
            this.vendedorComboBox.TabIndex = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label12);
            this.groupBox3.Controls.Add(label14);
            this.groupBox3.Controls.Add(label13);
            this.groupBox3.Controls.Add(label15);
            this.groupBox3.Location = new System.Drawing.Point(28, 503);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1151, 75);
            this.groupBox3.TabIndex = 653;
            this.groupBox3.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 26;
            this.lineShape1.X2 = 873;
            this.lineShape1.Y1 = 155;
            this.lineShape1.Y2 = 155;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1215, 590);
            this.shapeContainer1.TabIndex = 656;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 27;
            this.lineShape2.X2 = 874;
            this.lineShape2.Y1 = 227;
            this.lineShape2.Y2 = 227;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(325, 118);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(569, 34);
            this.descricaoTextBox.TabIndex = 1;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "nome", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVendedor.Location = new System.Drawing.Point(944, 201);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(94, 25);
            this.labelVendedor.TabIndex = 681;
            this.labelVendedor.Text = "vendedor";
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.BackColor = System.Drawing.Color.Transparent;
            this.labelSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSituacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSituacao.Location = new System.Drawing.Point(944, 242);
            this.labelSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(85, 25);
            this.labelSituacao.TabIndex = 679;
            this.labelSituacao.Text = "situacao";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.BackColor = System.Drawing.Color.Transparent;
            this.labelObservacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "observacao", true));
            this.labelObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelObservacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelObservacao.Location = new System.Drawing.Point(213, 244);
            this.labelObservacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(114, 25);
            this.labelObservacao.TabIndex = 676;
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
            this.labelNomeCliente.Location = new System.Drawing.Point(149, 202);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(61, 25);
            this.labelNomeCliente.TabIndex = 677;
            this.labelNomeCliente.Text = "nome";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.subtotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.subtotalTextBox.ForeColor = System.Drawing.Color.Red;
            this.subtotalTextBox.Location = new System.Drawing.Point(895, 338);
            this.subtotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(259, 49);
            this.subtotalTextBox.TabIndex = 688;
            this.subtotalTextBox.TabStop = false;
            this.subtotalTextBox.Text = "0,00";
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.valorPagoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorPagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.valorPagoTextBox.Location = new System.Drawing.Point(607, 338);
            this.valorPagoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(259, 49);
            this.valorPagoTextBox.TabIndex = 3;
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
            this.valorRestanteTextBox.Location = new System.Drawing.Point(895, 437);
            this.valorRestanteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorRestanteTextBox.Name = "valorRestanteTextBox";
            this.valorRestanteTextBox.ReadOnly = true;
            this.valorRestanteTextBox.Size = new System.Drawing.Size(259, 49);
            this.valorRestanteTextBox.TabIndex = 689;
            this.valorRestanteTextBox.TabStop = false;
            this.valorRestanteTextBox.Text = "0,00";
            // 
            // formaPagamentoTextBox
            // 
            this.formaPagamentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.formaPagamentoTextBox.Location = new System.Drawing.Point(60, 341);
            this.formaPagamentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.formaPagamentoTextBox.Multiline = true;
            this.formaPagamentoTextBox.Name = "formaPagamentoTextBox";
            this.formaPagamentoTextBox.ReadOnly = true;
            this.formaPagamentoTextBox.Size = new System.Drawing.Size(507, 146);
            this.formaPagamentoTextBox.TabIndex = 2;
            this.formaPagamentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formaPagamentoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formaPagamentoTextBox_KeyDown);
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmFinalizarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1215, 590);
            this.Controls.Add(label3);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.valorPagoTextBox);
            this.Controls.Add(this.valorRestanteTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(this.formaPagamentoTextBox);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(label18);
            this.Controls.Add(this.labelSituacao);
            this.Controls.Add(label20);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(label17);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(label1);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.vendedorComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.linkLabelManual);
            this.Controls.Add(this.textBoxPagaTudo);
            this.Controls.Add(this.NOTAtextBox);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(350, 150);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFinalizarPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Finalizar Pagamento";
            this.Load += new System.EventHandler(this.frmFinalizarPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFinalizarPagamento_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox NOTAtextBox;
        public System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.LinkLabel linkLabelManual;
        public System.Windows.Forms.TextBox textBoxPagaTudo;
        public System.Windows.Forms.ComboBox vendedorComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox btnFechar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelSituacao;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.Label labelNomeCliente;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox valorRestanteTextBox;
        public System.Windows.Forms.TextBox formaPagamentoTextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}