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
    public partial class frmCupomNaoFiscalContaReceber : Form
    {
        frmReceber instancia;

        string data, formaPagamento, codigoHaver;
        int ID;

        public frmCupomNaoFiscalContaReceber(frmReceber CupomContaReceber)
        {
            InitializeComponent();
            instancia = CupomContaReceber;

            formaPagamento = instancia.formaPagamentoTextBox.Text;
            ID = instancia._idCliente;
            codigoHaver = instancia._codigoHaverCupom;

            if (instancia._StausDaImpressoa != "normal")
            {
                this.listaContasTableAdapter.queryCUPOM(this.drogariaParanaDataSet.ListaContas, ID, codigoHaver);
                this.haverContasReceberTableAdapter.queryCUPOM(drogariaParanaDataSet.HaverContasReceber, ID, codigoHaver);

                data = DateTime.Parse(instancia.dataGridViewDetalhesHaver.CurrentRow.Cells[0].Value.ToString()).ToString();

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FormaPagamento", formaPagamento));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", data));
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.listaContasTableAdapter.queryCUPOM(this.drogariaParanaDataSet.ListaContas, ID, codigoHaver);
                this.haverContasReceberTableAdapter.queryCUPOM(drogariaParanaDataSet.HaverContasReceber, ID, codigoHaver);

                data = DateTime.Now.ToString();

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("FormaPagamento", formaPagamento));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", data));
                this.reportViewer1.RefreshReport();

                using (var rpd = new PrintReportSample.ReportPrintDocument(reportViewer1.LocalReport))
                {
                    rpd.Print();
                }

                reportViewer1.Clear();

                instancia.dataGridViewApagar.Refresh();
                instancia.dataGridViewHistorico.Refresh();

                instancia.panelPagamento.Visible = false;
                instancia.panelAPagar.Visible = true;
                instancia.checkBoxPesquisar.Enabled = true;
            }
        }

        private void frmCupomNaoFiscalContaReceber_Load(object sender, EventArgs e)
        {
            if (instancia._StausDaImpressoa == "normal")
            {
                this.Close();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void sair()
        {
            this.Close();
        }

        private void frmCupomNaoFiscalContaReceber_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
