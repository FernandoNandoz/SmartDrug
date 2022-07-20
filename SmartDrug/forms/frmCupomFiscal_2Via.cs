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
    public partial class frmCupomFiscal_2Via : Form
    {
        frmFluxoCaixa instancia;

        string Nota, data;

        public frmCupomFiscal_2Via(frmFluxoCaixa fluxo)
        {
            InitializeComponent();
            instancia = fluxo;

            Nota = instancia.fluxoCaixaDataGridView.CurrentRow.Cells[0].Value.ToString();
            data = instancia.fluxoCaixaDataGridView.CurrentRow.Cells[2].Value.ToString();

            this.relacaoContasTableAdapter.queryNota(this.drogariaParanaDataSet.RelacaoContas, Nota);
            this.relacaoVendasTableAdapter.queryReceber(this.drogariaParanaDataSet.RelacaoVendas, Nota);
            this.relacaoNotasTableAdapter.queryNotaVenda(this.drogariaParanaDataSet.RelacaoNotas, Nota);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataCompra", data));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("title", "C U P O M  D E  V E N D A"));
            this.reportViewer1.RefreshReport();
        }

        private void frmCupomFiscal_2Via_Load(object sender, EventArgs e)
        {
            
        }
    }
}
