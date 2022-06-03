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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            RegistroProdutos registroProdutos = new RegistroProdutos();
            registroProdutos.ShowDialog();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvCadastroProd.SelectedRows[0].Cells[0].Value.ToString());
                DataSet1TableAdapters.funcionarioTableAdapter dropEmployee = new DataSet1TableAdapters.funcionarioTableAdapter();
                dropEmployee.DeleteQuery(id);

                MessageBox.Show("Funcionario excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void dgvCadastroProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Venda venda = new Venda();
            venda.txbProduto.Text = dgvCadastroProd.Rows[0].Cells[1].Value.ToString();
        }

        private void dgvCadastroProd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
