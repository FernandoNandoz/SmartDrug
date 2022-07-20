namespace SmartDrug.forms
{
    partial class frmEntradaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaEstoque));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnCadastrarNota = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridViewEntradaEstoque = new System.Windows.Forms.DataGridView();
            this.ndocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRazaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNotaFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacaoEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.radNotaFiscal = new System.Windows.Forms.RadioButton();
            this.radFornecedor = new System.Windows.Forms.RadioButton();
            this.relacaoEstoqueTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.RelacaoEstoqueTableAdapter();
            this.panelCentral = new System.Windows.Forms.Panel();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).BeginInit();
            this.panelCentral.SuspendLayout();
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
            panelTop.Size = new System.Drawing.Size(1130, 57);
            panelTop.TabIndex = 159;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(10, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 30);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 79;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labTitulo
            // 
            labTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            labTitulo.AutoSize = true;
            labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labTitulo.Location = new System.Drawing.Point(419, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(300, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Entrada de Estoque";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(389, 646);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 32);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 99;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrarNota
            // 
            this.btnCadastrarNota.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCadastrarNota.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarNota.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarNota.Image")));
            this.btnCadastrarNota.Location = new System.Drawing.Point(505, 646);
            this.btnCadastrarNota.Name = "btnCadastrarNota";
            this.btnCadastrarNota.Size = new System.Drawing.Size(143, 32);
            this.btnCadastrarNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCadastrarNota.TabIndex = 98;
            this.btnCadastrarNota.TabStop = false;
            this.btnCadastrarNota.Click += new System.EventHandler(this.btnCadastrarNota_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(573, 115);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 25);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 97;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(655, 646);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 32);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 96;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textPesquisa.Location = new System.Drawing.Point(30, 115);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(532, 26);
            this.textPesquisa.TabIndex = 151;
            this.textPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisa_KeyDown);
            // 
            // dataGridViewEntradaEstoque
            // 
            this.dataGridViewEntradaEstoque.AllowUserToAddRows = false;
            this.dataGridViewEntradaEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEntradaEstoque.AllowUserToResizeColumns = false;
            this.dataGridViewEntradaEstoque.AllowUserToResizeRows = false;
            this.dataGridViewEntradaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEntradaEstoque.AutoGenerateColumns = false;
            this.dataGridViewEntradaEstoque.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewEntradaEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEntradaEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEntradaEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEntradaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEntradaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntradaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndocumentoDataGridViewTextBoxColumn,
            this.nomeRazaoDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn,
            this.idNotaFiscalDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn});
            this.dataGridViewEntradaEstoque.DataSource = this.relacaoEstoqueBindingSource;
            this.dataGridViewEntradaEstoque.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewEntradaEstoque.Location = new System.Drawing.Point(30, 153);
            this.dataGridViewEntradaEstoque.MultiSelect = false;
            this.dataGridViewEntradaEstoque.Name = "dataGridViewEntradaEstoque";
            this.dataGridViewEntradaEstoque.ReadOnly = true;
            this.dataGridViewEntradaEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEntradaEstoque.RowHeadersVisible = false;
            this.dataGridViewEntradaEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEntradaEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewEntradaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEntradaEstoque.Size = new System.Drawing.Size(1070, 466);
            this.dataGridViewEntradaEstoque.TabIndex = 156;
            this.dataGridViewEntradaEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEntradaEstoque_KeyDown);
            // 
            // ndocumentoDataGridViewTextBoxColumn
            // 
            this.ndocumentoDataGridViewTextBoxColumn.DataPropertyName = "Ndocumento";
            this.ndocumentoDataGridViewTextBoxColumn.HeaderText = "Nota Fiscal";
            this.ndocumentoDataGridViewTextBoxColumn.Name = "ndocumentoDataGridViewTextBoxColumn";
            this.ndocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndocumentoDataGridViewTextBoxColumn.Width = 220;
            // 
            // nomeRazaoDataGridViewTextBoxColumn
            // 
            this.nomeRazaoDataGridViewTextBoxColumn.DataPropertyName = "nomeRazao";
            this.nomeRazaoDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.nomeRazaoDataGridViewTextBoxColumn.Name = "nomeRazaoDataGridViewTextBoxColumn";
            this.nomeRazaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeRazaoDataGridViewTextBoxColumn.Width = 575;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle2.Format = "C2";
            this.valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 275;
            // 
            // idNotaFiscalDataGridViewTextBoxColumn
            // 
            this.idNotaFiscalDataGridViewTextBoxColumn.DataPropertyName = "idNotaFiscal";
            this.idNotaFiscalDataGridViewTextBoxColumn.HeaderText = "idNotaFiscal";
            this.idNotaFiscalDataGridViewTextBoxColumn.Name = "idNotaFiscalDataGridViewTextBoxColumn";
            this.idNotaFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNotaFiscalDataGridViewTextBoxColumn.Visible = false;
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFornecedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // relacaoEstoqueBindingSource
            // 
            this.relacaoEstoqueBindingSource.DataMember = "RelacaoEstoque";
            this.relacaoEstoqueBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radNotaFiscal
            // 
            this.radNotaFiscal.AutoSize = true;
            this.radNotaFiscal.Checked = true;
            this.radNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radNotaFiscal.Location = new System.Drawing.Point(30, 89);
            this.radNotaFiscal.Name = "radNotaFiscal";
            this.radNotaFiscal.Size = new System.Drawing.Size(106, 24);
            this.radNotaFiscal.TabIndex = 157;
            this.radNotaFiscal.TabStop = true;
            this.radNotaFiscal.Text = "Nota Fiscal";
            this.radNotaFiscal.UseVisualStyleBackColor = true;
            this.radNotaFiscal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntradaEstoque_KeyDown);
            // 
            // radFornecedor
            // 
            this.radFornecedor.AutoSize = true;
            this.radFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radFornecedor.Location = new System.Drawing.Point(137, 89);
            this.radFornecedor.Name = "radFornecedor";
            this.radFornecedor.Size = new System.Drawing.Size(109, 24);
            this.radFornecedor.TabIndex = 158;
            this.radFornecedor.Text = "Fornecedor";
            this.radFornecedor.UseVisualStyleBackColor = true;
            this.radFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntradaEstoque_KeyDown);
            // 
            // relacaoEstoqueTableAdapter
            // 
            this.relacaoEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(panelTop);
            this.panelCentral.Controls.Add(this.radFornecedor);
            this.panelCentral.Controls.Add(this.radNotaFiscal);
            this.panelCentral.Controls.Add(this.textPesquisa);
            this.panelCentral.Controls.Add(this.btnAtualizar);
            this.panelCentral.Controls.Add(this.dataGridViewEntradaEstoque);
            this.panelCentral.Controls.Add(this.btnCadastrarNota);
            this.panelCentral.Controls.Add(this.btnSair);
            this.panelCentral.Controls.Add(this.btnPesquisar);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 0);
            this.panelCentral.Margin = new System.Windows.Forms.Padding(2);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1130, 704);
            this.panelCentral.TabIndex = 160;
            // 
            // frmEntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 704);
            this.Controls.Add(this.panelCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntradaEstoque";
            this.Load += new System.EventHandler(this.frmEntradaEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntradaEstoque_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrarNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntradaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacaoEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnCadastrarNota;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewEntradaEstoque;
        private System.Windows.Forms.RadioButton radNotaFiscal;
        private System.Windows.Forms.RadioButton radFornecedor;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource relacaoEstoqueBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.RelacaoEstoqueTableAdapter relacaoEstoqueTableAdapter;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRazaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNotaFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
    }
}