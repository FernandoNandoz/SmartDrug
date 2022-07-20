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

namespace SmartDrug
{
    public partial class frmCadastrarNotaFiscal : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        //Variaveis responsavei por armazenar dados temporariamente.
        decimal baseCalculo = 0, resultadoValorICMS, totalNota;
        decimal porcentagem, valorICMS1 = 6, valorICMS2 = 100;
        //
        decimal Quantidade, valorUnitario, Desconto, resultado;

        public frmCadastrarNotaFiscal()
        {
            InitializeComponent();
        }

        private void frmCadastrarNotaFiscal_Load(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer todas as informações da tabela no banco de dados para o ComboBox (Fornecedor).
            this.fornecedoresTableAdapter.Fill(this.drogariaParanaDataSet.Fornecedores);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha Tela.
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha a Tela.
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //Verificação dos campos exigidos para proceguir com o registro dos Dados no banco de dados. 
            if (notaFiscalTextBox.Text != ("") && dataEmissaoMaskedTextBox.Text != ("") && dataEntradaMaskedTextBox.Text != ("") && cfopComboBox.Text != ("") && fornecedorComboBox.Text != ("") && chaveAcessoMaskedTextBox.Text != ("") && baseCalculoIcmsTextBox.Text != ("") && valorIcmsTextBox.Text != ("") && valorTotalTextBox.Text != (""))
            {
                //Strings de referencia da Tabela Usuario e Conexão da mesma.
                string NotaFiscal = ("INSERT INTO NotaFiscal (Ndocumento, chaveAcesso, CFOP, dataEmissao, dataEntrada, BaseCalculo_ICMS, valor_ICMS, ValorTotal, idFornecedor) VALUES (@Ndocumento, @chaveAcesso, @CFOP, @dataEmissao, @dataEntrada, @BaseCalculoICMS, @valorICMS, @valorTotal, @idFornecedor)");
                string ItensVendido = ("INSERT INTO itensVendidos (documento, codigo, idProduto, quantidade, valorUnitario, desconto, valorTotal) VALUES (@documento, @codigo, @idProduto, @quantidade, @valorUnitario, @desconto, @valorTotal)");
                string Produto = (" UPDATE Produto SET quantidade = quantidade + @adicional WHERE idProduto = @ID");
                SqlCommand exeNotaFiscal = new SqlCommand(NotaFiscal, banco.connection);
                SqlCommand exeItensVendido = new SqlCommand(ItensVendido, banco.connection);
                SqlCommand exeProduto = new SqlCommand(Produto, banco.connection);

                //Passando dados por parametros para inserção no banco.
                exeNotaFiscal.Parameters.AddWithValue("@Ndocumento", notaFiscalTextBox.Text);
                exeNotaFiscal.Parameters.AddWithValue("@chaveAcesso", chaveAcessoMaskedTextBox.Text);
                exeNotaFiscal.Parameters.AddWithValue("@CFOP", cfopComboBox.Text);
                exeNotaFiscal.Parameters.AddWithValue("@dataEmissao", dataEmissaoMaskedTextBox.Text);
                exeNotaFiscal.Parameters.AddWithValue("@dataEntrada", dataEntradaMaskedTextBox.Text);
                //Condicao que verifica se os campos especificados nao estao vazio, possibilitando a insercao dos dados convertidos em Real (Decimal).
                if (baseCalculoIcmsTextBox.Text != ("") && valorIcmsTextBox.Text != ("") && valorTotalTextBox.Text != (""))
                {
                    exeNotaFiscal.Parameters.AddWithValue("@BaseCalculoICMS", decimal.Parse(baseCalculoIcmsTextBox.Text));
                    exeNotaFiscal.Parameters.AddWithValue("@valorICMS", decimal.Parse(valorIcmsTextBox.Text));
                    exeNotaFiscal.Parameters.AddWithValue("@valorTotal", decimal.Parse(valorTotalTextBox.Text));
                }
                //
                exeNotaFiscal.Parameters.AddWithValue("@idFornecedor", fornecedorComboBox.SelectedValue);


                //Laco responsavel por porcorrer produto por produto no DataGridView e adicionalos ao banco de dados atraves de querys de insercao.
                for (int i = 0; i < produtosNotaFiscalDataGridView.Rows.Count - 0; ++i)
                {
                    //Codigo Responsavel por limpar o parametro a cada ciclo que o laco faz.
                    exeItensVendido.Parameters.Clear();
                    //Passando dados por parametros para inserção no banco.
                    exeItensVendido.Parameters.AddWithValue("@documento", produtosNotaFiscalDataGridView.CurrentRow.Cells[6].Value);
                    exeItensVendido.Parameters.AddWithValue("@codigo", produtosNotaFiscalDataGridView.Rows[i].Cells[0].Value);
                    exeItensVendido.Parameters.AddWithValue("@idProduto", produtosNotaFiscalDataGridView.Rows[i].Cells[6].Value);
                    exeItensVendido.Parameters.AddWithValue("@quantidade", produtosNotaFiscalDataGridView.Rows[i].Cells[2].Value);
                    //Condicao que verifica se os campos especificados nao estao vazio, possibilitando a insercao dos dados convertidos em Real (Decimal).
                    if (produtosNotaFiscalDataGridView.CurrentRow.Cells[3].Value != ("") && produtosNotaFiscalDataGridView.CurrentRow.Cells[4].Value != ("") && produtosNotaFiscalDataGridView.CurrentRow.Cells[5].Value != (""))
                    {
                        exeItensVendido.Parameters.AddWithValue("@valorUnitario", decimal.Parse(produtosNotaFiscalDataGridView.Rows[i].Cells[3].Value.ToString()));
                        exeItensVendido.Parameters.AddWithValue("@desconto", decimal.Parse(produtosNotaFiscalDataGridView.Rows[i].Cells[4].Value.ToString()));
                        exeItensVendido.Parameters.AddWithValue("@valorTotal", decimal.Parse(produtosNotaFiscalDataGridView.Rows[i].Cells[5].Value.ToString()));
                    }
                    //
                    //Codigo Responsavel por limpar o parametro a cada ciclo que o laco faz.
                    exeProduto.Parameters.Clear();
                    //Passando dados por parametros para inserção no banco.
                    exeProduto.Parameters.AddWithValue("@adicional", produtosNotaFiscalDataGridView.Rows[i].Cells[2].Value);
                    exeProduto.Parameters.AddWithValue("@ID", produtosNotaFiscalDataGridView.Rows[i].Cells[7].Value);

                    //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrais.
                    banco.conectar();
                    exeItensVendido.ExecuteNonQuery();
                    exeProduto.ExecuteNonQuery();
                    banco.desconectar();
                }
                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrais.
                banco.conectar();
                exeNotaFiscal.ExecuteNonQuery();
                banco.desconectar();

                //Codigo responsavel por apagar todos os dados ja adicionas dos Campos abaixo.
                notaFiscalTextBox.Clear();
                dataEmissaoMaskedTextBox.Clear();
                dataEntradaMaskedTextBox.Clear();
                cfopComboBox.Text = ("");
                fornecedorComboBox.Text = ("");
                chaveAcessoMaskedTextBox.Clear();
                baseCalculoIcmsTextBox.Clear();
                valorIcmsTextBox.Clear();
                valorTotalTextBox.Clear();

                MessageBox.Show("Nota Fiscal Cadastrada com Sucesso!");
            }
            else
            {
                MessageBox.Show("Nota Fiscal não pode ser cadastrada!" + "\n" + "Verifique o dados e tente novamente!");
            }
        }

