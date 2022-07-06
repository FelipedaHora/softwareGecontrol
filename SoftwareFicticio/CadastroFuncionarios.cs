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
    public partial class CadastroFuncionarios : Form
    {
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvarCadastroFunc_Click(object sender, EventArgs e)
        {
            RegistroFuncionarios registroFuncionarios = new RegistroFuncionarios();
            registroFuncionarios.ShowDialog();
        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.dataSet1.funcionario);
            dgvConsultaFuncionario.EnableHeadersVisualStyles = false;

            dgvConsultaFuncionario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(00, 25, 45);
            dgvConsultaFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 8, FontStyle.Bold);
            dgvConsultaFuncionario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvConsultaFuncionario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void dgvConsultaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvConsultaFuncionario.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //PEGANDO AS INFORMAÇÕES DO DATAGRIDVIEW E ARMAZENANDO EM VARIÁVEIS PARA ATUALIZAR CADASTRO
            int id = int.Parse(dgvConsultaFuncionario.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvConsultaFuncionario.CurrentRow.Cells[1].Value.ToString();
            string email = dgvConsultaFuncionario.CurrentRow.Cells[2].Value.ToString();
            decimal salario;
            if (dgvConsultaFuncionario.CurrentRow.Cells[3].Value.ToString() == "")
            {
                salario = 0.0m;
            }
            else
            {
                salario = decimal.Parse(dgvConsultaFuncionario.CurrentRow.Cells[3].Value.ToString());
            }
            
            string sexo = dgvConsultaFuncionario.CurrentRow.Cells[4].Value.ToString();
            string tipo_contrato = dgvConsultaFuncionario.CurrentRow.Cells[5].Value.ToString();
            DateTime data_cadastro = DateTime.Parse(dgvConsultaFuncionario.CurrentRow.Cells[6].Value.ToString());

            DateTime dataAtualizacao = DateTime.Now;

            try
            {
                string sexoAlteracao = "0";
                if (cbxSexo.SelectedIndex == 0)
                {
                    sexoAlteracao = "M";
                }
                else if (cbxSexo.SelectedIndex == 1)
                {
                    sexoAlteracao = "F";
                }
                string tipoContratoAlteracao = "0";
                if (cbxTipoContrato.SelectedIndex == 0)
                {
                    tipoContratoAlteracao = "CLT";
                }
                else if (cbxTipoContrato.SelectedIndex == 1)
                {
                    tipoContratoAlteracao = "PJ";
                }

                // Preenchendo o DataSet para atualizar os cadastros, os parametros que estão um AO LADO DO OUTRO são os novos a serem inseridos
                // Os que estão um acima do outro, sao os antigos que foram selecionados do DataGridView
             DataSet2TableAdapters.funcionarioTableAdapter funcionarioTableAdapter = new DataSet2TableAdapters.funcionarioTableAdapter();
             funcionarioTableAdapter.UpdateQuery(txbNome.Text, txbEmail.Text, tipoContratoAlteracao, dataAtualizacao, decimal.Parse(txbSalario.Text), sexo,id
                    );

                MessageBox.Show("Cadastro atualizado com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroFuncionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
