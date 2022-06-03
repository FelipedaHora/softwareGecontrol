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
    public partial class CadastroTerceiros : Form
    {
        public CadastroTerceiros()
        {
            InitializeComponent();

            
        }
        public string cadastroTerceiros { get; set; }
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSalvarCadastroTerc_Click(object sender, EventArgs e)
        {
            RegistroTerceiros registroTerceiros = new RegistroTerceiros();
            registroTerceiros.ShowDialog();

        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void CadastroTerceiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            this.terceirosTableAdapter.Fill(this.dataSet1.terceiros);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvCadastroTerceiros.SelectedRows[0].Cells[0].Value.ToString());
                DataSet1TableAdapters.terceirosTableAdapter deleteTerceiros = new DataSet1TableAdapters.terceirosTableAdapter();
                deleteTerceiros.DeleteQuery(id);

                MessageBox.Show("Cadastro deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int i;
        private void dgvCadastroTerceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dgvCadastroTerceiros.Rows[i];
            Venda venda = new Venda();
            venda.txbCliente.Text = row.Cells[1].Value.ToString();
        }

        private void CadastroTerceiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        
        private void dgvCadastroTerceiros_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
