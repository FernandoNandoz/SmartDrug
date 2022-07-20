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
    public partial class frmAlterar_CadastrarConta : Form
    {
        conexao banco = new conexao();
        //

        frmControleConta instancia;

        int ID;

        public frmAlterar_CadastrarConta(frmControleConta Conta)
        {
            InitializeComponent();
            instancia = Conta;

            ID = int.Parse(instancia.dataGridViewContas.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterar_CadastrarConta_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.drogariaParanaDataSet.Clientes);
            this.joinContasReceberTableAdapter.queryID(this.drogariaParanaDataSet.JoinContasReceber, ID);
            this.situacaoContaTableAdapter.Fill(this.drogariaParanaDataSet.SituacaoConta);

            descricaoContaTextBox.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string RelacaoHaverIS = ("INSERT INTO RelacaoHaver (idCliente, idSituacaoConta, dataAbertura) VALUES (@idCliente, @idSituacaoConta, @dataAbertura)");
            string RelacaoHaverUP = ("UPDATE RelacaoHaver SET idSituacaoConta = @idSituacaoConta, ultimaCompra = @ultimaCompra, ultimoHaver = @ultimoHaver, valorHaver = @valorHaver WHERE idRelacaoHaver = @ID");
            string FecharConta = ("UPDATE RelacaoHaver SET dataFechamento = @data WHERE idRelacaoHaver = @ID");
            SqlCommand exeRelacaoHaver = new SqlCommand(RelacaoHaverIS, banco.connection);
            SqlCommand exeRelacaoHaverUP = new SqlCommand(RelacaoHaverUP, banco.connection);
            SqlCommand exeFechamento = new SqlCommand(FecharConta, banco.connection);

            //
            exeRelacaoHaver.Parameters.AddWithValue("@idCliente", int.Parse(clientesComboBox.SelectedValue.ToString()));
            exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
            exeRelacaoHaver.Parameters.AddWithValue("@dataAbertura", DateTime.Now);

            //Ira Atualizar a data da ultima compra na conta do cliente.
            exeRelacaoHaverUP.Parameters.AddWithValue("@idSituacaoConta", situacaoComboBox.SelectedValue);
            exeRelacaoHaverUP.Parameters.AddWithValue("@ultimaCompra", DateTime.Parse(ultimaCompraMaskedTextBox.Text));
            exeRelacaoHaverUP.Parameters.AddWithValue("@ultimoHaver", DateTime.Parse(ultimoHaverMaskedTextBox.Text));
            exeRelacaoHaverUP.Parameters.AddWithValue("@valorHaver", decimal.Parse(valorHaverTextBox.Text));

            exeRelacaoHaverUP.Parameters.AddWithValue("@ID", ID);
            
            //
            exeFechamento.Parameters.AddWithValue("@data", DateTime.Now);
            exeFechamento.Parameters.AddWithValue("@ID", ID);

            if (radAbrir.Checked)
            {
                banco.conectar();
                exeRelacaoHaver.ExecuteNonQuery();
                banco.desconectar();
            }
            else
            {
                if (situacaoComboBox.Text == "FECHADO")
                {
                    banco.conectar();
                    exeFechamento.ExecuteNonQuery();
                    banco.desconectar();
                }
                else
                {
                    banco.conectar();
                    exeRelacaoHaverUP.ExecuteNonQuery();
                    banco.desconectar();
                }
            }
           
            MessageBox.Show("Conta Alterada Com Sucesso!!");
            this.Close();
        }

        private void radAlterar_CheckedChanged(object sender, EventArgs e)
        {
            descricaoContaTextBox.BringToFront();
            //
            descricaoContaTextBox.ReadOnly = false;
            descricaoContaTextBox.TabStop = true;
            clientesComboBox.TabStop = false;
            situacaoComboBox.Focus();
        }

        private void radAbrir_CheckedChanged(object sender, EventArgs e)
        {
            clientesComboBox.BringToFront();
            //
            descricaoContaTextBox.ReadOnly = true;
            descricaoContaTextBox.TabStop = false;
            clientesComboBox.TabStop = true;
            clientesComboBox.Focus();

        }

        private void frmAlterar_CadastrarConta_KeyDown(object sender, KeyEventArgs e)
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

        private void descricaoContaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void clientesComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void situacaoComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void ultimaCompraMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void ultimoHaverMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void valorHaverTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnSalvar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.btnSalvar_Click(sender, e);
        }       
    }
}
