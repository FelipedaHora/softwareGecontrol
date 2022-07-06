using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Devart.Data;
using Devart.Common;
using System.Data.SqlClient;


namespace SoftwareFicticio
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            txbSenha.PasswordChar = '*';
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbLogin.Clear();
            txbSenha.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           DataSet2TableAdapters.usuarioTableAdapter usuarioTableAdapter = new DataSet2TableAdapters.usuarioTableAdapter();
           object login = usuarioTableAdapter.GetLogin(txbLogin.Text);
           
           DataSet2TableAdapters.usuarioTableAdapter usuarioTableAdapter1 = new DataSet2TableAdapters.usuarioTableAdapter();
           var senha = usuarioTableAdapter1.GetSenha(txbSenha.Text);

            if (txbSenha.Text == "")
            {
                MessageBox.Show("Campo senha está vazio");
                txbLogin.Clear();
                txbSenha.Clear();
            }
            else if (txbLogin.Text == "")
            {
                MessageBox.Show("Campo usuário está vazio");
                txbLogin.Clear();
                txbSenha.Clear();
            }
            else if (login == null)
            {
                MessageBox.Show("Dados incorretos!");
                txbLogin.Clear();
                txbSenha.Clear();
            }
            else if (senha == null)
            {
                MessageBox.Show("Dados incorretos!");
                txbLogin.Clear();
                txbSenha.Clear();
            }
            
            else if (txbLogin.Text == login.ToString() && txbSenha.Text == senha.ToString())
            {
                try
                {
                    this.Hide();
                    frmTelaInicial frmTelaInicial = new frmTelaInicial();
                    frmTelaInicial.Closed += (s, args) => this.Close();
                    frmTelaInicial.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
