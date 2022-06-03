namespace SoftwareFicticio
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnChoiceFuncionarios = new System.Windows.Forms.Button();
            this.btnChoiceProdutos = new System.Windows.Forms.Button();
            this.btnChoiceTerceiros = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Controls.Add(this.btnCadastrar);
            this.pnlLeft.Controls.Add(this.btnVenda);
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 559);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 200);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 72);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastro";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.White;
            this.btnVenda.Location = new System.Drawing.Point(0, 122);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(200, 72);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTop.Controls.Add(this.lblHome);
            this.pnlTop.Location = new System.Drawing.Point(200, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(711, 27);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(120, 45);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "HOME";
            // 
            // btnChoiceFuncionarios
            // 
            this.btnChoiceFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnChoiceFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnChoiceFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiceFuncionarios.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnChoiceFuncionarios.Location = new System.Drawing.Point(319, 181);
            this.btnChoiceFuncionarios.Name = "btnChoiceFuncionarios";
            this.btnChoiceFuncionarios.Size = new System.Drawing.Size(173, 118);
            this.btnChoiceFuncionarios.TabIndex = 2;
            this.btnChoiceFuncionarios.Text = "Funcionários";
            this.btnChoiceFuncionarios.UseVisualStyleBackColor = false;
            this.btnChoiceFuncionarios.Click += new System.EventHandler(this.btnChoiceFuncionarios_Click);
            // 
            // btnChoiceProdutos
            // 
            this.btnChoiceProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnChoiceProdutos.FlatAppearance.BorderSize = 0;
            this.btnChoiceProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiceProdutos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceProdutos.ForeColor = System.Drawing.Color.White;
            this.btnChoiceProdutos.Location = new System.Drawing.Point(591, 181);
            this.btnChoiceProdutos.Name = "btnChoiceProdutos";
            this.btnChoiceProdutos.Size = new System.Drawing.Size(173, 118);
            this.btnChoiceProdutos.TabIndex = 3;
            this.btnChoiceProdutos.Text = "Produtos";
            this.btnChoiceProdutos.UseVisualStyleBackColor = false;
            this.btnChoiceProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnChoiceTerceiros
            // 
            this.btnChoiceTerceiros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnChoiceTerceiros.FlatAppearance.BorderSize = 0;
            this.btnChoiceTerceiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiceTerceiros.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoiceTerceiros.ForeColor = System.Drawing.Color.White;
            this.btnChoiceTerceiros.Location = new System.Drawing.Point(858, 181);
            this.btnChoiceTerceiros.Name = "btnChoiceTerceiros";
            this.btnChoiceTerceiros.Size = new System.Drawing.Size(173, 118);
            this.btnChoiceTerceiros.TabIndex = 4;
            this.btnChoiceTerceiros.Text = "Terceiros";
            this.btnChoiceTerceiros.UseVisualStyleBackColor = false;
            this.btnChoiceTerceiros.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwareFicticio.Properties.Resources.wallpaperSoftware;
            this.ClientSize = new System.Drawing.Size(1139, 558);
            this.Controls.Add(this.btnChoiceTerceiros);
            this.Controls.Add(this.btnChoiceProdutos);
            this.Controls.Add(this.btnChoiceFuncionarios);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.MaximizeBox = false;
            this.Name = "frmTelaInicial";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTelaInicial_FormClosing);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnChoiceFuncionarios;
        private System.Windows.Forms.Button btnChoiceProdutos;
        private System.Windows.Forms.Button btnChoiceTerceiros;
        private System.Windows.Forms.Label lblHome;
    }
}

