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
    public partial class RegistroVendas : Form
    {
        public RegistroVendas()
        {
            InitializeComponent();
        }
        int getId;
        string sendNome;
        public void getDataClient(string nome, int id)
        {
            //Metodo para ser instanciado na tela de Terceiros e coletar NOME para preencher o textbox
            txbCliente.Text = nome;
            sendNome = nome;
            DateTime datacadastro = DateTime.Now;
            mtbData.Text = datacadastro.ToString("dd.MM.yyyy");
            id = Convert.ToInt32(id);
            getId = Convert.ToInt32(id);
            txbIdCliente.Text = id.ToString();

        }

        public void salvarVendasSemItens()
        {
            //Registrando o ID e a data da venda no banco de dados
            DateTime dataRegistroIdVenda = DateTime.Now;
            dataRegistroIdVenda.ToString("yyyy-MM-dd");

            DateTime dataEntregar;
            dataEntregar = DateTime.Parse(mtbDataEntrega.Text);

            DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter = new DataSet2TableAdapters.vendaTableAdapter();
            vendaTableAdapter.InsertInicial(dataRegistroIdVenda, dataEntregar, getId);
            Close();
        }


        public void salvarVendasComItens()
        {
            //Registrando o ID e a data da venda no banco de dados
            DateTime dataRegistroIdVenda = DateTime.Now;
            dataRegistroIdVenda.ToString("yyyy-MM-dd");

            DateTime dataEntregar;
            dataEntregar = DateTime.Parse(mtbDataEntrega.Text);

            DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter = new DataSet2TableAdapters.vendaTableAdapter();
            vendaTableAdapter.InsertInicial(dataRegistroIdVenda, dataEntregar, getId);

            DataSet2TableAdapters.QueriesTableAdapter queriesTableAdapter = new DataSet2TableAdapters.QueriesTableAdapter();
            object idReceiver = queriesTableAdapter.getIdSequence("seq_venda");
            int idConvertVenda = Convert.ToInt32(idReceiver);
            int idConvertido = idConvertVenda - 1;



            //Instanciando a tela de venda para cadastrar uma nova venda
            Venda venda = new Venda();
            venda.txbIdCliente.Text = getId.ToString();
            venda.txbCliente.Text = sendNome;
            venda.mtbData.Text = dataRegistroIdVenda.ToString();
            venda.mtbDataEntrega.Text = mtbDataEntrega.Text;
            venda.btnSalvarAlterarVenda.Visible = false;
            venda.txbIdVenda.Text = idConvertido.ToString();
            venda.ShowDialog();
        }
        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            salvarVendasSemItens();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            //Instanciando a tela de cadastros de TERCEIROS e já informando que o Owner é esta tela aqui
            //Para que seja possível trazer as informações e preencher os textbox
            CadastroTerceiros cadastroTerc = new CadastroTerceiros();
            cadastroTerc.Owner = this;
            cadastroTerc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            salvarVendasComItens();
        }

        private void txbIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
