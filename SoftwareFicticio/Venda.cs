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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }
        
        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            this.terceirosTableAdapter.Fill(this.dataSet1.terceiros);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }
        
        public void getDataSell(string nome)
        {
           //Metodo para ser instanciado na tela de Terceiros e coletar NOME para preencher o textbox
           txbCliente.Text = nome;
           DateTime datacadastro = DateTime.Now;
           mtbData.Text = datacadastro.ToString("dd.MM.yyyy");
           
        }
        decimal precoProduto;
        public void getDataProduto(string produto,decimal preco)
        {
            //Metodo para ser instanciado na tela de Produtos e coletar a DESCRIÇÃO e o preço do produto
            //Para preencher o textbox
            txbProduto.Text = produto;
            txbPreco.Text = preco.ToString();
            precoProduto = preco;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instanciando a tela de cadastros de TERCEIROS e já informando que o Owner é esta tela aqui
            //Para que seja possível trazer as informações e preencher os textbox
            CadastroTerceiros cadastroTerc = new CadastroTerceiros();
            cadastroTerc.Owner = this;
            cadastroTerc.ShowDialog();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Venda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void txbCliente_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void mtbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            //Instanciando a tela de cadastros de produtos e já informando que o Owner é esta tela aqui
            //Para que seja possível trazer as informações e preencher os textbox
            CadastroProdutos cadastroProdutos = new CadastroProdutos();
            cadastroProdutos.Owner = this;
            cadastroProdutos.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btnLancarProduto_Click(object sender, EventArgs e)
        {
            //Lança o produto no DataGridView, e limpa os campos já preenchidos para que seja possível lançar outro produto
            double precoTotal = ((double)precoProduto * int.Parse(txbQuantidade.Text));
            dgvProdutosVenda.Rows.Add(txbProduto.Text,txbQuantidade.Text,txbPreco.Text,precoTotal);
            txbProduto.Clear();
            txbQuantidade.Clear();
            txbPreco.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpar todos os campos e refazer a venda
            txbProduto.Clear();
            txbQuantidade.Clear();
            txbPreco.Clear();
            txbCliente.Clear();
            dgvProdutosVenda.Rows.Clear();
        }
    }
}
