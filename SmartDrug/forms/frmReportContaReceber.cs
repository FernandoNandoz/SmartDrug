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
    public partial class frmReportContaReceber : Form
    {
        public frmReportContaReceber()
        {
            InitializeComponent();
        }

        private void frmReportContaReceber_Load(object sender, EventArgs e)
        {
            tipoRelatorioComboBox.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tipoRelatorioComboBox.Text == "Contas a Receber")
            {
                this.relacaoContasTableAdapter.queryReportData(this.drogariaParanaDataSet.RelacaoContas, DateTime.Parse(dataInicialMaskedTextBox.Text.ToString()), DateTime.Parse(dataFinalMaskedTextBox.Text.ToString()));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataInicio", dataInicialMaskedTextBox.Text));
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataFinal", dataFinalMaskedTextBox.Text));
                this.relacaoHaverTableAdapter.Fill(this.drogariaParanaDataSet.RelacaoHaver);
            }
            this.reportViewer1.RefreshReport();

            tipoRelatorioComboBox.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReportContaReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
