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
          
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);
            dgvCadastroProd.EnableHeadersVisualStyles = false;

            dgvCadastroProd.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(00, 25, 45);
            dgvCadastroProd.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            dgvCadastroProd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCadastroProd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void CadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        int id;
        string descricaoProduto;
        string unidadeVenda;
        decimal preco;
        DateTime dataCadastro;
        DateTime dataatualizacao;
      
        private void dgvCadastroProd_Click(object sender, EventArgs e)
        {
            
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            RegistroProdutos registroProdutos = new RegistroProdutos();
            registroProdutos.ShowDialog();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataSet2TableAdapters.produtosTableAdapter dropProduct = new DataSet2TableAdapters.produtosTableAdapter();
                dropProduct.DeleteQuery(id);
                MessageBox.Show("Produto excluído com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string choiceUnidadeVenda;
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxUnidadeVenda.SelectedIndex == 0)
                {
                    choiceUnidadeVenda = "UN";
                }
                else if (cbxUnidadeVenda.SelectedIndex == 1)
                {
                    choiceUnidadeVenda = "FD";
                }
                else
                {
                    choiceUnidadeVenda = "CX";
                }
                dataatualizacao = DateTime.Now;
                DataSet2TableAdapters.produtosTableAdapter produtosTableAdapter = new DataSet2TableAdapters.produtosTableAdapter();
                produtosTableAdapter.UpdateQuery(txbNome.Text, choiceUnidadeVenda, decimal.Parse(txbPreco.Text),dataatualizacao,id);
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void dgvCadastroProd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvCadastroProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar nos texts boxes as informaçoes dos produtos quando clicar na linha dele
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow dgvRow = dgvCadastroProd.Rows[e.RowIndex];
                    txbPreco.Text = dgvRow.Cells[3].Value.ToString();
                    txbNome.Text = dgvRow.Cells[1].Value.ToString();
                    string showUnidadeVenda = dgvRow.Cells[2].Value.ToString();
                    txbID.Text = dgvRow.Cells[0].Value.ToString();

                    if (showUnidadeVenda == "UN")
                    {
                        cbxUnidadeVenda.SelectedIndex = 0;
                    }
                    else if (showUnidadeVenda == "FD")
                    {
                        cbxUnidadeVenda.SelectedIndex = 1;
                    }
                    else
                    {
                        cbxUnidadeVenda.SelectedIndex = 2;
                    }


                    id = Convert.ToInt32(dgvCadastroProd.Rows[e.RowIndex].Cells[0].Value);
                    descricaoProduto = Convert.ToString(dgvCadastroProd.Rows[e.RowIndex].Cells[1].Value);
                    unidadeVenda = Convert.ToString(dgvCadastroProd.Rows[e.RowIndex].Cells[2].Value);
                    preco = Convert.ToDecimal(dgvCadastroProd.Rows[e.RowIndex].Cells[3].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            if (this.Owner.Name == "Venda")
            {
                try
                {
                    ((Venda)this.Owner).getDataProduto(descricaoProduto, preco,id);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (this.Owner.Name == "RegistroProdutos")
            {
                try
                {
                    ((RegistroProdutos)this.Owner).getProdutos(descricaoProduto, preco, unidadeVenda, id);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCadastroProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

