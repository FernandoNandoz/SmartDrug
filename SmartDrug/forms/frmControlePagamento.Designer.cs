namespace SmartDrug.forms
{
    partial class frmControlePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlePagamento));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label labelDataFinal;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.fecharGerarFaturaPictureBox = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnDetalhes = new System.Windows.Forms.PictureBox();
            this.RelacaoContaDataGridView = new System.Windows.Forms.DataGridView();
            this.descricaoPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorAluguelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacaoMensalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.pagarTudoInfTextBox = new System.Windows.Forms.TextBox();
            this.btnReceber = new System.Windows.Forms.PictureBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelSituacao = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacaoMensalidadeTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoMensalidadeTableAdapter();
            this.vendedorTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter();
            this.listaContasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaContasTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter();
            this.btnRenovarMensalidade = new System.Windows.Forms.Button();
            this.panelDataVencimento = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCalcularFatura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorAluguelTextBox = new System.Windows.Forms.TextBox();
            this.ParcelaComboBox = new System.Windows.Forms.ComboBox();
            this.dataVencimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelUltimaData = new System.Windows.Forms.Label();
            this.labelUltimaParcela = new System.Windows.Forms.Label();
            this.labelValorAluguel = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            labelDataFinal = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecharGerarFaturaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoMensalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasBindingSource)).BeginInit();
            this.panelDataVencimento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1507, 50);
            panelTop.TabIndex = 616;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(13, 9);
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
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            labTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            labTitulo.Location = new System.Drawing.Point(564, 6);
            labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(393, 39);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Controle de Pagamentos";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(1175, 63);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(261, 24);
            label15.TabIndex = 627;
            label15.Text = " F5 - Dar Baixa no Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(91, 85);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 31);
            label1.TabIndex = 678;
            label1.Text = "Cliente:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = System.Drawing.Color.Transparent;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label20.Location = new System.Drawing.Point(91, 132);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(238, 31);
            label20.TabIndex = 680;
            label20.Text = "Situacaoda Conta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(1036, 130);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 31);
            label3.TabIndex = 683;
            label3.Text = "Vendedor:";
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label6.Location = new System.Drawing.Point(13, 21);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(589, 94);
            label6.TabIndex = 619;
            label6.Text = resources.GetString("label6.Text");
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            panel1.Controls.Add(this.fecharGerarFaturaPictureBox);
            panel1.Controls.Add(label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(625, 50);
            panel1.TabIndex = 618;
            // 
            // fecharGerarFaturaPictureBox
            // 
            this.fecharGerarFaturaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fecharGerarFaturaPictureBox.Image")));
            this.fecharGerarFaturaPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecharGerarFaturaPictureBox.Location = new System.Drawing.Point(13, 9);
            this.fecharGerarFaturaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fecharGerarFaturaPictureBox.Name = "fecharGerarFaturaPictureBox";
            this.fecharGerarFaturaPictureBox.Size = new System.Drawing.Size(57, 37);
            this.fecharGerarFaturaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fecharGerarFaturaPictureBox.TabIndex = 77;
            this.fecharGerarFaturaPictureBox.TabStop = false;
            this.fecharGerarFaturaPictureBox.Click += new System.EventHandler(this.fecharGerarFaturaPictureBox_Click);
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            label2.ForeColor = System.Drawing.Color.Gainsboro;
            label2.Location = new System.Drawing.Point(144, 7);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(349, 39);
            label2.TabIndex = 31;
            label2.Text = "Renovar Mensalidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(69, 266);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 25);
            label5.TabIndex = 359;
            label5.Text = "Valor do Aluguel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(326, 189);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(205, 25);
            label4.TabIndex = 357;
            label4.Text = "Qnt de Parcela (Mês):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label7.Location = new System.Drawing.Point(76, 62);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(464, 31);
            label7.TabIndex = 334;
            label7.Text = "Informe os Dados para a Renovação!";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelDataFinal.Location = new System.Drawing.Point(69, 188);
            labelDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new System.Drawing.Size(191, 25);
            labelDataFinal.TabIndex = 333;
            labelDataFinal.Text = "Data de Pagamento:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1022, 734);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(167, 43);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 355;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(498, 734);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(167, 43);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 352;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.btnDetalhes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetalhes.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhes.Image")));
            this.btnDetalhes.Location = new System.Drawing.Point(673, 734);
            this.btnDetalhes.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(167, 43);
            this.btnDetalhes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDetalhes.TabIndex = 351;
            this.btnDetalhes.TabStop = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // RelacaoContaDataGridView
            // 
            this.RelacaoContaDataGridView.AllowUserToAddRows = false;
            this.RelacaoContaDataGridView.AllowUserToDeleteRows = false;
            this.RelacaoContaDataGridView.AllowUserToResizeColumns = false;
            this.RelacaoContaDataGridView.AllowUserToResizeRows = false;
            this.RelacaoContaDataGridView.AutoGenerateColumns = false;
            this.RelacaoContaDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.RelacaoContaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RelacaoContaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RelacaoContaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RelacaoContaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.RelacaoContaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RelacaoContaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoPagamentoDataGridViewTextBoxColumn,
            this.parcelaDataGridViewTextBoxColumn,
            this.vencimentoDataGridViewTextBoxColumn,
            this.dataPagamento,
            this.valorAluguelDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.idFormaPagamentoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idMensalidadeDataGridViewTextBoxColumn,
            this.documento,
            this.nomeVendedor});
            this.RelacaoContaDataGridView.DataSource = this.relacaoMensalidadeBindingSource;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RelacaoContaDataGridView.DefaultCellStyle = dataGridViewCellStyle34;
            this.RelacaoContaDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.RelacaoContaDataGridView.Location = new System.Drawing.Point(57, 196);
            this.RelacaoContaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RelacaoContaDataGridView.MultiSelect = false;
            this.RelacaoContaDataGridView.Name = "RelacaoContaDataGridView";
            this.RelacaoContaDataGridView.ReadOnly = true;
            this.RelacaoContaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RelacaoContaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.RelacaoContaDataGridView.RowHeadersVisible = false;
            this.RelacaoContaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RelacaoContaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RelacaoContaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RelacaoContaDataGridView.Size = new System.Drawing.Size(1396, 507);
            this.RelacaoContaDataGridView.TabIndex = 341;
            this.RelacaoContaDataGridView.TabStop = false;
            this.RelacaoContaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RelacaoContaDataGridView_CellFormatting);
            this.RelacaoContaDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RelacaoContaDataGridView_KeyDown);
            // 
            // descricaoPagamentoDataGridViewTextBoxColumn
            // 
            this.descricaoPagamentoDataGridViewTextBoxColumn.DataPropertyName = "descricaoPagamento";
            this.descricaoPagamentoDataGridViewTextBoxColumn.HeaderText = "Descricao Pagamento";
            this.descricaoPagamentoDataGridViewTextBoxColumn.Name = "descricaoPagamentoDataGridViewTextBoxColumn";
            this.descricaoPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoPagamentoDataGridViewTextBoxColumn.Width = 316;
            // 
            // parcelaDataGridViewTextBoxColumn
            // 
            this.parcelaDataGridViewTextBoxColumn.DataPropertyName = "parcela";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcelaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle32;
            this.parcelaDataGridViewTextBoxColumn.HeaderText = "Parc.";
            this.parcelaDataGridViewTextBoxColumn.Name = "parcelaDataGridViewTextBoxColumn";
            this.parcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcelaDataGridViewTextBoxColumn.Width = 61;
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            this.vencimentoDataGridViewTextBoxColumn.DataPropertyName = "vencimento";
            dataGridViewCellStyle33.Format = "d";
            this.vencimentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle33;
            this.vencimentoDataGridViewTextBoxColumn.HeaderText = "Vencimento";
            this.vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            this.vencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vencimentoDataGridViewTextBoxColumn.Width = 105;
            // 
            // dataPagamento
            // 
            this.dataPagamento.DataPropertyName = "dataPagamento";
            this.dataPagamento.HeaderText = "Pagamento em";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            // 
            // valorAluguelDataGridViewTextBoxColumn
            // 
            this.valorAluguelDataGridViewTextBoxColumn.DataPropertyName = "valorAluguel";
            this.valorAluguelDataGridViewTextBoxColumn.HeaderText = "Valor Aluguel";
            this.valorAluguelDataGridViewTextBoxColumn.Name = "valorAluguelDataGridViewTextBoxColumn";
            this.valorAluguelDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorAluguelDataGridViewTextBoxColumn.Width = 120;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 110;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 85;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Forma Pagamento";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idFormaPagamentoDataGridViewTextBoxColumn
            // 
            this.idFormaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "idFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.HeaderText = "idFormaPagamento";
            this.idFormaPagamentoDataGridViewTextBoxColumn.Name = "idFormaPagamentoDataGridViewTextBoxColumn";
            this.idFormaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFormaPagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMensalidadeDataGridViewTextBoxColumn
            // 
            this.idMensalidadeDataGridViewTextBoxColumn.DataPropertyName = "idMensalidade";
            this.idMensalidadeDataGridViewTextBoxColumn.HeaderText = "idMensalidade";
            this.idMensalidadeDataGridViewTextBoxColumn.Name = "idMensalidadeDataGridViewTextBoxColumn";
            this.idMensalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMensalidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Visible = false;
            // 
            // nomeVendedor
            // 
            this.nomeVendedor.DataPropertyName = "nomeVendedor";
            this.nomeVendedor.HeaderText = "Vendedor";
            this.nomeVendedor.Name = "nomeVendedor";
            this.nomeVendedor.ReadOnly = true;
            this.nomeVendedor.Visible = false;
            // 
            // relacaoMensalidadeBindingSource
            // 
            this.relacaoMensalidadeBindingSource.DataMember = "RelacaoMensalidade";
            this.relacaoMensalidadeBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagarTudoInfTextBox
            // 
            this.pagarTudoInfTextBox.Location = new System.Drawing.Point(500, 368);
            this.pagarTudoInfTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pagarTudoInfTextBox.Name = "pagarTudoInfTextBox";
            this.pagarTudoInfTextBox.Size = new System.Drawing.Size(132, 22);
            this.pagarTudoInfTextBox.TabIndex = 354;
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Transparent;
            this.btnReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceber.Image = ((System.Drawing.Image)(resources.GetObject("btnReceber.Image")));
            this.btnReceber.Location = new System.Drawing.Point(847, 734);
            this.btnReceber.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(167, 43);
            this.btnReceber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReceber.TabIndex = 628;
            this.btnReceber.TabStop = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relacaoMensalidadeBindingSource, "nome", true));
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelNomeCliente.Location = new System.Drawing.Point(199, 86);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(74, 29);
            this.labelNomeCliente.TabIndex = 679;
            this.labelNomeCliente.Text = "nome";
            // 
            // labelSituacao
            // 
            this.labelSituacao.AutoSize = true;
            this.labelSituacao.BackColor = System.Drawing.Color.Transparent;
            this.labelSituacao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relacaoMensalidadeBindingSource, "situacao", true));
            this.labelSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSituacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSituacao.Location = new System.Drawing.Point(341, 132);
            this.labelSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSituacao.Name = "labelSituacao";
            this.labelSituacao.Size = new System.Drawing.Size(102, 29);
            this.labelSituacao.TabIndex = 681;
            this.labelSituacao.Text = "situacao";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 41;
            this.lineShape1.X2 = 1084;
            this.lineShape1.Y1 = 139;
            this.lineShape1.Y2 = 139;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1507, 800);
            this.shapeContainer1.TabIndex = 682;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 43;
            this.lineShape2.X2 = 1086;
            this.lineShape2.Y1 = 60;
            this.lineShape2.Y2 = 60;
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.BackColor = System.Drawing.Color.Transparent;
            this.labelVendedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.relacaoMensalidadeBindingSource, "nomeVendedor", true));
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelVendedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVendedor.Location = new System.Drawing.Point(1179, 130);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(115, 29);
            this.labelVendedor.TabIndex = 684;
            this.labelVendedor.Text = "vendedor";
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // relacaoMensalidadeTableAdapter
            // 
            this.relacaoMensalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // listaContasBindingSource
            // 
            this.listaContasBindingSource.DataMember = "ListaContas";
            this.listaContasBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // listaContasTableAdapter
            // 
            this.listaContasTableAdapter.ClearBeforeFill = true;
            // 
            // btnRenovarMensalidade
            // 
            this.btnRenovarMensalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnRenovarMensalidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRenovarMensalidade.BackgroundImage")));
            this.btnRenovarMensalidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRenovarMensalidade.FlatAppearance.BorderSize = 0;
            this.btnRenovarMensalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovarMensalidade.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnRenovarMensalidade.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRenovarMensalidade.Location = new System.Drawing.Point(334, 734);
            this.btnRenovarMensalidade.Name = "btnRenovarMensalidade";
            this.btnRenovarMensalidade.Size = new System.Drawing.Size(157, 43);
            this.btnRenovarMensalidade.TabIndex = 685;
            this.btnRenovarMensalidade.UseVisualStyleBackColor = false;
            this.btnRenovarMensalidade.Click += new System.EventHandler(this.btnRenovarMensalidade_Click);
            // 
            // panelDataVencimento
            // 
            this.panelDataVencimento.Controls.Add(this.labelValorAluguel);
            this.panelDataVencimento.Controls.Add(label);
            this.panelDataVencimento.Controls.Add(this.labelUltimaParcela);
            this.panelDataVencimento.Controls.Add(this.labelUltimaData);
            this.panelDataVencimento.Controls.Add(label9);
            this.panelDataVencimento.Controls.Add(label8);
            this.panelDataVencimento.Controls.Add(this.btnVoltar);
            this.panelDataVencimento.Controls.Add(this.btnCalcularFatura);
            this.panelDataVencimento.Controls.Add(this.groupBox1);
            this.panelDataVencimento.Controls.Add(panel1);
            this.panelDataVencimento.Controls.Add(label5);
            this.panelDataVencimento.Controls.Add(this.valorAluguelTextBox);
            this.panelDataVencimento.Controls.Add(label4);
            this.panelDataVencimento.Controls.Add(this.ParcelaComboBox);
            this.panelDataVencimento.Controls.Add(this.dataVencimentoMaskedTextBox);
            this.panelDataVencimento.Controls.Add(label7);
            this.panelDataVencimento.Controls.Add(labelDataFinal);
            this.panelDataVencimento.Controls.Add(label10);
            this.panelDataVencimento.Controls.Add(label11);
            this.panelDataVencimento.Location = new System.Drawing.Point(446, 172);
            this.panelDataVencimento.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataVencimento.Name = "panelDataVencimento";
            this.panelDataVencimento.Size = new System.Drawing.Size(625, 539);
            this.panelDataVencimento.TabIndex = 686;
            this.panelDataVencimento.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoltar.Location = new System.Drawing.Point(331, 350);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(221, 39);
            this.btnVoltar.TabIndex = 622;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcularFatura
            // 
            this.btnCalcularFatura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnCalcularFatura.FlatAppearance.BorderSize = 0;
            this.btnCalcularFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcularFatura.Location = new System.Drawing.Point(74, 350);
            this.btnCalcularFatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcularFatura.Name = "btnCalcularFatura";
            this.btnCalcularFatura.Size = new System.Drawing.Size(213, 39);
            this.btnCalcularFatura.TabIndex = 621;
            this.btnCalcularFatura.TabStop = false;
            this.btnCalcularFatura.Text = "Gerar Nova Fatura";
            this.btnCalcularFatura.UseVisualStyleBackColor = false;
            this.btnCalcularFatura.Click += new System.EventHandler(this.btnCalcularFatura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Location = new System.Drawing.Point(7, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 130);
            this.groupBox1.TabIndex = 620;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leia:";
            // 
            // valorAluguelTextBox
            // 
            this.valorAluguelTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorAluguelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorAluguelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorAluguelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorAluguelTextBox.Location = new System.Drawing.Point(75, 294);
            this.valorAluguelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorAluguelTextBox.Name = "valorAluguelTextBox";
            this.valorAluguelTextBox.Size = new System.Drawing.Size(212, 34);
            this.valorAluguelTextBox.TabIndex = 2;
            this.valorAluguelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorAluguelTextBox_KeyDown);
            // 
            // ParcelaComboBox
            // 
            this.ParcelaComboBox.DisplayMember = "descricao";
            this.ParcelaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ParcelaComboBox.FormattingEnabled = true;
            this.ParcelaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ParcelaComboBox.Location = new System.Drawing.Point(331, 218);
            this.ParcelaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParcelaComboBox.Name = "ParcelaComboBox";
            this.ParcelaComboBox.Size = new System.Drawing.Size(212, 34);
            this.ParcelaComboBox.TabIndex = 1;
            this.ParcelaComboBox.ValueMember = "idCidade";
            // 
            // dataVencimentoMaskedTextBox
            // 
            this.dataVencimentoMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataVencimentoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataVencimentoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dataVencimentoMaskedTextBox.Location = new System.Drawing.Point(75, 217);
            this.dataVencimentoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataVencimentoMaskedTextBox.Mask = "00/00/0000";
            this.dataVencimentoMaskedTextBox.Name = "dataVencimentoMaskedTextBox";
            this.dataVencimentoMaskedTextBox.Size = new System.Drawing.Size(212, 34);
            this.dataVencimentoMaskedTextBox.TabIndex = 0;
            this.dataVencimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(71, 109);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(192, 24);
            label8.TabIndex = 623;
            label8.Text = "Data da Ultima Fatura:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(71, 143);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(134, 24);
            label9.TabIndex = 624;
            label9.Text = "Ultima Parcela:";
            // 
            // labelUltimaData
            // 
            this.labelUltimaData.AutoSize = true;
            this.labelUltimaData.BackColor = System.Drawing.Color.Transparent;
            this.labelUltimaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimaData.Location = new System.Drawing.Point(271, 109);
            this.labelUltimaData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUltimaData.Name = "labelUltimaData";
            this.labelUltimaData.Size = new System.Drawing.Size(40, 24);
            this.labelUltimaData.TabIndex = 625;
            this.labelUltimaData.Text = "null";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Location = new System.Drawing.Point(69, 154);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(480, 24);
            label10.TabIndex = 626;
            label10.Text = "_______________________________________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Location = new System.Drawing.Point(70, 82);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(480, 24);
            label11.TabIndex = 627;
            label11.Text = "_______________________________________________";
            // 
            // labelUltimaParcela
            // 
            this.labelUltimaParcela.AutoSize = true;
            this.labelUltimaParcela.BackColor = System.Drawing.Color.Transparent;
            this.labelUltimaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimaParcela.Location = new System.Drawing.Point(213, 143);
            this.labelUltimaParcela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUltimaParcela.Name = "labelUltimaParcela";
            this.labelUltimaParcela.Size = new System.Drawing.Size(40, 24);
            this.labelUltimaParcela.TabIndex = 628;
            this.labelUltimaParcela.Text = "null";
            // 
            // labelValorAluguel
            // 
            this.labelValorAluguel.AutoSize = true;
            this.labelValorAluguel.BackColor = System.Drawing.Color.Transparent;
            this.labelValorAluguel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorAluguel.Location = new System.Drawing.Point(481, 143);
            this.labelValorAluguel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorAluguel.Name = "labelValorAluguel";
            this.labelValorAluguel.Size = new System.Drawing.Size(40, 24);
            this.labelValorAluguel.TabIndex = 631;
            this.labelValorAluguel.Text = "null";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(317, 143);
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new System.Drawing.Size(156, 24);
            label.TabIndex = 629;
            label.Text = "Valor do Aluguel:";
            // 
            // frmControlePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 800);
            this.Controls.Add(this.btnRenovarMensalidade);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(label3);
            this.Controls.Add(this.labelSituacao);
            this.Controls.Add(label20);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(label15);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.panelDataVencimento);
            this.Controls.Add(this.RelacaoContaDataGridView);
            this.Controls.Add(this.pagarTudoInfTextBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControlePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlePagamento";
            this.Load += new System.EventHandler(this.frmControlePagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmControlePagamento_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecharGerarFaturaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelacaoContaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoMensalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaContasBindingSource)).EndInit();
            this.panelDataVencimento.ResumeLayout(false);
            this.panelDataVencimento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnDetalhes;
        public System.Windows.Forms.DataGridView RelacaoContaDataGridView;
        public System.Windows.Forms.TextBox pagarTudoInfTextBox;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource relacaoMensalidadeBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoMensalidadeTableAdapter relacaoMensalidadeTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnReceber;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelSituacao;
        private System.Windows.Forms.BindingSource listaContasBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ListaContasTableAdapter listaContasTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorAluguelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeVendedor;
        private System.Windows.Forms.Button btnRenovarMensalidade;
        private System.Windows.Forms.Panel panelDataVencimento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox fecharGerarFaturaPictureBox;
        private System.Windows.Forms.TextBox valorAluguelTextBox;
        private System.Windows.Forms.ComboBox ParcelaComboBox;
        private System.Windows.Forms.MaskedTextBox dataVencimentoMaskedTextBox;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCalcularFatura;
        private System.Windows.Forms.Label labelValorAluguel;
        private System.Windows.Forms.Label labelUltimaParcela;
        private System.Windows.Forms.Label labelUltimaData;
    }
}