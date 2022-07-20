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
    public partial class frmAcrecimoVenda : Form
    {
        public frmAcrecimoVenda()
        {
            InitializeComponent();
        }

        public decimal _Valor { get; set; }

        private void frmAcrecimoVenda_Load(object sender, EventArgs e)
        {

        }

        private void frmAcrecimoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnConfirmar_Click(sender, e);
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirmar.Focus();

            e.SuppressKeyPress = true;//para cancelar o evento Press e não reproduzir o som
            return;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _Valor = Convert.ToDecimal(txtCodigo.Text);
            }

            this.Close();
        }

        private void frmAcrecimoVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _Valor = Convert.ToDecimal(txtCodigo.Text);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString().Equals(","))
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }
    }
}
