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
    public partial class frmNovaVenda : Form
    {
        public frmNovaVenda()
        {
            InitializeComponent();
        }

        private void btnPic_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovaVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void frmNovaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else
                if (e.KeyCode == Keys.F)
                {
                    forms.frmFinalizarCompra abrir = new frmFinalizarCompra();
                    abrir.ShowDialog();
                    abrir.Dispose();
                }
        }
    }
}
