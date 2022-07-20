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
    public partial class frmCadastrosOrganizacionais : Form
    {
        //Chama a conexao do banco de dados feita em uma Calss(VariavelGlobais) e atribue a uma variavel publica.
        conexao banco = new conexao();

        public frmCadastrosOrganizacionais()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Pais = ("INSERT INTO Pais (Pais) Values (@descricao)");
            string Estado = ("INSERT INTO Estado (Estado) Values (@descricao)");
            string Cidade = ("INSERT INTO Cidade (Cidade) Values (@descricao)");
            string Banco = ("INSERT INTO Banco (banco) Values (@descricao)");
            string Vendedor = ("INSERT INTO Vendedor (nome) Values (@descricao)");
             
            if (radPais.Checked)
            {
                if (descricaoTextBox.Text != (""))
                {
                    SqlCommand execultPai = new SqlCommand(Pais, banco.connection);
                    banco.conectar();
                    execultPai.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    execultPai.ExecuteNonQuery();
                    banco.desconectar();
                    descricaoTextBox.Clear();
                    MessageBox.Show("Pais Cadastrado com Sucesso!");
                }
                else
                    MessageBox.Show("Não foi possivel Salvar pois não a nada informado.");
            }
            
            if(radEstado.Checked)
            {
                if (descricaoTextBox.Text != (""))
                {
                    SqlCommand execult = new SqlCommand(Estado, banco.connection);
                    banco.conectar();
                    execult.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    execult.ExecuteNonQuery();
                    banco.desconectar();
                    descricaoTextBox.Clear();
                    MessageBox.Show("Estado Cadastrado com Sucesso!");
                }
                else
                    MessageBox.Show("Não foi possivel Salvar pois não a nada informado.");
            }

            if(radCidade.Checked)
            {
                if (descricaoTextBox.Text != (""))
                {
                    SqlCommand execult = new SqlCommand(Cidade, banco.connection);
                    banco.conectar();
                    execult.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    execult.ExecuteNonQuery();
                    banco.desconectar();
                    descricaoTextBox.Clear();
                    MessageBox.Show("Cidade Cadastrado com Sucesso!");
                }
                else
                    MessageBox.Show("Não foi possivel Salvar pois não a nada informado.");
            }

            if(radBanco.Checked)
            {
                if (descricaoTextBox.Text != (""))
                {
                    SqlCommand execult = new SqlCommand(Banco, banco.connection);
                    banco.conectar();
                    execult.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    execult.ExecuteNonQuery();
                    banco.desconectar();
                    descricaoTextBox.Clear();
                    MessageBox.Show("Banco Cadastrado com Sucesso!");
                }
                else
                    MessageBox.Show("Não foi possivel Salvar pois não a nada informado.");
            }

            if(radVendedor.Checked)
            {
                if (descricaoTextBox.Text != (""))
                {
                    SqlCommand execult = new SqlCommand(Vendedor, banco.connection);
                    banco.conectar();
                    execult.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                    execult.ExecuteNonQuery();
                    banco.desconectar();
                    descricaoTextBox.Clear();
                    MessageBox.Show("Vendedor Cadastrado com Sucesso!");
                }
                else
                    MessageBox.Show("Não foi possivel Salvar pois não a nada informado.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrosOrganizacionais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmCadastrosOrganizacionais_Load(object sender, EventArgs e)
        {
            descricaoTextBox.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descricaoTextBox_KeyDown(object sender, KeyEventArgs e)
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
    }
}
