namespace SmartDrug.forms
{
    partial class frmFluxoCaixa
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fluxoCaixaDataGridView = new System.Windows.Forms.DataGridView();
            this.ndocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFluxoCaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluxoCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.textTotalCredito = new System.Windows.Forms.TextBox();
            this.totaisCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textTotalDebito = new System.Windows.Forms.TextBox();
            this.textTotalCaixa = new System.Windows.Forms.TextBox();
            this.fluxoCaixaTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.FluxoCaixaTableAdapter();
            this.totaisCaixaTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.TotaisCaixaTableAdapter();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.dataFinalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataInicialMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            labelDataFinal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxoCaixaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxoCaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaisCaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.BackColor = System.Drawing.Color.Transparent;
            labelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDataFinal.Location = new System.Drawing.Point(201, 86);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new System.Drawing.Size(86, 20);
            labelDataFinal.TabIndex = 329;
            labelDataFinal.Text = "Data Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(42, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 330;
            label1.Text = "Data Inicial:";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1130, 57);
            panelTop.TabIndex = 338;
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
            labTitulo.Location = new System.Drawing.Point(450, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(229, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Fluxo de Caixa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(869, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Total em Caixa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Totais Debitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Totais Créditos:";
            // 
            // fluxoCaixaDataGridView
            // 
            this.fluxoCaixaDataGridView.AllowUserToAddRows = false;
            this.fluxoCaixaDataGridView.AllowUserToDeleteRows = false;
            this.fluxoCaixaDataGridView.AllowUserToResizeColumns = false;
            this.fluxoCaixaDataGridView.AllowUserToResizeRows = false;
            this.fluxoCaixaDataGridView.AutoGenerateColumns = false;
            this.fluxoCaixaDataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.fluxoCaixaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fluxoCaixaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.fluxoCaixaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fluxoCaixaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.fluxoCaixaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fluxoCaixaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndocumentoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.creditoDataGridViewTextBoxColumn,
            this.debitoDataGridViewTextBoxColumn,
            this.idFluxoCaixaDataGridViewTextBoxColumn});
            this.fluxoCaixaDataGridView.DataSource = this.fluxoCaixaBindingSource;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fluxoCaixaDataGridView.DefaultCellStyle = dataGridViewCellStyle29;
            this.fluxoCaixaDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.fluxoCaixaDataGridView.Location = new System.Drawing.Point(47, 157);
            this.fluxoCaixaDataGridView.MultiSelect = false;
            this.fluxoCaixaDataGridView.Name = "fluxoCaixaDataGridView";
            this.fluxoCaixaDataGridView.ReadOnly = true;
            this.fluxoCaixaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fluxoCaixaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.fluxoCaixaDataGridView.RowHeadersVisible = false;
            this.fluxoCaixaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.fluxoCaixaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fluxoCaixaDataGridView.Size = new System.Drawing.Size(1035, 382);
            this.fluxoCaixaDataGridView.TabIndex = 81;
            this.fluxoCaixaDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            // 
            // ndocumentoDataGridViewTextBoxColumn
            // 
            this.ndocumentoDataGridViewTextBoxColumn.DataPropertyName = "Ndocumento";
            this.ndocumentoDataGridViewTextBoxColumn.HeaderText = "Nº Doc";
            this.ndocumentoDataGridViewTextBoxColumn.Name = "ndocumentoDataGridViewTextBoxColumn";
            this.ndocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndocumentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 446;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            dataGridViewCellStyle26.Format = "g";
            dataGridViewCellStyle26.NullValue = null;
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 132;
            // 
            // creditoDataGridViewTextBoxColumn
            // 
            this.creditoDataGridViewTextBoxColumn.DataPropertyName = "credito";
            dataGridViewCellStyle27.Format = "C2";
            this.creditoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.creditoDataGridViewTextBoxColumn.HeaderText = "Crédito";
            this.creditoDataGridViewTextBoxColumn.Name = "creditoDataGridViewTextBoxColumn";
            this.creditoDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditoDataGridViewTextBoxColumn.Width = 145;
            // 
            // debitoDataGridViewTextBoxColumn
            // 
            this.debitoDataGridViewTextBoxColumn.DataPropertyName = "debito";
            dataGridViewCellStyle28.Format = "C2";
            this.debitoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.debitoDataGridViewTextBoxColumn.HeaderText = "Débito";
            this.debitoDataGridViewTextBoxColumn.Name = "debitoDataGridViewTextBoxColumn";
            this.debitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitoDataGridViewTextBoxColumn.Width = 145;
            // 
            // idFluxoCaixaDataGridViewTextBoxColumn
            // 
            this.idFluxoCaixaDataGridViewTextBoxColumn.DataPropertyName = "idFluxoCaixa";
            this.idFluxoCaixaDataGridViewTextBoxColumn.HeaderText = "idFluxoCaixa";
            this.idFluxoCaixaDataGridViewTextBoxColumn.Name = "idFluxoCaixaDataGridViewTextBoxColumn";
            this.idFluxoCaixaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFluxoCaixaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fluxoCaixaBindingSource
            // 
            this.fluxoCaixaBindingSource.DataMember = "FluxoCaixa";
            this.fluxoCaixaBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textTotalCredito
            // 
            this.textTotalCredito.BackColor = System.Drawing.SystemColors.Window;
            this.textTotalCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTotalCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTotalCredito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totaisCaixaBindingSource, "TotalCredito", true));
            this.textTotalCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalCredito.Location = new System.Drawing.Point(47, 577);
            this.textTotalCredito.Name = "textTotalCredito";
            this.textTotalCredito.Size = new System.Drawing.Size(176, 32);
            this.textTotalCredito.TabIndex = 167;
            // 
            // totaisCaixaBindingSource
            // 
            this.totaisCaixaBindingSource.DataMember = "TotaisCaixa";
            this.totaisCaixaBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // textTotalDebito
            // 
            this.textTotalDebito.BackColor = System.Drawing.SystemColors.Window;
            this.textTotalDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTotalDebito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTotalDebito.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.totaisCaixaBindingSource, "TotalDebito", true));
            this.textTotalDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalDebito.ForeColor = System.Drawing.Color.Red;
            this.textTotalDebito.Location = new System.Drawing.Point(286, 577);
            this.textTotalDebito.Name = "textTotalDebito";
            this.textTotalDebito.Size = new System.Drawing.Size(176, 32);
            this.textTotalDebito.TabIndex = 169;
            // 
            // textTotalCaixa
            // 
            this.textTotalCaixa.BackColor = System.Drawing.SystemColors.Window;
            this.textTotalCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTotalCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textTotalCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalCaixa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textTotalCaixa.Location = new System.Drawing.Point(875, 577);
            this.textTotalCaixa.Name = "textTotalCaixa";
            this.textTotalCaixa.Size = new System.Drawing.Size(207, 32);
            this.textTotalCaixa.TabIndex = 171;
            this.textTotalCaixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            // 
            // fluxoCaixaTableAdapter
            // 
            this.fluxoCaixaTableAdapter.ClearBeforeFill = true;
            // 
            // totaisCaixaTableAdapter
            // 
            this.totaisCaixaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(363, 109);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 26);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 328;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataFinalMaskedTextBox
            // 
            this.dataFinalMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataFinalMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataFinalMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFinalMaskedTextBox.Location = new System.Drawing.Point(205, 109);
            this.dataFinalMaskedTextBox.Mask = "00/00/0000";
            this.dataFinalMaskedTextBox.Name = "dataFinalMaskedTextBox";
            this.dataFinalMaskedTextBox.Size = new System.Drawing.Size(152, 26);
            this.dataFinalMaskedTextBox.TabIndex = 325;
            this.dataFinalMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // dataInicialMaskedTextBox
            // 
            this.dataInicialMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.dataInicialMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataInicialMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicialMaskedTextBox.Location = new System.Drawing.Point(46, 109);
            this.dataInicialMaskedTextBox.Mask = "00/00/0000";
            this.dataInicialMaskedTextBox.Name = "dataInicialMaskedTextBox";
            this.dataInicialMaskedTextBox.Size = new System.Drawing.Size(153, 26);
            this.dataInicialMaskedTextBox.TabIndex = 1;
            this.dataInicialMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.dataInicialMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Location = new System.Drawing.Point(376, 643);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 32);
            this.btnAtualizar.TabIndex = 339;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            this.btnAtualizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonImprimir.Location = new System.Drawing.Point(498, 643);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(123, 32);
            this.buttonImprimir.TabIndex = 340;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            this.buttonImprimir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSair.Location = new System.Drawing.Point(627, 643);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(115, 32);
            this.buttonSair.TabIndex = 341;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1130, 704);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(panelTop);
            this.Controls.Add(label1);
            this.Controls.Add(labelDataFinal);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataFinalMaskedTextBox);
            this.Controls.Add(this.dataInicialMaskedTextBox);
            this.Controls.Add(this.textTotalCaixa);
            this.Controls.Add(this.textTotalDebito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fluxoCaixaDataGridView);
            this.Controls.Add(this.textTotalCredito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFluxoCaixa";
            this.Load += new System.EventHandler(this.frmFluxoCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFluxoCaixa_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxoCaixaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxoCaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totaisCaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTotalCredito;
        private System.Windows.Forms.TextBox textTotalDebito;
        private System.Windows.Forms.TextBox textTotalCaixa;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource fluxoCaixaBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.FluxoCaixaTableAdapter fluxoCaixaTableAdapter;
        private System.Windows.Forms.BindingSource totaisCaixaBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.TotaisCaixaTableAdapter totaisCaixaTableAdapter;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.MaskedTextBox dataFinalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox dataInicialMaskedTextBox;
        public System.Windows.Forms.DataGridView fluxoCaixaDataGridView;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFluxoCaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonSair;
    }
}