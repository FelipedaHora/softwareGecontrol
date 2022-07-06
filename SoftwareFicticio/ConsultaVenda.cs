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
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.vendapadraoview2'. Você pode movê-la ou removê-la conforme necessário.
            this.vendapadraoview2TableAdapter.Fill(this.dataSet2.vendapadraoview2);
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.vendapadrao'. Você pode movê-la ou removê-la conforme necessário.
            this.vendapadraoTableAdapter.Fill(this.dataSet2.vendapadrao);
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.vendapadraoview'. Você pode movê-la ou removê-la conforme necessário.
            this.vendapadraoviewTableAdapter.Fill(this.dataSet2.vendapadraoview);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dataSet1.venda);

            dgvConsultaVenda.EnableHeadersVisualStyles = false;

            dgvConsultaVenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(00, 25, 45);
            dgvConsultaVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            dgvConsultaVenda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvConsultaVenda.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        
        

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenda = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[0].Value.ToString());
                DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter = new DataSet2TableAdapters.vendaTableAdapter();
                vendaTableAdapter.DeleteQuery(idVenda);
                MessageBox.Show("Venda excluída com sucesso!");
                dgvConsultaVenda.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            int numeroNF = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[4].Value.ToString());
            DateTime dataRegistroIdVenda = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[6].Value.ToString());
            getDataRegistroIdVenda = dataRegistroIdVenda;
            DateTime dataEmissao = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[6].Value.ToString());
            double valorTotal = double.Parse(this.dgvConsultaVenda.CurrentRow.Cells[5].Value.ToString());
            DateTime dataEntregar = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[7].Value.ToString());

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
            
            DateTime dataRegitroIdVenda = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[6].Value.ToString());
            DateTime dataEntregaVenda = DateTime.Parse(this.dgvConsultaVenda.CurrentRow.Cells[7].Value.ToString());
            int idVenda = int.Parse(this.dgvConsultaVenda.CurrentRow.Cells[0].Value.ToString());
            string nome = this.dgvConsultaVenda.CurrentRow.Cells[2].Value.ToString();
            
            Venda alterarVendaExistente = new Venda();
            alterarVendaExistente.Owner = this;
      
            alterarVendaExistente.txbIdCliente.Text = idClienteVenda.ToString();
            alterarVendaExistente.mtbData.Text = dataRegitroIdVenda.ToString();
            alterarVendaExistente.txbIdVenda.Text = idVenda.ToString();
            alterarVendaExistente.txbCliente.Text = nome.ToString();
            alterarVendaExistente.mtbDataEntrega.Text = dataEntregaVenda.ToString();

            //Adaptações da nova tela instanciadas
            alterarVendaExistente.btnSalvarAlterarVenda.Visible = true;
            alterarVendaExistente.btnSalvarVenda.Visible = false;
            alterarVendaExistente.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //MessageBox.Show(idVenda.ToString());
        }

        private void dgvConsultaVenda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
