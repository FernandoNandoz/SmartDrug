using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDrug.forms
{
    public partial class ctrConfigurações : UserControl
    {
        public ctrConfigurações()
        {
            InitializeComponent();
        }

        private void btnPic_Configuracoes_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
