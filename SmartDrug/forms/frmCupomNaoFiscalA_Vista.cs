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
    public partial class frmCupomNaoFiscalA_Vista : Form
    {
        frmFinalizarVenda instancia;

        string NOTA;

        public frmCupomNaoFiscalA_Vista(frmFinalizarVenda venda)
        {
            InitializeComponent();
            instancia = venda;

            NOTA = instancia.NOTAtextBox.Text;

            this.relacaoContasTableAdapter.queryNota(this.drogariaParanaDataSet.RelacaoContas, NOTA);
            this.relacaoNotasTableAdapter.queryNotaVenda(this.drogariaParanaDataSet.RelacaoNotas, NOTA);
            this.relacaoVendasTableAdapter.queryReceber(this.drogariaParanaDataSet.RelacaoVendas, NOTA);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Vendedor", instancia.vendedorComboBox.Text));
            this.reportViewer1.RefreshReport();

            using (var rpd = new PrintReportSample.ReportPrintDocument(reportViewer1.LocalReport))
            {
                rpd.Print();
            }

            reportViewer1.Clear();

            instancia.Close();
        }

        private void frmCupomNaoFiscalA_Vista_Load(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
