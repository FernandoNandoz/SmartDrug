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
    public partial class frmFinalizarPagamento : Form
    {
        #region Variaveis e instancias

        conexao banco = new conexao();

        frmControlePagamento instancia;

        int FormaPagamento = 0, parcelaAtual = 0;
        string descricaoPagamento;

        decimal valorPago, subTotal, valorRestante;

        public int _idCliente { get; set; }
        public string _documento { get; set; }
        public string _situacaoConta { get; set; }

        #endregion

        public frmFinalizarPagamento(frmControlePagamento hospedes)
        {
            InitializeComponent();
            instancia = hospedes;

            _idCliente = int.Parse(instancia.RelacaoContaDataGridView.CurrentRow.Cells[10].Value.ToString());
            _documento = instancia.RelacaoContaDataGridView.CurrentRow.Cells[12].Value.ToString();
            _situacaoConta = instancia.RelacaoContaDataGridView.CurrentRow.Cells[6].Value.ToString();
            parcelaAtual = int.Parse(instancia.RelacaoContaDataGridView.CurrentRow.Cells[1].Value.ToString());
            descricaoPagamento = instancia.RelacaoContaDataGridView.CurrentRow.Cells[0].Value.ToString();

            subTotal = decimal.Parse(instancia.RelacaoContaDataGridView.CurrentRow.Cells[4].Value.ToString());
        }

        private void limparValores()
        {
            descricaoTextBox.Clear();
            labelNomeCliente.Text = "";
            labelObservacao.Text = "";
            labelSituacao.Text = "";
            labelVendedor.Text = "";
            FormaPagamento = 1;
            formaPagamentoTextBox.Text = "DINHEIRO";
            valorPago = 0;
            valorPagoTextBox.Text = "0,00";
            valorRestante = 0;
            valorRestanteTextBox.Text = "0,00";
            subTotal = 0;
            subtotalTextBox.Text = "0,00";

            instancia.RelacaoContaDataGridView.Refresh();
        }

        private void processarPagamento()
        {
            #region QuerySQL
            string RelacaoHospedes = ("UPDATE RelacaoHospedes SET parcela = @parcela, saldo = @saldo, situacao = @situacao, ultimoPagamento = @ultimoPagamento, valorPagameno = @valorPagamento WHERE idCliente = @ID");
            string MensalidadeUpdt = ("UPDATE Mensalidade SET idFormaPagamento = @idFormaPagamento, descricaoPagamento = @descricaoPagamento, situacao = @situacao, valorAluguel = @valorAluguel, saldo = @saldo, idVendedor = @idVendedor, dataPagamento = @dataPagamento WHERE documento = @documento");
            string FluxoCaixa = ("INSERT INTO FluxoCaixa (Ndocumento, descricao, data, credito, debito) VALUES (@Ndocumento, @descricao, @data, @credito, @debito)");
            SqlCommand executRelacao = new SqlCommand(RelacaoHospedes, banco.connection);
            SqlCommand exeMensalidadeUpdt = new SqlCommand(MensalidadeUpdt, banco.connection);
            SqlCommand exeFluxoCaixa = new SqlCommand(FluxoCaixa, banco.connection);
            #endregion

            #region Atualiza os Dados da Tabela Relação de Hospedes
            executRelacao.Parameters.AddWithValue("@ID", _idCliente);
            executRelacao.Parameters.AddWithValue("@parcela", parcelaAtual);
            executRelacao.Parameters.AddWithValue("@situacao", "ABERTA");
            executRelacao.Parameters.AddWithValue("@saldo", valorRestante);
            executRelacao.Parameters.AddWithValue("@ultimoPagamento", DateTime.Now);
            executRelacao.Parameters.AddWithValue("@valorPagamento", subTotal);

            banco.conectar();
            executRelacao.ExecuteNonQuery();
            banco.desconectar();
            #endregion


            #region Atualiza os Dados da Table de Mensalidades
            exeMensalidadeUpdt.Parameters.AddWithValue("@documento", _documento);
            exeMensalidadeUpdt.Parameters.AddWithValue("@parcelaAtual", parcelaAtual);
            exeMensalidadeUpdt.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
            if (descricaoTextBox.Text == "")
            {
                exeMensalidadeUpdt.Parameters.AddWithValue("@descricaoPagamento", descricaoPagamento);
            }
            else
            {
                exeMensalidadeUpdt.Parameters.AddWithValue("@descricaoPagamento", descricaoTextBox.Text);
            }
            exeMensalidadeUpdt.Parameters.AddWithValue("@valorAluguel", subTotal);
            exeMensalidadeUpdt.Parameters.AddWithValue("@saldo", valorRestante);
            exeMensalidadeUpdt.Parameters.AddWithValue("@situacao", "PAGO");
            exeMensalidadeUpdt.Parameters.AddWithValue("@idVendedor", vendedorComboBox.SelectedValue);
            exeMensalidadeUpdt.Parameters.AddWithValue("@dataPagamento", DateTime.Now);

            banco.conectar();
            exeMensalidadeUpdt.ExecuteNonQuery();
            banco.desconectar();
            #endregion


            #region Registra o Movimento
            exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", _documento);
            exeFluxoCaixa.Parameters.AddWithValue("@descricao", "Pag Apto." + descricaoPagamento + " - (" + descricaoTextBox.Text + ")" + " - Parcela " + parcelaAtual);
            exeFluxoCaixa.Parameters.AddWithValue("@data", DateTime.Now);
            exeFluxoCaixa.Parameters.AddWithValue("@credito", subTotal);
            exeFluxoCaixa.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));

            banco.conectar();
            exeFluxoCaixa.ExecuteNonQuery();
            banco.desconectar();
            #endregion

        }

        private void frmFinalizarPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                if (valorPago == subTotal)
                {
                    //try
                    //{
                        processarPagamento();

                        frmCupomMensalidade abrir = new frmCupomMensalidade(this);
                        abrir.ShowDialog();
                        abrir.Dispose();

                        limparValores();
                    //}
                    //catch (Exception ex)
                    //{
                        //MessageBox.Show("" + ex);
                    //}
                }
                else
                {
                    MessageBox.Show("O Valor informado não está igual ao Valor a Pagar.");
                }
            }
        }

        private void frmFinalizarPagamento_Load(object sender, EventArgs e)
        {
            #region Abrindo Tableas
            this.clientesTableAdapter.queryID(drogariaParanaDataSet.Clientes, _idCliente);
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            #endregion

            vendedorComboBox.Focus();
            vendedorComboBox.SelectedValue = 8;
            FormaPagamento = 1;
            formaPagamentoTextBox.Text = "DINHEIRO";
            labelSituacao.Text = _situacaoConta;

            valorPagoTextBox.Text = ("0,00");

            subtotalTextBox.Text = Convert.ToDecimal(subTotal).ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendedorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (vendedorComboBox.Text != "-----")
                {
                    SendKeys.Send("{TAB}");

                    e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                    return;
                }
                else
                {
                    MessageBox.Show("Informe o Vendedor!!!");
                }
            }
        }

        private void descricaoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                FormaPagamento = 1;
                formaPagamentoTextBox.Text = "DINHEIRO";
                valorPagoTextBox.Text = "0,00";
            }
            if (e.KeyCode == Keys.D2)
            {
                FormaPagamento = 2;
                formaPagamentoTextBox.Text = "DEBITO";
                valorPagoTextBox.Text = "0,00";
            }

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void valorPagoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Show("DESEJA CONCLUIR o PAGAMENTO?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir o pagamente usando F5!  :-) ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        processarPagamento();

                        frmCupomMensalidade abrir = new frmCupomMensalidade(this);
                        abrir.ShowDialog();
                        abrir.Dispose();

                        limparValores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void valorPagoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (valorPagoTextBox.Text == (""))
                {
                    valorPago = 0;
                }
                else
                {
                    valorPago = decimal.Parse(valorPagoTextBox.Text);
                }
                subTotal = decimal.Parse(subtotalTextBox.Text);

                if (valorPago <= subTotal)
                {
                    valorRestante = subTotal - valorPago;

                    valorRestanteTextBox.Text = Convert.ToDecimal(valorRestante).ToString();
                }
                else
                {
                    valorRestante = 0;

                    valorRestanteTextBox.Text = Convert.ToDecimal(valorRestante).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
