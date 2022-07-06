using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFicticio
{
    public partial class Venda : Form
    {
        int id;

        public Venda()
        {
            InitializeComponent();
        }

        public Venda(int idVenda)
        {
            this.id = idVenda;
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            this.terceirosTableAdapter1.Fill(this.dataSet2.terceiros);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            dgvProdutosVenda.EnableHeadersVisualStyles = false;

            dgvProdutosVenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(00, 25, 45);
            dgvProdutosVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            dgvProdutosVenda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProdutosVenda.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            CadastroTerceiros cadastroTerceiros = new CadastroTerceiros();
            cadastroTerceiros.Owner = this;
            cadastroTerceiros.ShowDialog();
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
            ConsultaVenda consultaVenda = new ConsultaVenda();
            consultaVenda.Owner = this;
            id = Convert.ToInt32(id);
            getIdVendaIten = Convert.ToInt32(id);
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
        public void pegarProdutosVendasItens(int idVenda, int idProduto, int quantidade, decimal valorUnitario, decimal valorTotal)
        {
           //Método para gerar a Query ao banco, para gerar o insert na tabela vendas_itens de acordo com cada produto lançado na venda
            DataSet2TableAdapters.vendas_itensTableAdapter vendas_ItensTableAdapter = new DataSet2TableAdapters.vendas_itensTableAdapter();
            vendas_ItensTableAdapter.InsertQuery(idVenda,idProduto,quantidade,valorUnitario,valorTotal);
        }
        double precoUnitario;
        int count = 0;
        private void btnLancarProduto_Click(object sender, EventArgs e)
        {
            count++;

            //Lança o produto no DataGridView, e limpa os campos já preenchidos para que seja possível lançar outro produto
            int mult;
            mult = int.Parse(txbQuantidade.Text);
            precoUnitario = ((double)precoProduto * mult);
            dgvProdutosVenda.Rows.Add(txbIdProduto.Text, txbProduto.Text, txbQuantidade.Text, txbPreco.Text, precoUnitario);

            //Assim que lançados no datagridview os campos são limpos automaticamente para que seja possível lançar um novo produto
            txbProduto.Clear();
            txbQuantidade.Clear();
            txbPreco.Clear();
            txbIdProduto.Clear();

            //Loop para somar os valores dos produtos
            double sum = 0;
            for (int i = 0; i < dgvProdutosVenda.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgvProdutosVenda.Rows[i].Cells[4].Value);
            }
            txbValorTotal.Text = sum.ToString() + ",00";
        }
        public void armazenarProdutosVendasItens()
        {
            foreach(DataGridViewRow row in dgvProdutosVenda.Rows)
            {
                int idVenda = int.Parse(txbIdVenda.Text);
                int idProduto = int.Parse(row.Cells[0].Value.ToString());
                int quantidade = int.Parse(row.Cells[2].Value.ToString());
                decimal valorUnitario = decimal.Parse(row.Cells[3].Value.ToString());
                decimal valorTotal = decimal.Parse(row.Cells[4].Value.ToString());
                pegarProdutosVendasItens(idVenda,idProduto,quantidade,valorUnitario,valorTotal);
            }
        }
        
        public void pegarInformacoesDaVenda(int idCliente, DateTime dataRegistroVenda, int idVenda)
        {
            if (txbIdCliente.Text == null)
            {
                idCliente = 0;
            }
            
            txbIdCliente.Text = idCliente.ToString();
            mtbData.Text = dataRegistroVenda.ToString();
            txbIdVenda.Text = idVenda.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpar todos os campos e refazer a venda
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
                armazenarProdutosVendasItens();
                MessageBox.Show("Venda feita com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            VendaAuxiliar vendaAux = new VendaAuxiliar();
            vendaAux.Owner = this;
            vendaAux.ShowDialog();

        }

        private void txbIdProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
              
        }

        private void button2_Click_5(object sender, EventArgs e)
        {
            ConsultaVenda consultaVenda = new ConsultaVenda();
            consultaVenda.Owner = this;
            consultaVenda.ShowDialog();
        }

        private void btnSalvarAlterarVenda_Click(object sender, EventArgs e)
        {
            armazenarProdutosVendasItens(); 
            DataSet2TableAdapters.vendaTableAdapter vendaUpdateQuery = new DataSet2TableAdapters.vendaTableAdapter();
            vendaUpdateQuery.UpdateQuery(int.Parse(txbIdCliente.Text), DateTime.Parse(mtbData.Text), DateTime.Parse(mtbData.Text), 
                 DateTime.Parse(mtbDataEntrega.Text), decimal.Parse(txbValorTotal.Text), int.Parse(txbIdVenda.Text));
             
        }

        private void button2_Click_6(object sender, EventArgs e)
        {
            
        }
    }
}
