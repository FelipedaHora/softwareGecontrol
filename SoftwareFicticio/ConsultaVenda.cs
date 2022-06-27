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
            RegistroVendas registroVendas = new RegistroVendas();
            registroVendas.ShowDialog();
            
        }

        private void ConsultaVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dataSet1.venda);

        }
        
        public void setVendaId()
        {
            
        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            
        }

        int getIdVenda;
        int getIdCliente;
        int getNumeroNF;
        DateTime getDataRegistroIdVenda;
        DateTime getDataEmissao;
        DateTime getDataEntregar;
        double getValorTotal;

        private void dgvConsultaVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenda = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[0].Value.ToString());
            getIdVenda = idVenda;
            int idCliente = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[1].Value.ToString());
            getIdCliente = idCliente;
            int numeroNF = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[2].Value.ToString());
            DateTime dataRegistroIdVenda = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[3].Value.ToString());
            getDataRegistroIdVenda = dataRegistroIdVenda;
            DateTime dataEmissao = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[4].Value.ToString());
            double valorTotal = double.Parse(this.dgvConsultaVenda.CurrentRow.Cells[6].Value.ToString());
            DateTime dataEntregar = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[5].Value.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblAlterar_Click(object sender, EventArgs e)
        {
            int idClienteVenda;
            if (this.dgvConsultaVenda.CurrentRow.Cells[1].Value.ToString() == "")
            {
                idClienteVenda = 0;
            }
            else
            {
                idClienteVenda = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[1].Value.ToString());
            }
            
            DateTime dataRegitroIdVenda = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[3].Value.ToString());
            int idVenda = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[0].Value.ToString());
            
            Venda alterarVendaExistente = new Venda();
            alterarVendaExistente.Owner = this;
            

            alterarVendaExistente.txbIdCliente.Text = idClienteVenda.ToString();
            alterarVendaExistente.mtbData.Text = dataRegitroIdVenda.ToString();
            alterarVendaExistente.txbIdVenda.Text = idVenda.ToString();
            alterarVendaExistente.btnSalvarAlterarVenda.Visible = true;
            alterarVendaExistente.btnSalvarVenda.Visible = false;
            alterarVendaExistente.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //MessageBox.Show(idVenda.ToString());
        }
    }
}
