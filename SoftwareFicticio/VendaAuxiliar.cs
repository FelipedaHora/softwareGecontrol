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
    public partial class VendaAuxiliar : Form
    {
        public VendaAuxiliar()
        {
            InitializeComponent();
        }

        private void VendaAuxiliar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.dataSet2.venda);

        }
        public void setId()
        {
            if(this.Owner.Name == "Venda")
            {
                try
                {
                    ((Venda)this.Owner).getIdVenda(int.Parse(txbID.Text));
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txbID.Text);
            Close();
        }

        private void vendaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txbIdVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
