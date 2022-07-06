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
    public partial class RelatorioFuncionarios : Form
    {
        public RelatorioFuncionarios()
        {
            InitializeComponent();
        }

        private void RelatorioFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.dataSet2.funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
