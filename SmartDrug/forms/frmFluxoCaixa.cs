using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDrug.forms
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                //Codigo responsavel por trazer todas as informações da tabela no banco de dados para as TextBox (Totais Creditos e Totais Debitos).
                this.totaisCaixaTableAdapter.Fill(this.drogariaParanaDataSet.TotaisCaixa);

                //Codigo responsavel por trazer todas as informações da tabela no banco de dados para o DataGridView.
                this.fluxoCaixaTableAdapter.Fill(this.drogariaParanaDataSet.FluxoCaixa);

                //Codigo responsavel pelo calculo dos valores obtidos por (Totais Credito) e (Totais Debito), e em seguida mostar o resultado em tempo real na TexBox (Totais Caixa).
                decimal num1 = 0, num2 = 0, TotalCaixa;

                if (textTotalCredito.Text == ("") && (textTotalDebito.Text == ("")))
                {
                    textTotalCredito.Text = "0";
                    textTotalDebito.Text = "0";
                }
                num1 = decimal.Parse(textTotalCredito.Text);
                num2 = decimal.Parse(textTotalDebito.Text);

                TotalCaixa = num1 - num2;

                //TextBox que recebe o valor do calculo.
                textTotalCaixa.Text = ("" + TotalCaixa);

                //Codigo responsavel por converter os valor das respectivas TextBox para o formato Decimal (Real = 0,00).
                textTotalCredito.Text = Convert.ToDecimal(textTotalCredito.Text).ToString("C2");
                textTotalDebito.Text = Convert.ToDecimal(textTotalDebito.Text).ToString("C2");
                textTotalCaixa.Text = Convert.ToDecimal(textTotalCaixa.Text).ToString("C2");

                btnAtualizar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (dataInicialMaskedTextBox.Text == ("") || dataFinalMaskedTextBox.Text == (""))
            {
                this.fluxoCaixaTableAdapter.Fill(this.drogariaParanaDataSet.FluxoCaixa);
            }
            else
            {
                try
                {
                    this.fluxoCaixaTableAdapter.queryPesquisa(this.drogariaParanaDataSet.FluxoCaixa, DateTime.Parse(dataInicialMaskedTextBox.Text.ToString()), DateTime.Parse(dataFinalMaskedTextBox.Text.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, Verifique se as data estao inseridas corretamente, e tente novamente!");
                }
            }
        }

        private void frmFluxoCaixa_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Codigo responsavel por trazer novamente todas as informações da tabela no banco de dados e atualizar no DataGridView.
            this.fluxoCaixaTableAdapter.Fill(this.drogariaParanaDataSet.FluxoCaixa);
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frmCupomFiscal_2Via abrir = new frmCupomFiscal_2Via(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            //Fecha a Tela.
            this.Close();
        }

    }
}
