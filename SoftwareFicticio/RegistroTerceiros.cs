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
    }
}
