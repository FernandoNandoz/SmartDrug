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
    public partial class frmPrincipal : Form
    {
        conexao banco = new conexao();

        public frmPrincipal()
        {
            InitializeComponent();
            customizeDesing();

            timerHorarioAtual.Enabled = true;
            timerHorarioAtual.Interval = 1000;
            timerHorarioAtual.Tick += timerHorarioAtual_Tick;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }


        private void timerHorarioAtual_Tick(object sender, EventArgs e)
        {
            labelHorario.Text = (DateTime.Now.ToString("HH:mm:ss"));

            if (DateTime.Now.Hour >= 00 && DateTime.Now.Hour <= 12)
            {
                labelPeriodo.Text = "Bom Dia!!";
            }

            if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 18)
            {
                labelPeriodo.Text = "Boa Tarde!!";
            }

            if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour <= 23)
            {
                labelPeriodo.Text = "Boa Noite!!";
            }
        }

        private void customizeDesing()
        {
            subCadastrar.Visible = false;
            subEstoque.Visible = false;
            subFinanceiro.Visible = false;
            subRelatorio.Visible = false;
            subConfiguracoes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subCadastrar.Visible == true)
            {
                subCadastrar.Visible = false;
            }

            if (subEstoque.Visible == true)
            {
                subEstoque.Visible = false;
            }

            if (subFinanceiro.Visible == true)
            {
                subFinanceiro.Visible = false;
            }

            if (subRelatorio.Visible == true)
            {
                subRelatorio.Visible = false;
            }

            if (subConfiguracoes.Visible == true)
            {
                subConfiguracoes.Visible = false;
            }

            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            showSubMenu(subCadastrar);
        }

        #region SubMenuCadastrar
        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCadUsuario());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmCadProduto());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmCadCliente());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmCadFornecedor());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmCadFuncionario());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        #endregion

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            showSubMenu(subEstoque);
        }

        #region SubMenuEstoque
        private void btnEntradaEstoque_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmEntradaEstoque());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        #endregion

        private void btnVendas_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmVendas());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            showSubMenu(subFinanceiro);
        }

        #region SubMenuFinaceiro
        private void btnFluxoCaixa_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmFluxoCaixa());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmContasReceber());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        #endregion

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            showSubMenu(subRelatorio);
        }

        #region SubMenuRelatorio
        private void btnRelatCadastros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No momento a tela esta em manutenção, e logo estará funcionando!");

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnRelatEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No momento a tela esta em manutenção, e logo estará funcionando!");

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnRelatVendas_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmReportVendas());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnRelatFinanceiro_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmReportContaReceber());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        #endregion

        private void btnApartamentos_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmHospedes());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            showSubMenu(subConfiguracoes);
        }

        #region SubMenuConfigurações
        private void btnBackup_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmBackup());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnCadOrganizacionais_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmCadastrosOrganizacionais());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }

        private void btnControleContas_Click(object sender, EventArgs e)
        {
            openChildForm(new forms.frmControleConta());

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(childForm);
            panelCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            //
            // Codigo correspondente ao botão
            //

            //Apos a execução do codigo acima o submenu em que ele esta será ocultado.
            hideSubMenu();
        }
        
    }
}
