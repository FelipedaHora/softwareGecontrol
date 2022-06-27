namespace SoftwareFicticio
{
    partial class RegistroVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarCadastroFunc = new System.Windows.Forms.Button();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txbIdCliente = new System.Windows.Forms.TextBox();
            this.btnAdicionarProdutos = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 353);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTop.Controls.Add(this.lblVenda);
            this.pnlTop.Location = new System.Drawing.Point(201, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(826, 100);
            this.pnlTop.TabIndex = 5;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.White;
            this.lblVenda.Location = new System.Drawing.Point(531, 26);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(241, 45);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "NOVA VENDA";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(314, 176);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(436, 22);
            this.txbCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(267, 149);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(863, 149);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(52, 24);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(867, 176);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.ReadOnly = true;
            this.mtbData.Size = new System.Drawing.Size(95, 22);
            this.mtbData.TabIndex = 29;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataEntrega
            // 
            this.mtbDataEntrega.Location = new System.Drawing.Point(271, 280);
            this.mtbDataEntrega.Mask = "00/00/0000";
            this.mtbDataEntrega.Name = "mtbDataEntrega";
            this.mtbDataEntrega.Size = new System.Drawing.Size(128, 22);
            this.mtbDataEntrega.TabIndex = 36;
            this.mtbDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Data de entrega";
            // 
            // btnSalvarCadastroFunc
            // 
            this.btnSalvarCadastroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSalvarCadastroFunc.FlatAppearance.BorderSize = 0;
            this.btnSalvarCadastroFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarCadastroFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarCadastroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadastroFunc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroFunc.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCadastroFunc.Location = new System.Drawing.Point(681, 254);
            this.btnSalvarCadastroFunc.Name = "btnSalvarCadastroFunc";
            this.btnSalvarCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroFunc.TabIndex = 38;
            this.btnSalvarCadastroFunc.Text = "Salvar";
            this.btnSalvarCadastroFunc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(635, 176);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(115, 22);
            this.btnPesquisarCliente.TabIndex = 39;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // txbIdCliente
            // 
            this.txbIdCliente.Location = new System.Drawing.Point(271, 176);
            this.txbIdCliente.Name = "txbIdCliente";
            this.txbIdCliente.Size = new System.Drawing.Size(37, 22);
            this.txbIdCliente.TabIndex = 40;
            this.txbIdCliente.TextChanged += new System.EventHandler(this.txbIdCliente_TextChanged);
            // 
            // btnAdicionarProdutos
            // 
            this.btnAdicionarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnAdicionarProdutos.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAdicionarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAdicionarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProdutos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProdutos.Location = new System.Drawing.Point(834, 253);
            this.btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            this.btnAdicionarProdutos.Size = new System.Drawing.Size(128, 48);
            this.btnAdicionarProdutos.TabIndex = 41;
            this.btnAdicionarProdutos.Text = "Adicionar Produtos";
            this.btnAdicionarProdutos.UseVisualStyleBackColor = false;
            this.btnAdicionarProdutos.Click += new System.EventHandler(this.btnAdicionarProdutos_Click);
            // 
            // RegistroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 353);
            this.Controls.Add(this.btnAdicionarProdutos);
            this.Controls.Add(this.txbIdCliente);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.btnSalvarCadastroFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbDataEntrega);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Name = "RegistroVendas";
            this.Text = "RegistroVendas";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.MaskedTextBox mtbDataEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarCadastroFunc;
        public System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.TextBox txbIdCliente;
        private System.Windows.Forms.Button btnAdicionarProdutos;
    }
}