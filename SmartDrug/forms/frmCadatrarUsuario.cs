﻿using System;
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
    public partial class frmCadUsuario : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void AutoComplete()
        {
            try
            {
                SqlCommand exePesquisa = new SqlCommand("SELECT nome FROM Usuario", banco.connection);
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
            nome_completoTextBox.Clear();
            loginTextBox.Clear();
            combPerfil.Text = "";
            senhaTextBox.Clear();
            textRepetirSenha.Clear();
            emailTextBox.Clear();
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
            string usuario = ("INSERT INTO Usuario (nome, login, perfil, senha, email, idVendedor, Vendedor, vendedorAlteracao, dataCadastro) VALUES (@nome, @login, @perfil, @senha, @email, @idVendedor, @vendedor, @vendedorAlteracao, @dataCadastro)");
            SqlCommand exeCad = new SqlCommand(usuario, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@nome", nome_completoTextBox.Text);
            exeCad.Parameters.AddWithValue("@login", loginTextBox.Text);
            exeCad.Parameters.AddWithValue("@perfil", combPerfil.Text);
            exeCad.Parameters.AddWithValue("@senha", senhaTextBox.Text);
            exeCad.Parameters.AddWithValue("@email", emailTextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedor", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedor", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", "Não possui Alteracão!");
            exeCad.Parameters.AddWithValue("@dataCadastro", DateTime.Now);


            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (nome_completoTextBox.Text != ("") && loginTextBox.Text != ("") && combPerfil.Text != ("") && senhaTextBox.Text == textRepetirSenha.Text)
            {
                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

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
            string usuario = ("UPDATE Usuario SET nome = @nome, login = @login, perfil = @perfil, senha = @senha, email = @email, idVendedorAlteracao = @idVendedorAlteracao, vendedorAlteracao = @vendedorAlteracao, dataAlteracao = @dataAlteracao WHERE idUsuario = @ID");
            SqlCommand exeCad = new SqlCommand(usuario, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@ID", idTextBox.Text);
            exeCad.Parameters.AddWithValue("@nome", nome_completoTextBox.Text);
            exeCad.Parameters.AddWithValue("@login", loginTextBox.Text);
            exeCad.Parameters.AddWithValue("@perfil", combPerfil.Text);
            exeCad.Parameters.AddWithValue("@senha", senhaTextBox.Text);
            exeCad.Parameters.AddWithValue("@email", emailTextBox.Text);
            exeCad.Parameters.AddWithValue("@idVendedorAlteracao", comboBoxVendedor.SelectedValue);
            exeCad.Parameters.AddWithValue("@vendedorAlteracao", comboBoxVendedor.Text);
            exeCad.Parameters.AddWithValue("@dataAlteracao", DateTime.Now);

            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (nome_completoTextBox.Text != ("") && loginTextBox.Text != ("") && combPerfil.Text != ("") && senhaTextBox.Text == textRepetirSenha.Text)
            {
                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

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
            string usuario = ("DELETE FROM Usuario WHERE idUsuario = @ID");
            SqlCommand exeCad = new SqlCommand(usuario, banco.connection);

            //Passando dados por parametros para inserção no banco.
            exeCad.Parameters.AddWithValue("@ID", idTextBox.Text);

            //Verificação dos campos exigidos e senhas para proceguir com a inserção; 
            if (idTextBox.Text != "")
            {
                //Abertura(Conectar) do banco e execução da query de inserção, inserindo e salvando os dados cadastrados.
                banco.conectar();
                exeCad.ExecuteNonQuery();
                banco.desconectar();

                MessageBox.Show("Cadastro Excluido com Sucesso!");
            }
            else
            {
                MessageBox.Show("O cadastro não pôde ser Excluido." + "\n" + "Verifique os dados e tente novamente!");
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

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            this.vendedorTableAdapter.Fill(this.drogariaParanaDataSet.Vendedor);
            comboBoxVendedor.Focus();
            comboBoxVendedor.SelectedValue = 8;
        }

        //Botão responsavel por salvar os dados inseridos para cadastro.
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

        //Evento responsavel por ativar tarefas atribuidas a botoes de atalho no teclado.
        private void FrmCadUsuario_KeyDown(object sender, KeyEventArgs e)
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
                    this.usuarioTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Usuario, PesquisarTextBox.Text);

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
                this.usuarioTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Usuario, PesquisarTextBox.Text);
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

        private void nome_completoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void combPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
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
    }
}
