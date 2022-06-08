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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
          
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }
        private void CadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        int id;
        string descricaoProduto;
        string unidadeVenda;
        decimal preco;
        DateTime dataCadastro;
        DateTime dataatualizacao;
        private void dgvCadastroProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvCadastroProd.Rows[e.RowIndex].Cells[0].Value);
            descricaoProduto = Convert.ToString(dgvCadastroProd.Rows[e.RowIndex].Cells[1].Value);
            unidadeVenda = Convert.ToString(dgvCadastroProd.Rows[e.RowIndex].Cells[2].Value);
            preco = Convert.ToDecimal(dgvCadastroProd.Rows[e.RowIndex].Cells[3].Value);

            if (this.Owner.Name == "Venda")
            {
                try
                {
                    ((Venda)this.Owner).getDataProduto(descricaoProduto,preco);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(this.Owner.Name == "RegistroProdutos")
            {
                try
                {
                    ((RegistroProdutos)this.Owner).getProdutos(descricaoProduto, preco, unidadeVenda,id);
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void dgvCadastroProd_Click(object sender, EventArgs e)
        {
            
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            RegistroProdutos registroProdutos = new RegistroProdutos();
            registroProdutos.ShowDialog();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataSet2TableAdapters.produtosTableAdapter produtosTableAdapter = new DataSet2TableAdapters.produtosTableAdapter();
                produtosTableAdapter.DeleteQuery(id);

                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string choiceUnidadeVenda;
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(cbxUnidadeVenda.SelectedIndex == 0)
            {
                choiceUnidadeVenda = "UN";
            }
            else if(cbxUnidadeVenda.SelectedIndex == 1)
            {
                choiceUnidadeVenda = "FD";
            }
            else
            {
                choiceUnidadeVenda = "CX";
            }
            dataatualizacao = DateTime.Now;
            DataSet2TableAdapters.produtosTableAdapter produtosTableAdapter = new DataSet2TableAdapters.produtosTableAdapter();
            produtosTableAdapter.UpdateQuery(txbNome.Text, choiceUnidadeVenda, decimal.Parse(txbPreco.Text),
                descricaoProduto,
                unidadeVenda,
                preco,
                dataatualizacao);
        }
    }
}
