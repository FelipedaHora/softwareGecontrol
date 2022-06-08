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

            DataSet2TableAdapters.terceirosTableAdapter insertTerceiros = new DataSet2TableAdapters.terceirosTableAdapter();
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
        string registro;
        public void getData(string nome, string email, string telefone,string documento)
        {
            txbNome.Text = nome;
            txbEmail.Text = email;
            mtbTelefone.Text = telefone;
            if(documento.Length == 14)
            {
                rbCPF.Checked = true;
                mtbCPF.Text = documento;
            }
            else if(documento.Length == 18)
            {
                rbCNPJ.Checked = true;
                mtbCNPJ.Text = documento;
            }
            
            
            registro = documento;
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
            try
            {
                /*DataSet1TableAdapters.funcionarioTableAdapter dropEmployee = new DataSet1TableAdapters.funcionarioTableAdapter();
                dropEmployee.DeleteQuery(id);
                MessageBox.Show("Funcionario excluído com sucesso!");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CadastroTerceiros cadastroTerceiros = new CadastroTerceiros();
            cadastroTerceiros.Owner= this;
            cadastroTerceiros.ShowDialog();

        }
        
    }
}
