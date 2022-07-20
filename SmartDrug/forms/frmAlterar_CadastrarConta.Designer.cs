namespace SmartDrug.forms
{
    partial class frmAlterar_CadastrarConta
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterar_CadastrarConta));
            System.Windows.Forms.Label labTitulo;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.joinContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situacaoContaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ultimaCompraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valorHaverTextBox = new System.Windows.Forms.TextBox();
            this.descricaoContaTextBox = new System.Windows.Forms.TextBox();
            this.situacaoContaTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.SituacaoContaTableAdapter();
            this.ultimoHaverMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.joinContasReceberTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter();
            this.radAbrir = new System.Windows.Forms.RadioButton();
            this.radAlterar = new System.Windows.Forms.RadioButton();
            this.clientesComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoContaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(319, 195);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 20);
            label8.TabIndex = 379;
            label8.Text = "Situação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(319, 252);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(118, 20);
            label5.TabIndex = 375;
            label5.Text = "Ultima Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(657, 252);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 20);
            label4.TabIndex = 373;
            label4.Text = "Valor do Haver:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(319, 137);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 20);
            label3.TabIndex = 370;
            label3.Text = "Nome / Titula Conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(488, 252);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 382;
            label2.Text = "Ultimo Haver:";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            panelTop.Controls.Add(this.btnFechar);
            panelTop.Controls.Add(labTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.ForeColor = System.Drawing.Color.Gainsboro;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1130, 41);
            panelTop.TabIndex = 617;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 7);
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
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            labTitulo.Location = new System.Drawing.Point(402, 5);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(324, 31);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Alterar Situação da Conta";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(551, 336);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 358;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(430, 336);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 357;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.joinContasReceberBindingSource, "idSituacaoConta", true));
            this.situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "SituacaoConta", true));
            this.situacaoComboBox.DataSource = this.situacaoContaBindingSource;
            this.situacaoComboBox.DisplayMember = "SituacaoConta";
            this.situacaoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Location = new System.Drawing.Point(320, 218);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(504, 26);
            this.situacaoComboBox.TabIndex = 2;
            this.situacaoComboBox.ValueMember = "idSituacaoConta";
            this.situacaoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.situacaoComboBox_KeyDown);
            // 
            // joinContasReceberBindingSource
            // 
            this.joinContasReceberBindingSource.DataMember = "JoinContasReceber";
            this.joinContasReceberBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // situacaoContaBindingSource
            // 
            this.situacaoContaBindingSource.DataMember = "SituacaoConta";
            this.situacaoContaBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // ultimaCompraMaskedTextBox
            // 
            this.ultimaCompraMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ultimaCompraMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ultimaCompraMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "ultimaCompra", true));
            this.ultimaCompraMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimaCompraMaskedTextBox.Location = new System.Drawing.Point(321, 275);
            this.ultimaCompraMaskedTextBox.Mask = "00/00/0000";
            this.ultimaCompraMaskedTextBox.Name = "ultimaCompraMaskedTextBox";
            this.ultimaCompraMaskedTextBox.Size = new System.Drawing.Size(165, 26);
            this.ultimaCompraMaskedTextBox.TabIndex = 3;
            this.ultimaCompraMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.ultimaCompraMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultimaCompraMaskedTextBox_KeyDown);
            // 
            // valorHaverTextBox
            // 
            this.valorHaverTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.valorHaverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorHaverTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.valorHaverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "valorHaver", true));
            this.valorHaverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorHaverTextBox.Location = new System.Drawing.Point(661, 275);
            this.valorHaverTextBox.Name = "valorHaverTextBox";
            this.valorHaverTextBox.Size = new System.Drawing.Size(161, 26);
            this.valorHaverTextBox.TabIndex = 5;
            this.valorHaverTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorHaverTextBox_KeyDown);
            // 
            // descricaoContaTextBox
            // 
            this.descricaoContaTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoContaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoContaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "nome", true));
            this.descricaoContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoContaTextBox.Location = new System.Drawing.Point(321, 162);
            this.descricaoContaTextBox.Name = "descricaoContaTextBox";
            this.descricaoContaTextBox.ReadOnly = true;
            this.descricaoContaTextBox.Size = new System.Drawing.Size(501, 26);
            this.descricaoContaTextBox.TabIndex = 1;
            this.descricaoContaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoContaTextBox_KeyDown);
            // 
            // situacaoContaTableAdapter
            // 
            this.situacaoContaTableAdapter.ClearBeforeFill = true;
            // 
            // ultimoHaverMaskedTextBox
            // 
            this.ultimoHaverMaskedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ultimoHaverMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ultimoHaverMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.joinContasReceberBindingSource, "ultimoHaver", true));
            this.ultimoHaverMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoHaverMaskedTextBox.Location = new System.Drawing.Point(492, 275);
            this.ultimoHaverMaskedTextBox.Mask = "00/00/0000";
            this.ultimoHaverMaskedTextBox.Name = "ultimoHaverMaskedTextBox";
            this.ultimoHaverMaskedTextBox.Size = new System.Drawing.Size(163, 26);
            this.ultimoHaverMaskedTextBox.TabIndex = 4;
            this.ultimoHaverMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.ultimoHaverMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultimoHaverMaskedTextBox_KeyDown);
            // 
            // joinContasReceberTableAdapter
            // 
            this.joinContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // radAbrir
            // 
            this.radAbrir.AutoSize = true;
            this.radAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAbrir.Location = new System.Drawing.Point(543, 91);
            this.radAbrir.Name = "radAbrir";
            this.radAbrir.Size = new System.Drawing.Size(173, 24);
            this.radAbrir.TabIndex = 386;
            this.radAbrir.Text = "Abrir um Nova Conta";
            this.radAbrir.UseVisualStyleBackColor = true;
            this.radAbrir.CheckedChanged += new System.EventHandler(this.radAbrir_CheckedChanged);
            // 
            // radAlterar
            // 
            this.radAlterar.AutoSize = true;
            this.radAlterar.Checked = true;
            this.radAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAlterar.Location = new System.Drawing.Point(324, 91);
            this.radAlterar.Name = "radAlterar";
            this.radAlterar.Size = new System.Drawing.Size(194, 24);
            this.radAlterar.TabIndex = 385;
            this.radAlterar.TabStop = true;
            this.radAlterar.Text = "Alterar Dados da Conta";
            this.radAlterar.UseVisualStyleBackColor = true;
            this.radAlterar.CheckedChanged += new System.EventHandler(this.radAlterar_CheckedChanged);
            // 
            // clientesComboBox
            // 
            this.clientesComboBox.DataSource = this.clientesBindingSource;
            this.clientesComboBox.DisplayMember = "nome";
            this.clientesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.clientesComboBox.FormattingEnabled = true;
            this.clientesComboBox.Location = new System.Drawing.Point(320, 162);
            this.clientesComboBox.Name = "clientesComboBox";
            this.clientesComboBox.Size = new System.Drawing.Size(502, 26);
            this.clientesComboBox.TabIndex = 0;
            this.clientesComboBox.ValueMember = "idCliente";
            this.clientesComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clientesComboBox_KeyDown);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlterar_CadastrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 650);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.radAbrir);
            this.Controls.Add(this.radAlterar);
            this.Controls.Add(this.ultimoHaverMaskedTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.situacaoComboBox);
            this.Controls.Add(label8);
            this.Controls.Add(this.ultimaCompraMaskedTextBox);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.valorHaverTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.descricaoContaTextBox);
            this.Controls.Add(this.clientesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmAlterar_CadastrarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterar_CadastrarConta";
            this.Load += new System.EventHandler(this.frmAlterar_CadastrarConta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAlterar_CadastrarConta_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoContaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnSalvar;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.MaskedTextBox ultimaCompraMaskedTextBox;
        private System.Windows.Forms.TextBox valorHaverTextBox;
        private System.Windows.Forms.TextBox descricaoContaTextBox;
        private System.Windows.Forms.BindingSource situacaoContaBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.SituacaoContaTableAdapter situacaoContaTableAdapter;
        private System.Windows.Forms.MaskedTextBox ultimoHaverMaskedTextBox;
        private System.Windows.Forms.BindingSource joinContasReceberBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter joinContasReceberTableAdapter;
        private System.Windows.Forms.RadioButton radAbrir;
        private System.Windows.Forms.RadioButton radAlterar;
        private System.Windows.Forms.ComboBox clientesComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}