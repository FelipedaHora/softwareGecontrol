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
    public partial class RegistroProdutos : Form
    {
        public RegistroProdutos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroTerc_Click(object sender, EventArgs e)
        {
            try
            {
                string unVenda = "0";
                if (cbxUnidadeVenda.SelectedIndex == 0)
                {
                    unVenda = "UN";
                }
                else if (cbxUnidadeVenda.SelectedIndex == 1)
                {
                    unVenda = "FD";
                }
                else if (cbxUnidadeVenda.SelectedIndex == 2)
                {
                    unVenda = "CX";
                }

                DateTime dataCadastro = DateTime.Now;

                DataSet1TableAdapters.produtosTableAdapter productInsertData = new DataSet1TableAdapters.produtosTableAdapter();
                productInsertData.InsertQuery(txbDescProduto.Text, unVenda, decimal.Parse(txbPreco.Text), dataCadastro);

                MessageBox.Show("Cadastro criado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