        private void descontoTextBox_TextChanged(object sender, EventArgs e)
        {
            //Codigo responsavel por calcular os valores dos produtos juntamente com descontos (se houver!) automaticamente.
            if (quantidadeTextBox.Text == (""))
            {
                Quantidade = 0;
            }
            else
            {
                Quantidade = decimal.Parse(quantidadeTextBox.Text);
            }
            if (valorUnitarioTextBox.Text == (""))
            {
                valorUnitario = 0;
            }
            else
            {
                valorUnitario = decimal.Parse(valorUnitarioTextBox.Text);
            }
            if (descontoTextBox.Text == (""))
            {
                Desconto = 0;
            }
            else
            {
                Desconto = decimal.Parse(descontoTextBox.Text);
            }
            resultado = Quantidade * valorUnitario - Desconto;
            totalProdutosTextBox.Text = ("") + resultado;
        }

        //Evento responsavel por ativar tarefas atribuidas a botoes de atalho no teclado.
        private void codigoBarraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Condicao que irar verificar se a tecla "ENTER" foi apertada, caso seja, ira executar o codigo dentro da chave.
            if (e.KeyCode == Keys.Enter)
            {
                //Variavel que receber o valor capturado pelo Leitor de Codigo de Barras.
                string CodigoBarra = codigoBarraTextBox.Text;

                //Codigo responsavel por adicionar os dados dos Produtos solicitados nas TextBox.
                this.produtoTableAdapter.queryCodigoBarra(this.drogariaParanaDataSet.Produto, CodigoBarra);
            }
        }

        //Evento responsavel por ativar tarefas atribuidas a botoes de atalho no teclado.
        private void descontoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Condicao que irar verificar se a tecla "ENTER" foi apertada, caso seja, ira executar o codigo dentro da chave.
            if (e.KeyCode == Keys.Enter)
            {
                //Codigo responsavel por adicionar os dados dos Produtos solicitados no DataGriView.
                produtosNotaFiscalDataGridView.Rows.Add(codigoBarraTextBox.Text, nomeProdutoComboBox.Text, quantidadeTextBox.Text, valorUnitarioTextBox.Text, descontoTextBox.Text, totalProdutosTextBox.Text, notaFiscalTextBox.Text, nomeProdutoComboBox.SelectedValue);

                //Calculo do Imposto
                baseCalculo = baseCalculo + decimal.Parse(totalProdutosTextBox.Text);
                baseCalculoIcmsTextBox.Text = ("") + baseCalculo;

                porcentagem = valorICMS1 / valorICMS2;
                resultadoValorICMS = baseCalculo * porcentagem;
                valorIcmsTextBox.Text = ("") + resultadoValorICMS;

                totalNota = baseCalculo + resultadoValorICMS;
                valorTotalTextBox.Text = ("") + totalNota;

                //Codigo responsavel por apagar todos os dados ja adicionas dos Campos abaixo.
                codigoBarraTextBox.Clear();
                nomeProdutoComboBox.Text = ("");
                quantidadeTextBox.Clear();
                valorUnitarioTextBox.Clear();
                descontoTextBox.Clear();
                totalProdutosTextBox.Clear();
            }
        }

        private void frmCadastrarNotaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void notaFiscalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            SendKeys.Send("{TAB}");

            e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
            return;
        }
    }
}
