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
    public partial class frmEntradaEstoque : Form
    {
        public frmEntradaEstoque()
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha a tela.
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a tela.
            this.Close();
        }

        private void frmEntradaEstoque_Load(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer todas as informações da tabela no banco de dados para o DataGridView.
            this.relacaoEstoqueTableAdapter.Fill(this.drogariaParanaDataSet.RelacaoEstoque);
            radNotaFiscal.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer novamente todas as informações da tabela no banco de dados e atualizar no DataGridView.
            this.relacaoEstoqueTableAdapter.Fill(this.drogariaParanaDataSet.RelacaoEstoque);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Codigo reponsavel por verificar qual tipo de pesquisa o usuario deseja fazer e logo apos executalo.
            if (radFornecedor.Checked)
            {
                //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
                this.relacaoEstoqueTableAdapter.queryFornecedorPesquisa(this.drogariaParanaDataSet.RelacaoEstoque, textPesquisa.Text);
            }
            else
            {
                //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
                this.relacaoEstoqueTableAdapter.queryNotaPesquisa(this.drogariaParanaDataSet.RelacaoEstoque, textPesquisa.Text);
            }
        }

        private void btnCadastrarNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta função esta desativada temporariamente!");
            
            //openChildForm(new frmCadastrarNotaFiscal());
        }

        private void frmEntradaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnFechar_Click(sender, e);
            }
        }

        private void textPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Codigo reponsavel por verificar qual tipo de pesquisa o usuario deseja fazer e logo apos executalo.
                if (radFornecedor.Checked)
                {
                    //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
                    this.relacaoEstoqueTableAdapter.queryFornecedorPesquisa(this.drogariaParanaDataSet.RelacaoEstoque, textPesquisa.Text);
                }
                else
                {
                    //Codigo responsavel por trazer uma informações filtrada ou melhor desejada que esteja na tabela no banco de dados para o DataGridView.
                    this.relacaoEstoqueTableAdapter.queryNotaPesquisa(this.drogariaParanaDataSet.RelacaoEstoque, textPesquisa.Text);
                }

                dataGridViewEntradaEstoque.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void dataGridViewEntradaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openChildForm(new frmCadastrarNotaFiscal());

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }
    }
}
