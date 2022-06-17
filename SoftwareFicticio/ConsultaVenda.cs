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
        public void setVendaId()
        {
            if (this.Owner.Name == "Venda")
            {
                try
                {
                    for(int i = 0; i <= dgvConsultaVenda.Rows.Count -2; i++)
                    {
                        ((Venda)this.Owner).getIdVenda(int.Parse(dgvConsultaVenda.CurrentRow.Cells[0].Value.ToString()));
                    }
                    
                }
                catch (Exception ex)
                {

                }
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
