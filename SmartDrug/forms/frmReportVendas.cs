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
    public partial class frmReportVendas : Form
    {
        public frmReportVendas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.relacaoVendasTableAdapter.queryData(this.drogariaParanaDataSet.RelacaoVendas, DateTime.Parse(dataInicialMaskedTextBox.Text.ToString()), DateTime.Parse(dataFinalMaskedTextBox.Text.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicio", dataInicialMaskedTextBox.Text));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dataFinalMaskedTextBox.Text));
            this.reportViewer1.RefreshReport();

            dataInicialMaskedTextBox.Focus();
        }

        private void frmReportVendas_Load(object sender, EventArgs e)
        {
            dataInicialMaskedTextBox.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
