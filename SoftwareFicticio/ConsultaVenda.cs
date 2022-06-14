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
            venda.Owner = this;
            venda.ShowDialog();
        }

        private void ConsultaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dataSet1.venda);

        }

        /*VARIAVEL AUXILIAR CRIADA PARA O METODO ABAIXO. 
         
        OBJETIVO: INSTANCIAR O METODO getIdVenda para acessar o ID da venda que acabara DE SER CRIADA E GERAR O VALOR PARA 
        O LACO DE REPETICAO QUE VAI PREENCHER O vendaItenTableAdapter
        */
        int idSell;
        public void setVendaId()
        {
           int numRows = dgvConsultaVenda.Rows.Count;
           int sizeLoop = numRows - 1;
          
           for(int i = 0; i <= sizeLoop; ++i)
            {
                idSell = Convert.ToInt32(dgvConsultaVenda.CurrentRow.Cells[0].Value);
            }
            Venda venda = new Venda();
            try
            {
                ((Venda)this.Owner).getIdVenda(idSell);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            
        }
        

        private void dgvConsultaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
