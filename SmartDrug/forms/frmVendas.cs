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
using System.Drawing.Printing;


namespace SmartDrug.forms
{
    public partial class frmVendas : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        bool naoApertouF1 = true;

        public frmVendas()
        {
            InitializeComponent();

            codigoBarraTextBox.Focus();
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

        private void limparValores()
        {
            //Logo apos apaga os valores 
            textBoxNomeProduto.Clear();
            codigoBarraTextBox.Clear();
            quantidadeTextBox.Text = "0";
            valorUnitarioTextBox.Text = "0,00";
            valorTotalTextBox.Text = "0,00";
        }

        private void verificarEstoque()
        {
            //Variaveis para calcular o Quantidade de Produto em Estoque.
            int Qnt = 0, QntPedida;
            //Qnt = int.Parse(quantidadeAtualTextBox.Text);
            QntPedida = int.Parse(quantidadeTextBox.Text);

            //Se a quantidade atual do estoque for igual a 0.
            if (Qnt == 0)
            {
                //Informa a menssagem.
                MessageBox.Show("Este Produto acabou no Estoque! O Saldo atual é de " + Qnt + " unidades!");

                //Logo apos apaga os valores 
                limparValores();

                //Cursor volta para o campo Codigo Barra.
                codigoBarraTextBox.Focus();
            }
            else
                //Se a quantidade atual do estoque for menor que a Pedida.
                if (Qnt < QntPedida)
                {
                    //Informa a menssagem.
                    MessageBox.Show("Este Produto, não possui " + QntPedida + " unidades em estoque! O Saldo atual é de " + Qnt + " unidades!");

                    //Logo apos apaga os valores 
                    limparValores();

                    //Cursor volta para o campo Codigo Barra.
                    codigoBarraTextBox.Focus();
                }
        }

        private void calculaTotalGeral()
        {
            //Variaveis para calcular o ValorTotal.
            decimal valorTotal = 0, TotalGeralAtual = 0, resultadoTotal = 0;

            //Armazena nas variaveis e calcula o TotalGeral correspondente aos produtos.
            valorTotal = decimal.Parse(valorTotalTextBox.Text);
            TotalGeralAtual = decimal.Parse(TotalGeralTextBox.Text);
            resultadoTotal = TotalGeralAtual + valorTotal;
            subTotalTextBox.Text = (("") + resultadoTotal);
            TotalGeralTextBox.Text = (("") + resultadoTotal);
        }

        private void CalcularTotalGeralGrid()
        {
            try
            {
                if (grid.Rows.Count > 0)
                {
                    decimal totalGeral = 0;
                    foreach (DataGridViewRow r in grid.Rows)
                    {
                        totalGeral += Convert.ToDecimal(r.Cells["ValorTotal"].Value);
                    }

                    subTotalTextBox.Text = totalGeral.ToString("N2"); // PABLO - SubTotal Geral - Incluir desconto na soma
                    TotalGeralTextBox.Text = totalGeral.ToString("N2");
                }
                else
                    TotalGeralTextBox.Text = "0,00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar cálcular o Total Geral!\n\nDetalhe técnico: " + ex.Message, "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculaQuantidadeProduto()
        {
            //Codigo responsavel por calcular o valor referente a quantidade de produtos selecionados.
            int quantidadeV = 0;
            decimal valorUnitarioV = 0, resultadoV;

            try
            {
                if (quantidadeTextBox.Text != "")
                {
                    quantidadeV = int.Parse(quantidadeTextBox.Text);
                }

                valorUnitarioV = decimal.Parse(valorUnitarioTextBox.Text);
                resultadoV = quantidadeV * valorUnitarioV;
                valorTotalTextBox.Text = ("" + resultadoV);
            }
            catch (Exception ex)
            {
                quantidadeV = 0;
            }
        }

        //Eventos de Botões do Teclado.
        private void frmVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            #region Botão F1
            if (e.KeyCode == Keys.F1)
            {
                limparValores();

                //Valor atribuido as campos.
                naoApertouF1 = false;
                textBoxNomeProduto.Focus();
                textBoxNomeProduto.Text = "...";

                SituaçãoTextBox.Text = "Pesquisando Produto...";

                try
                {
                    SqlCommand exePesquisa = new SqlCommand("SELECT nome FROM Produto", banco.connection);
                    banco.conectar();
                    SqlDataReader dr = exePesquisa.ExecuteReader();
                    AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

                    while (dr.Read())
                    {
                        lista.Add(dr.GetString(0));
                    }
                    textBoxNomeProduto.AutoCompleteCustomSource = lista;
                    banco.desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion


            #region Botão F2
            if (e.KeyCode == Keys.F2)
            {
                SituaçãoTextBox.Text = "Reemprimir Vendas";

                openChildForm(new forms.frmReemprimirVenda());
            }
            #endregion


            #region Botão F3
            if (e.KeyCode == Keys.F3)
            {
                SituaçãoTextBox.Text = "Orçamentos";

                openChildForm(new forms.frmConcluirOrcamento());
            }
            #endregion


            #region Botão F5
            if (e.KeyCode == Keys.F5)
            {
                if (TotalGeralTextBox.Text != "0,00")
                {
                    SituaçãoTextBox.Text = "Finalizando Venda...";
                    codigoBarraTextBox.Focus();

                    //Abre o From Finalizar Venda.
                    frmFinalizarVenda abrir = new frmFinalizarVenda(this);
                    abrir.ShowDialog();
                    abrir.Dispose();
                }
                else
                {
                    MessageBox.Show("Informe algum Produto!!!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion


            #region Botão F10
            //Execulta quando o Botão (F10) for apertado. 
            if (e.KeyCode == Keys.F10)
            {
                if (TotalGeralTextBox.Text != "0,00")
                {
                    SituaçãoTextBox.Text = "Cancelando Item...";

                    frmCancelarItem frmCancelarItem = new frmCancelarItem();
                    frmCancelarItem.ShowInTaskbar = false;
                    frmCancelarItem.ShowDialog();

                    if (frmCancelarItem._Item > 0)
                    {
                        bool encontrouItem = false;
                        DataGridViewRow row = new DataGridViewRow();
                        for (int i = 0; i < grid.Rows.Count; i++)
                        {
                            row = grid.Rows[i];
                            if (row.Cells["numeroItem"].Value.Equals(frmCancelarItem._Item))
                            {
                                grid.FirstDisplayedScrollingRowIndex = i;
                                grid.CurrentCell = row.Cells["numeroItem"];
                                row.Selected = true;
                                encontrouItem = true;
                                break;
                            }
                        }

                        if (encontrouItem)
                        {
                            grid.Rows.Remove(grid.Rows[grid.CurrentRow.Index]);
                            grid.Refresh();

                            calculaTotalGeral();
                            CalcularTotalGeralGrid();

                            SituaçãoTextBox.Text = "Item Cancelado!";
                        }
                        else
                        {
                            MessageBox.Show("Item não encontrado!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    //O cursor ira voltar para o campo do codigo. 
                    codigoBarraTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Informe algum Produto!!!");
                }
            }
            #endregion

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {            
            //Valor atribuido as campos.
            codigoBarraTextBox.Focus();
        }

        //Evento que Lê o codigo de barra.
        private void codigoBarraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Condicao que irar verificar se a tecla "ENTER" foi apertada, caso seja, ira executar o codigo dentro da chave.
                if (e.KeyCode == Keys.Enter)
                {
                    if (codigoBarraTextBox.Text == "")
                    {
                        MessageBox.Show("Este Produto não possui Cadastro feito!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Logo apos apaga os valores 
                        limparValores();
                    }
                    else
                    {
                        //Variavel que receber o valor capturado pelo Leitor de Codigo de Barras.
                        string CodigoBarra = codigoBarraTextBox.Text;

                        //Codigo responsavel por adicionar os dados dos Produtos solicitados nas TextBox.
                        this.produtoTableAdapter.queryCodigoBarra(this.drogariaParanaDataSet.Produto, CodigoBarra);

                        quantidadeTextBox.Text = "1";
                        quantidadeTextBox.Focus();
                        naoApertouF1 = true;
                    }           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            SituaçãoTextBox.Text = "Venda em Andamento...";

            calculaQuantidadeProduto();
        }

        private void quantidadeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quantidadeTextBox.Text != "")
                {
                    if (textBoxNomeProduto.Text == "PRODUTO NAO CADASTRADO" || textBoxNomeProduto.Text == "PRODUTOS COSMETICOS - DERONEIA")
                    {
                        valorUnitarioTextBox.ReadOnly = false;
                        valorUnitarioTextBox.TabStop = true;

                        SendKeys.Send("{TAB}");

                        e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                        return;
                    }
                    else
                    {
                        
                        //Calcula quantidade de produto
                        calculaQuantidadeProduto();

                        //Calcula o TotalGeral correspondente aos produtos.
                        calculaTotalGeral();

                        SituaçãoTextBox.Text = "Venda em Andamento...";

                        //Adiciona os Itens
                        grid.Rows.Add(grid.Rows.Count + 1, 
                                      codigoBarraTextBox.Text, 
                                      textBoxNomeProduto.Text, 
                                      quantidadeTextBox.Text, 
                                      Convert.ToDecimal(valorUnitarioTextBox.Text).ToString("N2"),
                                      Convert.ToDecimal(valorTotalTextBox.Text).ToString("N2"),
                                      labelIdProduto.Text);

                        grid.FirstDisplayedScrollingRowIndex = grid.Rows.Count - 1;
                        grid.Refresh();
                        grid.ClearSelection();
                        grid.Rows[grid.Rows.Count - 1].Selected = true;

                        CalcularTotalGeralGrid();

                        grid.Refresh();
                        

                        //Logo apos apaga os valores 
                        limparValores();

                        //Cursor volta para o campo Codigo Barra.
                        codigoBarraTextBox.Select();
                        codigoBarraTextBox.Focus();
                        e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("O campo Quantidade não pode estár vazio!" + "\n" + "Informe a Quantidade e prossiga com a Venda!");

                }
            }
        }  

        //Executa a Query de Consultar os Produtos na Pesquisa manual 
        private void textBoxNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxNomeProduto.Text != "..." || textBoxNomeProduto.Text == "")
                {
                    this.produtoTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Produto, textBoxNomeProduto.Text);
                    //
                    quantidadeTextBox.Text = "1";
                    quantidadeTextBox.Focus();
                    naoApertouF1 = true;
                }
            }
        }

        private void valorUnitarioTextBox_TextChanged(object sender, EventArgs e)
        {
            SituaçãoTextBox.Text = "Venda em Andamento...";

            //Calcula quantidade de produto
            calculaQuantidadeProduto();
        }   

        private void valorUnitarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Calcula quantidade de produto
                calculaQuantidadeProduto();

                //Calcula o TotalGeral correspondente aos produtos.
                calculaTotalGeral();

                SituaçãoTextBox.Text = "Venda em Andamento...";

                //Adiciona os Itens quando for PRODUTO NÃO CADASTRADO
                grid.Rows.Add(grid.Rows.Count + 1,
                                     codigoBarraTextBox.Text,
                                     textBoxNomeProduto.Text,
                                     quantidadeTextBox.Text,
                                     Convert.ToDecimal(valorUnitarioTextBox.Text).ToString("N2"),
                                     Convert.ToDecimal(valorTotalTextBox.Text).ToString("N2"),
                                     labelIdProduto.Text);

                grid.FirstDisplayedScrollingRowIndex = grid.Rows.Count - 1;
                grid.Refresh();
                grid.ClearSelection();
                grid.Rows[grid.Rows.Count - 1].Selected = true;

                CalcularTotalGeralGrid();

                grid.Refresh();


                //Logo apos apaga os valores 
                limparValores();

                //Cursor volta para o campo Codigo Barra.
                codigoBarraTextBox.Focus();

                //Anula as propriedades do valor unitario!
                valorUnitarioTextBox.ReadOnly = true;
                valorUnitarioTextBox.TabStop = false;

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (naoApertouF1)
            {
                if (e.KeyChar >= 48 || e.KeyChar <= 65)
                {
                    e.Handled = true;
                    MessageBox.Show("Para pesquisa MANUAL aperte F1!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codigoBarraTextBox.Focus();
                }
            }
        }
    }
}
