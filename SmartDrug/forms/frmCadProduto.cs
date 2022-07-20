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
    public partial class frmCadProduto : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();
        //
        string codigoBarra;

        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void Evento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void AutoComplete()
        {
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
                PesquisarTextBox.AutoCompleteCustomSource = lista;
                banco.desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            banco.desconectar();
        }

        private void limparValores()
        {
            //Apos salvar os dados e fechar(Desconectar) o banco, todas as TextBox e ComboBox serão Limpaz.
            codigoTextBox.Clear();
            nome_produtoTextBox.Clear();
            precoTextBox.Clear();
            observacaoTextBox.Clear();
            descricaoTextBox.Clear();
            composicaoTextBox.Clear();
            tipoProdutoTextBox.Clear();
            NCMtextBox.Clear();
            CTLtextBox.Clear();
            idTextBox.Clear();
            PesquisarTextBox.Clear();
            //comboBoxVendedor.SelectedValue = 8;
            labelNomeCompleto.Text = "";
            labelVendedor.Text = "";
            labelVendedorAlteracao.Text = "";

            comboBoxVendedor.Focus();
            AutoComplete();
        }

        private void insertQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string Produtos = ("INSERT INTO Produto (codigoBarra, nome, quantidade, preco, observacao, descricao, composicao, tipoProduto, NCM, CTL, idVendedor, vendedor, vendedorAlteracao, dataCadastro) VALUES (@codigo, @nome, @quantidade, @preco, @observacao, @descricao, @composicao, @tipoProduto, @NCM, @CTL, @idVendedor, @vendedor, @vendedorAlteracao, @dataCadastro)");
            SqlCommand exeCad = new SqlCommand(Produtos, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@codigo", codigoTextBox.Text);
            exeCad.Parameters.AddWithValue("@nome", nome_produtoTextBox.Text);
            exeCad.Parameters.AddWithValue("@quantidade", quantidadeTextBox.Text);
            if (precoTextBox.Text != "")
            {
                exeCad.Parameters.AddWithValue("@preco", decimal.Parse(precoTextBox.Text));
            }
            exeCad.Parameters.AddWithValue("@observacao", observacaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@composicao", composicaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@tipoProduto", tipoProdutoTextBox.Text);
            exeCad.Parameters.AddWithValue("@NCM", NCMtextBox.Text);
            exeCad.Parameters.AddWithValue("@CTL", CTLtextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedor", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedor", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", "Não possui Alteracão!");
            exeCad.Parameters.AddWithValue("@dataCadastro", DateTime.Now);


            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (nome_produtoTextBox.Text != ("") && quantidadeTextBox.Text != ("") && precoTextBox.Text != (""))
            {
                codigoTextBox.Focus();

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

                limparValores();


                MessageBox.Show("Cadastro realizado com Sucesso!");


            }
            else
            {
                MessageBox.Show("O Cadastro não pôde ser realizado." + "\n" + "Verifique os dados e tente novamente!");
            }
        }

        private void updateQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string Produtos = ("UPDATE Produto SET codigoBarra = @codigo, nome = @nome, quantidade = @quantidade, preco = @preco, observacao = @observacao, descricao = @descricao, composicao = @composicao, tipoProduto = @tipoProduto, NCM = @NCM, CTL = @CTL, idVendedorAlteracao = @idVendedorAlteracao, vendedorAlteracao = @vendedorAlteracao, dataAlteracao = @dataAlteracao WHERE idProduto = @ID");

            SqlCommand exeCad = new SqlCommand(Produtos, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@ID", idTextBox.Text);
            exeCad.Parameters.AddWithValue("@codigo", codigoTextBox.Text);
            exeCad.Parameters.AddWithValue("@nome", nome_produtoTextBox.Text);
            exeCad.Parameters.AddWithValue("@quantidade", quantidadeTextBox.Text);
            if (precoTextBox.Text != "")
            {
                exeCad.Parameters.AddWithValue("@preco", decimal.Parse(precoTextBox.Text));
            }
            exeCad.Parameters.AddWithValue("@observacao", observacaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@composicao", composicaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@tipoProduto", tipoProdutoTextBox.Text);
            exeCad.Parameters.AddWithValue("@NCM", NCMtextBox.Text);
            exeCad.Parameters.AddWithValue("@CTL", CTLtextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedorAlteracao", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@dataAlteracao", DateTime.Now);


            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (codigoTextBox.Text != ("") && nome_produtoTextBox.Text != ("") && quantidadeTextBox.Text != ("") && precoTextBox.Text != (""))
            {
                PesquisarTextBox.Focus();

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

                limparValores();

                MessageBox.Show("Cadastro alterado com Sucesso!");

            }
            else
            {
                MessageBox.Show("A Alteração não pôde ser realizada." + "\n" + "Verifique os dados e tente novamente!");
            }
        }

        private void excluirQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string Produtos = ("DELETE FROM Produto WHERE idProduto = @ID");
            SqlCommand exeCad = new SqlCommand(Produtos, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@ID", idTextBox.Text);

            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (idTextBox.Text != "")
            {
                PesquisarTextBox.Focus();

                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

                limparValores();

                MessageBox.Show("Cadastro excluido com Sucesso!");

            }
            else
            {
                MessageBox.Show("O cadastro não pôde ser excluido." + "\n" + "Verifique os dados e tente novamente!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a tela de Cadastro.
            this.Close();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);

            comboBoxVendedor.Focus();
            comboBoxVendedor.SelectedValue = 8;
        }

        private void FrmCadProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxVendedor.Text != "-----")
            {
                if (panelAlterar.Visible == false)
                {
                    insertQuery();
                    limparValores();
                }

                if (panelAlterar.Visible == true && labelTipoAcao.Text == "Alterar Cadastro:")
                {
                    updateQuery();
                    limparValores();
                }

                if (panelAlterar.Visible == true && labelTipoAcao.Text == "Excluir Cadastro:")
                {
                    excluirQuery();
                    limparValores();
                }
            }
            else
            {
                MessageBox.Show("Informe o Vendedor!!!");
            }
        }

        private void codigoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Condicao que irar verificar se a tecla "ENTER" foi apertada, caso seja, ira executar o codigo dentro da chave.
                if (e.KeyCode == Keys.Enter)
                {
                    #region Verificador de Codigo de Barra
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Produto = ("SELECT * FROM Produto WHERE codigoBarra = @codigo");
                    SqlCommand exeVerificacao = new SqlCommand(Produto, banco.connection);
                    banco.conectar();
                    exeVerificacao.Parameters.AddWithValue("@codigo", codigoTextBox.Text);
                    SqlDataReader datareader = exeVerificacao.ExecuteReader();
                    if (datareader.Read())
                    {
                        VerificarProduto.produto(datareader["codigoBarra"].ToString());
                        codigoBarra = VerificarProduto._ProdutoVerificado();
                    }
                    banco.desconectar();
                    #endregion

                    if (idTextBox.Text == "")
                    {

                        if (codigoTextBox.Text == codigoBarra)
                        {
                            if (panelAlterar.Visible == false)
                            {
                                MessageBox.Show("Este Produto ja esta Cadastrado!");
                            }
                            else
                            {
                                #region Verificador de Codigo de Barra
                                banco.conectar();
                                SqlDataReader datareaderPesquisa = exeVerificacao.ExecuteReader();
                                if (datareaderPesquisa.Read())
                                {
                                    idTextBox.Text = datareaderPesquisa["idProduto"].ToString();

                                    labelNomeCompleto.Text = datareaderPesquisa["nome"].ToString();
                                    labelVendedor.Text = datareaderPesquisa["vendedor"].ToString();
                                    labelVendedorAlteracao.Text = datareaderPesquisa["vendedorAlteracao"].ToString();

                                    codigoTextBox.Text = datareaderPesquisa["codigoBarra"].ToString();
                                    nome_produtoTextBox.Text = datareaderPesquisa["nome"].ToString();
                                    CTLtextBox.Text = datareaderPesquisa["CTL"].ToString();
                                    NCMtextBox.Text = datareaderPesquisa["NCM"].ToString();
                                    tipoProdutoTextBox.Text = datareaderPesquisa["tipoProduto"].ToString();
                                    quantidadeTextBox.Text = datareaderPesquisa["quantidade"].ToString();
                                    descricaoTextBox.Text = datareaderPesquisa["descricao"].ToString();
                                    precoTextBox.Text = datareaderPesquisa["preco"].ToString();
                                    composicaoTextBox.Text = datareaderPesquisa["composicao"].ToString();
                                    observacaoTextBox.Text = datareaderPesquisa["observacao"].ToString();
                                }
                                banco.desconectar();
                                #endregion

                                nome_produtoTextBox.Focus();

                                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                                return;
                            }
                        }
                        else
                        {

                            //Variavel que receber o valor capturado pelo Leitor de Codigo de Barras.
                            string CodigoBarra = codigoTextBox.Text;
                            nome_produtoTextBox.Focus();
                        }

                    }
                    else
                    {
                        SendKeys.Send("{TAB}");

                        e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                        return;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;
            btnLimparValores.Visible = false;

            limparValores();
            comboBoxVendedor.Focus();
            comboBoxVendedor.SelectedValue = 8;
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            limparValores();
            labelTipoAcao.Text = "Alterar Cadastro:";
            panelAlterar.Visible = true;
            btnLimparValores.Visible = true;
            comboBoxVendedor.SelectedValue = 8;

            comboBoxVendedor.Focus();

            AutoComplete();
        }

        private void PesquisarTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PesquisarTextBox.Text == "")
                {
                    MessageBox.Show("Informe um Nome!");
                }
                else
                {
                    #region Verificador de Codigo de Barra
                    //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                    string Produto = ("SELECT * FROM Produto WHERE (nome LIKE @nome + '%')");
                    SqlCommand exeVerificacao = new SqlCommand(Produto, banco.connection);
                    banco.conectar();
                    exeVerificacao.Parameters.AddWithValue("@nome", PesquisarTextBox.Text);
                    SqlDataReader datareader = exeVerificacao.ExecuteReader();
                    if (datareader.Read())
                    {
                        idTextBox.Text = datareader["idProduto"].ToString();

                        labelNomeCompleto.Text = datareader["nome"].ToString();
                        labelVendedor.Text = datareader["vendedor"].ToString();
                        labelVendedorAlteracao.Text = datareader["vendedorAlteracao"].ToString();

                        codigoTextBox.Text = datareader["codigoBarra"].ToString();
                        nome_produtoTextBox.Text = datareader["nome"].ToString();
                        CTLtextBox.Text = datareader["CTL"].ToString();
                        NCMtextBox.Text = datareader["NCM"].ToString();
                        tipoProdutoTextBox.Text = datareader["tipoProduto"].ToString();
                        quantidadeTextBox.Text = datareader["quantidade"].ToString();
                        descricaoTextBox.Text = datareader["descricao"].ToString();
                        precoTextBox.Text = datareader["preco"].ToString();
                        composicaoTextBox.Text = datareader["composicao"].ToString();
                        observacaoTextBox.Text = datareader["observacao"].ToString();
                    }
                    banco.desconectar();
                    #endregion


                    comboBoxVendedor.Focus();
                }

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (PesquisarTextBox.Text == "")
            {
                MessageBox.Show("Informe um Nome!");
            }
            else
            {
                #region Verificador de Codigo de Barra
                //Ira verificar se o Cliente ja possui conta aberta, se nao houver ele ira efetuar a abertura.
                string Produto = ("SELECT * FROM Produto WHERE (nome LIKE @nome + '%')");
                SqlCommand exeVerificacao = new SqlCommand(Produto, banco.connection);
                banco.conectar();
                exeVerificacao.Parameters.AddWithValue("@nome", PesquisarTextBox.Text);
                SqlDataReader datareader = exeVerificacao.ExecuteReader();
                if (datareader.Read())
                {
                    idTextBox.Text = datareader["idProduto"].ToString();

                    labelNomeCompleto.Text = datareader["nome"].ToString();
                    labelVendedor.Text = datareader["vendedor"].ToString();
                    labelVendedorAlteracao.Text = datareader["vendedorAlteracao"].ToString();

                    codigoTextBox.Text = datareader["codigoBarra"].ToString();
                    nome_produtoTextBox.Text = datareader["nome"].ToString();
                    CTLtextBox.Text = datareader["CTL"].ToString();
                    NCMtextBox.Text = datareader["NCM"].ToString();
                    tipoProdutoTextBox.Text = datareader["tipoProduto"].ToString();
                    quantidadeTextBox.Text = datareader["quantidade"].ToString();
                    descricaoTextBox.Text = datareader["descricao"].ToString();
                    precoTextBox.Text = datareader["preco"].ToString();
                    composicaoTextBox.Text = datareader["composicao"].ToString();
                    observacaoTextBox.Text = datareader["observacao"].ToString();
                }
                banco.desconectar();
                #endregion


                comboBoxVendedor.Focus();
            }
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            limparValores();
            comboBoxVendedor.SelectedValue = 8;

            labelTipoAcao.Text = "Excluir Cadastro:";
            panelAlterar.Visible = true;
            btnLimparValores.Visible = true;

            comboBoxVendedor.Focus();

            AutoComplete();
        }

        private void observacaoTextBox_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnSalvar_Click(sender, e);
            }
        }

        private void comboBoxVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBoxVendedor.Text != "-----")
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

        private void btnLimparValores_Click(object sender, EventArgs e)
        {
            limparValores();
        }
    }
}