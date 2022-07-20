using Microsoft.Reporting.WinForms;
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
using System.IO;
using System.Globalization;
using System.Drawing.Printing;
using System.Drawing.Imaging;

namespace SmartDrug.forms
{
    public partial class frmFinalizarVenda : Form
    {

        #region Variaveis e Instancias

        conexao banco = new conexao();

        frmVendas instancia;

        int IDcliente, FormaPagamento = 0, quantidadeTotalProdutos = 0;
        string codigo;
        
        decimal valorPago, subTotal, subTotalGeral, desconto, valorRestante;

        bool pagamentoEmAndamento = false, tudoCerto = false;

        #endregion

        public frmFinalizarVenda(frmVendas vendas)
        {
            InitializeComponent();
            instancia = vendas;            
        }

        private void limparValores()
        {
            vendedorComboBox.SelectedValue = 8;
            textBoxPesquisaCliente.Clear();
            descricaoTextBox.Clear();
            label_ID.Text = "";
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
            codigo = "";

            instancia.grid.Rows.Clear();
            instancia.subTotalTextBox.Text = "0,00";
            instancia.TotalGeralTextBox.Text = "0,00";
            labelSituacao.Text = ("...");
        }

        private void processarPagamento()
        {
            #region QuerySQL
            string Vendas = ("INSERT INTO Vendas (Ndocumento, dataEmissao, desconto, idVendedor, idFormaPagamento, idSituacao, valorTotal, idCliente, descricaoVenda, quantidadeProdutos, valorPago) VALUES (@Ndocumento, @dataEmissao, @desconto, @idVendedor, @idFormaPagamento, @idSituacao, @valorTotal, @idCliente, @descricaoVenda, @quantidadeProdutos, @valorPago)");
            string itemVendido = ("INSERT INTO itensVendidos (documento, codigo, idProduto, quantidade, valorUnitario, desconto, valorTotal) VALUES (@documento, @codigo, @idProduto, @quantidade, @valorUnitario, @desconto, @valorTotal)");
            string ContasReceber = ("INSERT INTO ContasReceber (Ndocumento, total, idCliente, idSituacao, idFormaRecebimento, descricao, dataCompra, parcela, valorPacela, idVendedor, idSituacaoCliente, saldo, idSituacaoConta, vendedorHaver) VALUES (@Ndocumento, @total, @idCliente, @idSituacao, @idFormaRecebimento, @descricao, @dataCompra, @parcela, @valorParcela, @idVendedor, @idSituacaoCliente, @saldo, @idSituacaoConta, @vendedorHaver)");
            string FluxoCaixa = ("INSERT INTO FluxoCaixa (Ndocumento, descricao, data, credito, debito) VALUES (@Ndocumento, @descricao, @data, @credito, @debito)");
            string RelacaoHaverIS = ("INSERT INTO RelacaoHaver (idCliente, idSituacaoConta, ultimaCompra) VALUES (@idCliente, @idSituacaoConta, @ultimaCompra)");
            string RelacaoHaverUP = ("UPDATE RelacaoHaver SET ultimaCompra = @AtualizarData WHERE idCliente = @idCliente");
            //string Produtos = ("UPDATE Produto SET quantidade = quantidade - @pedido WHERE idProduto = @ID");
            SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
            SqlCommand exeItemVendidos = new SqlCommand(itemVendido, banco.connection);
            SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
            SqlCommand exeFluxoCaixa = new SqlCommand(FluxoCaixa, banco.connection);
            SqlCommand exeRelacaoHaver = new SqlCommand(RelacaoHaverIS, banco.connection);
            SqlCommand exeRelacaoHaverUP = new SqlCommand(RelacaoHaverUP, banco.connection);
            //SqlCommand exeProduto = new SqlCommand(Produtos, banco.connection);
            #endregion


            #region Verificador de Conta
            //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
            string RelacaoHaver = ("SELECT * FROM RelacaoHaver WHERE idCliente = @ID");
            SqlCommand exeVerificacao = new SqlCommand(RelacaoHaver, banco.connection);
            banco.conectar();
            exeVerificacao.Parameters.AddWithValue("@ID", int.Parse(label_ID.Text));
            SqlDataReader datareader = exeVerificacao.ExecuteReader();
            if (datareader.Read())
            {
                VerificarHaver.haver(datareader["idCliente"].ToString());
                IDcliente = int.Parse("" + VerificarHaver._verificado());
            }
            banco.desconectar();
            #endregion          


            #region gerador do Codigo do Documento
            Random randNum = new Random();

            codigo = ("" + DateTime.Now.Millisecond + vendedorComboBox.SelectedValue + DateTime.Now.Second + int.Parse(label_ID.Text) + randNum.Next(DateTime.Now.Year));

            NOTAtextBox.Text = ("" + codigo);
            #endregion


            #region Registra os dados dos Produtos Vendidos
            for (int i = 0; i < instancia.grid.Rows.Count - 0; i++)
            {
                //
                exeItemVendidos.Parameters.Clear();
                exeItemVendidos.Parameters.AddWithValue("@documento", codigo);
                exeItemVendidos.Parameters.AddWithValue("@codigo", instancia.grid.Rows[i].Cells[1].Value);
                exeItemVendidos.Parameters.AddWithValue("@idProduto", int.Parse(instancia.grid.Rows[i].Cells[6].Value.ToString()));
                exeItemVendidos.Parameters.AddWithValue("@quantidade", int.Parse(instancia.grid.Rows[i].Cells[3].Value.ToString()));
                exeItemVendidos.Parameters.AddWithValue("@valorUnitario", decimal.Parse(instancia.grid.Rows[i].Cells[4].Value.ToString()));
                exeItemVendidos.Parameters.AddWithValue("@desconto", 0);
                exeItemVendidos.Parameters.AddWithValue("@valorTotal", decimal.Parse(instancia.grid.Rows[i].Cells[5].Value.ToString()));

                /*
                exeProduto.Parameters.Clear();
                exeProduto.Parameters.AddWithValue("@ID", int.Parse(instancia.grid.Rows[i].Cells[6].Value.ToString()));
                exeProduto.Parameters.AddWithValue("@pedido", int.Parse(instancia.grid.Rows[i].Cells[3].Value.ToString()));
                */

                //
                banco.conectar();
                exeItemVendidos.ExecuteNonQuery();
                //exeProduto.ExecuteNonQuery();
                banco.desconectar();
            }
            #endregion


            #region Registra os dados da venda
            exeVendas.Parameters.AddWithValue("@Ndocumento", codigo);
            exeVendas.Parameters.AddWithValue("@dataEmissao", DateTime.Now);
            exeVendas.Parameters.AddWithValue("@desconto", decimal.Parse(descontoTextBox.Text));
            exeVendas.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
            exeVendas.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
            exeVendas.Parameters.AddWithValue("@idSituacao", 1);
            exeVendas.Parameters.AddWithValue("@valorTotal", decimal.Parse(subtotalTextBox.Text));
            exeVendas.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
            if (descricaoTextBox.Text == "")
            {
                exeVendas.Parameters.AddWithValue("@descricaoVenda", labelNomeCliente.Text);
            }
            else
            {
                exeVendas.Parameters.AddWithValue("@descricaoVenda", descricaoTextBox.Text);
            }
            exeVendas.Parameters.AddWithValue("@quantidadeProdutos", quantidadeTotalProdutos);
            exeVendas.Parameters.AddWithValue("@valorPago", decimal.Parse(valorPagoTextBox.Text));
         
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
                    //Registra Movimento de caixa - Valor Total
                    exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", codigo);
                    if (descricaoTextBox.Text != (""))
                    {
                        exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");
                    }
                    else
                    {
                        exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text);
                    }
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
                    //Verificar se o Cliente possui uma conta aberta ou não, caso não tenha ele gera uma
                    if (IDcliente != int.Parse(label_ID.Text))
                    {
                        exeRelacaoHaver.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
                        exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
                        exeRelacaoHaver.Parameters.AddWithValue("@ultimaCompra", DateTime.Now);

                        banco.conectar();
                        exeRelacaoHaver.ExecuteNonQuery();
                        banco.desconectar();
                    }
                    else
                    {
                        //Caso o Cliente ja tenha uma conta aberta;
                        //Ira apenas Atualizar a data da ultima compra na conta do cliente.

                        exeRelacaoHaverUP.Parameters.AddWithValue("@AtualizarData", DateTime.Now);
                        exeRelacaoHaverUP.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));

