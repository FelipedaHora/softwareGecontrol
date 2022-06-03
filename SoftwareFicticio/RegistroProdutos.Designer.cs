namespace SoftwareFicticio
{
    partial class RegistroProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxUnidadeVenda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbDescProduto = new System.Windows.Forms.TextBox();
            this.btnSalvarCadastroTerc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(218, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 100);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(648, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "PRODUTOS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 391);
            this.panel2.TabIndex = 7;
            // 
            // cbxUnidadeVenda
            // 
            this.cbxUnidadeVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadeVenda.FormattingEnabled = true;
            this.cbxUnidadeVenda.Items.AddRange(new object[] {
            "UN",
            "FD",
            "CX"});
            this.cbxUnidadeVenda.Location = new System.Drawing.Point(839, 154);
            this.cbxUnidadeVenda.Name = "cbxUnidadeVenda";
            this.cbxUnidadeVenda.Size = new System.Drawing.Size(188, 24);
            this.cbxUnidadeVenda.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(835, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unidade de venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(255, 127);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(208, 24);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Descrição do produto:";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(259, 232);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(204, 22);
            this.txbPreco.TabIndex = 12;
            // 
            // txbDescProduto
            // 
            this.txbDescProduto.Location = new System.Drawing.Point(259, 154);
            this.txbDescProduto.Name = "txbDescProduto";
            this.txbDescProduto.Size = new System.Drawing.Size(351, 22);
            this.txbDescProduto.TabIndex = 11;
            // 
            // btnSalvarCadastroTerc
            // 
            this.btnSalvarCadastroTerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSalvarCadastroTerc.FlatAppearance.BorderSize = 0;
            this.btnSalvarCadastroTerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarCadastroTerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarCadastroTerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadastroTerc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroTerc.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCadastroTerc.Location = new System.Drawing.Point(899, 311);
            this.btnSalvarCadastroTerc.Name = "btnSalvarCadastroTerc";
            this.btnSalvarCadastroTerc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroTerc.TabIndex = 23;
            this.btnSalvarCadastroTerc.Text = "Salvar";
            this.btnSalvarCadastroTerc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroTerc.Click += new System.EventHandler(this.btnSalvarCadastroTerc_Click);
            // 
            // RegistroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 392);
            this.Controls.Add(this.btnSalvarCadastroTerc);
            this.Controls.Add(this.cbxUnidadeVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbDescProduto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroProdutos";
            this.Text = "RegistroProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroProdutos_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxUnidadeVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbDescProduto;
        private System.Windows.Forms.Button btnSalvarCadastroTerc;
    }
}