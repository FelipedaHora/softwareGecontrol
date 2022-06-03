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
    public partial class RegistroTerceiros : Form
    {
        public RegistroTerceiros()
        {
            InitializeComponent();
            mtbCNPJ.Visible = false;
            mtbCPF.Visible = false;
        }

        private void btnSalvarCadastroTerc_Click(object sender, EventArgs e)
        {
            string document = "0";
            if (rbCPF.Checked == true)
            {
                document = mtbCPF.Text;
            }
            else if (rbCNPJ.Checked == true)
            {
                document = mtbCNPJ.Text;
            }
            DateTime dataCadastro = DateTime.Now;

            DataSet1TableAdapters.terceirosTableAdapter insertTerceiros = new DataSet1TableAdapters.terceirosTableAdapter();
            insertTerceiros.InsertQuery(txbNome.Text, document, txbEmail.Text, mtbTelefone.Text, dataCadastro);

            MessageBox.Show("Cadastro criado com sucesso!");
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCNPJ.Checked == true)
            {
                mtbCNPJ.Visible = true;
            }
            else
            {
                mtbCNPJ.Visible = false;
            }
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked == true)
            {
                mtbCPF.Visible = true;
            }
            else
            {
                mtbCPF.Visible = false;
            }
        }

        private void RegistroTerceiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void getData()
        {
            CadastroTerceiros cadastroTerceiros = new CadastroTerceiros();
            
            txbNome.Text = cadastroTerceiros.dgvCadastroTerceiros.SelectedRows[0].Cells[1].Value.ToString();
            txbEmail.Text = cadastroTerceiros.dgvCadastroTerceiros.SelectedRows[0].Cells[3].Value.ToString();
            /*
            if (rbCNPJ.Checked == true)
            {
                mtbCNPJ.Text = cadastroTerceiros.dgvCadastroTerceiros.SelectedRows[0].Cells[2].Value.ToString();
            }
            else if(rbCPF.Checked == true)
            {
                mtbCPF.Text = cadastroTerceiros.dgvCadastroTerceiros.SelectedRows[0].Cells[2].Value.ToString();
            }*/
        }

        private void RegistroTerceiros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            this.terceirosTableAdapter.Fill(this.dataSet1.terceiros);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                int idTerceiros = int.Parse(dgvCadastroTerceiros.SelectedRows[0].Cells[0].Value.ToString());
                DataSet1TableAdapters.terceirosTableAdapter deleteTerceiros = new DataSet1TableAdapters.terceirosTableAdapter();
                deleteTerceiros.DeleteQuery(idTerceiros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CadastroTerceiros cadastroTerceiros = new CadastroTerceiros();

        }
    }
}
