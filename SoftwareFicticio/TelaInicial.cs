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
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
             
            btnChoiceFuncionarios.Visible = true;
            btnChoiceProdutos.Visible = true;
            btnChoiceTerceiros.Visible = true;
        }

        private void btnChoiceFuncionarios_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionario = new CadastroFuncionarios();
            cadastroFuncionario.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroTerceiros cadastroTerceiros = new CadastroTerceiros();
            cadastroTerceiros.ShowDialog();
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
            Venda venda = new Venda();
            venda.ShowDialog();
        }
    }
}
