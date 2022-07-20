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
    public partial class frmConcluirOrcamento : Form
    {
        public frmConcluirOrcamento()
        {
            InitializeComponent();
        }

        private void frmConcluirOrcamento_Load(object sender, EventArgs e)
        {
            this.relacaoNotasTableAdapter.queryOrcamento(this.drogariaParanaDataSet.RelacaoNotas);

            textPesquisa.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.relacaoNotasTableAdapter.queryOrcamento(this.drogariaParanaDataSet.RelacaoNotas);
        }
        
        private void btnConcluirOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                forms.frmFinalizarOrcamento abrir = new frmFinalizarOrcamento(this);
                abrir.ShowDialog();
                abrir.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No momento nao a Orcamentos!" + "\n" + "Por Favor, crie novos Orcamentos e tente novamente!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (radDescricaoCompra.Checked)
            {
                this.relacaoNotasTableAdapter.queryPesquisa(this.drogariaParanaDataSet.RelacaoNotas, textPesquisa.Text);
            }
            if (radDataCompra.Checked)
            {
                this.relacaoNotasTableAdapter.queryData(this.drogariaParanaDataSet.RelacaoNotas, DateTime.Parse(dataInicialMaskedTextBox.Text), DateTime.Parse(dataFinalMaskedTextBox.Text));
            }
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
            //
            dataInicialMaskedTextBox.Visible = true;
            dataFinalMaskedTextBox.Visible = true;
            //
            textPesquisa.Visible = false;

            btnPesquisar.Location = new System.Drawing.Point(407, 102);

        }

        private void radDescricaoCompra_CheckedChanged(object sender, EventArgs e)
        {
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

            textPesquisa.Focus();

            //
        }

        private void frmConcluirOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                frmFinalizarOrcamento abrir = new frmFinalizarOrcamento(this);
                abrir.ShowDialog();
                abrir.Dispose();
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
                    this.relacaoNotasTableAdapter.queryPesquisa(this.drogariaParanaDataSet.RelacaoNotas, textPesquisa.Text);
                }
                if (radDataCompra.Checked)
                {
                    this.relacaoNotasTableAdapter.queryData(this.drogariaParanaDataSet.RelacaoNotas, DateTime.Parse(dataInicialMaskedTextBox.Text), DateTime.Parse(dataFinalMaskedTextBox.Text));
                }

                dataGridViewOrcamentos.Focus();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }

        private void dataGridViewOrcamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmFinalizarOrcamento abrir = new frmFinalizarOrcamento(this);
                abrir.ShowDialog();
                abrir.Dispose();

                e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
                return;
            }
        }    
    }
}
