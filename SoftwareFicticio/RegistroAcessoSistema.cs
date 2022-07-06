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
    public partial class RegistroAcessoSistema : Form
    {
        public RegistroAcessoSistema()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvaRegistroFunc_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet2TableAdapters.usuarioTableAdapter usuarioTableAdapter = new DataSet2TableAdapters.usuarioTableAdapter();
                usuarioTableAdapter.InsertQuery(txbLogin.Text, txbSenha.Text);

                MessageBox.Show("Login criado com sucesso!");
                txbLogin.Clear();
                txbSenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
