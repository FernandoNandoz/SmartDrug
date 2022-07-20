using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDrug
{
    public partial class frmReemprimirMensalidade : Form
    {
        forms.frmControlePagamento instancia;

        string nota, vendedor;

        public frmReemprimirMensalidade(forms.frmControlePagamento cupom)
        {
            InitializeComponent();
            instancia = cupom;

            vendedor = instancia.RelacaoContaDataGridView.CurrentRow.Cells[13].Value.ToString();
            nota = instancia.RelacaoContaDataGridView.CurrentRow.Cells[12].Value.ToString();

            this.relacaoMensalidadeTableAdapter.queryNota(this.drogariaParanaDataSet.RelacaoMensalidade, nota);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Documento", nota));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nome", vendedor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Via", "2ª Via"));
            this.reportViewer1.RefreshReport();
        }

        private void frmReemprimirMensalidade_Load(object sender, EventArgs e)
        {
            
        }
    }
}
