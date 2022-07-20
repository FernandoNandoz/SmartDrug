using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDrug.forms
{
    public partial class frmControleConta : Form
    {
        public frmControleConta()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmControleConta_Load(object sender, EventArgs e)
        {
            this.joinContasReceberTableAdapter.Fill(this.drogariaParanaDataSet.JoinContasReceber);
            textPesquisa.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.joinContasReceberTableAdapter.queryPesquisa(drogariaParanaDataSet.JoinContasReceber, textPesquisa.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.joinContasReceberTableAdapter.Fill(this.drogariaParanaDataSet.JoinContasReceber);
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new forms.frmAlterar_CadastrarConta(this));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No momento nao a Contas Abertas!" + "\n" + "Por Favor, crie novas Contas e tente novamente!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmControleConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnSair_Click(sender, e);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.joinContasReceberTableAdapter.queryPesquisa(drogariaParanaDataSet.JoinContasReceber, textPesquisa.Text);

                dataGridViewContas.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void dataGridViewContas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    openChildForm(new forms.frmAlterar_CadastrarConta(this));

                    e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No momento nao a Contas Abertas!" + "\n" + "Por Favor, crie novas Contas e tente novamente!");
                }
            }
        }
     
    }
}
