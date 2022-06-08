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
    public partial class ConsultaVenda : Form
    {
        public ConsultaVenda()
        {
            InitializeComponent();
        }

        private void lblNova_Click(object sender, EventArgs e)
        {
            //Instanciando a tela de venda para cadastrar uma nova venda
            Venda venda = new Venda();
            venda.ShowDialog();
        }

        private void ConsultaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dataSet1.venda);

        }
        int id;
        public void getVendaId(int id)
        {
            id = Convert.ToInt32(dgvConsultaVenda.CurrentRow.Cells[0].Value);
        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter = new DataSet2TableAdapters.vendaTableAdapter();
            vendaTableAdapter.DeleteQuery(id);
        }
    }
}
