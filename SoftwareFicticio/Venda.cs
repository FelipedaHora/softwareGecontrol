﻿using System;
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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.terceiros'. Você pode movê-la ou removê-la conforme necessário.
            this.terceirosTableAdapter.Fill(this.dataSet1.terceiros);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSet1.produtos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroTerceiros cadastroTerc = new CadastroTerceiros();// { Owner = this };
            cadastroTerc.btnSelecionar.Visible = true;
            cadastroTerc.ShowDialog();
            

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Venda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        public void txbCliente_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void mtbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DateTime datacadastro = new DateTime();
            datacadastro = DateTime.Now;

            mtbData.Text = datacadastro.ToString("dd.MM.yyyy");
            mtbData.Show();
        }
    }
}
