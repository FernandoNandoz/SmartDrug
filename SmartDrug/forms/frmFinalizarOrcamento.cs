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
    public partial class frmFinalizarOrcamento : Form
    {
        #region Variaveis e Instancias
        conexao banco = new conexao();
        
        frmConcluirOrcamento instancia;

        int IDcliente, idClienteGrid, FormaPagamento = 0, quantidadeTotalProdutos = 0;
        string documento;
        
        decimal valorPago, subTotal, desconto, valorRestante;
        #endregion

        public string _documento { get; set; }

        public frmFinalizarOrcamento(frmConcluirOrcamento Orcamento)
        {
            InitializeComponent();
            instancia = Orcamento;

            idClienteGrid = int.Parse(instancia.dataGridViewOrcamentos.CurrentRow.Cells[14].Value.ToString());
            documento = instancia.dataGridViewOrcamentos.CurrentRow.Cells[0].Value.ToString();

            subTotal = decimal.Parse(instancia.dataGridViewOrcamentos.CurrentRow.Cells[4].Value.ToString());
            desconto = decimal.Parse(instancia.dataGridViewOrcamentos.CurrentRow.Cells[6].Value.ToString());

            _documento = documento;
        }

        private void limparValores()
        {
            vendedorComboBox.SelectedValue = 8;
            descricaoTextBox.Clear();
            labelNomeCliente.Text = "";
            labelObservacao.Text = "";
            labelSituacao.Text = "";
            labelVendedor.Text = "";
            FormaPagamento = 7;
            formaPagamentoTextBox.Text = "CONTAS A RECEBER";
            valorPago = 0;
            valorPagoTextBox.Text = "0,00";
            valorRestante = 0;
            valorRestanteTextBox.Text = "0,00";
            desconto = 0;
            descontoTextBox.Text = "0,00";
            subTotal = 0;
            subtotalTextBox.Text = "0,00";
            labelSituacao.ForeColor = Color.Black;
        }

        private void processarPagamento()
        {
            #region QuerySQL
            string Vendas = ("UPDATE Vendas SET idFormaPagamento = @idFormaPagamento WHERE Ndocumento = @Ndocumento");
            string ContasReceber = ("INSERT INTO ContasReceber (Ndocumento, total, idCliente, idSituacao, idFormaRecebimento, descricao, dataCompra, parcela, valorPacela, idVendedor, idSituacaoCliente, saldo, idSituacaoConta, vendedorHaver) VALUES (@Ndocumento, @total, @idCliente, @idSituacao, @idFormaRecebimento, @descricao, @dataCompra, @parcela, @valorParcela, @idVendedor, @idSituacaoCliente, @saldo, @idSituacaoConta, @vendedorHaver)");
            string FluxoCaixa = ("INSERT INTO FluxoCaixa (Ndocumento, descricao, data, credito, debito) VALUES (@Ndocumento, @descricao, @data, @credito, @debito)");
            string RelacaoHaverIS = ("INSERT INTO RelacaoHaver (idCliente, idSituacaoConta, ultimaCompra) VALUES (@idCliente, @idSituacaoConta, @ultimaCompra)");
            string RelacaoHaverUP = ("UPDATE RelacaoHaver SET ultimaCompra = @AtualizarData WHERE idCliente = @idCliente");
            string Produtos = ("UPDATE Produto SET quantidade = quantidade - @pedido WHERE idProduto = @ID");
            SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
            SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
            SqlCommand exeFluxoCaixa = new SqlCommand(FluxoCaixa, banco.connection);
            SqlCommand exeRelacaoHaver = new SqlCommand(RelacaoHaverIS, banco.connection);
            SqlCommand exeRelacaoHaverUP = new SqlCommand(RelacaoHaverUP, banco.connection);
            SqlCommand exeProduto = new SqlCommand(Produtos, banco.connection);
            #endregion


            #region Verificador de Conta
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string RelacaoHaver = ("SELECT * FROM RelacaoHaver WHERE idCliente = @ID");
            SqlCommand exeVerificacao = new SqlCommand(RelacaoHaver, banco.connection);
            banco.conectar();
            exeVerificacao.Parameters.AddWithValue("@ID", idClienteGrid);
            SqlDataReader datareader = exeVerificacao.ExecuteReader();
            if (datareader.Read())
            {
                VerificarHaver.haver(datareader["idCliente"].ToString());
                IDcliente = int.Parse("" + VerificarHaver._verificado());
            }
            banco.desconectar();
            #endregion


            #region Atualiza os Dados da Venda
            exeVendas.Parameters.AddWithValue("@Ndocumento", documento);
            exeVendas.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
            
            banco.conectar();
            exeVendas.ExecuteNonQuery();
            banco.desconectar();
            #endregion
            
            
            #region Forma de pagamento - DINHEIRO / DEBITO
            //Se o valor Pago for o equivalente Valor Total, e o valor restante seja igual a zero.
            //O movimento de caixa será registrado com o valor total da compra.
            //
            //Se o valor pago não for o  equivalente ao Valor Total, e o valor restante for diferente de zero.
            //O movimento de caixa será registado com o valor que foi pago, e o restante sera resgitrado em Contas a Receber.

            if (FormaPagamento == 1 || FormaPagamento == 2)
            {
                //O Gerador de Contas ira verificar se o Cliente em questão possui uma conta aberta, caso não tneh ele abrirá uma.
                //
                //O Valor Pago será Registrado no Movimento de Caixa;
                //E o Valor Restante será Registrado como Contas a Receber.

                if (valorRestante == 0)
                {
                    #region Registra o Movimento de Caixa
                    exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", documento);
                    exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");
                    exeFluxoCaixa.Parameters.AddWithValue("@data", DateTime.Now);
                    exeFluxoCaixa.Parameters.AddWithValue("@credito", decimal.Parse(subtotalTextBox.Text));
                    exeFluxoCaixa.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));

                    banco.conectar();
                    exeFluxoCaixa.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion
                }
                else
                {
                    #region Gerador de Contas
                    if (IDcliente != idClienteGrid)
                    {
                        exeRelacaoHaver.Parameters.AddWithValue("@idCliente", idClienteGrid);
                        exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
                        exeRelacaoHaver.Parameters.AddWithValue("@ultimaCompra", DateTime.Now);

                        banco.conectar();
                        exeRelacaoHaver.ExecuteNonQuery();
                        banco.desconectar();
                    }
                    else
                    {
                        //Ira Atualizar a data da ultima compra na conta do cliente.
                        exeRelacaoHaverUP.Parameters.AddWithValue("@AtualizarData", DateTime.Now);
                        exeRelacaoHaverUP.Parameters.AddWithValue("@idCliente", idClienteGrid);

                        banco.conectar();
                        exeRelacaoHaverUP.ExecuteNonQuery();
                        banco.desconectar();
                    }
                    #endregion


                    #region Registra o Movimento de Caixa
                    //Registra Movimento de caixa - Valor Pago
                    exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", documento);
                    exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");
                    exeFluxoCaixa.Parameters.AddWithValue("@data", DateTime.Now);
                    exeFluxoCaixa.Parameters.AddWithValue("@credito", decimal.Parse(valorPagoTextBox.Text));
                    exeFluxoCaixa.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));

                    banco.conectar();
                    exeFluxoCaixa.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion


                    #region Registra a Conta a Receber
                    exeContasReceber.Parameters.AddWithValue("@Ndocumento", documento);
                    exeContasReceber.Parameters.AddWithValue("@total", valorRestante);
                    exeContasReceber.Parameters.AddWithValue("@idCliente", idClienteGrid);
                    exeContasReceber.Parameters.AddWithValue("@idSituacao", 1);
                    exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", 7);
                    exeContasReceber.Parameters.AddWithValue("@parcela", 0);
                    exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                    exeContasReceber.Parameters.AddWithValue("@idVendedor", vendedorComboBox.SelectedValue);
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 2);
                    exeContasReceber.Parameters.AddWithValue("@dataCompra", DateTime.Now);
                    exeContasReceber.Parameters.AddWithValue("@saldo", valorRestante);
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeContasReceber.Parameters.AddWithValue("@vendedorHaver", vendedorComboBox.Text);
                    exeContasReceber.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");                  

                    banco.conectar();
                    exeContasReceber.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion
                }
            }
            #endregion


            #region Forma de pagamento - CREDITO / CONTAS A RECEBER
            if (FormaPagamento == 3 || FormaPagamento == 7)
            {
                #region Gerador de Contas
                if (IDcliente != idClienteGrid)
                {
                    exeRelacaoHaver.Parameters.AddWithValue("@idCliente", idClienteGrid);
                    exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeRelacaoHaver.Parameters.AddWithValue("@ultimaCompra", DateTime.Now);

                    banco.conectar();
                    exeRelacaoHaver.ExecuteNonQuery();
                    banco.desconectar();
                }
                else
                {
                    //Ira Atualizar a data da ultima compra na conta do cliente.
                    exeRelacaoHaverUP.Parameters.AddWithValue("@AtualizarData", DateTime.Now);
                    exeRelacaoHaverUP.Parameters.AddWithValue("@idCliente", idClienteGrid);

                    banco.conectar();
                    exeRelacaoHaverUP.ExecuteNonQuery();
                    banco.desconectar();
                }
                #endregion


                #region Registra Conta a Receber
                exeContasReceber.Parameters.AddWithValue("@Ndocumento", documento);
                exeContasReceber.Parameters.AddWithValue("@total", decimal.Parse(subtotalTextBox.Text));
                exeContasReceber.Parameters.AddWithValue("@idCliente", idClienteGrid);
                exeContasReceber.Parameters.AddWithValue("@idSituacao", 1);
                exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", 7);
                exeContasReceber.Parameters.AddWithValue("@parcela", 0);
                exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                exeContasReceber.Parameters.AddWithValue("@idVendedor", vendedorComboBox.SelectedValue);
                exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 2);
                exeContasReceber.Parameters.AddWithValue("@dataCompra", DateTime.Now);
                exeContasReceber.Parameters.AddWithValue("@saldo", decimal.Parse(subtotalTextBox.Text));
                exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 1);
                exeContasReceber.Parameters.AddWithValue("@vendedorHaver", vendedorComboBox.Text);
                exeContasReceber.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");

                banco.conectar();
                exeContasReceber.ExecuteNonQuery();
                banco.desconectar();
                #endregion
            }
             #endregion

            MessageBox.Show("ORÇAMENTO FATURADO COM SUCESSO!!!!!");
        }

        private void frmFinalizarOrcamento_Load(object sender, EventArgs e)
        {
            #region Abrindo Tabelas
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            this.clientesTableAdapter.queryID(drogariaParanaDataSet.Clientes, idClienteGrid);
            this.joinContasReceberTableAdapter.queryPesquisa(this.drogariaParanaDataSet.JoinContasReceber, labelNomeCliente.Text);
            #endregion

            if (labelSituacao.Text == "CONGELADA")
            {
                labelSituacao.ForeColor = Color.Red;
            }

            vendedorComboBox.SelectedValue = 8;
            FormaPagamento = 7;
            formaPagamentoTextBox.Text = "CONTAS A RECEBER";

            valorPagoTextBox.Text = ("0,00");

            subtotalTextBox.Text = Convert.ToDecimal(subTotal).ToString();
        }

        private void frmFinalizarOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            //
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            //
            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    processarPagamento();

                    frmCupomFinalizarOrcamento abrir = new frmCupomFinalizarOrcamento(this);
                    abrir.ShowDialog();
                    abrir.Dispose();

                    limparValores();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valorPagoTextBox.Text = "0,00";
                valorPago = 0;

                decimal resultadoDesconto = 0;
                //
                if (descontoTextBox.Text == (""))
                {
                    desconto = 0;
                }
                else
                {
                    desconto = decimal.Parse(descontoTextBox.Text);
                }
                resultadoDesconto = subTotal - desconto;

                subtotalTextBox.Text = Convert.ToDecimal(resultadoDesconto).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (e.KeyCode == Keys.D3)
            {
                FormaPagamento = 3;
                formaPagamentoTextBox.Text = "CREDITO";
                valorPagoTextBox.Text = "0,00";
            }
            if (e.KeyCode == Keys.D5)
            {
                FormaPagamento = 7;
                formaPagamentoTextBox.Text = "CONTAS A RECEBER";
                valorPagoTextBox.Text = "0,00";
            }

            if (e.KeyCode == Keys.Enter)
            {
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

        private void valorPagoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Show("DESEJA CONCLUIR O ORÇAMENTO?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir a Orçamento usando F5!  :-) ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    processarPagamento();

                    frmCupomFinalizarOrcamento abrir = new frmCupomFinalizarOrcamento(this);
                    abrir.ShowDialog();
                    abrir.Dispose();

                    limparValores();
                }

                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void descontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                desconto = decimal.Parse(descontoTextBox.Text);
                descontoTextBox.Text = Convert.ToDecimal(desconto).ToString();

                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}