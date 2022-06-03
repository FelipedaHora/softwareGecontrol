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

            btnSelecionar.Visible = false;

        }
        public string cadastroTerceiros { get; set; }
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroTerc_Click(object sender, EventArgs e)
        {

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


        }

        public void dgvCadastroTerceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int id = int.Parse(dgvCadastroTerceiros.SelectedRows[0].Cells[0].Value.ToString());
            string nome = dgvCadastroTerceiros.SelectedRows[0].Cells[1].Value.ToString();
            string cpfORcnpj = dgvCadastroTerceiros.SelectedRows[0].Cells[2].Value.ToString();
            string email = dgvCadastroTerceiros.SelectedRows[0].Cells[3].Value.ToString();
            string telefone = dgvCadastroTerceiros.SelectedRows[0].Cells[4].Value.ToString();
            DateTime dataCadastro = DateTime.Parse(dgvCadastroTerceiros.SelectedRows[0].Cells[5].Value.ToString());
            DateTime dataAtualizacao = DateTime.Parse(dgvCadastroTerceiros.SelectedRows[0].Cells[6].Value.ToString()); */
        }

        private void CadastroTerceiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void dgvCadastroTerceiros_Click(object sender, EventArgs e)
        {


        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroTerceiros registroTerceiros = new RegistroTerceiros();
                registroTerceiros.Owner = this;
                registroTerceiros.getData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
