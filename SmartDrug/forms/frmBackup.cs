using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SmartDrug.forms
{
    public partial class frmBackup : Form
    {
        conexao banco = new conexao();

        int counter, statusBackup = 2;

        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            buttonEfetuarBackup.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerBackup_Tick(object sender, EventArgs e)
        {
            if (progressBarBackup.Value < 100)
            {
                //
                counter = counter + 20;
                labelProgressoBackup.Text = counter.ToString() + "%";
                progressBarBackup.Value = progressBarBackup.Value + 20;
            }
            else
            {
                // Exit loop code.  
                timerBackup.Enabled = false;
                timerBackup.Stop();
                //
                panelBackupConluido.Location = new System.Drawing.Point(161, 23);
                //
                panelBackupConluido.Visible = true;
            }
        }

        private void GerarBackup()
        {
            try
            {
                statusBackup = 1;

                //
                timerBackup.Interval = 600;
                timerBackup.Enabled = true;
                this.timerBackup.Tick += new System.EventHandler(this.timerBackup_Tick);
                //
                //
                string Backup = ("BACKUP DATABASE DrogariaParana TO DISK = 'D:Backup Drogaria Parana/Backup Drogaria Parana.bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup DrogariaParana'");
                SqlCommand exeBackup = new SqlCommand(Backup, banco.connection);
                //
                banco.conectar();
                exeBackup.ExecuteNonQuery();
                banco.desconectar();
                //
                counter = counter + 20;
                progressBarBackup.Value = progressBarBackup.Value + 20;

                statusBackup = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panelBackupConluido.Visible = false;
            labelProgressoBackup.Text = "0%";
            progressBarBackup.Value = 0;
        }

        private void frmBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnFechar_Click(sender, e);
            }
        }

        private void buttonEfetuarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusBackup == 2)
                {
                    if (MessageBox.Show("LEMBRE-SE: Antes de INICIAR o BACKUP certifique-se se o HD está bem conectado." + "\n" + "Deseja contnuar!?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        GerarBackup();

                        btnOK.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Aguarde o Backup ser Finalizado!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
