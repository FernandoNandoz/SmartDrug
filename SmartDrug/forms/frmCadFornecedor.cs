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
    public partial class frmCadFornecedor : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        public frmCadFornecedor()
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
                SqlCommand exePesquisa = new SqlCommand("SELECT nomeRazao FROM Fornecedores", banco.connection);
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
        }

        private void limparValores()
        {
            //Apos salvar os dados e fechar(Desconectar) o banco, todas as TextBox e ComboBox serão Limpaz.
            nome_RazaoTextBox.Clear();
            nome_FantasiaTextBox.Clear();
            maskCNPJ.Clear();
            maskInscricaoM.Clear();
            maskInscricaoE.Clear();
            enderecoTextBox.Clear();
            paisComboBox.Text = ("");
            estadoComboBox.Text = ("");
            cidadeComboBox.Text = ("");
            maskTelefone.Clear();
            maskTelefone2.Clear();
            textNomeContato.Clear();
            emailTextBox.Clear();
            observacaoTextBox.Clear();
            idTextBox.Clear();
            PesquisarTextBox.Clear();
            comboBoxVendedor.SelectedValue = 8;
            labelNomeCompleto.Text = "";
            labelVendedor.Text = "";
            labelVendedorAlteracao.Text = "";

            PesquisarTextBox.Focus();
            AutoComplete();
        }

        private void insertQuery()
        {
            //String de referencia da Tabela Usuario e Conexão da mesma.
            string Fornecedor = ("INSERT INTO Fornecedores (nomeRazao, nomeFantasia, cnpj, inscricaoMunicipal, inscricaoEstadual, endereco, pais, estado, cidade, telefone, telefone2, nomeContato, email, observacao, idVendedor, vendedor, vendedorAlteracao, dataCadastro) VALUES (@nomeRazao, @nomeFantasia, @cnpj, @inscricaoM, @inscricaoE, @endereco, @pais, @estado, @cidade, @telefone, @telefone2, @nomeContato, @email, @observacao, @idVendedor, @vendedor, @vendedorAlteracao, @dataCadastro)");
            SqlCommand exeCad = new SqlCommand(Fornecedor, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@nomeRazao", nome_RazaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@nomeFantasia", nome_FantasiaTextBox.Text);
            exeCad.Parameters.AddWithValue("@cnpj", maskCNPJ.Text);
            exeCad.Parameters.AddWithValue("@inscricaoM", maskInscricaoM.Text);
            exeCad.Parameters.AddWithValue("@inscricaoE", maskInscricaoE.Text);
            exeCad.Parameters.AddWithValue("@endereco", enderecoTextBox.Text);
            exeCad.Parameters.AddWithValue("@pais", paisComboBox.Text);
            exeCad.Parameters.AddWithValue("@estado", estadoComboBox.Text);
            exeCad.Parameters.AddWithValue("@cidade", cidadeComboBox.Text);
            exeCad.Parameters.AddWithValue("@telefone", maskTelefone.Text);
            exeCad.Parameters.AddWithValue("@telefone2", maskTelefone2.Text);
            exeCad.Parameters.AddWithValue("@nomeContato", textNomeContato.Text);
            exeCad.Parameters.AddWithValue("@email", emailTextBox.Text);
            exeCad.Parameters.AddWithValue("@observacao", observacaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedor", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedor", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", "Não possui Alteracão!");
            exeCad.Parameters.AddWithValue("@dataCadastro", DateTime.Now);

            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (nome_RazaoTextBox.Text != ("") && maskCNPJ.Text != ("") && maskInscricaoM.Text != ("") && maskInscricaoE.Text != ("") && enderecoTextBox.Text != ("") && maskTelefone.Text != (""))
            {
                nome_RazaoTextBox.Focus();

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
            string Fornecedor = ("UPDATE Fornecedores SET nomeRazao = @nomeRazao, nomeFantasia = @nomeFantasia, cnpj = @cnpj, inscricaoMunicipal = @inscricaoM, inscricaoEstadual = @inscricaoE, endereco = @endereco, pais = @pais, estado = @estado, cidade = @cidade, telefone = @telefone, telefone2 = @telefone2, nomeContato = @nomeContato, email = @email, observacao = @observacao, idVendedorAlteracao = @idVendedorAlteracao, vendedorAlteracao = @vendedorAlteracao, dataAlteracao = @dataAlteracao WHERE idFornecedor = @ID");

            SqlCommand exeCad = new SqlCommand(Fornecedor, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@ID", idTextBox.Text);
            exeCad.Parameters.AddWithValue("@nomeRazao", nome_RazaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@nomeFantasia", nome_FantasiaTextBox.Text);
            exeCad.Parameters.AddWithValue("@cnpj", maskCNPJ.Text);
            exeCad.Parameters.AddWithValue("@inscricaoM", maskInscricaoM.Text);
            exeCad.Parameters.AddWithValue("@inscricaoE", maskInscricaoE.Text);
            exeCad.Parameters.AddWithValue("@endereco", enderecoTextBox.Text);
            exeCad.Parameters.AddWithValue("@pais", paisComboBox.Text);
            exeCad.Parameters.AddWithValue("@estado", estadoComboBox.Text);
            exeCad.Parameters.AddWithValue("@cidade", cidadeComboBox.Text);
            exeCad.Parameters.AddWithValue("@telefone", maskTelefone.Text);
            exeCad.Parameters.AddWithValue("@telefone2", maskTelefone2.Text);
            exeCad.Parameters.AddWithValue("@nomeContato", textNomeContato.Text);
            exeCad.Parameters.AddWithValue("@email", emailTextBox.Text);
            exeCad.Parameters.AddWithValue("@observacao", observacaoTextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedorAlteracao", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@dataAlteracao", DateTime.Now);

            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (nome_RazaoTextBox.Text != ("") && maskCNPJ.Text != ("") && maskInscricaoM.Text != ("") && maskInscricaoE.Text != ("") && enderecoTextBox.Text != ("") && maskTelefone.Text != (""))
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
            string Fornecedor = ("DELETE FROM Fornecedores WHERE idFornecedor = @ID");

            SqlCommand exeCad = new SqlCommand(Fornecedor, banco.connection);

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha a tela de Cadastro.
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a tela de Cadastro.
            this.Close();
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            this.fornecedoresTableAdapter.Fill(this.drogariaParanaDataSet.Fornecedores);
            this.paisTableAdapter.Fill(this.drogariaParanaDataSet.Pais);
            this.estadoTableAdapter.Fill(this.drogariaParanaDataSet.Estado);
            this.cidadeTableAdapter.Fill(this.drogariaParanaDataSet.Cidade);

            comboBoxVendedor.Focus();
            comboBoxVendedor.SelectedValue = 8;
        }

        //Botão responsavel por salvar os dados inseridos para cadastro.
        private void btnSalvar_Click(object sender, EventArgs e)
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

        //Evento responsavel por ativar tarefas atribuidas a botoes de atalho no teclado.
        private void frmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;

            limparValores();
            comboBoxVendedor.Focus();
            comboBoxVendedor.SelectedValue = 8;
        }

        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            limparValores();
            labelTipoAcao.Text = "Alterar Cadastro:";
            panelAlterar.Visible = true;
            comboBoxVendedor.SelectedValue = 8;

            PesquisarTextBox.Focus();

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
                    this.fornecedoresTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Fornecedores, PesquisarTextBox.Text);

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
                this.fornecedoresTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Fornecedores, PesquisarTextBox.Text);
            }
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            limparValores();
            comboBoxVendedor.SelectedValue = 8;

            labelTipoAcao.Text = "Excluir Cadastro:";
            panelAlterar.Visible = true;

            PesquisarTextBox.Focus();

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
                this.btnSalvar_Click(sender, e);
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
    }
}
