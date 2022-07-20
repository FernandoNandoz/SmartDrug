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
    public partial class frmDetalhesReceberCupom : Form
    {
        frmReceber instancia;

        string Nota, data;

        public frmDetalhesReceberCupom(frmReceber cupom)
        {
            InitializeComponent();
            instancia = cupom;

            if (instancia._StatusDoCupom == "ver produtos")
            {
                Nota = instancia.dataGridViewHistorico.CurrentRow.Cells[13].Value.ToString();
                data = instancia.dataGridViewHistorico.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                Nota = instancia.dataGridViewAlterarNota.CurrentRow.Cells[13].Value.ToString();
                data = instancia.dataGridViewAlterarNota.CurrentRow.Cells[0].Value.ToString();
            }

            this.relacaoContasTableAdapter.queryNota(this.drogariaParanaDataSet.RelacaoContas, Nota);
            this.relacaoVendasTableAdapter.queryReceber(this.drogariaParanaDataSet.RelacaoVendas, Nota);
            this.relacaoNotasTableAdapter.queryNotaVenda(this.drogariaParanaDataSet.RelacaoNotas, Nota);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataCompra", data));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("title", "C U P O M  D E  V E N D A"));
            this.reportViewer1.RefreshReport();
        }

        private void frmDetalhesReceberCupom_Load(object sender, EventArgs e)
        {
            
        }
    }
}
