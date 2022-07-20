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
    public partial class frmReceber : Form
    {

        #region Variaveis e Intancias
        conexao banco = new conexao();

        frmContasReceber instancia;

        int ID = 0, FormaPagamento = 1, parcela;

        string idSituacao, DiaAtual, ultimoDia, codigoHaver, AlterarNota_TipoDeAcao, documentoRefresh;

        decimal subtotal = 0, subtotalGeral = 0, valorRestante = 0, valorPago = 0, desconto = 0;

        decimal TotalGeral_Conta;

        TimeSpan date;

        bool pesquisado = false;
        #endregion

        public string _codigoHaverCupom { get; set; }
        public string _StausDaImpressoa { get; set; }
        public string _StatusDoCupom { get; set; }
        public int _idCliente { get; set; }

        public frmReceber(frmContasReceber receber)
        {
            InitializeComponent();
            instancia = receber;

            ID = int.Parse(instancia.contasReceberDataGridView.CurrentRow.Cells[7].Value.ToString());
            labelNomeClienteCabecalho.Text = instancia.contasReceberDataGridView.CurrentRow.Cells[0].Value.ToString();

            _idCliente = ID;
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

        #region Metodos de Pagamento - Dados da Venda
        private void atualizarDadosVenda_ApenasUmaConta()
        {
            #region QuerySQL
            string Vendas = ("UPDATE Vendas SET dataEmissao = @dataEmissao, idVendedor = @idVendedor, idFormaPagamento = @idFormaPagamento, idSituacao = @idSituacao WHERE Ndocumento = @NOTA");
            SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
            #endregion


            #region Atualizando Tabela de Venda
            exeVendas.Parameters.AddWithValue("@NOTA", dataGridViewApagar.CurrentRow.Cells[8].Value.ToString());
            exeVendas.Parameters.AddWithValue("@dataEmissao", DateTime.Now);
            exeVendas.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
            exeVendas.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
            exeVendas.Parameters.AddWithValue("@idSituacao", 1);

            //
            banco.conectar();
            exeVendas.ExecuteNonQuery();
            banco.desconectar();
            #endregion      
        }

        private void atualizarDadosVenda_ParcialOuCompleto()
        {
            #region QuerySQL
            string Vendas = ("UPDATE Vendas SET dataEmissao = @dataEmissao, idVendedor = @idVendedor, idFormaPagamento = @idFormaPagamento, idSituacao = @idSituacao WHERE Ndocumento = @NOTA");
            SqlCommand exeVendaCompleta = new SqlCommand(Vendas, banco.connection); 
            #endregion


            #region Atualizando Tabela de Venda
            for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; ++i)
            {
                exeVendaCompleta.Parameters.Clear();
                exeVendaCompleta.Parameters.AddWithValue("@NOTA", dataGridViewApagar.Rows[i].Cells[8].Value.ToString());
                exeVendaCompleta.Parameters.AddWithValue("@dataEmissao", DateTime.Now);
                exeVendaCompleta.Parameters.AddWithValue("@idVendedor", int.Parse(vendedorComboBox.SelectedValue.ToString()));
                exeVendaCompleta.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
                exeVendaCompleta.Parameters.AddWithValue("@idSituacao", 1);

                //
                banco.conectar();
                exeVendaCompleta.ExecuteNonQuery();
                banco.desconectar();
            }
            #endregion
        }
        #endregion

        #region Metodos de Pagamento - Movimento de Caixa/Fluxo de Caixa
        private void registrarMovimento_ApenasUmaConta()
        {
            #region QuerySQL
            string FluxoCaixa = ("INSERT INTO FluxoCaixa (Ndocumento, descricao, data, credito, debito) VALUES (@Ndocumento, @descricao, @data, @credito, @debito)");
            SqlCommand exeFluxoCaixa = new SqlCommand(FluxoCaixa, banco.connection);
            #endregion


            #region Registrando Fluxo de Caixa
            exeFluxoCaixa.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.CurrentRow.Cells[8].Value.ToString());
            exeFluxoCaixa.Parameters.AddWithValue("@data", DateTime.Now);
            exeFluxoCaixa.Parameters.AddWithValue("@credito", decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString()));
            exeFluxoCaixa.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));
            exeFluxoCaixa.Parameters.AddWithValue("@descricao", labelNomeClienteCabecalho.Text + " - " + dataGridViewApagar.CurrentRow.Cells[1].Value.ToString());


            banco.conectar();
            exeFluxoCaixa.ExecuteNonQuery();
            banco.desconectar();
            #endregion
        }

        private void registrarMovimento_ParcialOuCompleto()
        {
            #region Query das Tabelas
            string FluxoCaixa = ("INSERT INTO FluxoCaixa (Ndocumento, descricao, data, credito, debito) VALUES (@Ndocumento, @descricao, @data, @credito, @debito)");
            SqlCommand exeFluxoCaixaCompleta = new SqlCommand(FluxoCaixa, banco.connection); 
            #endregion

            #region Variaveis
            // Adiciona o valor da variavel Valor Pago a outra variavel
            // Assim o sistema não meche na Vairavel Valor Pago, e sim na de Valor Disponivel
            // 
            // A variavel Valor Pago não pode ser alterada em gipotese alguma, ja que outros metodos usam ela também.

            decimal valorDisponivel = valorPago;
            int parcelaCondicao;
            #endregion

            #region Registrando Fluxo de Caixa
            parcela = int.Parse(dataGridViewApagar.CurrentRow.Cells[6].Value.ToString());

            if (parcela == 0)
            {
                parcela = 1;
            }

            for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; ++i)
            {
                //Variavel que armazena o Valor Total de cada conta separada
                decimal subTotalRows = decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString());

                exeFluxoCaixaCompleta.Parameters.Clear();
                exeFluxoCaixaCompleta.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.Rows[i].Cells[8].Value.ToString());
                exeFluxoCaixaCompleta.Parameters.AddWithValue("@data", DateTime.Now);

                if (valorDisponivel <= 0)
                {
                    break;
                }
                else
                {
                    if (valorDisponivel >= subTotalRows)
                    {
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@credito", subTotalRows);
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@descricao", labelNomeClienteCabecalho.Text + " - " + dataGridViewApagar.Rows[i].Cells[1].Value.ToString() + " - Parc. " + parcela);

                    }
                    else
                    {
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@credito", valorDisponivel);
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@debito", decimal.Parse("0,00"));
                        exeFluxoCaixaCompleta.Parameters.AddWithValue("@descricao", labelNomeClienteCabecalho.Text + " - " + dataGridViewApagar.Rows[i].Cells[1].Value.ToString() + " - Parc. " + parcela);
                    }

                    valorDisponivel = valorDisponivel - subTotalRows;
                }
                //
                //
                banco.conectar();
                exeFluxoCaixaCompleta.ExecuteNonQuery();
                banco.desconectar();
            }
            #endregion
        }
        #endregion

        #region Metodos de Pagamento - Contas a Receber
        private void registrarContaReceber_ApenasUmaConta()
        {
            #region QuerySQL
            string ContasReceber = ("UPDATE ContasReceber SET idSituacao = @idSituacao, idFormaRecebimento = @idFormaRecebimento, parcela = @parcela, valorPacela = @valorParcela, vendedorHaver = @Vendedor, idSituacaoCliente = @idSituacaoCliente, ultimoHaver = @ultimoHaver, valorHaver = @valorHaver, saldo = @saldo, idSituacaoConta = @idSituacaoConta, dataCupom = @dataCupom, codigoHaver = @codigoHaver WHERE Ndocumento = @Ndocumento AND parcela = @parcelaCondicao");
            SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
            #endregion

            #region Atualizando Tabela Contas a Receber
            parcela = 0;
            int parcelaCondicao = int.Parse(dataGridViewApagar.CurrentRow.Cells[6].Value.ToString());
            parcela = int.Parse(dataGridViewApagar.CurrentRow.Cells[6].Value.ToString());

            if (parcela == 0)
            {
                parcela = 1;
            }

            exeContasReceber.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.CurrentRow.Cells[8].Value.ToString());
            exeContasReceber.Parameters.AddWithValue("@idSituacao", 2);
            exeContasReceber.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
            exeContasReceber.Parameters.AddWithValue("@parcela", parcela);
            exeContasReceber.Parameters.AddWithValue("@valorParcela", decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString()));
            exeContasReceber.Parameters.AddWithValue("@Vendedor", vendedorComboBox.Text);
            exeContasReceber.Parameters.AddWithValue("@idSituacaoCliente", 1);
            exeContasReceber.Parameters.AddWithValue("@ultimoHaver", DateTime.Parse(DateTime.Now.ToShortDateString()));
            exeContasReceber.Parameters.AddWithValue("@valorHaver", decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString()));
            exeContasReceber.Parameters.AddWithValue("@saldo", 0);
            exeContasReceber.Parameters.AddWithValue("@dataCupom", DateTime.Parse(DateTime.Now.ToShortDateString()));
            exeContasReceber.Parameters.AddWithValue("@idSituacaoConta", 5);
            exeContasReceber.Parameters.AddWithValue("@parcelaCondicao", parcelaCondicao);
            exeContasReceber.Parameters.AddWithValue("@codigoHaver", codigoHaver);

            //
            banco.conectar();
            exeContasReceber.ExecuteNonQuery();
            banco.desconectar();
            #endregion
        }

        private void registrarContaReceber_ParcialOuCompleto()
        {
            #region QuerySQL
            string ContasReceber_Insert = ("INSERT INTO ContasReceber (Ndocumento, total, idCliente, idSituacao, idFormaRecebimento, descricao, dataCompra, parcela, valorPacela, idVendedor, idSituacaoCliente, saldo, idSituacaoConta, vendedorHaver) VALUES (@Ndocumento, @total, @idCliente, @idSituacao, @idFormaRecebimento, @descricao, @dataCompra, @parcela, @valorParcela, @idVendedor, @idSituacaoCliente, @saldo, @idSituacaoConta, @vendedorHaver)");
            string ContasReceber = ("UPDATE ContasReceber SET idSituacao = @idSituacao, idFormaRecebimento = @idFormaRecebimento, parcela = @parcela, valorPacela = @valorParcela, vendedorHaver = @Vendedor, idSituacaoCliente = @idSituacaoCliente, ultimoHaver = @ultimoHaver, valorHaver = @valorHaver, saldo = @saldo, idSituacaoConta = @idSituacaoConta, dataCupom = @dataCupom, descricao = @descricaoVenda, codigoHaver = @codigoHaver WHERE Ndocumento = @Ndocumento AND parcela = @parcelaCondicao");
            SqlCommand exeContaReceberInsert = new SqlCommand(ContasReceber_Insert, banco.connection);
            SqlCommand exeContasReceberCompleta = new SqlCommand(ContasReceber, banco.connection);
            #endregion

            #region Variaveis
            // Adiciona o valor da variavel Valor Pago a outra variavel
            // Assim o sistema não meche na Vairavel Valor Pago, e sim na de Valor Disponivel
            // 
            // A variavel Valor Pago não pode ser alterada em gipotese alguma, ja que outros metodos usam ela também.

            decimal valorDisponivel = valorPago, diferenca, valorReceber, subTotalLiquido = decimal.Parse(subtotalTextBox.Text);
            int parcelaCondicao, novaParcela;
            #endregion

            #region Atualizando Tabela Contas a Recebe 

            for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; ++i)
            {
                novaParcela = int.Parse(dataGridViewApagar.Rows[i].Cells[6].Value.ToString());
                parcelaCondicao = int.Parse(dataGridViewApagar.Rows[i].Cells[6].Value.ToString());
                parcela = int.Parse(dataGridViewApagar.Rows[i].Cells[6].Value.ToString());
                valorReceber = decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString());

                if (parcela == 0)
                {
                    parcela = 1;
                }


                if (novaParcela == 0)
                {
                    novaParcela = 1;
                }

                if (valorDisponivel <= 0)
                {
                    break;
                }
                else
                {
                    if (valorDisponivel >= valorReceber)
                    {
                        exeContasReceberCompleta.Parameters.Clear();
                        exeContasReceberCompleta.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.Rows[i].Cells[8].Value.ToString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
                        exeContasReceberCompleta.Parameters.AddWithValue("@parcela", parcela);
                        exeContasReceberCompleta.Parameters.AddWithValue("@Vendedor", vendedorComboBox.Text);
                        exeContasReceberCompleta.Parameters.AddWithValue("@dataCupom", DateTime.Now.ToShortDateString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacao", 2);
                        exeContasReceberCompleta.Parameters.AddWithValue("@valorParcela", decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString()));//
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacaoCliente", 2);
                        exeContasReceberCompleta.Parameters.AddWithValue("@ultimoHaver", DateTime.Now);
                        exeContasReceberCompleta.Parameters.AddWithValue("@valorHaver", decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString()));
                        exeContasReceberCompleta.Parameters.AddWithValue("@saldo", 0);
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacaoConta", 5);
                        exeContasReceberCompleta.Parameters.AddWithValue("@descricaoVenda", dataGridViewApagar.Rows[i].Cells[1].Value.ToString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@parcelaCondicao", parcelaCondicao);
                        exeContasReceberCompleta.Parameters.AddWithValue("@codigoHaver", codigoHaver);
                    }
                    else
                    {
                        diferenca = valorReceber - valorDisponivel;

                        if (diferenca == desconto)
                        {
                            diferenca = 0;
                            valorDisponivel = valorReceber;
                        }

                        #region Da baixa no valor que foi pago

                        exeContasReceberCompleta.Parameters.Clear();
                        exeContasReceberCompleta.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.Rows[i].Cells[8].Value.ToString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@idFormaRecebimento", FormaPagamento);
                        exeContasReceberCompleta.Parameters.AddWithValue("@parcela", parcela);
                        exeContasReceberCompleta.Parameters.AddWithValue("@Vendedor", vendedorComboBox.Text);
                        exeContasReceberCompleta.Parameters.AddWithValue("@dataCupom", DateTime.Now.ToShortDateString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacao", 2);
                        exeContasReceberCompleta.Parameters.AddWithValue("@valorParcela", valorDisponivel);
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacaoCliente", 2);
                        exeContasReceberCompleta.Parameters.AddWithValue("@ultimoHaver", DateTime.Now);
                        exeContasReceberCompleta.Parameters.AddWithValue("@valorHaver", valorDisponivel);
                        exeContasReceberCompleta.Parameters.AddWithValue("@idSituacaoConta", 1);
                        exeContasReceberCompleta.Parameters.AddWithValue("@saldo", diferenca);
                        exeContasReceberCompleta.Parameters.AddWithValue("@parcelaCondicao", parcelaCondicao);
                        exeContasReceberCompleta.Parameters.AddWithValue("@descricaoVenda", dataGridViewApagar.Rows[i].Cells[1].Value.ToString());
                        exeContasReceberCompleta.Parameters.AddWithValue("@codigoHaver", codigoHaver);

                        #endregion

                        if (diferenca <= 0)
                        {
                            valorDisponivel = valorDisponivel - valorReceber;

                            banco.conectar();
                            exeContasReceberCompleta.ExecuteNonQuery();
                            banco.desconectar();

                            break;
                        }
                        else
                        {
                            #region Gera uma nova parcela

                            exeContaReceberInsert.Parameters.Clear();
                            exeContaReceberInsert.Parameters.AddWithValue("@Ndocumento", dataGridViewApagar.Rows[i].Cells[8].Value.ToString());
                            exeContaReceberInsert.Parameters.AddWithValue("@idFormaRecebimento", 7);
                            exeContaReceberInsert.Parameters.AddWithValue("@parcela", novaParcela + 1);
                            exeContaReceberInsert.Parameters.AddWithValue("@idSituacao", 1);
                            exeContaReceberInsert.Parameters.AddWithValue("@valorParcela", decimal.Parse("0,00"));
                            exeContaReceberInsert.Parameters.AddWithValue("@idSituacaoCliente", 2);
                            exeContaReceberInsert.Parameters.AddWithValue("@idSituacaoConta", 1);
                            exeContaReceberInsert.Parameters.AddWithValue("@saldo", diferenca);
                            exeContaReceberInsert.Parameters.AddWithValue("@total", diferenca);
                            exeContaReceberInsert.Parameters.AddWithValue("@idCliente", ID);
                            exeContaReceberInsert.Parameters.AddWithValue("@idVendedor", dataGridViewApagar.Rows[i].Cells[10].Value.ToString());
                            exeContaReceberInsert.Parameters.AddWithValue("@dataCompra", DateTime.Parse(dataGridViewApagar.Rows[i].Cells[0].Value.ToString()));
                            exeContaReceberInsert.Parameters.AddWithValue("@vendedorHaver", "NULL");
                            exeContaReceberInsert.Parameters.AddWithValue("@descricao", dataGridViewApagar.Rows[i].Cells[1].Value.ToString());

                            banco.conectar();
                            exeContaReceberInsert.ExecuteNonQuery();
                            banco.desconectar();

                            #endregion
                        }
                    }

                    valorDisponivel = valorDisponivel - valorReceber;
                }
                //
                banco.conectar();
                exeContasReceberCompleta.ExecuteNonQuery();
                banco.desconectar();
            }
            #endregion

            novaParcela = 0;
            parcela = 0;
            parcelaCondicao = 0;
        }
        #endregion

        #region Metodo de Pagamento - Relacao Haver
        private void atualizarRelacaHaver()
        {
            #region QuerySQL
            string RelacaoHaver = ("UPDATE RelacaoHaver SET idSituacaoConta = @idSituacaoConta, ultimoHaver = @ultimoHaver, valorHaver = @valorHaver WHERE idCliente = @IDcliente");
            SqlCommand exeRelacaoHaver = new SqlCommand(RelacaoHaver, banco.connection);
            #endregion

            #region Atualizando Tabela Relacao Haver
            exeRelacaoHaver.Parameters.AddWithValue("@IDcliente", ID);
            exeRelacaoHaver.Parameters.AddWithValue("@idSituacaoConta", 1);
            exeRelacaoHaver.Parameters.AddWithValue("@ultimoHaver", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            exeRelacaoHaver.Parameters.AddWithValue("@valorHaver", valorPago);

            banco.conectar();
            exeRelacaoHaver.ExecuteNonQuery();
            banco.desconectar();
            #endregion
        }
        #endregion

        #region Metodo de Pagamento - HaverContasReceber
        private void registrarHaverContasReceber()
        {
            #region QuerySQL
            string haver = ("INSERT INTO HaverContasReceber (idCliente, codigoHaver, descricao, dataPagamento, situacaoHaver, totalHaver, vendedorHaver, idSituacao, idVendedor, idFormaPagamento, totalDivida, desconto) VALUES (@idCliente, @codigoHaver, @descricao, @dataPagamento, @situacaoHaver, @totalHaver, @vendedorHaver, @idSituacao, @idVendedor, @idFormaPagamento, @totalDivida, @desconto)");
            SqlCommand exeHaver = new SqlCommand(haver, banco.connection);
            #endregion

            #region Registra os dados do Haver
            exeHaver.Parameters.Clear();
            exeHaver.Parameters.AddWithValue("@idCliente", ID);
            exeHaver.Parameters.AddWithValue("@codigoHaver", codigoHaver);
            exeHaver.Parameters.AddWithValue("@descricao", dataGridViewApagar.CurrentRow.Cells[1].Value.ToString());
            exeHaver.Parameters.AddWithValue("@dataPagamento", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            exeHaver.Parameters.AddWithValue("@situacaoHaver", "PAGO");
            exeHaver.Parameters.AddWithValue("@totalHaver", valorPago);
            exeHaver.Parameters.AddWithValue("@vendedorHaver", vendedorComboBox.Text);
            exeHaver.Parameters.AddWithValue("@idSituacao", 2);
            exeHaver.Parameters.AddWithValue("@idVendedor", vendedorComboBox.SelectedValue);
            exeHaver.Parameters.AddWithValue("@idFormaPagamento", FormaPagamento);
            exeHaver.Parameters.AddWithValue("@totalDivida", TotalGeral_Conta);
            exeHaver.Parameters.AddWithValue("@desconto", desconto);

            banco.conectar();
            exeHaver.ExecuteNonQuery();
            banco.desconectar();
            #endregion
        }
        #endregion

        private void limparValores()
        {
            labelAjudaPagamentoConta1.Visible = false;
            labelAjudaPagamentoConta2.Visible = false;

            this.relacaoContasTableAdapter.queryID_(this.drogariaParanaDataSet.RelacaoContas, ID);
            this.listaContasTableAdapter.queryHistorico(this.drogariaParanaDataSet.ListaContas, codigoHaver);
            this.dataGridViewApagar.Refresh();
            this.dataGridViewHistorico.Refresh();
            this.dataGridViewAlterarNota.Refresh();

            this.haverContasReceberTableAdapter.queryID(drogariaParanaDataSet.HaverContasReceber, ID);
            this.dataGridViewDetalhesHaver.Refresh();


            subtotal = 0;
            valorPago = 0;
            valorRestante = 0;
            desconto = 0;
            FormaPagamento = 0;
            parcela = 0;

            subtotalTextBox.Text = "0,00";
            valorPagoTextBox.Text = "0,00";
            descontoTextBox.Text = "0,00";
            textBoxValorRestante.Text = "0,00";

            cabeçalho();
            
        }

        private void ProcessarPagamento()
        {
            _idCliente = ID;
            _StausDaImpressoa = "normal";

            if (radPagarPacial_Completa.Checked == true && pesquisado == false)
            {
                this.relacaoContasTableAdapter.queryID_ASC(this.drogariaParanaDataSet.RelacaoContas, ID);
            }

            #region gerador de codigoHaver
            Random randNum = new Random(DateTime.Now.Year);

            codigoHaver = null;
            codigoHaver = ("" + DateTime.Now.Millisecond + randNum.Next(DateTime.Now.Year) + DateTime.Now.Second + vendedorComboBox.SelectedValue + ID);

            _codigoHaverCupom = codigoHaver;

            #endregion

            if (radPagarPacial_Completa.Checked == true)
            {           
                registrarContaReceber_ParcialOuCompleto();

                registrarMovimento_ParcialOuCompleto();

                atualizarDadosVenda_ParcialOuCompleto();

                atualizarRelacaHaver();

                registrarHaverContasReceber();
            }

            if (radApenasUmaConta.Checked == true)
            {
                atualizarDadosVenda_ApenasUmaConta();

                registrarMovimento_ApenasUmaConta();

                registrarContaReceber_ApenasUmaConta();

                atualizarRelacaHaver();

                registrarHaverContasReceber();
            }

            vendedorComboBox.Focus();

            MessageBox.Show("CONTA RECEBIDA COM SUCESSO!!!!!");

        }

        private void frmReceber_Load(object sender, EventArgs e)
        {
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            this.relacaoContasTableAdapter.queryID_(this.drogariaParanaDataSet.RelacaoContas, ID);
            
            cabeçalho();

            formaPagamentoTextBox.Text = "DINHEIRO";
            FormaPagamento = 1;
            dataGridViewApagar.Focus();
            panelAPagar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceber_KeyDown(object sender, KeyEventArgs e)
        {
            #region Botão ESC

            if (e.KeyCode == Keys.Escape)
            {
                #region KeyDown Panel A Pagar

                if (panelAPagar.Visible == true)
                {
                    checkBoxPesquisar.Enabled = true;
                    this.Close();
                }

                #region KeyDown Pesquisa Panel A PAGAR
                if (checkBoxPesquisar.Checked == true)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        try
                        {
                            this.relacaoContasTableAdapter.queryDescricao(this.drogariaParanaDataSet.RelacaoContas, textBoxPesquisaDescricao.Text, ID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                        return;
                    }
                }
                #endregion

                #endregion

                #region KeyDown Panel Pagamento

                if (panelPagamento.Visible == true)
                {
                    panelPagamento.Visible = false;
                    panelAPagar.Visible = true;
                    checkBoxPesquisar.Enabled = true;
                }

                #region KeyDown FormaPagamento
                try
                {
                    //
                    if (e.KeyCode == Keys.D1)
                    {
                        FormaPagamento = 1;
                        formaPagamentoTextBox.Text = "DINHEIRO";
                    }

                    if (e.KeyCode == Keys.D2)
                    {
                        FormaPagamento = 2;
                        formaPagamentoTextBox.Text = "DEBITO";
                    }

                    if (e.KeyCode == Keys.D3)
                    {
                        FormaPagamento = 3;
                        formaPagamentoTextBox.Text = "CREDITO";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                #endregion

                #endregion

                #region KeyDown Panel Historico de Pagamento

                if (panelHistorico.Visible == true)
                {
                    this.btnFecharHistorico_Click(sender, e);
                }

                #endregion

                #region KeyDow Panel Detalhes Haver

                if (panelDetalhesHaver.Visible == true)
                {
                    this.btnSairDetalhesHaver_Click(sender, e);
                }

                #endregion

                #region KeyDow Panel Alterar Nota

                if (panelAlterarNota.Visible == true)
                {
                    if (panelAlterarNotaBottom.Visible == true)
                    {
                        this.btnFecharAlterarNota_Bottom_Click(sender, e);
                    }
                    else
                    {
                        this.btnFecharAlterarNota_Click(sender, e);
                    }
                }

                #endregion

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }

            #endregion

            #region Botão F5

            if (e.KeyCode == Keys.F5)
            {
                if (vendedorComboBox.Text != "-----" && vendedorComboBox.Text != "")
                {
                    #region Pagamento de uma Unica Conta
                    if (radApenasUmaConta.Checked == true)
                    {
                        if (valorPago >= subtotal)
                        {
                            try
                            {
                                ProcessarPagamento();

                                frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
                                abrir.ShowDialog();
                                abrir.Dispose();

                                limparValores();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("" + ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O valor informado não cobre esta divida!" + "\n" + "Informe outro valor e tente novamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    #endregion

                    #region Pagamento Parcial ou Completo
                    if (radPagarPacial_Completa.Checked == true)
                    {
                        if (labelNomeClienteCabecalho.Text != "CLIENTE NAO CADASTRADO")
                        {
                            if (valorPago != 0)
                            {

                                try
                                {
                                    ProcessarPagamento();

                                    frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
                                    abrir.ShowDialog();
                                    abrir.Dispose();

                                    limparValores();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }

                            }
                            else
                            {
                                MessageBox.Show("O valor informado não cobre nenhuma divida existente!" + "\n" + "Informe outro valor e tente novamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            if (valorPago >= subtotal)
                            {
                                try
                                {
                                    ProcessarPagamento();

                                    frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
                                    abrir.ShowDialog();
                                    abrir.Dispose();

                                    limparValores();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este valor não pode ser dividido pois o Cliente não possui uma conta aberta." + "\n" + "Compras de clientes não cadastrados so podem ser pagas de 1x.");
                            }
                        }

                    }
                    #endregion

                    frmReceber_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Informe o Vendedor!!!");
                    vendedorComboBox.Focus();
                    
                }
                checkBoxPesquisar.Checked = false;
                panelPesquisa.Visible = false;
            }

            #endregion
        }

        #region Panel Informativo
        private void cabeçalho()
        {
            this.relacaoContasTableAdapter.queryID_(this.drogariaParanaDataSet.RelacaoContas, ID);
            this.dataGridViewApagar.Refresh();

            this.listaContasTableAdapter.queryHistorico(this.drogariaParanaDataSet.ListaContas, codigoHaver);
            this.listaContasTableAdapter.queryID(this.drogariaParanaDataSet.ListaContas, ID);
            this.dataGridViewHistorico.Refresh();
            this.dataGridViewAlterarNota.Refresh();

            this.haverContasReceberTableAdapter.queryID(drogariaParanaDataSet.HaverContasReceber, ID);
            this.dataGridViewDetalhesHaver.Refresh();

            this.relacaoVendasTableAdapter.queryReceber(drogariaParanaDataSet.RelacaoVendas, documentoRefresh);
            this.dataGridViewProdutosNota.Refresh();


            #region Divida Total
            TotalGeral_Conta = 0;

            for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; i++)
            {
                TotalGeral_Conta = TotalGeral_Conta + decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString());
            }

            labelDividaTotal.Text = ("R$ " + TotalGeral_Conta);
            #endregion

            #region UltimoPagamento
            //
            DiaAtual = DateTime.Now.ToShortDateString();

            try
            {
                ultimoDia = dataGridViewHistorico.CurrentRow.Cells[10].Value.ToString();
                date = Convert.ToDateTime(DiaAtual) - Convert.ToDateTime(ultimoDia);
                labelUtimoPagamento.Text = ("" + date.Days + " Dias");
            }
            catch
            {
                labelUtimoPagamento.Text = "0 Dias";
            }


            #endregion

            #region Status
            if (date.Days <= 30)
            {
                labelAvaliacao.Text = "Pagamento em dia!";
                labelAvaliacao.ForeColor = Color.LimeGreen;
            }

            if (date.Days > 30 && date.Days <= 40)
            {
                labelAvaliacao.Text = "Pagamento Regular!";
                labelAvaliacao.ForeColor = Color.Orange;
            }

            if (date.Days > 40 && date.Days < 60)
            {
                labelAvaliacao.Text = "Pagamento em Atraso!";
                labelAvaliacao.ForeColor = Color.OrangeRed;
            }

            if (date.Days >= 60)
            {
                labelAvaliacao.Text = "Conta com Pendências. *¬*";
                labelAvaliacao.ForeColor = Color.Red;
            }
            #endregion

            #region Situacao
            try
            {
                idSituacao = dataGridViewHistorico.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                idSituacao = "";
            }

            if (idSituacao == "1")
            {
                labelSituacaoConta.Text = "ABERTA";
                labelSituacaoConta.ForeColor = Color.Orange;
            }

            if (idSituacao == "2")
            {
                labelSituacaoConta.Text = "FECHADA";
                labelSituacaoConta.ForeColor = Color.Black;
            }

            if (idSituacao == "3")
            {
                labelSituacaoConta.Text = "CONGELADA";
                labelSituacaoConta.ForeColor = Color.Red;
            }

            if (idSituacao == "5")
            {
                labelSituacaoConta.Text = "CONTA QUITADA";
                labelSituacaoConta.ForeColor = Color.LimeGreen;
            }
            #endregion
        }

        private void buttonEfetuarPagamento_Click(object sender, EventArgs e)
        {
            if (TotalGeral_Conta != 0)
            {
                #region Evento do Panel
                if (panelAPagar.Visible == true)
                {
                    panelAPagar.Visible = false;
                }

                if (panelHistorico.Visible == true)
                {
                    panelHistorico.Visible = false;
                }

                if (panelPesquisa.Visible == true)
                {
                    panelPesquisa.Visible = false;
                }

                if (panelDetalhesHaver.Visible == true)
                {
                    panelDetalhesHaver.Visible = false;
                }

                if (panelAlterarNota.Visible == true)
                {
                    panelAlterarNota.Visible = false;
                    panelAlterarNotaBottom.Visible = false;
                }

                if (panelPagamento.Visible == false)
                {
                    panelPagamento.Visible = true;
                }
                #endregion

                vendedorComboBox.Focus();
                vendedorComboBox.SelectedValue = 8;
                checkBoxPesquisar.Enabled = false;
                radPagarPacial_Completa.Checked = true;

                //informa o nome do cliente,
                btnNomeFinalizaPag.Text = "Cliente: " + labelNomeClienteCabecalho.Text;

                try
                {
                    subtotal = 0;

                    for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; i++)
                    {
                        subtotal = subtotal + decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    subtotal = 0;
                }
                subtotalGeral = subtotal;
                subtotalTextBox.Text = Convert.ToDecimal(subtotal).ToString();
            }
            else
            {
                MessageBox.Show("No momento esta pessoa não possue Dividas com a Farmacia." + "\n" + "Tente novamente quando esta pessoa possuir Dividas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            #region Eventos - Visible
            if (panelPagamento.Visible == true)
            {
                panelPagamento.Visible = false;
            }

            if (panelAPagar.Visible == true)
            {
                panelAPagar.Visible = false;
            }

            if (panelPesquisa.Visible == true)
            {
                panelPesquisa.Visible = false;
            }

            if (panelDetalhesHaver.Visible == true)
            {
                panelDetalhesHaver.Visible = false;
            }

            if (panelAlterarNota.Visible == true)
            {
                panelAlterarNota.Visible = false;
                panelAlterarNotaBottom.Visible = false;
            }

            if (panelHistorico.Visible == false)
            {
                panelHistorico.Visible = true;
            }
            #endregion

            this.haverContasReceberTableAdapter.queryID(this.drogariaParanaDataSet.HaverContasReceber, ID);

            checkBoxPesquisar.Enabled = false;
            textBoxPesquisaDescricaoHistorico.Focus();
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            #region Eventos - Visible
            if (panelPagamento.Visible == true)
            {
                panelPagamento.Visible = false;
            }

            if (panelAPagar.Visible == true)
            {
                panelAPagar.Visible = false;
            }

            if (panelHistorico.Visible == true)
            {
                panelHistorico.Visible = false;
            }

            if (panelPesquisa.Visible == true)
            {
                panelPesquisa.Visible = false;
            }

            if (panelDetalhesHaver.Visible == true)
            {
                panelDetalhesHaver.Visible = false;
            }

            if (panelAlterarNota.Visible == false)
            {
                panelAlterarNota.Visible = true;
                panelAlterarNotaBottom.Visible = false;
            }
            #endregion

            checkBoxPesquisar.Enabled = false;

            this.listaContasTableAdapter.queryID(this.drogariaParanaDataSet.ListaContas, ID);
        }

        private void checkBoxPesquisar_CheckedChanged(object sender, EventArgs e)
        {
            #region Evento - Visible
            if (panelPesquisa.Visible == false)
            {
                panelPesquisa.Visible = true;
            }
            else
            {
                panelPesquisa.Visible = false;

                if (panelPagamento.Visible == false)
                {
                    this.relacaoContasTableAdapter.queryID_(this.drogariaParanaDataSet.RelacaoContas, ID);
                    pesquisado = false;
                }
            }
            #endregion

            textBoxPesquisaDescricao.Clear();
            textBoxPesquisaDescricao.Focus();
        }
        #endregion


        #region Panel A Pagar

        private void btnPesquisarDescricao_Click(object sender, EventArgs e)
        {
            try
            {
                this.relacaoContasTableAdapter.queryDescricao(this.drogariaParanaDataSet.RelacaoContas, textBoxPesquisaDescricao.Text, ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPesquisaDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelPesquisa.Visible == true)
            {
                try
                {
                    this.relacaoContasTableAdapter.queryDescricao(this.drogariaParanaDataSet.RelacaoContas, textBoxPesquisaDescricao.Text, ID);
                    pesquisado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        #endregion


        #region Panel Pagamento

        #region KeyDows

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

        private void formaPagamentoTextBox_KeyDown(object sender, KeyEventArgs e)
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
                //Virifica e atribui um valor a variavel desconto.
                if (descontoTextBox.Text == "")
                {
                    desconto = 0;
                }
                else
                {
                    desconto = decimal.Parse(descontoTextBox.Text);
                    descontoTextBox.Text = Convert.ToDecimal(desconto).ToString();
                }

                //Garante que o nome do Vendedor seja informado corretamente.
                if (vendedorComboBox.Text != "-----" && vendedorComboBox.Text != "")
                {
                    #region Pagamento de uma Unica Conta
                    if (radApenasUmaConta.Checked == true)
                    {
                        if (valorPago >= subtotal)
                        {
                            if (MessageBox.Show("DESEJA CONCLUIR O PAGAMENTO?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir o pagamento usando F5!  :-) ", "Deseja continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    ProcessarPagamento();

                                    frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
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
                        else
                        {
                            MessageBox.Show("O valor informado não cobre esta divida!" + "\n" + "Informe outro valor e tente novamente.");
                        }
                    }
                    #endregion

                    #region Pagamento Parcial ou Completo
                    if (radPagarPacial_Completa.Checked == true)
                    {
                        if (labelNomeClienteCabecalho.Text != "CLIENTE NAO CADASTRADO")
                        {
                            if (valorPago != 0)
                            {

                                if (MessageBox.Show("DESEJA CONCLUIR O PAGAMENTO?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir o pagamento usando F5!  :-) ", "Deseja continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    try
                                    {
                                        ProcessarPagamento();

                                        frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
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
                            else
                            {
                                MessageBox.Show("O valor informado não cobre nenhuma divida existente!" + "\n" + "Informe outro valor e tente novamente.");
                            }
                        }
                        else
                        {
                            if (valorPago >= subtotal)
                            {
                                if (MessageBox.Show("DESEJA CONCLUIR O PAGAMENTO?" + "\n" + "\n" + "LEMBRETE: Você também pode Concluir o pagamento usando F5!  :-) ", "Deseja continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    try
                                    {
                                        ProcessarPagamento();

                                        frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
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
                            else
                            {
                                MessageBox.Show("Este valor não pode ser dividido pois o Cliente não possui uma conta aberta." + "\n" + "Compras de clientes não cadastrados so podem ser pagas de 1x.");
                            }
                        }
                        
                    }
                    #endregion

                    frmReceber_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Informe o Vendedor!!!");
                    vendedorComboBox.Focus();
                    
                }
                checkBoxPesquisar.Checked = false;
                panelPesquisa.Visible = false;
            }
        }

        private void descontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (descontoTextBox.Text == "")
                {
                    desconto = 0;
                }
                else
                {
                    desconto = decimal.Parse(descontoTextBox.Text);
                    descontoTextBox.Text = Convert.ToDecimal(desconto).ToString();
                }
                valorPago = decimal.Parse(valorPagoTextBox.Text);
                valorPagoTextBox.Text = Convert.ToDecimal(valorPago).ToString();

                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }      
            
        }

        private void dataGridViewApagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radApenasUmaConta.Checked == true)
                {
                    if (vendedorComboBox.Text != "-----" && vendedorComboBox.Text != "")
                    {
                        panel_inferior.VerticalScroll.Value = 0;
                        formaPagamentoTextBox.Focus();

                    }
                    else
                    {
                        panel_inferior.VerticalScroll.Value = 0;
                        vendedorComboBox.Focus();
                    }

                    try
                    {
                        subtotal = 0;
                        subtotal = decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString());
                        subtotalTextBox.Text = Convert.ToDecimal(subtotal).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        #endregion

        private void btnFecharPagamento_Click(object sender, EventArgs e)
        {
            panelPagamento.Visible = false;
            panelAPagar.Visible = true;
            checkBoxPesquisar.Enabled = true;

            subtotal = 0;
            valorPago = 0;
            valorRestante = 0;
            desconto = 0;
            FormaPagamento = 0;
            parcela = 0;

            subtotalTextBox.Text = "0,00";
            valorPagoTextBox.Text = "0,00";
            descontoTextBox.Text = "0,00";
            textBoxValorRestante.Text = "0,00";

        }

        private void dataGridViewApagar_MouseClick(object sender, MouseEventArgs e)
        {
            if (radApenasUmaConta.Checked == true)
            {
                try
                {
                    subtotal = 0;
                    subtotal = decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString());
                    subtotalTextBox.Text = Convert.ToDecimal(subtotal).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //panel_inferior.VerticalScroll.Value = 0;
            }
        }

        private void radApenasUmaConta_CheckedChanged(object sender, EventArgs e)
        {
            if (panelAPagar.Visible == false)
            {
                checkBoxPesquisar.Enabled = true;
                panelAPagar.Visible = true;
            }

            try
            {
                subtotal = 0;
                subtotal = decimal.Parse(dataGridViewApagar.CurrentRow.Cells[7].Value.ToString());
            }
            catch (Exception)
            {
                subtotal = 0;
            }
            subtotalTextBox.Text = Convert.ToDecimal(subtotal).ToString();

            panel_inferior.VerticalScroll.Value = 500;
            dataGridViewApagar.Focus();

            labelAjudaPagamentoConta1.Visible = true;
            labelAjudaPagamentoConta2.Visible = true;
        }

        private void radPagarPacial_Completa_CheckedChanged(object sender, EventArgs e)
        {
            labelAjudaPagamentoConta1.Visible = false;
            labelAjudaPagamentoConta2.Visible = false;
            checkBoxPesquisar.Checked = false;
            checkBoxPesquisar.Enabled = false;

            if (panelAPagar.Visible == true)
            {
                panelAPagar.Visible = false;
            }

            try
            {
                subtotal = 0;

                for (int i = 0; i < dataGridViewApagar.Rows.Count - 0; i++)
                {
                    subtotal = subtotal + decimal.Parse(dataGridViewApagar.Rows[i].Cells[7].Value.ToString());
                }
            }
            catch (Exception)
            {
                subtotal = 0;
            }
            subtotalTextBox.Text = Convert.ToDecimal(subtotal).ToString();

            vendedorComboBox.Focus();
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
                subtotal = decimal.Parse(subtotalTextBox.Text);

                if (valorPago <= subtotal)
                {
                    valorRestante = subtotal - valorPago;

                    textBoxValorRestante.Text = Convert.ToDecimal(valorRestante).ToString();
                }
                else
                {
                    valorRestante = 0;

                    textBoxValorRestante.Text = Convert.ToDecimal(valorRestante).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                resultadoDesconto = subtotalGeral - desconto;
                valorRestante = resultadoDesconto - valorPago;

                subtotalTextBox.Text = Convert.ToDecimal(resultadoDesconto).ToString();
                textBoxValorRestante.Text = Convert.ToDecimal(valorRestante).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Panel Historico

        #region KeyDows
        
        private void textBoxPesquisaDescricaoHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelHistorico.Visible == true)
            {
                try
                {
                    this.haverContasReceberTableAdapter.queryPesquisa(drogariaParanaDataSet.HaverContasReceber, textBoxPesquisaDescricaoHistorico.Text, ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        #endregion

        private void btnFecharHistorico_Click(object sender, EventArgs e)
        {
            panelHistorico.Visible = false;
            panelAPagar.Visible = true;
            checkBoxPesquisar.Enabled = true;
        }

        private void dataGridViewHistorico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Id Situacao - Cabeçalho()
            if (idSituacao == "3")
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }

                if (e.Value.Equals("A PAGAR"))
                {
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
            else
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewHistorico.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                }
            }
        }

        private void btnPesquisarDescricaoHistorico_Click(object sender, EventArgs e)
        {
            try
            {
                this.haverContasReceberTableAdapter.queryPesquisa(drogariaParanaDataSet.HaverContasReceber, textBoxPesquisaDescricaoHistorico.Text, ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarData_Click(object sender, EventArgs e)
        {
            this.haverContasReceberTableAdapter.queryData(drogariaParanaDataSet.HaverContasReceber, DateTime.Parse(dateTimeDataPagamento.Text.ToString()), ID);
        }

        private void btnDetalhesHaver_Click(object sender, EventArgs e)
        {
            if (panelDetalhesHaver.Visible == false)
            {
                try
                {
                    this.listaContasTableAdapter.queryHistorico(this.drogariaParanaDataSet.ListaContas, dataGridViewDetalhesHaver.CurrentRow.Cells[5].Value.ToString());
                }
                catch
                {
                    this.listaContasTableAdapter.queryID(this.drogariaParanaDataSet.ListaContas, ID);
                }
                panelHistorico.Visible = false;
                panelDetalhesHaver.Visible = true;
            }
        }

        private void btnImprimirCupom_Click(object sender, EventArgs e)
        {
            try
            {
                _StausDaImpressoa = "resgatarCupom";
                _codigoHaverCupom = dataGridViewDetalhesHaver.CurrentRow.Cells[5].Value.ToString();

                frmCupomNaoFiscalContaReceber abrir = new frmCupomNaoFiscalContaReceber(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No momento este Cliente não possui CUPONS para serem resgatados." + "\n" + "Só será possivel resgatar um CUPOM de Haver apos o proximo pagamento!");
           }
        }

        #endregion


        #region Detalhes Haver

        #region KeyDows
        
        private void textBoxPesquisaDescricaoDetalhesCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelDetalhesHaver.Visible == true)
            {
                try
                {
                    this.listaContasTableAdapter.queryPesquisarDescricao(this.drogariaParanaDataSet.ListaContas, textBoxPesquisaDescricaoDetalhesCompra.Text, ID, dataGridViewDetalhesHaver.CurrentRow.Cells[5].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        #endregion

        private void btnVerProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                _StatusDoCupom = "ver produtos";

                frmDetalhesReceberCupom abrir = new frmDetalhesReceberCupom(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSairDetalhesHaver_Click(object sender, EventArgs e)
        {
            if (panelDetalhesHaver.Visible == true)
            {
                panelHistorico.Visible = true;
                panelDetalhesHaver.Visible = false;
                dataGridViewDetalhesHaver.Focus();
            }
        }

        private void btnBuscarDataDetalhesCompra_Click(object sender, EventArgs e)
        {
            if (dateTimeInicialAlterar.Text != dateTimeFinal.Text)
            {
                try
                {
                    this.listaContasTableAdapter.queryPesquisaData(this.drogariaParanaDataSet.ListaContas, DateTime.Parse(dateTimeInicialAlterar.Text), DateTime.Parse(dateTimeFinal.Text), ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, Verifique se as data estao inseridas corretamente, e tente novamente!");
                }
            }
            else
            {
                MessageBox.Show("As Datas informadas não podem ser iguais." + "\n" + "A Datas precisam ter pelo menos um dia de diferença!");
            }
        }

        private void btnPesquisarDetalhesCompra_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaContasTableAdapter.queryPesquisarDescricao(this.drogariaParanaDataSet.ListaContas, textBoxPesquisaDescricaoDetalhesCompra.Text, ID, dataGridViewDetalhesHaver.CurrentRow.Cells[5].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  

        private void dataGridViewDetalhesHaver_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //IdSituaca - Cabecalho()
            if (idSituacao == "3")
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }

                if (e.Value.Equals("A PAGAR"))
                {
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
            else
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewDetalhesHaver.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                }
            }
        }

        #endregion


        #region Alterar Nota

        #region KeyDows

        private void textBoxQuantidadeATN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelAlterarNotaBottom.Visible == true)
            {
                if (textBoxQuantidadeATN.Text != "" && textBoxQuantidadeATN.Text != "0")
                {
                    btnConfirmarATN.Focus();

                    e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                    return;
                }
                else
                {
                    MessageBox.Show("Erro: A quantidade não pode estar vazia ou igual a 0.");
                }
            }
        }

        private void dataGridViewProdutosNota_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNomeProdutoATN.Text = dataGridViewProdutosNota.CurrentRow.Cells[1].Value.ToString();
            textBoxValorUnitarioATN.Text = dataGridViewProdutosNota.CurrentRow.Cells[3].Value.ToString();
            textBoxQuantidadeATN.Text = dataGridViewProdutosNota.CurrentRow.Cells[2].Value.ToString();
        }

        private void textDescricaoAlterarNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panelAlterarNotaBottom.Visible == true)
            {
                try
                {
                    this.listaContasTableAdapter.queryPesquisaAlterarNota(this.drogariaParanaDataSet.ListaContas, textDescricaoAlterarNota.Text, ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        #endregion

        private void btnFecharAlterarNota_Click(object sender, EventArgs e)
        {
            if (panelAlterarNota.Visible == true)
            {
                panelAlterarNotaBottom.Visible = false;
                panelAlterarNota.Visible = false;
                panelAPagar.Visible = true;

                checkBoxPesquisar.Enabled = true;
            }
        }

        private void btnAlterarProduroATN_Click(object sender, EventArgs e)
        {
            textBoxNomeProdutoATN.Clear();
            textBoxValorUnitarioATN.Text = "0,00";
            textBoxQuantidadeATN.Text = "0";
            textBoxValorTotalATN.Text = "0,00";

            #region Variaveis e Instancias
            int parcela = 0;
            string situacao = "", documento = "";

            documento = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
            parcela = int.Parse(dataGridViewAlterarNota.CurrentRow.Cells[6].Value.ToString());
            situacao = dataGridViewAlterarNota.CurrentRow.Cells[4].Value.ToString();
            #endregion

            if (situacao != "PAGO" && parcela == 0)
            {
                #region Renomear Labels
                labelTitleAltera_ExcluirATN.Text = "Alterando Produto:";
                labelAltera_ExcluirATN.Text = "Alterar:";
                #endregion

                AlterarNota_TipoDeAcao = "alterar";
                panelAlterarNotaBottom.Visible = true;
                textBoxQuantidadeATN.ReadOnly = false;
                dataGridViewProdutosNota.Focus();

                try
                {
                    this.relacaoVendasTableAdapter.queryReceber(drogariaParanaDataSet.RelacaoVendas, documento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                if (situacao == "PAGO")
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ser Alterada, pois ja foi PAGA!" + "\n" + "Contas QUITADAS não podem ser alteradas." + "\n" + "Selecione outro Conta e tente novamente!");
                }
                else
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ser Alterada, pois ja esta sendo PAGA!" + "\n" + "Contas que foram DIVIDIDAS e PARCELADAS não podem ser alteradas." + "\n" + "Selecione outro Conta e tente novamente!");
                }
            }
        }

        private void btnRemoverProdutoATN_Click(object sender, EventArgs e)
        {
            textBoxNomeProdutoATN.Clear();
            textBoxValorUnitarioATN.Text = "0,00";
            textBoxQuantidadeATN.Text = "0";
            textBoxValorTotalATN.Text = "0,00";

            #region Variaveis e Instancias
            int parcela = 0;
            string situacao = "", documento = "";

            documento = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
            parcela = int.Parse(dataGridViewAlterarNota.CurrentRow.Cells[6].Value.ToString());
            situacao = dataGridViewAlterarNota.CurrentRow.Cells[4].Value.ToString();
            #endregion

            if (situacao != "PAGO" && parcela == 0)
            {
                #region Renomear Labels
                labelTitleAltera_ExcluirATN.Text = "Excluindo Produto:";
                labelAltera_ExcluirATN.Text = "Excluir:";
                #endregion

                AlterarNota_TipoDeAcao = "remover";
                panelAlterarNotaBottom.Visible = true;
                textBoxQuantidadeATN.ReadOnly = true;
                dataGridViewProdutosNota.Focus();

                try
                {
                    this.relacaoVendasTableAdapter.queryReceber(drogariaParanaDataSet.RelacaoVendas, documento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                if (situacao == "PAGO")
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ter um Produto removido, pois ja foi PAGA!" + "\n" + "Contas QUITADAS não podem ter um Produto REMOVIDO." + "\n" + "Selecione outro Conta e tente novamente!");
                }
                else
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ter um Produto removido, pois ja esta sendo PAGA!" + "\n" + "Contas que foram DIVIDIDAS e PARCELADAS não podem ter um Produto REMOVIDO." + "\n" + "Selecione outro Conta e tente novamente!");
                }
            }
        }

        private void textBoxQuantidadeATN_TextChanged(object sender, EventArgs e)
        {
            //Codigo responsavel por calcular o valor referente a quantidade de produtos selecionados.
            int quantidadeV = 0;
            decimal valorUnitarioV = 0, resultadoV = 0;

            try
            {
                if (textBoxQuantidadeATN.Text == "")
                {
                    quantidadeV = 0;
                }
                else
                {
                    quantidadeV = int.Parse(textBoxQuantidadeATN.Text);
                }
                valorUnitarioV = decimal.Parse(textBoxValorUnitarioATN.Text);
                resultadoV = valorUnitarioV * quantidadeV;
                textBoxValorTotalATN.Text = ("" + resultadoV);
            }
            catch (Exception)
            {
                quantidadeV = 0;
                valorUnitarioV = 0;
            }

        }

        private void btnExcluirNotaATN_Click(object sender, EventArgs e)
        {
            #region Variaveis e Instancias
            int parcela;
            string situacao, documento;

            documento = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
            parcela = int.Parse(dataGridViewAlterarNota.CurrentRow.Cells[6].Value.ToString());
            situacao = dataGridViewAlterarNota.CurrentRow.Cells[4].Value.ToString();
            #endregion

            if (situacao != "PAGO" && parcela == 0)
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja EXCLUIR esta Nota?" + "\n" + "Uma vez EXCLUIDA não pode ser mais recuperada!", (""), MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string Vendas = ("DELETE FROM Vendas WHERE Ndocumento = @Ndocumento");
                        string ContasReceber = ("DELETE FROM ContasReceber WHERE Ndocumento = @Ndocumento");
                        string itemVendido = ("DELETE FROM itensVendidos WHERE documento = @documento");
                        SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
                        SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
                        SqlCommand exeItemVendidos = new SqlCommand(itemVendido, banco.connection);

                        exeVendas.Parameters.AddWithValue("@Ndocumento", documento);
                        exeItemVendidos.Parameters.AddWithValue("@documento", documento);
                        exeContasReceber.Parameters.AddWithValue("@Ndocumento", documento);

                        banco.conectar();
                        exeVendas.ExecuteNonQuery();
                        exeItemVendidos.ExecuteNonQuery();
                        exeContasReceber.ExecuteNonQuery();
                        banco.desconectar();

                        MessageBox.Show("Nota CANCELADA E EXCLUIDA com Sucesso!");

                        this.relacaoContasTableAdapter.queryID_(this.drogariaParanaDataSet.RelacaoContas, ID);
                        this.listaContasTableAdapter.queryID(this.drogariaParanaDataSet.ListaContas, ID);
                        this.dataGridViewAlterarNota.Refresh();
                        this.dataGridViewApagar.Refresh();

                        this.haverContasReceberTableAdapter.queryID(drogariaParanaDataSet.HaverContasReceber, ID);
                        this.dataGridViewDetalhesHaver.Refresh();

                        cabeçalho();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (situacao == "PAGO")
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ser Excluida, pois ja foi PAGO!" + "\n" + "Contas quitadas não podem ser Excluidas." + "\n" + "Selecione outro Conta e tente novamente!");
                }
                else
                {
                    MessageBox.Show("Esta Conta (Nota) não pode ser Excluida, pois ja esta sendo PAGA!" + "\n" + "Contas que foram divididas e parceladas não podem ser Excluidas." + "\n" + "Selecione outro Conta e tente novamente!");
                }
            }
        }

        private void btnConfirmarATN_Click(object sender, EventArgs e)
        {
            #region Variaveis
            int id = 0, quantidadeAtual = 0;
            bool podeRemover = false;
            string documento = "";
            decimal totalAtual = 0, totaProduto = 0, totalProduto_Alterado = 0, resultadoTotal = 0, saldo = 0;           
            #endregion

            if (AlterarNota_TipoDeAcao == "alterar")
            {
                if (textBoxQuantidadeATN.Text != "" && textBoxQuantidadeATN.Text != "0" && textBoxValorTotalATN.Text != "" && textBoxValorTotalATN.Text != "0,00")
                {
                    #region Instancias
                    documentoRefresh = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
                    documento = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
                    id = int.Parse(dataGridViewProdutosNota.CurrentRow.Cells[9].Value.ToString());
                    quantidadeAtual = int.Parse(dataGridViewProdutosNota.CurrentRow.Cells[2].Value.ToString());
                    totalAtual = decimal.Parse(labelValorTotalAlterarNora.Text);
                    totaProduto = decimal.Parse(dataGridViewProdutosNota.CurrentRow.Cells[4].Value.ToString());
                    totalProduto_Alterado = decimal.Parse(textBoxValorTotalATN.Text);
                    #endregion

                    #region Codigo de Alteração do Produto
                    if (totalProduto_Alterado > totaProduto)
                    {
                        //Calcula o valor que sera retirado do valor total da conta do usuario.
                        saldo = totalProduto_Alterado - totaProduto;

                        //Calcula o novo valor do total da conta do usuario
                        resultadoTotal = totalAtual + saldo;  
                    }

                    if (totalProduto_Alterado < totaProduto)
                    {
                        //Calcula o valor que sera retirado do valor total da conta do usuario.
                        saldo = totaProduto - totalProduto_Alterado;

                        //Calcula o novo valor do total da conta do usuario
                        resultadoTotal = totalAtual - saldo;  
                    }

                    if (totalProduto_Alterado != totaProduto)
                    {
                        try
                        {
                            if (MessageBox.Show("Tem certeza que deseja ALTERAR este Produto?", (""), MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string Vendas = ("UPDATE Vendas SET valorTotal = @total WHERE Ndocumento = @documento");
                                string ContasReceber = ("UPDATE ContasReceber SET total = @total, saldo = @saldo WHERE Ndocumento = @documento");
                                string itemVendido = ("UPDATE itensVendidos SET quantidade = @quantidade, valorTotal = @total WHERE idProduto = @ID AND quantidade = @quantidadeAtual");
                                SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
                                SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
                                SqlCommand exeItemVendidos = new SqlCommand(itemVendido, banco.connection);

                                exeVendas.Parameters.AddWithValue("@documento", documento);
                                exeVendas.Parameters.AddWithValue("@total", resultadoTotal /*decimal.Parse(textBoxValorTotalATN.Text)*/);

                                exeContasReceber.Parameters.AddWithValue("@documento", documento);
                                exeContasReceber.Parameters.AddWithValue("@total", resultadoTotal /*decimal.Parse(textBoxValorTotalATN.Text)*/);
                                exeContasReceber.Parameters.AddWithValue("@saldo", resultadoTotal /*decimal.Parse(textBoxValorTotalATN.Text)*/);

                                exeItemVendidos.Parameters.AddWithValue("@ID", id);
                                exeItemVendidos.Parameters.AddWithValue("@quantidade", textBoxQuantidadeATN.Text);
                                exeItemVendidos.Parameters.AddWithValue("@quantidadeAtual", quantidadeAtual);
                                exeItemVendidos.Parameters.AddWithValue("@total", decimal.Parse(textBoxValorTotalATN.Text));

                                banco.conectar();
                                exeVendas.ExecuteNonQuery();
                                exeContasReceber.ExecuteNonQuery();
                                exeItemVendidos.ExecuteNonQuery();
                                banco.desconectar();

                                MessageBox.Show("Produto ALTERADO com Sucesso!");

                                cabeçalho();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Produto não pode ser alterado, pois a QUANTIDADE informada é igual a QUANTIDADE ATUAL do Produto." + "\n" + "\n" + "Informe outra quantidade e tente Novamente!", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Erro: O processo não pode ser concluido pois não foi informado nenhum produto" + "\n" + "Clique um produto e tente novamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                #region Laco de contagem de Produtos
                for (int i = 0; i < dataGridViewProdutosNota.Rows.Count - 0; i++)
                {
                    if (i == 0)
                    {
                        podeRemover = false;
                    }
                    else
                    {
                        podeRemover = true;
                    }
                }
                #endregion


                if (textBoxQuantidadeATN.Text != "" && textBoxQuantidadeATN.Text != "0" && textBoxValorTotalATN.Text != "" && textBoxValorTotalATN.Text != "0,00")
                {
                    if (podeRemover)
                    {
                        #region Instancias
                        documentoRefresh = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
                        documento = dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
                        id = int.Parse(dataGridViewProdutosNota.CurrentRow.Cells[9].Value.ToString());
                        quantidadeAtual = int.Parse(dataGridViewProdutosNota.CurrentRow.Cells[2].Value.ToString());
                        totalAtual = decimal.Parse(labelValorTotalAlterarNora.Text);
                        totaProduto = decimal.Parse(dataGridViewProdutosNota.CurrentRow.Cells[4].Value.ToString());
                        totalProduto_Alterado = decimal.Parse(textBoxValorTotalATN.Text);
                        #endregion

                        #region Codigo de Remoção do Produto
                        try
                        {
                            resultadoTotal = totalAtual - totaProduto;

                            if (MessageBox.Show("Tem certeza que deseja Remover este Produto?" + "\n" + "Uma vez REMOVIDO não pode ser mais recuperada!", (""), MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                string Vendas = ("UPDATE Vendas SET valorTotal = @total WHERE Ndocumento = @documento");
                                string ContasReceber = ("UPDATE ContasReceber SET total = @total, saldo = @saldo WHERE Ndocumento = @documento");
                                string itemVendido = ("DELETE FROM itensVendidos WHERE idProduto = @ID AND quantidade = @quantidadeAtual");
                                SqlCommand exeVendas = new SqlCommand(Vendas, banco.connection);
                                SqlCommand exeContasReceber = new SqlCommand(ContasReceber, banco.connection);
                                SqlCommand exeItemVendidos = new SqlCommand(itemVendido, banco.connection);

                                exeVendas.Parameters.AddWithValue("@documento", documento);
                                exeVendas.Parameters.AddWithValue("@total", resultadoTotal);

                                exeContasReceber.Parameters.AddWithValue("@documento", documento);
                                exeContasReceber.Parameters.AddWithValue("@total", resultadoTotal);
                                exeContasReceber.Parameters.AddWithValue("@saldo", resultadoTotal);

                                exeItemVendidos.Parameters.AddWithValue("@ID", id);
                                exeItemVendidos.Parameters.AddWithValue("@quantidadeAtual", quantidadeAtual);

                                banco.conectar();
                                exeVendas.ExecuteNonQuery();
                                exeContasReceber.ExecuteNonQuery();
                                exeItemVendidos.ExecuteNonQuery();
                                banco.desconectar();

                                MessageBox.Show("Produto REMOVIDO com Sucesso!");

                                cabeçalho();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("Esta Produto não pode ser apagado, pois ele é o unico dessa Nota." + "\n" + "\n" + "Caso ainda deseje REMOVER este Produto:" + "\n" + "\n" + "Exclua a NOTA na TELA anterior e o produto também será REMOVIDO!" + "\n" + "\n" + "Agora se está tentando diminuir a quantidade:" + "\n" + "\n" + "Volte a Tela anterior e aperte no Botão ALTERAR PRODUTO que o produto terá sua quantidade alterada!", "Aviso de Sitema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: O processo não pode ser concluido pois não foi informado nenhum produto" + "\n" + "Clique um produto e tente novamente.", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPesquisaAlterarNota_Click(object sender, EventArgs e)
        {
            try
            {
                this.listaContasTableAdapter.queryPesquisaAlterarNota(this.drogariaParanaDataSet.ListaContas, textDescricaoAlterarNota.Text, ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarAlterarNota_Click(object sender, EventArgs e)
        {
            if (dateTimeDataAlterarNota.Text != dateTimeDataAlterarNota.Text)
            {
                this.listaContasTableAdapter.queryPesquisaData(drogariaParanaDataSet.ListaContas, DateTime.Parse(dateTimeDataAlterarNota.Text.ToString()), DateTime.Parse(dateTimeDataAlterarNota.Text.ToString()), ID);
            }
            else
            {
                MessageBox.Show("As Datas informadas não podem ser iguais." + "\n" + "A Datas precisam ter pelo menos um dia de diferença!");
            }
        }

        private void dataGridViewAlterarNota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //IdSituaca - Cabecalho()
            if (idSituacao == "3")
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }

                if (e.Value.Equals("A PAGAR"))
                {
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                }
            }
            else
            {
                if (e.Value.Equals("PAGO"))
                {
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridViewAlterarNota.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                }
            }
        }

        private void btnFecharAlterarNota_Bottom_Click(object sender, EventArgs e)
        {
            if (panelAlterarNotaBottom.Visible == true)
            {
                textBoxNomeProdutoATN.Clear();
                textBoxValorUnitarioATN.Text = "0,00";
                textBoxQuantidadeATN.Text = "0";
                textBoxValorTotalATN.Text = "0,00";

                panelAlterarNotaBottom.Visible = false;
            }
        }

        private void btnVizualizarCupom_Click(object sender, EventArgs e)
        {
            try
            {
                _StatusDoCupom = "vizualizar cupom";

                frmDetalhesReceberCupom abrir = new frmDetalhesReceberCupom(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion            

    }
}