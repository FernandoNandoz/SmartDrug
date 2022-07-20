using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;

namespace SmartDrug.forms
{
    public partial class frmReemprimirVenda : Form
    {

        public frmReemprimirVenda()
        {
            InitializeComponent();
        }

        #region Metodo Deconstrucao que deu certo, não necessita do report viewer
        private void imprimir()
        {
            PrintDocument printDoc = new PrintDocument();
            //printDoc.PrinterSettings.PrinterName = "Bematech 4200";
            printDoc.DocumentName = "Cupom";

            //if (!printDoc.PrinterSettings.IsValid)
                //throw new Exception("Não foi possível localizar a impressora");

            printDoc.PrintPage += new PrintPageEventHandler(PrintPageFicha);

            printDoc.Print();
        }

        private void PrintPageFicha(object sender, PrintPageEventArgs ev)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 17f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            ev.Graphics.DrawString("PDV : " + "DINAIAS", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("PDV : " + "dinaias", pdvFont);
            currentUsedHeight += size.Height;

            ev.Graphics.DrawString("VENDA : Cartão", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("VENDA", pdvFont);
            currentUsedHeight += size.Height;
        }
        #endregion

       
        private void frmReemprimirVenda_Load(object sender, EventArgs e)
        {
            this.relacaoContasTableAdapter.queryPagoReemprimirVenda(this.drogariaParanaDataSet.RelacaoContas);
            textPesquisa.Focus();
        }       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.relacaoContasTableAdapter.queryPagoReemprimirVenda(this.drogariaParanaDataSet.RelacaoContas);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radDescricaoCompra.Checked)
            {
                this.relacaoContasTableAdapter.queryPesquisa(this.drogariaParanaDataSet.RelacaoContas, textPesquisa.Text);
            }
            if (radDataCompra.Checked)
            {
                this.relacaoContasTableAdapter.queryReportData(this.drogariaParanaDataSet.RelacaoContas, DateTime.Parse(dataInicialMaskedTextBox.Text), DateTime.Parse(dataFinalMaskedTextBox.Text));
            }
        }

        private void radDescricaoCompra_CheckedChanged(object sender, EventArgs e)
        {
            textPesquisa.Focus();
            //
            textPesquisa.TabIndex = 0;
            textPesquisa.TabStop = true;
            dataInicialMaskedTextBox.TabStop = false;
            dataFinalMaskedTextBox.TabStop = false;
            //
            dataInicialMaskedTextBox.Visible = false;
            dataFinalMaskedTextBox.Visible = false;
            //
            textPesquisa.Visible = true;
            //
            btnPesquisar.Location = new System.Drawing.Point(565, 102);
           
        }

        private void radDataCompra_CheckedChanged(object sender, EventArgs e)
        {
            dataInicialMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            dataFinalMaskedTextBox.Text = DateTime.Now.ToShortDateString();

            dataInicialMaskedTextBox.TabIndex = 0;
            dataFinalMaskedTextBox.TabIndex = 1;
            textPesquisa.TabStop = false;
            dataInicialMaskedTextBox.TabStop = true;
            dataFinalMaskedTextBox.TabStop = true;
            //
            dataInicialMaskedTextBox.Focus();
            //
            btnPesquisar.Location = new System.Drawing.Point(407, 102);
            //
            dataInicialMaskedTextBox.Visible = true;
            dataFinalMaskedTextBox.Visible = true;
            //
            textPesquisa.Visible = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frmCupomReemprimirVenda abrir = new frmCupomReemprimirVenda(this);
                abrir.ShowDialog();
                abrir.Dispose();
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

        private void textPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (radDescricaoCompra.Checked)
                {
                    this.relacaoContasTableAdapter.queryPesquisa(this.drogariaParanaDataSet.RelacaoContas, textPesquisa.Text);
                }
                if (radDataCompra.Checked)
                {
                    this.relacaoContasTableAdapter.queryReportData(this.drogariaParanaDataSet.RelacaoContas, DateTime.Parse(dataInicialMaskedTextBox.Text), DateTime.Parse(dataFinalMaskedTextBox.Text));
                }

                dataGridViewReemprimirVendas.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void dataGridViewReemprimirVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmCupomReemprimirVenda abrir = new frmCupomReemprimirVenda(this);
                abrir.ShowDialog();
                abrir.Dispose();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }
    }
}
