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
            dgvCadastroTerceiros.EnableHeadersVisualStyles = false;
            
            dgvCadastroTerceiros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(00, 25, 45);
            dgvCadastroTerceiros.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            dgvCadastroTerceiros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCadastroTerceiros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.terceirosTableAdapter dropTerceiros = new DataSet1TableAdapters.terceirosTableAdapter();
                dropTerceiros.DeleteQuery(id);
                MessageBox.Show("Terceiro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int id;
        string nome;
        string email;
        string telefone;
        string registro;
        public void dgvCadastroTerceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nome = this.dgvCadastroTerceiros.CurrentRow.Cells[1].Value.ToString();
            email = this.dgvCadastroTerceiros.CurrentRow.Cells[3].Value.ToString();
            telefone = this.dgvCadastroTerceiros.CurrentRow.Cells[4].Value.ToString();
            registro = this.dgvCadastroTerceiros.CurrentRow.Cells[2].Value.ToString();
            id = int.Parse(this.dgvCadastroTerceiros.CurrentRow.Cells[0].Value.ToString());
            if (this.Owner.Name == "RegistroVendas")
            {
                try
                {
                    ((RegistroVendas)this.Owner).getDataClient(nome,id);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(this.Owner.Name == "RegistroTerceiros")
            {
                try
                {
                    ((RegistroTerceiros)this.Owner).getData(nome,email,telefone,registro);
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(this.Owner.Name == "Venda")
            {
                try
                {
                    ((Venda)this.Owner).getDataSell(nome, id);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            if (this.Owner.Name == "Venda")
            {
                try
                {
                    ((Venda)this.Owner).getDataSell(nome,id);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { }
        }
    }
}
