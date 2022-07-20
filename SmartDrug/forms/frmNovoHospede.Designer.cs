namespace SmartDrug.forms
{
    partial class frmNovoHospede
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
            System.Windows.Forms.Label labelDataFinal;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoHospede));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.fecharGerarFaturaPictureBox = new System.Windows.Forms.PictureBox();
            this.btnGerarFatura = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.clientesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeContatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rginscricaoEstadualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnCalcularFatura = new System.Windows.Forms.PictureBox();
            this.panelDataVencimento = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorAluguelTextBox = new System.Windows.Forms.TextBox();
            this.ParcelaComboBox = new System.Windows.Forms.ComboBox();
            this.dataVencimentoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            labelDataFinal = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecharGerarFaturaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGerarFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularFatura)).BeginInit();
            this.panelDataVencimento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            labelDataFinal.Location = new System.Drawing.Point(62, 115);
            labelDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new System.Drawing.Size(191, 25);
            labelDataFinal.TabIndex = 333;
            labelDataFinal.Text = "Data de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(55, 67);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(475, 29);
            label3.TabIndex = 334;
            label3.Text = "Informe os Dados para Fatura do Hospede!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(319, 116);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(205, 25);
            label4.TabIndex = 357;
            label4.Text = "Qnt de Parcela (Mês):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(62, 194);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 25);
            label5.TabIndex = 359;
            label5.Text = "Valor do Aluguel:";
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
            panelTop.TabIndex = 617;
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
            labTitulo.Location = new System.Drawing.Point(624, 7);
            labTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(243, 39);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Novo Hospede";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            panel1.Controls.Add(this.fecharGerarFaturaPictureBox);
            panel1.Controls.Add(label1);
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
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            label1.ForeColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(195, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 39);
            label1.TabIndex = 31;
            label1.Text = "Gerar Fatura";
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            label6.Location = new System.Drawing.Point(13, 23);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(589, 94);
            label6.TabIndex = 619;
            label6.Text = resources.GetString("label6.Text");
            // 
            // btnGerarFatura
            // 
            this.btnGerarFatura.BackColor = System.Drawing.Color.Transparent;
            this.btnGerarFatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerarFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarFatura.Image")));
            this.btnGerarFatura.Location = new System.Drawing.Point(661, 726);
            this.btnGerarFatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarFatura.Name = "btnGerarFatura";
            this.btnGerarFatura.Size = new System.Drawing.Size(187, 47);
            this.btnGerarFatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGerarFatura.TabIndex = 350;
            this.btnGerarFatura.TabStop = false;
            this.btnGerarFatura.Click += new System.EventHandler(this.btnGerarFatura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 349;
            this.label2.Text = "Nome Cliente:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(56, 123);
            this.textPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(683, 30);
            this.textPesquisa.TabIndex = 343;
            this.textPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisa_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(856, 726);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(187, 47);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 348;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(467, 726);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(187, 47);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 347;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(748, 123);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(140, 31);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 344;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoClienteDataGridViewTextBoxColumn
            // 
            this.idSituacaoClienteDataGridViewTextBoxColumn.DataPropertyName = "idSituacaoCliente";
            this.idSituacaoClienteDataGridViewTextBoxColumn.HeaderText = "idSituacaoCliente";
            this.idSituacaoClienteDataGridViewTextBoxColumn.Name = "idSituacaoClienteDataGridViewTextBoxColumn";
            this.idSituacaoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            this.observacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeContatoDataGridViewTextBoxColumn
            // 
            this.nomeContatoDataGridViewTextBoxColumn.DataPropertyName = "nomeContato";
            this.nomeContatoDataGridViewTextBoxColumn.HeaderText = "Nome Contato";
            this.nomeContatoDataGridViewTextBoxColumn.Name = "nomeContatoDataGridViewTextBoxColumn";
            this.nomeContatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeContatoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefone2DataGridViewTextBoxColumn
            // 
            this.telefone2DataGridViewTextBoxColumn.DataPropertyName = "telefone2";
            this.telefone2DataGridViewTextBoxColumn.HeaderText = "Telefone Secundario";
            this.telefone2DataGridViewTextBoxColumn.Name = "telefone2DataGridViewTextBoxColumn";
            this.telefone2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefone2DataGridViewTextBoxColumn.Width = 180;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 130;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 130;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            this.paisDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisDataGridViewTextBoxColumn.Width = 130;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 200;
            // 
            // tipoClienteDataGridViewTextBoxColumn
            // 
            this.tipoClienteDataGridViewTextBoxColumn.DataPropertyName = "tipoCliente";
            this.tipoClienteDataGridViewTextBoxColumn.HeaderText = "Tipo Cliente";
            this.tipoClienteDataGridViewTextBoxColumn.Name = "tipoClienteDataGridViewTextBoxColumn";
            this.tipoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoClienteDataGridViewTextBoxColumn.Width = 140;
            // 
            // rginscricaoEstadualDataGridViewTextBoxColumn
            // 
            this.rginscricaoEstadualDataGridViewTextBoxColumn.DataPropertyName = "rg_inscricaoEstadual";
            this.rginscricaoEstadualDataGridViewTextBoxColumn.HeaderText = "RG/Inscr Estadual";
            this.rginscricaoEstadualDataGridViewTextBoxColumn.Name = "rginscricaoEstadualDataGridViewTextBoxColumn";
            this.rginscricaoEstadualDataGridViewTextBoxColumn.ReadOnly = true;
            this.rginscricaoEstadualDataGridViewTextBoxColumn.Width = 180;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ";
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfcnpjDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.AllowUserToResizeColumns = false;
            this.dataGridViewCliente.AllowUserToResizeRows = false;
            this.dataGridViewCliente.AutoGenerateColumns = false;
            this.dataGridViewCliente.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn,
            this.rginscricaoEstadualDataGridViewTextBoxColumn,
            this.tipoClienteDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.telefone2DataGridViewTextBoxColumn,
            this.nomeContatoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn,
            this.idSituacaoClienteDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn});
            this.dataGridViewCliente.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCliente.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCliente.Location = new System.Drawing.Point(56, 179);
            this.dataGridViewCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCliente.RowHeadersVisible = false;
            this.dataGridViewCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(1392, 517);
            this.dataGridViewCliente.TabIndex = 346;
            this.dataGridViewCliente.TabStop = false;
            this.dataGridViewCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCliente_KeyDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(315, 280);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(172, 42);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 352;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcularFatura
            // 
            this.btnCalcularFatura.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularFatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcularFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularFatura.Image")));
            this.btnCalcularFatura.Location = new System.Drawing.Point(124, 280);
            this.btnCalcularFatura.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularFatura.Name = "btnCalcularFatura";
            this.btnCalcularFatura.Size = new System.Drawing.Size(171, 43);
            this.btnCalcularFatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalcularFatura.TabIndex = 352;
            this.btnCalcularFatura.TabStop = false;
            this.btnCalcularFatura.Click += new System.EventHandler(this.btnCalcularFatura_Click);
            // 
            // panelDataVencimento
            // 
            this.panelDataVencimento.Controls.Add(this.groupBox1);
            this.panelDataVencimento.Controls.Add(panel1);
            this.panelDataVencimento.Controls.Add(label5);
            this.panelDataVencimento.Controls.Add(this.valorAluguelTextBox);
            this.panelDataVencimento.Controls.Add(label4);
            this.panelDataVencimento.Controls.Add(this.ParcelaComboBox);
            this.panelDataVencimento.Controls.Add(this.dataVencimentoMaskedTextBox);
            this.panelDataVencimento.Controls.Add(this.btnCalcularFatura);
            this.panelDataVencimento.Controls.Add(this.btnVoltar);
            this.panelDataVencimento.Controls.Add(label3);
            this.panelDataVencimento.Controls.Add(labelDataFinal);
            this.panelDataVencimento.Location = new System.Drawing.Point(420, 180);
            this.panelDataVencimento.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataVencimento.Name = "panelDataVencimento";
            this.panelDataVencimento.Size = new System.Drawing.Size(625, 467);
            this.panelDataVencimento.TabIndex = 351;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Location = new System.Drawing.Point(7, 333);
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
            this.valorAluguelTextBox.Location = new System.Drawing.Point(68, 222);
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
            this.ParcelaComboBox.Location = new System.Drawing.Point(324, 145);
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
            this.dataVencimentoMaskedTextBox.Location = new System.Drawing.Point(68, 144);
            this.dataVencimentoMaskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataVencimentoMaskedTextBox.Mask = "00/00/0000";
            this.dataVencimentoMaskedTextBox.Name = "dataVencimentoMaskedTextBox";
            this.dataVencimentoMaskedTextBox.Size = new System.Drawing.Size(212, 34);
            this.dataVencimentoMaskedTextBox.TabIndex = 0;
            this.dataVencimentoMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // frmNovoHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 800);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.btnGerarFatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.panelDataVencimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNovoHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNovoHospede";
            this.Load += new System.EventHandler(this.frmNovoHospede_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNovoHospede_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecharGerarFaturaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGerarFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalcularFatura)).EndInit();
            this.panelDataVencimento.ResumeLayout(false);
            this.panelDataVencimento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnGerarFatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeContatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rginscricaoEstadualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox btnCalcularFatura;
        private System.Windows.Forms.Panel panelDataVencimento;
        private System.Windows.Forms.MaskedTextBox dataVencimentoMaskedTextBox;
        private System.Windows.Forms.ComboBox ParcelaComboBox;
        private System.Windows.Forms.TextBox valorAluguelTextBox;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox fecharGerarFaturaPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}