                        banco.conectar();
                        exeRelacaoHaverUP.ExecuteNonQuery();
                        banco.desconectar();
                    }

                    #endregion


                    #region Registra o Movimento de Caixa
                    //Registra Movimento de caixa - Valor Pago
                    exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", codigo);
                    if (descricaoTextBox.Text != (""))
                    {
                        exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text + " - (" + descricaoTextBox.Text + ")");
                    }
                    else
                    {
                        exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeCliente.Text);
                    }
                    exeFluxoCaixa.Parameters.AddWithValue("@data", DateTime.Now);
                    exeFluxoCaixa.Parameters.AddWithValue("@credito", decimal.Parse(valorPagoTextBox.Text));
                    exeFluxoCaixa.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));

                    banco.conectar();
                    exeFluxoCaixa.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion


                    #region Registra a Conta a Receber
                    exeContasReceber.Parameters.AddWithValue("@Ndocumento", codigo);
                    exeContasReceber.Parameters.AddWithValue("@total", valorRestante);
                    exeContasReceber.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
                    exeContasReceber.Parameters.AddWithValue("@idSituacao", 1);
                    exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
                    exeContasReceber.Parameters.AddWithValue("@parcela", 0);
                    exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                    exeContasReceber.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 2);
                    exeContasReceber.Parameters.AddWithValue("@dataCompra", DateTime.Now);
                    exeContasReceber.Parameters.AddWithValue("@saldo", valorRestante);
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeContasReceber.Parameters.AddWithValue("@vendedorHaver", "NULL");
                    if (descricaoTextBox.Text != (""))
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    }
                    else
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", labelNomeCliente.Text);
                    }

                    banco.conectar();
                    exeContasReceber.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion
                }
            }
            #endregion


            #region Forma de pagamento - CREDITO / CONTAS A RECEBER
            if (FormaPagamento == 3 || FormaPagamento == 6 || FormaPagamento == 7)
            {
                #region Gerador de Contas
                //Verificar se o Cliente possui uma conta aberta ou não, caso não tenha ele gera uma
                if (IDcliente != int.Parse(label_ID.Text))
                {
                    exeRelacaoHaver.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
                    exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeRelacaoHaver.Parameters.AddWithValue("@ultimaCompra", DateTime.Now);

                    banco.conectar();
                    exeRelacaoHaver.ExecuteNonQuery();
                    banco.desconectar();
                }
                else
                {
                    //Caso o Cliente ja tenha uma conta aberta;
                    //Ira apenas Atualizar a data da ultima compra na conta do cliente.

                    exeRelacaoHaverUP.Parameters.AddWithValue("@AtualizarData", DateTime.Now);
                    exeRelacaoHaverUP.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));

                    banco.conectar();
                    exeRelacaoHaverUP.ExecuteNonQuery();
                    banco.desconectar();
                }
                #endregion

                if (valorRestante == 0)
                {
                    #region Registra Conta a Receber

                    exeContasReceber.Parameters.AddWithValue("@Ndocumento", codigo);
                    exeContasReceber.Parameters.AddWithValue("@total", decimal.Parse(subtotalTextBox.Text));
                    exeContasReceber.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
                    exeContasReceber.Parameters.AddWithValue("@idSituacao", 1);
                    exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
                    exeContasReceber.Parameters.AddWithValue("@parcela", 0);
                    exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                    exeContasReceber.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 2);
                    exeContasReceber.Parameters.AddWithValue("@dataCompra", DateTime.Now);
                    exeContasReceber.Parameters.AddWithValue("@saldo", decimal.Parse(subtotalTextBox.Text));
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeContasReceber.Parameters.AddWithValue("@vendedorHaver", "NULL");
                    if (descricaoTextBox.Text != (""))
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    }
                    else
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", labelNomeCliente.Text);
                    }

                    banco.conectar();
                    exeContasReceber.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion
                }
                else
                {
                    #region Registra Conta a Receber - Com Restante de um pagamento

                    exeContasReceber.Parameters.AddWithValue("@Ndocumento", codigo);
                    exeContasReceber.Parameters.AddWithValue("@total", decimal.Parse(subtotalTextBox.Text));
                    exeContasReceber.Parameters.AddWithValue("@idCliente", int.Parse(label_ID.Text));
                    exeContasReceber.Parameters.AddWithValue("@idSituacao", 1);
                    exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
                    exeContasReceber.Parameters.AddWithValue("@parcela", 0);
                    exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                    exeContasReceber.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 2);
                    exeContasReceber.Parameters.AddWithValue("@dataCompra", DateTime.Now);
                    exeContasReceber.Parameters.AddWithValue("@saldo", decimal.Parse(valorRestanteTextBox.Text));
                    exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 1);
                    exeContasReceber.Parameters.AddWithValue("@vendedorHaver", "NULL");
                    if (descricaoTextBox.Text != (""))
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    }
                    else
                    {
                        exeContasReceber.Parameters.AddWithValue("@descricao", labelNomeCliente.Text);
                    }

                    banco.conectar();
                    exeContasReceber.ExecuteNonQuery();
                    banco.desconectar();
                    #endregion
                }
            }
            #endregion

            if (FormaPagamento == 6)
            {
                MessageBox.Show("ORÇAMENTO REALIZA COM SUCESSO!!!!!");
            }
            else
            {
                MessageBox.Show("VENDA REALIZA COM SUCESSO!!!!!");
            }

            tudoCerto = false;
        }

        private void frmFinalizarVenda_KeyDown(object sender, KeyEventArgs e)
        {
            //
            if (e.KeyCode == Keys.Escape)
            {
                instancia.codigoBarraTextBox.Focus();
                limparValores();
                this.Close();
            }

            /*if (e.KeyCode == Keys.F4)
            {
                frmAcrecimoVenda acrevimo = new frmAcrecimoVenda();
                acrevimo.ShowDialog();
                acrevimo.Dispose();

                subTotal = subTotal + acrevimo._Valor;

                descontoTextBox_TextChanged(sender, e);
            }*/


            if (e.KeyCode == Keys.F5 && tudoCerto == true)
            {
                pagamentoEmAndamento = true;

                if (pagamentoEmAndamento)
                {
                    try
                    {
                        if (labelSituacao.Text != "CONGELADA")
                        {
                            if (labelSituacao.Text != "FECHADA")
                            {
                                processarPagamento();

                                #region GerarCupomNãoFiscal - A VISTA
                                if (FormaPagamento == 1 || FormaPagamento == 2)
                                {
                                    frmCupomNaoFiscalA_Vista abrirCupom_aVista = new frmCupomNaoFiscalA_Vista(this);
                                    abrirCupom_aVista.ShowDialog();
                                    abrirCupom_aVista.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - CONTAS A RECEBER
                                if (FormaPagamento == 3 || FormaPagamento == 7)
                                {
                                    frmCumpoNaoFiscal abrirCupomReceber = new frmCumpoNaoFiscal(this);
                                    abrirCupomReceber.ShowDialog();
                                    abrirCupomReceber.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - ORCAMENTO
                                if (FormaPagamento == 6)
                                {
                                    frmCumpoNaoFiscal abrirCupomOrcamento = new frmCumpoNaoFiscal(this);
                                    abrirCupomOrcamento.ShowDialog();
                                    abrirCupomOrcamento.Dispose();
                                }
                                #endregion

                                limparValores();
                            }
                            else
                            {
                                MessageBox.Show("Esta se encontra FECHADA não pode ser usada!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Esta se encontra CONGELA e não pode ser usada!" + "\n" + "\n" + "Desesja continuar a Venda?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                processarPagamento();

                                #region GerarCupomNãoFiscal - A VISTA
                                if (FormaPagamento == 1 || FormaPagamento == 2)
                                {
                                    frmCupomNaoFiscalA_Vista abrirCupom_aVista = new frmCupomNaoFiscalA_Vista(this);
                                    abrirCupom_aVista.ShowDialog();
                                    abrirCupom_aVista.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - CONTAS A RECEBER
                                if (FormaPagamento == 3 || FormaPagamento == 7)
                                {
                                    frmCumpoNaoFiscal abrirCupomReceber = new frmCumpoNaoFiscal(this);
                                    abrirCupomReceber.ShowDialog();
                                    abrirCupomReceber.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - ORCAMENTO
                                if (FormaPagamento == 6)
                                {
                                    frmCumpoNaoFiscal abrirCupomOrcamento = new frmCumpoNaoFiscal(this);
                                    abrirCupomOrcamento.ShowDialog();
                                    abrirCupomOrcamento.Dispose();
                                }
                                #endregion

                                limparValores();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }

            }       
        }

        private void frmFinalizarVenda_Load(object sender, EventArgs e)
        {
            #region Abrindo Tabelas
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            #endregion

            vendedorComboBox.SelectedValue = 8;
            FormaPagamento = 7;
            formaPagamentoTextBox.Text = "CONTAS A RECEBER";

            valorPagoTextBox.Text = ("0,00");
            descontoTextBox.Text = ("0,00");

            subtotalTextBox.Text = Convert.ToDecimal(instancia.TotalGeralTextBox.Text).ToString();
            subTotalGeral = decimal.Parse(instancia.TotalGeralTextBox.Text);
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

                resultadoDesconto = subTotalGeral - desconto;
                subTotal = resultadoDesconto;

                subtotalTextBox.Text = Convert.ToDecimal(subTotal).ToString();

                valorPagoTextBox_TextChanged(sender, e);


                if (desconto >= subTotalGeral)
                {
                    resultadoDesconto = 0;
                    subTotal = resultadoDesconto;

                    subtotalTextBox.Text = Convert.ToDecimal(subTotal).ToString();

                    valorPagoTextBox_TextChanged(sender, e);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valorPagoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (descontoTextBox.Text == "")
                {
                    desconto = 0;
                }

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            instancia.codigoBarraTextBox.Focus();
            limparValores();
            this.Close();
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
            if (e.KeyCode == Keys.D4)
            {
                FormaPagamento = 6;
                formaPagamentoTextBox.Text = "ORCAMENTO";
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

        private void vendedorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (vendedorComboBox.Text != "-----")
                {
                    try
                    {
                        SqlCommand exePesquisa = new SqlCommand("SELECT nome FROM Clientes", banco.connection);
                        banco.conectar();
                        SqlDataReader dr = exePesquisa.ExecuteReader();
                        AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                        while (dr.Read())
                        {
                            lista.Add(dr.GetString(0));
                        }
                        textBoxPesquisaCliente.AutoCompleteCustomSource = lista;
                        banco.desconectar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

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

        private void textBoxPesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPesquisaCliente.Text != "")
                {
                    this.clientesTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Clientes, textBoxPesquisaCliente.Text);
                    this.joinContasReceberTableAdapter.queryPesquisa(this.drogariaParanaDataSet.JoinContasReceber, textBoxPesquisaCliente.Text);

                    if (labelSituacao.Text == "CONGELADA" || labelSituacao.Text == "FECHADA")
                    {
                        labelSituacao.ForeColor = Color.Red;
                    }

                    SendKeys.Send("{TAB}");

                    tudoCerto = true;
                }
                else
                {
                    MessageBox.Show("ERRO: O Nome do Cliente não pode estar Vazio, adicione um nome e tente novamente!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPesquisaCliente.Focus();
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
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
            if (e.KeyCode == Keys.Enter && tudoCerto == true)
            {
                pagamentoEmAndamento = true;

                if (pagamentoEmAndamento)
                {
                    if (labelSituacao.Text != "CONGELADA")
                    {
                        if (labelSituacao.Text != "FECHADA")
                        {
                            if (MessageBox.Show("DESEJA CONCLUIR A VENDA?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir a Venda usando F5!  :-) ", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                processarPagamento();

                                #region GerarCupomNãoFiscal - A VISTA
                                if (FormaPagamento == 1 || FormaPagamento == 2)
                                {
                                    frmCupomNaoFiscalA_Vista abrirCupom_aVista = new frmCupomNaoFiscalA_Vista(this);
                                    abrirCupom_aVista.ShowDialog();
                                    abrirCupom_aVista.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - CONTAS A RECEBER
                                if (FormaPagamento == 3 || FormaPagamento == 7)
                                {
                                    frmCumpoNaoFiscal abrirCupomReceber = new frmCumpoNaoFiscal(this);
                                    abrirCupomReceber.ShowDialog();
                                    abrirCupomReceber.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - ORCAMENTO
                                if (FormaPagamento == 6)
                                {
                                    frmCumpoNaoFiscal abrirCupomOrcamento = new frmCumpoNaoFiscal(this);
                                    abrirCupomOrcamento.ShowDialog();
                                    abrirCupomOrcamento.Dispose();
                                }
                                #endregion

                                limparValores();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esta se encontra FECHADA e não pode ser usada!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Esta se encontra CONGELA e não pode ser usada!" + "\n" + "\n" + "Desesja continuar a Venda?", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (MessageBox.Show("DESEJA CONCLUIRO A VENDA?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir a Venda usando F5!  :-) ", "Aviso de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                processarPagamento();

                                #region GerarCupomNãoFiscal - A VISTA
                                if (FormaPagamento == 1 || FormaPagamento == 2)
                                {
                                    frmCupomNaoFiscalA_Vista abrirCupom_aVista = new frmCupomNaoFiscalA_Vista(this);
                                    abrirCupom_aVista.ShowDialog();
                                    abrirCupom_aVista.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - CONTAS A RECEBER
                                if (FormaPagamento == 3 || FormaPagamento == 7)
                                {
                                    frmCumpoNaoFiscal abrirCupomReceber = new frmCumpoNaoFiscal(this);
                                    abrirCupomReceber.ShowDialog();
                                    abrirCupomReceber.Dispose();
                                }
                                #endregion


                                #region GerarCupomNaoFiscal - ORCAMENTO
                                if (FormaPagamento == 6)
                                {
                                    frmCumpoNaoFiscal abrirCupomOrcamento = new frmCumpoNaoFiscal(this);
                                    abrirCupomOrcamento.ShowDialog();
                                    abrirCupomOrcamento.Dispose();
                                }
                                #endregion

                                limparValores();
                            }
                        }
                    }
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void descontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }
    }
}