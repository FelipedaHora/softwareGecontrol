using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareFicticio
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();

            // HIDE THE BUTTONS TO SHOW WHEN THE USER PRESS "Cadastrar"
            btnChoiceFuncionarios.Visible = false;
            btnChoiceProdutos.Visible = false;
            btnChoiceTerceiros.Visible = false;
            btnRelatorioFunc.Visible = false;
            btnRelatorioProd.Visible = false;
            btnRelatorioTerc.Visible = false;
            btnRelatorioVendas.Visible = false;
            btnCadastrarLogin.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnChoiceFuncionarios.Visible = true;
            btnChoiceProdutos.Visible = true;
            btnChoiceTerceiros.Visible = true;
            btnCadastrarLogin.Visible = true;

        }

        private void btnChoiceFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionario = new CadastroFuncionarios();
            cadastroFuncionario.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.Owner = this;
            cadastroProdutos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroTerceiros registroTerceiros = new RegistroTerceiros();
            registroTerceiros.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void btnChoiceConsultarFunc_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            ConsultaVenda consultaVenda = new ConsultaVenda();
            consultaVenda.ShowDialog();
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnChoiceFuncionarios.Visible = true;
            btnChoiceProdutos.Visible = true;
            btnChoiceTerceiros.Visible = true;
            btnCadastrarLogin.Visible = true;

            btnRelatorioFunc.Visible = false;
            btnRelatorioProd.Visible = false;
            btnRelatorioTerc.Visible = false;
            btnRelatorioVendas.Visible = false;
        }

        private void btnCadastrar_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            btnChoiceFuncionarios.Visible = false;
            btnChoiceProdutos.Visible = false;
            btnChoiceTerceiros.Visible = false;
            btnCadastrarLogin.Visible = false;
        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            btnRelatorioFunc.Visible = true;
            btnRelatorioProd.Visible = true;
            btnRelatorioTerc.Visible = true;
            btnRelatorioVendas.Visible = true;

            btnChoiceFuncionarios.Visible = false;
            btnChoiceProdutos.Visible = false;
            btnChoiceTerceiros.Visible = false;
            btnCadastrarLogin.Visible = false;
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            btnRelatorioFunc.Visible = false;
            btnRelatorioProd.Visible = false;
            btnRelatorioTerc.Visible = false;
            btnRelatorioVendas.Visible = false;
           
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorioVendas = new RelatorioVendas();
            relatorioVendas.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Closed += (s, args) => this.Close();
            telaLogin.Show();
        }

        private void btnRelatorioFunc_Click(object sender, EventArgs e)
        {
            RelatorioFuncionarios relatorioFuncionarios = new RelatorioFuncionarios();
            relatorioFuncionarios.ShowDialog();
        }

        private void btnRelatorioProd_Click(object sender, EventArgs e)
        {
            RelatorioProdutos relatorioProdutos = new RelatorioProdutos();
            relatorioProdutos.ShowDialog();
        }

        private void btnCadastrarLogin_Click(object sender, EventArgs e)
        {
            RegistroAcessoSistema registroAcessoSistema = new RegistroAcessoSistema();
            registroAcessoSistema.ShowDialog();
        }

        private void btnRelatorioTerc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
