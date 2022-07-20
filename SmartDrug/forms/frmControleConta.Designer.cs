namespace SmartDrug.forms
{
    partial class frmControleConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleConta));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnAlterarCadastro = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.dataGridViewContas = new System.Windows.Forms.DataGridView();
            this.joinContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogariaParanaDataSet = new SmartDrug.DataSource.DrogariaParanaDataSet();
            this.joinContasReceberTableAdapter = new SmartDrug.DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRelacaoHaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSituacaoContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).BeginInit();
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
            panelTop.TabIndex = 616;
            panelTop.TabStop = true;
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
            labTitulo.Location = new System.Drawing.Point(412, 13);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(293, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Controle de Contas";
            // 
            // btnAlterarCadastro
            // 
            this.btnAlterarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarCadastro.Image")));
            this.btnAlterarCadastro.Location = new System.Drawing.Point(498, 575);
            this.btnAlterarCadastro.Name = "btnAlterarCadastro";
            this.btnAlterarCadastro.Size = new System.Drawing.Size(125, 38);
            this.btnAlterarCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAlterarCadastro.TabIndex = 361;
            this.btnAlterarCadastro.TabStop = false;
            this.btnAlterarCadastro.Click += new System.EventHandler(this.btnAlterarCadastro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 360;
            this.label2.Text = "Nome Cliente:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.textPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(37, 60);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(513, 26);
            this.textPesquisa.TabIndex = 1;
            this.textPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPesquisa_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(629, 575);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 38);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 359;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(367, 575);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 38);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtualizar.TabIndex = 358;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(556, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 25);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 355;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridViewContas
            // 
            this.dataGridViewContas.AllowUserToAddRows = false;
            this.dataGridViewContas.AllowUserToDeleteRows = false;
            this.dataGridViewContas.AllowUserToResizeColumns = false;
            this.dataGridViewContas.AllowUserToResizeRows = false;
            this.dataGridViewContas.AutoGenerateColumns = false;
            this.dataGridViewContas.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewContas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.situacaoContaDataGridViewTextBoxColumn,
            this.ultimoHaverDataGridViewTextBoxColumn,
            this.valorHaverDataGridViewTextBoxColumn,
            this.ultimaCompraDataGridViewTextBoxColumn,
            this.idRelacaoHaverDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idSituacaoContaDataGridViewTextBoxColumn});
            this.dataGridViewContas.DataSource = this.joinContasReceberBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContas.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewContas.Location = new System.Drawing.Point(37, 105);
            this.dataGridViewContas.MultiSelect = false;
            this.dataGridViewContas.Name = "dataGridViewContas";
            this.dataGridViewContas.ReadOnly = true;
            this.dataGridViewContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewContas.RowHeadersVisible = false;
            this.dataGridViewContas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewContas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContas.Size = new System.Drawing.Size(1055, 435);
            this.dataGridViewContas.TabIndex = 2;
            this.dataGridViewContas.TabStop = false;
            this.dataGridViewContas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewContas_KeyDown);
            // 
            // joinContasReceberBindingSource
            // 
            this.joinContasReceberBindingSource.DataMember = "JoinContasReceber";
            this.joinContasReceberBindingSource.DataSource = this.drogariaParanaDataSet;
            // 
            // drogariaParanaDataSet
            // 
            this.drogariaParanaDataSet.DataSetName = "DrogariaParanaDataSet";
            this.drogariaParanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinContasReceberTableAdapter
            // 
            this.joinContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.dataGridViewContas);
            this.panelCentral.Controls.Add(this.btnPesquisar);
            this.panelCentral.Controls.Add(this.btnAlterarCadastro);
            this.panelCentral.Controls.Add(this.btnAtualizar);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.btnSair);
            this.panelCentral.Controls.Add(this.textPesquisa);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 57);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1130, 647);
            this.panelCentral.TabIndex = 617;
            this.panelCentral.TabStop = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 655;
            // 
            // situacaoContaDataGridViewTextBoxColumn
            // 
            this.situacaoContaDataGridViewTextBoxColumn.DataPropertyName = "SituacaoConta";
            this.situacaoContaDataGridViewTextBoxColumn.HeaderText = "Situação da Conta";
            this.situacaoContaDataGridViewTextBoxColumn.Name = "situacaoContaDataGridViewTextBoxColumn";
            this.situacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoContaDataGridViewTextBoxColumn.Width = 400;
            // 
            // ultimoHaverDataGridViewTextBoxColumn
            // 
            this.ultimoHaverDataGridViewTextBoxColumn.DataPropertyName = "ultimoHaver";
            this.ultimoHaverDataGridViewTextBoxColumn.HeaderText = "ultimoHaver";
            this.ultimoHaverDataGridViewTextBoxColumn.Name = "ultimoHaverDataGridViewTextBoxColumn";
            this.ultimoHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoHaverDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorHaverDataGridViewTextBoxColumn
            // 
            this.valorHaverDataGridViewTextBoxColumn.DataPropertyName = "valorHaver";
            this.valorHaverDataGridViewTextBoxColumn.HeaderText = "valorHaver";
            this.valorHaverDataGridViewTextBoxColumn.Name = "valorHaverDataGridViewTextBoxColumn";
            this.valorHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorHaverDataGridViewTextBoxColumn.Visible = false;
            // 
            // ultimaCompraDataGridViewTextBoxColumn
            // 
            this.ultimaCompraDataGridViewTextBoxColumn.DataPropertyName = "ultimaCompra";
            this.ultimaCompraDataGridViewTextBoxColumn.HeaderText = "ultimaCompra";
            this.ultimaCompraDataGridViewTextBoxColumn.Name = "ultimaCompraDataGridViewTextBoxColumn";
            this.ultimaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimaCompraDataGridViewTextBoxColumn.Visible = false;
            // 
            // idRelacaoHaverDataGridViewTextBoxColumn
            // 
            this.idRelacaoHaverDataGridViewTextBoxColumn.DataPropertyName = "idRelacaoHaver";
            this.idRelacaoHaverDataGridViewTextBoxColumn.HeaderText = "idRelacaoHaver";
            this.idRelacaoHaverDataGridViewTextBoxColumn.Name = "idRelacaoHaverDataGridViewTextBoxColumn";
            this.idRelacaoHaverDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRelacaoHaverDataGridViewTextBoxColumn.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSituacaoContaDataGridViewTextBoxColumn
            // 
            this.idSituacaoContaDataGridViewTextBoxColumn.DataPropertyName = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.HeaderText = "idSituacaoConta";
            this.idSituacaoContaDataGridViewTextBoxColumn.Name = "idSituacaoContaDataGridViewTextBoxColumn";
            this.idSituacaoContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSituacaoContaDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmControleConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 704);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmControleConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControleConta";
            this.Load += new System.EventHandler(this.frmControleConta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmControleConta_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterarCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogariaParanaDataSet)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnAlterarCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnAtualizar;
        private System.Windows.Forms.PictureBox btnPesquisar;
        public System.Windows.Forms.DataGridView dataGridViewContas;
        private DataSource.DrogariaParanaDataSet drogariaParanaDataSet;
        private System.Windows.Forms.BindingSource joinContasReceberBindingSource;
        private DataSource.DrogariaParanaDataSetTableAdapters.JoinContasReceberTableAdapter joinContasReceberTableAdapter;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRelacaoHaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSituacaoContaDataGridViewTextBoxColumn;
    }
}