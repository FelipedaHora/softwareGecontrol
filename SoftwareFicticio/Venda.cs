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
        int getId;
        public void getDataSell(string nome, int id)
        {
            //Metodo para ser instanciado na tela de Terceiros e coletar NOME para preencher o textbox
            txbCliente.Text = nome;
            DateTime datacadastro = DateTime.Now;
            mtbData.Text = datacadastro.ToString("dd.MM.yyyy");
            id = Convert.ToInt32(id);
            getId = Convert.ToInt32(id);
            txbIdCliente.Text = id.ToString();

        }
        decimal precoProduto;
        public void getDataProduto(string produto, decimal preco, int id)
        {
            //Metodo para ser instanciado na tela de Produtos e coletar a DESCRIÇÃO e o preço do produto
            //Para preencher o textbox
            txbProduto.Text = produto;
            txbPreco.Text = preco.ToString();
            precoProduto = preco;
            txbIdProduto.Text = id.ToString();
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
        int getIdVendaIten;
        public void getIdVenda(int id)
        {
            VendaAuxiliar vendaAuxiliar = new VendaAuxiliar();
            vendaAuxiliar.Owner = this;
            getIdVendaIten = id;
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

        //Lança o produto no DataGridView, e limpa os campos já preenchidos para que seja possível lançar outro produto
        double precoUnitario;
        int count = 0;
        private void btnLancarProduto_Click(object sender, EventArgs e)
        {
            count++;
            precoUnitario = ((double)precoProduto * int.Parse(txbQuantidade.Text));
            dgvProdutosVenda.Rows.Add(txbProduto.Text, txbQuantidade.Text, txbPreco.Text, precoUnitario);

            txbProduto.Clear();
            txbQuantidade.Clear();
            txbPreco.Clear();

            double sum = 0;
            for (int i = 0; i < dgvProdutosVenda.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvProdutosVenda.Rows[i].Cells[3].Value);
            }
            txbValorTotal.Text = sum.ToString();


            for (int i = 0; i <= count; i++)
            {
                //Gerando a query da venda_iten com os dados da tela
                DataSet2TableAdapters.vendas_itensTableAdapter vendas_ItensTableAdapter = new DataSet2TableAdapters.vendas_itensTableAdapter();
                vendas_ItensTableAdapter.InsertQuery(getIdVendaIten, int.Parse(txbIdProduto.Text), int.Parse(txbQuantidade.Text), (decimal)precoUnitario, decimal.Parse(txbValorTotal.Text));
            }
        }

        private void gerarVendasItens()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {//Limpar todos os campos e refazer a venda
            txbProduto.Clear();
            txbQuantidade.Clear();
            txbPreco.Clear();
            txbCliente.Clear();
            dgvProdutosVenda.Rows.Clear();
            mtbDataEntrega.Clear();
            txbValorTotal.Clear();
        }
        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                //Gerando a query de venda com os dados da tela
                DateTime dataPedido = DateTime.Now;
                DateTime dataEmissao = DateTime.Now;
                DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter = new DataSet2TableAdapters.vendaTableAdapter();
                vendaTableAdapter.InsertQuery(getId, dataPedido, dataEmissao, DateTime.Parse(mtbDataEntrega.Text), decimal.Parse(txbValorTotal.Text));

                MessageBox.Show("Venda registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gerarVendasItens();

        }
        private void txbValorTotal_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txbProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
           
        }
    }
}
