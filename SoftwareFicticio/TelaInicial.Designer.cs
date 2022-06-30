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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicial));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnChoiceFuncionarios = new System.Windows.Forms.Button();
            this.btnChoiceProdutos = new System.Windows.Forms.Button();
            this.btnChoiceTerceiros = new System.Windows.Forms.Button();
            this.btnRelatorioFunc = new System.Windows.Forms.Button();
            this.btnRelatorioProd = new System.Windows.Forms.Button();
            this.btnRelatorioTerc = new System.Windows.Forms.Button();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Controls.Add(this.btnSair);
            this.pnlLeft.Controls.Add(this.btnRelatorios);
            this.pnlLeft.Controls.Add(this.btnCadastrar);
            this.pnlLeft.Controls.Add(this.btnVenda);
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 559);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(-3, 278);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(200, 72);
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            this.btnRelatorios.MouseEnter += new System.EventHandler(this.btnRelatorios_MouseEnter);
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
            this.btnCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCadastrar_MouseClick);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
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
            this.btnVenda.ImageList = this.imageList1;
            this.btnVenda.Location = new System.Drawing.Point(0, 122);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(200, 72);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "venda-rapida.png");
            this.imageList1.Images.SetKeyName(1, "compartilhar.png");
            this.imageList1.Images.SetKeyName(2, "calendario.png");
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
            // btnRelatorioFunc
            // 
            this.btnRelatorioFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnRelatorioFunc.FlatAppearance.BorderSize = 0;
            this.btnRelatorioFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioFunc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioFunc.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioFunc.Location = new System.Drawing.Point(319, 181);
            this.btnRelatorioFunc.Name = "btnRelatorioFunc";
            this.btnRelatorioFunc.Size = new System.Drawing.Size(173, 118);
            this.btnRelatorioFunc.TabIndex = 5;
            this.btnRelatorioFunc.Text = "Funcionários";
            this.btnRelatorioFunc.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioProd
            // 
            this.btnRelatorioProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnRelatorioProd.FlatAppearance.BorderSize = 0;
            this.btnRelatorioProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioProd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioProd.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioProd.Location = new System.Drawing.Point(591, 181);
            this.btnRelatorioProd.Name = "btnRelatorioProd";
            this.btnRelatorioProd.Size = new System.Drawing.Size(173, 118);
            this.btnRelatorioProd.TabIndex = 6;
            this.btnRelatorioProd.Text = "Produtos";
            this.btnRelatorioProd.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioTerc
            // 
            this.btnRelatorioTerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnRelatorioTerc.FlatAppearance.BorderSize = 0;
            this.btnRelatorioTerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioTerc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioTerc.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioTerc.Location = new System.Drawing.Point(858, 181);
            this.btnRelatorioTerc.Name = "btnRelatorioTerc";
            this.btnRelatorioTerc.Size = new System.Drawing.Size(173, 118);
            this.btnRelatorioTerc.TabIndex = 7;
            this.btnRelatorioTerc.Text = "Terceiros";
            this.btnRelatorioTerc.UseVisualStyleBackColor = false;
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnRelatorioVendas.FlatAppearance.BorderSize = 0;
            this.btnRelatorioVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioVendas.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioVendas.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(319, 324);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(173, 118);
            this.btnRelatorioVendas.TabIndex = 8;
            this.btnRelatorioVendas.Text = "Vendas";
            this.btnRelatorioVendas.UseVisualStyleBackColor = false;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 484);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 72);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwareFicticio.Properties.Resources.wallpaperSoftware;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 558);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.btnRelatorioTerc);
            this.Controls.Add(this.btnRelatorioProd);
            this.Controls.Add(this.btnRelatorioFunc);
            this.Controls.Add(this.btnChoiceTerceiros);
            this.Controls.Add(this.btnChoiceProdutos);
            this.Controls.Add(this.btnChoiceFuncionarios);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTelaInicial";
            this.ShowInTaskbar = false;
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
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnRelatorioFunc;
        private System.Windows.Forms.Button btnRelatorioProd;
        private System.Windows.Forms.Button btnRelatorioTerc;
        private System.Windows.Forms.Button btnRelatorioVendas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSair;
    }
}

