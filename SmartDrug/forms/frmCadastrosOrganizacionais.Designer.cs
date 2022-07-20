namespace SmartDrug.forms
{
    partial class frmCadastrosOrganizacionais
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
            System.Windows.Forms.Label nome_produtoLabel;
            System.Windows.Forms.Panel panelTop;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrosOrganizacionais));
            System.Windows.Forms.Label labTitulo;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.radPais = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVendedor = new System.Windows.Forms.RadioButton();
            this.radBanco = new System.Windows.Forms.RadioButton();
            this.radCidade = new System.Windows.Forms.RadioButton();
            this.radEstado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            nome_produtoLabel = new System.Windows.Forms.Label();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.BackColor = System.Drawing.Color.Transparent;
            nome_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_produtoLabel.Location = new System.Drawing.Point(22, 23);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(80, 18);
            nome_produtoLabel.TabIndex = 148;
            nome_produtoLabel.Text = "Descrição:";
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
            labTitulo.Location = new System.Drawing.Point(369, 12);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(404, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Cadastros Organizacionais";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(568, 422);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 33);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSair.TabIndex = 150;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(447, 422);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 33);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 149;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnSalvar_PreviewKeyDown);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descricaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descricaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(25, 44);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(461, 26);
            this.descricaoTextBox.TabIndex = 147;
            this.descricaoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descricaoTextBox_KeyDown);
            // 
            // radPais
            // 
            this.radPais.AutoSize = true;
            this.radPais.Checked = true;
            this.radPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPais.Location = new System.Drawing.Point(22, 31);
            this.radPais.Name = "radPais";
            this.radPais.Size = new System.Drawing.Size(55, 22);
            this.radPais.TabIndex = 316;
            this.radPais.TabStop = true;
            this.radPais.Text = "Pais";
            this.radPais.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVendedor);
            this.groupBox1.Controls.Add(this.radBanco);
            this.groupBox1.Controls.Add(this.radCidade);
            this.groupBox1.Controls.Add(this.radEstado);
            this.groupBox1.Controls.Add(this.radPais);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(310, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 215);
            this.groupBox1.TabIndex = 317;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Cadastros:";
            // 
            // radVendedor
            // 
            this.radVendedor.AutoSize = true;
            this.radVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVendedor.Location = new System.Drawing.Point(22, 143);
            this.radVendedor.Name = "radVendedor";
            this.radVendedor.Size = new System.Drawing.Size(89, 22);
            this.radVendedor.TabIndex = 320;
            this.radVendedor.Text = "Vendedor";
            this.radVendedor.UseVisualStyleBackColor = true;
            // 
            // radBanco
            // 
            this.radBanco.AutoSize = true;
            this.radBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBanco.Location = new System.Drawing.Point(22, 115);
            this.radBanco.Name = "radBanco";
            this.radBanco.Size = new System.Drawing.Size(69, 22);
            this.radBanco.TabIndex = 319;
            this.radBanco.Text = "Banco";
            this.radBanco.UseVisualStyleBackColor = true;
            // 
            // radCidade
            // 
            this.radCidade.AutoSize = true;
            this.radCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCidade.Location = new System.Drawing.Point(22, 87);
            this.radCidade.Name = "radCidade";
            this.radCidade.Size = new System.Drawing.Size(72, 22);
            this.radCidade.TabIndex = 318;
            this.radCidade.Text = "Cidade";
            this.radCidade.UseVisualStyleBackColor = true;
            // 
            // radEstado
            // 
            this.radEstado.AutoSize = true;
            this.radEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEstado.Location = new System.Drawing.Point(22, 59);
            this.radEstado.Name = "radEstado";
            this.radEstado.Size = new System.Drawing.Size(73, 22);
            this.radEstado.TabIndex = 317;
            this.radEstado.Text = "Estado";
            this.radEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(nome_produtoLabel);
            this.groupBox2.Location = new System.Drawing.Point(310, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 91);
            this.groupBox2.TabIndex = 318;
            this.groupBox2.TabStop = false;
            // 
            // frmCadastrosOrganizacionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 704);
            this.Controls.Add(panelTop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCadastrosOrganizacionais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrosOrganizacionais";
            this.Load += new System.EventHandler(this.frmCadastrosOrganizacionais_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastrosOrganizacionais_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.RadioButton radPais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBanco;
        private System.Windows.Forms.RadioButton radCidade;
        private System.Windows.Forms.RadioButton radEstado;
        private System.Windows.Forms.RadioButton radVendedor;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}