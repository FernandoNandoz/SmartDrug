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
    public partial class frmContasReceber : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        public frmContasReceber()
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a Tela.
            this.Close();
        }

        private void FrmContasReceber_Load(object sender, EventArgs e)
        {
            this.joinContasReceberTableAdapter.Fill(this.drogariaParanaDataSet.JoinContasReceber);
            textDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
            this.joinContasReceberTableAdapter.queryPesquisa(this.drogariaParanaDataSet.JoinContasReceber, textDescricao.Text);
        }

        private void textDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && textDescricao.Focus())
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
                this.joinContasReceberTableAdapter.queryPesquisa(this.drogariaParanaDataSet.JoinContasReceber, textDescricao.Text);

                contasReceberDataGridView.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer novamente todas as informações da tabela no banco de dados e atualizar no DataGridView.
            this.joinContasReceberTableAdapter.Fill(this.drogariaParanaDataSet.JoinContasReceber);
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmReceber(this));
        }

        private void contasReceberDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                for (int i = 0; i < contasReceberDataGridView.Rows.Count - 0; ++i)
                {
                    if (contasReceberDataGridView.Rows[i].Cells[4].Value.ToString() == "CONGELADA")
                    {
                        contasReceberDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        contasReceberDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    }

                    if (contasReceberDataGridView.Rows[i].Cells[4].Value.ToString() == "FECHADA")
                    {
                        contasReceberDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.DimGray;
                        contasReceberDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contasReceberDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape && contasReceberDataGridView.Focus())
            {
                this.Close();
            }


            if (e.KeyCode == Keys.Enter)
            {
                if(contasReceberDataGridView.Rows.Count != 0)
                {
                    openChildForm(new forms.frmReceber(this));

                    e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                    return;
                }
                else
                {
                    MessageBox.Show("Nenhum Cliente foi encontrado. Tente Novamente!");
                    textDescricao.Focus();
                }
            }
        }
    }
}
