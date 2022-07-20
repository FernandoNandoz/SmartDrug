namespace SmartDrug.forms
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            System.Windows.Forms.Label labTitulo;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.PictureBox pictureBox3;
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.timerBackup = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelProgressoBackup = new System.Windows.Forms.Label();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.panelBackupConluido = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.PictureBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.buttonEfetuarBackup = new System.Windows.Forms.Button();
            panelTop = new System.Windows.Forms.Panel();
            labTitulo = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.panelBackupConluido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
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
            labTitulo.Location = new System.Drawing.Point(499, 11);
            labTitulo.Name = "labTitulo";
            labTitulo.Size = new System.Drawing.Size(124, 37);
            labTitulo.TabIndex = 31;
            labTitulo.Text = "Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(362, 166);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 620;
            label2.Text = "Aguarde...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(16, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(88, 69);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(107, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(250, 20);
            label3.TabIndex = 23;
            label3.Text = "Backup Realizado com Sucesso!!!";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            pictureBox3.Location = new System.Drawing.Point(0, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(368, 36);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // timerBackup
            // 
            this.timerBackup.Tick += new System.EventHandler(this.timerBackup_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 619;
            this.label1.Text = "Backup de Dados:";
            // 
            // labelProgressoBackup
            // 
            this.labelProgressoBackup.AutoSize = true;
            this.labelProgressoBackup.Location = new System.Drawing.Point(759, 166);
            this.labelProgressoBackup.Name = "labelProgressoBackup";
            this.labelProgressoBackup.Size = new System.Drawing.Size(21, 13);
            this.labelProgressoBackup.TabIndex = 618;
            this.labelProgressoBackup.Text = "0%";
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(365, 182);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(425, 36);
            this.progressBarBackup.TabIndex = 617;
            // 
            // panelBackupConluido
            // 
            this.panelBackupConluido.BackColor = System.Drawing.Color.Silver;
            this.panelBackupConluido.Controls.Add(pictureBox2);
            this.panelBackupConluido.Controls.Add(label3);
            this.panelBackupConluido.Controls.Add(this.btnOK);
            this.panelBackupConluido.Controls.Add(this.pictureFechar);
            this.panelBackupConluido.Controls.Add(pictureBox3);
            this.panelBackupConluido.Location = new System.Drawing.Point(750, 257);
            this.panelBackupConluido.Name = "panelBackupConluido";
            this.panelBackupConluido.Size = new System.Drawing.Size(368, 190);
            this.panelBackupConluido.TabIndex = 622;
            this.panelBackupConluido.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(143, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOK.TabIndex = 22;
            this.btnOK.TabStop = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureFechar
            // 
            this.pictureFechar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureFechar.Image = ((System.Drawing.Image)(resources.GetObject("pictureFechar.Image")));
            this.pictureFechar.Location = new System.Drawing.Point(318, 0);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(50, 36);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFechar.TabIndex = 21;
            this.pictureFechar.TabStop = false;
            // 
            // buttonEfetuarBackup
            // 
            this.buttonEfetuarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEfetuarBackup.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonEfetuarBackup.FlatAppearance.BorderSize = 0;
            this.buttonEfetuarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEfetuarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEfetuarBackup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEfetuarBackup.Location = new System.Drawing.Point(475, 240);
            this.buttonEfetuarBackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEfetuarBackup.Name = "buttonEfetuarBackup";
            this.buttonEfetuarBackup.Size = new System.Drawing.Size(180, 32);
            this.buttonEfetuarBackup.TabIndex = 624;
            this.buttonEfetuarBackup.TabStop = false;
            this.buttonEfetuarBackup.Text = "Gerar Backup";
            this.buttonEfetuarBackup.UseVisualStyleBackColor = false;
            this.buttonEfetuarBackup.Click += new System.EventHandler(this.buttonEfetuarBackup_Click);
            this.buttonEfetuarBackup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBackup_KeyDown);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 512);
            this.Controls.Add(this.buttonEfetuarBackup);
            this.Controls.Add(this.panelBackupConluido);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProgressoBackup);
            this.Controls.Add(this.progressBarBackup);
            this.Controls.Add(panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBackup_KeyDown);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.panelBackupConluido.ResumeLayout(false);
            this.panelBackupConluido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Timer timerBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProgressoBackup;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.Panel panelBackupConluido;
        private System.Windows.Forms.PictureBox btnOK;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Button buttonEfetuarBackup;
    }
}