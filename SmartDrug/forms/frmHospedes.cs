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
    public partial class frmHospedes : Form
    {
        conexao banco = new conexao();

        public frmHospedes()
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

        private void frmHospedes_Load(object sender, EventArgs e)
        {
            textDescricao.Focus();

            this.hospedesTableAdapter.Fill(this.drogariaParanaDataSet.Hospedes);
            hospedesDataGridView.Refresh();
        }
      
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.hospedesTableAdapter.queryPesquisa(drogariaParanaDataSet.Hospedes, textDescricao.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.hospedesTableAdapter.Fill(this.drogariaParanaDataSet.Hospedes);
        }

        private void btnNovoHospede_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmNovoHospede());
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new frmControlePagamento(this));
            }
            catch (Exception ex)
            {
                MessageBox.Show("No momento nao a Hospedes com Faturas Abertas!" + "\n" + "Por Favor, va em Novo Hospese e Abra uma nova fatura e tente novamente!");
            }
        }

        private void btnExcluirHospede_Click(object sender, EventArgs e)
        {
            string RelacaoHospedes = ("DELETE FROM RelacaoHospedes WHERE idCliente = @idCliente");
            string Mensalidade = ("DELETE FROM Mensalidade WHERE idCliente = @idCliente");
            SqlCommand executRelacao = new SqlCommand(RelacaoHospedes, banco.connection);
            SqlCommand exeMensalidade = new SqlCommand(Mensalidade, banco.connection);

            executRelacao.Parameters.Clear();
            executRelacao.Parameters.AddWithValue("@idCliente", hospedesDataGridView.CurrentRow.Cells[6].Value);
            //
            exeMensalidade.Parameters.Clear();
            exeMensalidade.Parameters.AddWithValue("@idCliente", hospedesDataGridView.CurrentRow.Cells[6].Value);

            if (MessageBox.Show("Tem certeza que deseja EXCLUIR este Hospede?" + "\n" + "Uma vez EXCLUIDA não pode ser mais recuperada!" + "\n" + "\n" + "Nome do Hospede: " + hospedesDataGridView.CurrentRow.Cells[0].Value, (""), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    banco.conectar();
                    executRelacao.ExecuteNonQuery();
                    exeMensalidade.ExecuteNonQuery();
                    banco.desconectar();

                    MessageBox.Show("Hospede Deletado com Sucesso!!!");

                    textDescricao.Focus();

                    this.hospedesTableAdapter.Fill(this.drogariaParanaDataSet.Hospedes);
                    hospedesDataGridView.Refresh();

                }
                catch
                {
                    MessageBox.Show("Por favor, Selecione um Hospede para que posso ser Excluido.");
                    this.Close();
                }
            }
        }

        private void hospedesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.Equals("ATRASADO"))
            {
                hospedesDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                hospedesDataGridView.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            }
        }

        private void frmHospedes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.hospedesTableAdapter.queryPesquisa(drogariaParanaDataSet.Hospedes, textDescricao.Text);

                hospedesDataGridView.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void hospedesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openChildForm(new frmControlePagamento(this));

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        
    }
}
