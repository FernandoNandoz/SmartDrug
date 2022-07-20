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
    public partial class frmCupomMensalidade : Form
    {
        frmFinalizarPagamento instancia;

        string vendedor;

        public frmCupomMensalidade(frmFinalizarPagamento Cupom)
        {
            InitializeComponent();
            instancia = Cupom;
          
            vendedor = instancia.vendedorComboBox.Text;

            this.relacaoMensalidadeTableAdapter.queryCupom(this.drogariaParanaDataSet.RelacaoMensalidade, instancia._idCliente);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Documento", instancia._documento));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nome", vendedor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Via", "1º Via"));
            this.reportViewer1.RefreshReport();


            using (var rpd = new PrintReportSample.ReportPrintDocument(reportViewer1.LocalReport))
            {
                rpd.Print();
            }

            reportViewer1.Clear();

            instancia.Close();
        }

        private void frmCupomMensalidade_Load(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
