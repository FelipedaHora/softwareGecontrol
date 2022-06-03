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
    public partial class RegistroFuncionarios : Form
    {
        public RegistroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                string sexo = "0";
                if (cbxSexo.SelectedIndex == 0)
                {
                    sexo = "M";
                }
                else if (cbxSexo.SelectedIndex == 1)
                {
                    sexo = "F";
                }
                string tipoContrato = "0";
                if (cbxTipoContrato.SelectedIndex == 0)
                {
                    tipoContrato = "CLT";
                }
                else if (cbxTipoContrato.SelectedIndex == 1)
                {
                    tipoContrato = "PJ";
                }

                DateTime dataCadastro = DateTime.Now;

                DataSet1TableAdapters.funcionarioTableAdapter insertFuncDataSet = new DataSet1TableAdapters.funcionarioTableAdapter();
                insertFuncDataSet.InsertQuery(txbNome.Text, txbEmail.Text, decimal.Parse(txbSalario.Text), sexo, tipoContrato, dataCadastro);

                MessageBox.Show("Cadastro criado com sucesso!");
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistroFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
