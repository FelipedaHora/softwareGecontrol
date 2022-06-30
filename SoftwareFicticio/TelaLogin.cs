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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
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
            this.Hide();
            frmTelaInicial frmTelaInicial = new frmTelaInicial();
            frmTelaInicial.Closed += (s, args) => this.Close();
            frmTelaInicial.Show();
        }
    }
}
