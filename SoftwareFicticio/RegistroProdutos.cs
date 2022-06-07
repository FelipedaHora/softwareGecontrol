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

        private void txbDescProduto_TextChanged(object sender, EventArgs e)
        {

        }

        
        int i;
        string nome;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            nome = row.Cells[1].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           /* try
            {
                DataSet1TableAdapters.produtosTableAdapter dropProduct = new DataSet1TableAdapters.produtosTableAdapter();
                dropProduct.DeleteQuery(id);

                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.ShowDialog();
        }
    }
}
