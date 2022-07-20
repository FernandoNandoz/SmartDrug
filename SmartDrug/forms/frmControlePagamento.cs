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
    public partial class frmControlePagamento : Form
    {
        conexao banco = new conexao();

        frmHospedes instancia;

        int ID, ultimaParcela = 0, addMes = 1;

        string codigo, codigoM, ultimaData, proximaData, valorAluguel;

        public frmControlePagamento(frmHospedes hospedes)
        {
            InitializeComponent();
            instancia = hospedes;

            ID = int.Parse(instancia.hospedesDataGridView.CurrentRow.Cells[6].Value.ToString());
        }

        private void verificarUltimaParcela()
        {
            RelacaoContaDataGridView.Sort(RelacaoContaDataGridView.Columns[1], ListSortDirection.Ascending);

            for (int i = 0; i < RelacaoContaDataGridView.Rows.Count; i++)
            {
                DataGridViewCell parc = this.RelacaoContaDataGridView.Rows[i].Cells[1];
                DataGridViewCell ultimadata = this.RelacaoContaDataGridView.Rows[i].Cells[2];
                DataGridViewCell ValorAluguel = this.RelacaoContaDataGridView.Rows[i].Cells[4];
                ultimaParcela = Convert.ToInt32(parc.Value);
                ultimaData = Convert.ToString(ultimadata.Value);
                valorAluguel = Convert.ToString(ValorAluguel.Value);
            }
            //
            DateTime DATA = DateTime.Parse(ultimaData);

            proximaData = DATA.AddMonths(addMes).ToShortDateString(); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.relacaoMensalidadeTableAdapter.queryID(this.drogariaParanaDataSet.RelacaoMensalidade, ID);
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (labelSituacao.Text == "PAGO")
            {
                frmReemprimirMensalidade abrir = new frmReemprimirMensalidade(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            else
            {
                MessageBox.Show("Esta mensalidade não possui Comprovante de Pagamento, pois ainda nao foi paga!" + "\n" + "Efetue o pagamento e tente novamente!");
            }

        }

        private void frmControlePagamento_Load(object sender, EventArgs e)
        {
            RelacaoContaDataGridView.Focus();
            try
            {
                this.relacaoMensalidadeTableAdapter.queryID(this.drogariaParanaDataSet.RelacaoMensalidade, ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmControlePagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    if (labelSituacao.Text != "PAGO")
                    {
                        frmFinalizarPagamento abrir = new frmFinalizarPagamento(this);
                        abrir.ShowDialog();
                        abrir.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Esta Mensalidade ja foi Paga! Verifique a Situação da Mensalidade e tente novamente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void RelacaoContaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                for (int i = 0; i < RelacaoContaDataGridView.Rows.Count - 0; ++i)
                {
                    if (RelacaoContaDataGridView.Rows[i].Cells[6].Value.ToString() == "ATRASADO")
                    {
                        RelacaoContaDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        RelacaoContaDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    }

                    if (RelacaoContaDataGridView.Rows[i].Cells[6].Value.ToString() == "PAGO")
                    {
                        RelacaoContaDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                        RelacaoContaDataGridView.Rows[i].DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
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

        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelSituacao.Text != "PAGO")
                {
                    frmFinalizarPagamento abrir = new frmFinalizarPagamento(this);
                    abrir.ShowDialog();
                    abrir.Dispose();
                }
                else
                {
                    MessageBox.Show("Esta Mensalidade ja foi Paga! Verifique a Situação da Mensalidade e tente novamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RelacaoContaDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmFinalizarPagamento abrir = new frmFinalizarPagamento(this);
                abrir.ShowDialog();
                abrir.Dispose();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void btnRenovarMensalidade_Click(object sender, EventArgs e)
        {
            verificarUltimaParcela();

            labelUltimaData.Text = ultimaData;
            labelUltimaParcela.Text = "" + ultimaParcela;
            labelValorAluguel.Text = valorAluguel;

            dataVencimentoMaskedTextBox.Text = proximaData;

            panelDataVencimento.Visible = true;
            panelDataVencimento.BringToFront();
            dataVencimentoMaskedTextBox.Focus();
            dataVencimentoMaskedTextBox.TabStop = true;
            ParcelaComboBox.TabStop = true;
            valorAluguelTextBox.TabStop = true;
        }


        #region Panel Renovar Mensalidades

        private void fecharGerarFaturaPictureBox_Click(object sender, EventArgs e)
        {
            panelDataVencimento.SendToBack();
            RelacaoContaDataGridView.Focus();
            dataVencimentoMaskedTextBox.TabStop = false;
            ParcelaComboBox.TabStop = false;
            valorAluguelTextBox.TabStop = false;
        }

        private void btnCalcularFatura_Click(object sender, EventArgs e)
        {
            try
            {
                int parcela = 1, condicao = 1;
                //
                parcela += int.Parse(ParcelaComboBox.Text);
                //
                DateTime data = DateTime.Parse(ultimaData);
                //
                codigo = ("" + DateTime.Now.Second + DateTime.Now.Day + 8 + ID + 1 + DateTime.Now.Month);

                string Mensalidade = ("INSERT INTO Mensalidade (idCliente, idFormaPagamento, descricaoPagamento, vencimento, parcela, situacao, idVendedor, documento, valorAluguel, saldo) VALUES (@idCliente, @idFormaPagamento, @descricaoPagamento, @vencimento, @parcela, @situacao, @idVendedor, @documento, @valorAluguel, @saldo)");
                SqlCommand exeMensalidade = new SqlCommand(Mensalidade, banco.connection);

                for (int i = 1; i < parcela; i++)
                {
                    ultimaParcela += 1;

                    codigoM = ("" + DateTime.Now.Second + DateTime.Now.Day + i + ID + addMes + DateTime.Now.Month);

                    exeMensalidade.Parameters.Clear();
                    exeMensalidade.Parameters.AddWithValue("@idCliente", ID);
                    exeMensalidade.Parameters.AddWithValue("@idFormaPagamento", 1);
                    exeMensalidade.Parameters.AddWithValue("@descricaoPagamento", RelacaoContaDataGridView.CurrentRow.Cells[0].Value);
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
                    exeMensalidade.Parameters.AddWithValue("@parcela", ultimaParcela);
                    exeMensalidade.Parameters.AddWithValue("@situacao", "ABERTA");
                    exeMensalidade.Parameters.AddWithValue("@idVendedor", 8);
                    exeMensalidade.Parameters.AddWithValue("@documento", codigoM);
                    exeMensalidade.Parameters.AddWithValue("@valorAluguel", decimal.Parse(valorAluguelTextBox.Text));
                    exeMensalidade.Parameters.AddWithValue("@saldo", decimal.Parse(valorAluguelTextBox.Text));

                    banco.conectar();
                    exeMensalidade.ExecuteNonQuery();
                    banco.desconectar();
                }


                MessageBox.Show("Mensalidade Renovada com Sucesso!!");

                panelDataVencimento.Visible = false;
                panelDataVencimento.SendToBack();
                RelacaoContaDataGridView.Focus();
                dataVencimentoMaskedTextBox.TabStop = false;
                ParcelaComboBox.TabStop = false;
                valorAluguelTextBox.TabStop = false;

                RelacaoContaDataGridView.Focus();
                try
                {
                    this.relacaoMensalidadeTableAdapter.queryID(this.drogariaParanaDataSet.RelacaoMensalidade, ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelDataVencimento.Visible = false;
            panelDataVencimento.SendToBack();
            RelacaoContaDataGridView.Focus();
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
                    int parcela = 1, condicao = 1;
                    //
                    parcela += int.Parse(ParcelaComboBox.Text);
                    //
                    DateTime data = DateTime.Parse(ultimaData);
                    //
                    codigo = ("" + DateTime.Now.Second + DateTime.Now.Day + 8 + ID + 1 + DateTime.Now.Month);

                    string Mensalidade = ("INSERT INTO Mensalidade (idCliente, idFormaPagamento, descricaoPagamento, vencimento, parcela, situacao, idVendedor, documento, valorAluguel, saldo) VALUES (@idCliente, @idFormaPagamento, @descricaoPagamento, @vencimento, @parcela, @situacao, @idVendedor, @documento, @valorAluguel, @saldo)");
                    SqlCommand exeMensalidade = new SqlCommand(Mensalidade, banco.connection);

                    for (int i = 1; i < parcela; i++)
                    {
                        ultimaParcela += 1;

                        codigoM = ("" + DateTime.Now.Second + DateTime.Now.Day + i + ID + addMes + DateTime.Now.Month);

                        exeMensalidade.Parameters.Clear();
                        exeMensalidade.Parameters.AddWithValue("@idCliente", ID);
                        exeMensalidade.Parameters.AddWithValue("@idFormaPagamento", 1);
                        exeMensalidade.Parameters.AddWithValue("@descricaoPagamento", RelacaoContaDataGridView.CurrentRow.Cells[0].Value);
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
                        exeMensalidade.Parameters.AddWithValue("@parcela", ultimaParcela);
                        exeMensalidade.Parameters.AddWithValue("@situacao", "ABERTA");
                        exeMensalidade.Parameters.AddWithValue("@idVendedor", 8);
                        exeMensalidade.Parameters.AddWithValue("@documento", codigoM);
                        exeMensalidade.Parameters.AddWithValue("@valorAluguel", decimal.Parse(valorAluguelTextBox.Text));
                        exeMensalidade.Parameters.AddWithValue("@saldo", decimal.Parse(valorAluguelTextBox.Text));

                        banco.conectar();
                        exeMensalidade.ExecuteNonQuery();
                        banco.desconectar();
                    }


                    MessageBox.Show("Mensalidade Renovada com Sucesso!!");

                    panelDataVencimento.Visible = false;
                    panelDataVencimento.SendToBack();
                    RelacaoContaDataGridView.Focus();
                    dataVencimentoMaskedTextBox.TabStop = false;
                    ParcelaComboBox.TabStop = false;
                    valorAluguelTextBox.TabStop = false;


                    RelacaoContaDataGridView.Focus();
                    try
                    {
                        this.relacaoMensalidadeTableAdapter.queryID(this.drogariaParanaDataSet.RelacaoMensalidade, ID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion
    }
}
