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
    public partial class frmNovoHospede : Form
    {
        conexao banco = new conexao();

        string codigo, codigoM;

        public frmNovoHospede()
        {
            InitializeComponent();
        }

        private void frmNovoHospede_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.drogariaParanaDataSet.Clientes);
            textPesquisa.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Clientes, textPesquisa.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.drogariaParanaDataSet.Clientes);
        }

        private void btnGerarFatura_Click(object sender, EventArgs e)
        {
            panelDataVencimento.BringToFront();
            dataVencimentoMaskedTextBox.Focus();
            textPesquisa.TabStop = false;
            dataVencimentoMaskedTextBox.TabStop = true;
            ParcelaComboBox.TabStop = true;
            valorAluguelTextBox.TabStop = true;
        }

        private void btnCalcularFatura_Click(object sender, EventArgs e)
        {
            try
            {
                int parcela = 1, condicao = 1, addMes = 1;
                //
                parcela += int.Parse(ParcelaComboBox.Text);
                //
                DateTime data = DateTime.Parse(dataVencimentoMaskedTextBox.Text);
                //
                codigo = ("" + DateTime.Now.Second + DateTime.Now.Day + 8 + dataGridViewCliente.CurrentRow.Cells[14].Value + 1 + DateTime.Now.Month);


                string RelacaoHospedes = ("INSERT INTO RelacaoHospedes (idCliente, parcela, situacao) VALUES (@idCliente, @parcela, @situacao)");
                string Mensalidade = ("INSERT INTO Mensalidade (idCliente, idFormaPagamento, descricaoPagamento, vencimento, parcela, situacao, idVendedor, documento, valorAluguel, saldo) VALUES (@idCliente, @idFormaPagamento, @descricaoPagamento, @vencimento, @parcela, @situacao, @idVendedor, @documento, @valorAluguel, @saldo)");
                SqlCommand executRelacao = new SqlCommand(RelacaoHospedes, banco.connection);
                SqlCommand exeMensalidade = new SqlCommand(Mensalidade, banco.connection);

                executRelacao.Parameters.Clear();
                executRelacao.Parameters.AddWithValue("@idCliente", dataGridViewCliente.CurrentRow.Cells[14].Value);
                executRelacao.Parameters.AddWithValue("@parcela", int.Parse(ParcelaComboBox.Text));
                executRelacao.Parameters.AddWithValue("@situacao", "ABERTA");

                banco.conectar();
                executRelacao.ExecuteNonQuery();
                banco.desconectar();

                for (int i = 1; i < parcela; i++)
                {
                    codigoM = ("" + DateTime.Now.Second + DateTime.Now.Day + i + dataGridViewCliente.CurrentRow.Cells[14].Value + addMes + DateTime.Now.Month);

                    exeMensalidade.Parameters.Clear();
                    exeMensalidade.Parameters.AddWithValue("@idCliente", dataGridViewCliente.CurrentRow.Cells[14].Value);
                    exeMensalidade.Parameters.AddWithValue("@idFormaPagamento", 1);
                    exeMensalidade.Parameters.AddWithValue("@descricaoPagamento", dataGridViewCliente.CurrentRow.Cells[0].Value);
                    if (condicao == 1)
                    {
                        exeMensalidade.Parameters.AddWithValue("@vencimento", DateTime.Parse(data.ToShortDateString()));
                        condicao = 0;
                    }
                    else
                    {
                        exeMensalidade.Parameters.AddWithValue("@vencimento", DateTime.Parse(data.AddMonths(addMes).ToShortDateString()));
                        addMes = addMes + 1;
                    }
                    exeMensalidade.Parameters.AddWithValue("@parcela", i);
                    exeMensalidade.Parameters.AddWithValue("@situacao", "ABERTA");
                    exeMensalidade.Parameters.AddWithValue("@idVendedor", 8);
                    exeMensalidade.Parameters.AddWithValue("@documento", codigoM);
                    exeMensalidade.Parameters.AddWithValue("@valorAluguel", decimal.Parse(valorAluguelTextBox.Text));
                    exeMensalidade.Parameters.AddWithValue("@saldo", decimal.Parse(valorAluguelTextBox.Text));

                    banco.conectar();
                    exeMensalidade.ExecuteNonQuery();
                    banco.desconectar();
                }


                MessageBox.Show("Fatura Gerada com Sucesso!!");

                panelDataVencimento.SendToBack();
                textPesquisa.Focus();
                textPesquisa.TabStop = true;
                dataVencimentoMaskedTextBox.TabStop = false;
                ParcelaComboBox.TabStop = false;
                valorAluguelTextBox.TabStop = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelDataVencimento.SendToBack();
            textPesquisa.Focus();
            textPesquisa.TabStop = true;
            dataVencimentoMaskedTextBox.TabStop = false;
            ParcelaComboBox.TabStop = false;
            valorAluguelTextBox.TabStop = false;
        }

        private void valorAluguelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int parcela = 1, condicao = 1, addMes = 1;
                    //
                    parcela += int.Parse(ParcelaComboBox.Text);
                    //
                    DateTime data = DateTime.Parse(dataVencimentoMaskedTextBox.Text);
                    //
                    codigo = ("" + DateTime.Now.Second + DateTime.Now.Day + 8 + dataGridViewCliente.CurrentRow.Cells[14].Value + 1 + DateTime.Now.Month);


                    string RelacaoHospedes = ("INSERT INTO RelacaoHospedes (idCliente, parcela, situacao) VALUES (@idCliente, @parcela, @situacao)");
                    string Mensalidade = ("INSERT INTO Mensalidade (idCliente, idFormaPagamento, descricaoPagamento, vencimento, parcela, situacao, idVendedor, documento, valorAluguel, saldo) VALUES (@idCliente, @idFormaPagamento, @descricaoPagamento, @vencimento, @parcela, @situacao, @idVendedor, @documento, @valorAluguel, @saldo)");
                    SqlCommand executRelacao = new SqlCommand(RelacaoHospedes, banco.connection);
                    SqlCommand exeMensalidade = new SqlCommand(Mensalidade, banco.connection);

                    executRelacao.Parameters.Clear();
                    executRelacao.Parameters.AddWithValue("@idCliente", dataGridViewCliente.CurrentRow.Cells[14].Value);
                    executRelacao.Parameters.AddWithValue("@parcela", int.Parse(ParcelaComboBox.Text));
                    executRelacao.Parameters.AddWithValue("@situacao", "ABERTA");

                    banco.conectar();
                    executRelacao.ExecuteNonQuery();
                    banco.desconectar();

                    for (int i = 1; i < parcela; i++)
                    {
                        codigoM = ("" + DateTime.Now.Second + DateTime.Now.Day + i + dataGridViewCliente.CurrentRow.Cells[14].Value + addMes + DateTime.Now.Month);

                        exeMensalidade.Parameters.Clear();
                        exeMensalidade.Parameters.AddWithValue("@idCliente", dataGridViewCliente.CurrentRow.Cells[14].Value);
                        exeMensalidade.Parameters.AddWithValue("@idFormaPagamento", 1);
                        exeMensalidade.Parameters.AddWithValue("@descricaoPagamento", dataGridViewCliente.CurrentRow.Cells[0].Value);
                        if (condicao == 1)
                        {
                            exeMensalidade.Parameters.AddWithValue("@vencimento", DateTime.Parse(data.ToShortDateString()));
                            condicao = 0;
                        }
                        else
                        {
                            exeMensalidade.Parameters.AddWithValue("@vencimento", DateTime.Parse(data.AddMonths(addMes).ToShortDateString()));
                            addMes = addMes + 1;
                        }
                        exeMensalidade.Parameters.AddWithValue("@parcela", i);
                        exeMensalidade.Parameters.AddWithValue("@situacao", "ABERTA");
                        exeMensalidade.Parameters.AddWithValue("@idVendedor", 8);
                        exeMensalidade.Parameters.AddWithValue("@documento", codigoM);
                        exeMensalidade.Parameters.AddWithValue("@valorAluguel", decimal.Parse(valorAluguelTextBox.Text));
                        exeMensalidade.Parameters.AddWithValue("@saldo", decimal.Parse(valorAluguelTextBox.Text));

                        banco.conectar();
                        exeMensalidade.ExecuteNonQuery();
                        banco.desconectar();
                    }


                    MessageBox.Show("Fatura Gerada com Sucesso!!");

                    panelDataVencimento.SendToBack();
                    textPesquisa.Focus();
                    textPesquisa.TabStop = true;
                    dataVencimentoMaskedTextBox.TabStop = false;
                    ParcelaComboBox.TabStop = false;
                    valorAluguelTextBox.TabStop = false;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmNovoHospede_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fecharGerarFaturaPictureBox_Click(object sender, EventArgs e)
        {
            panelDataVencimento.SendToBack();
        }

        private void textPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.clientesTableAdapter.queryPesquisa(this.drogariaParanaDataSet.Clientes, textPesquisa.Text);

                dataGridViewCliente.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void dataGridViewCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                panelDataVencimento.BringToFront();
                dataVencimentoMaskedTextBox.Focus();
                textPesquisa.TabStop = false;
                dataVencimentoMaskedTextBox.TabStop = true;
                ParcelaComboBox.TabStop = true;
                valorAluguelTextBox.TabStop = true;

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }
    }
}
