namespace SoftwareFicticio
{
    partial class Venda
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblVenda = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSalvarCadastroFunc = new System.Windows.Forms.Button();
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.produtosTableAdapter();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.terceirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terceirosTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.terceirosTableAdapter();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.dgvProdutosVenda = new System.Windows.Forms.DataGridView();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLancarProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTop.Controls.Add(this.lblVenda);
            this.pnlTop.Location = new System.Drawing.Point(161, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.White;
            this.lblVenda.Location = new System.Drawing.Point(711, 27);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(137, 45);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "VENDA";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Location = new System.Drawing.Point(1, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 782);
            this.pnlLeft.TabIndex = 3;
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
            this.btnSalvarCadastroFunc.Location = new System.Drawing.Point(870, 723);
            this.btnSalvarCadastroFunc.Name = "btnSalvarCadastroFunc";
            this.btnSalvarCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroFunc.TabIndex = 16;
            this.btnSalvarCadastroFunc.Text = "Salvar";
            this.btnSalvarCadastroFunc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
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
            this.btnPesquisarCliente.Location = new System.Drawing.Point(651, 155);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(115, 22);
            this.btnPesquisarCliente.TabIndex = 18;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(284, 233);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(482, 22);
            this.txbProduto.TabIndex = 20;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(280, 127);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(73, 24);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(280, 206);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(82, 24);
            this.lblProduto.TabIndex = 22;
            this.lblProduto.Text = "Produto";
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(866, 206);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(63, 24);
            this.lblPreco.TabIndex = 23;
            this.lblPreco.Text = "Preço";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(870, 233);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.ReadOnly = true;
            this.txbPreco.Size = new System.Drawing.Size(128, 22);
            this.txbPreco.TabIndex = 24;
            this.txbPreco.TextChanged += new System.EventHandler(this.txbPreco_TextChanged);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(651, 233);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(115, 22);
            this.btnPesquisarProduto.TabIndex = 27;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(866, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(870, 155);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.ReadOnly = true;
            this.mtbData.Size = new System.Drawing.Size(95, 22);
            this.mtbData.TabIndex = 28;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbData_MaskInputRejected);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(284, 308);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(108, 22);
            this.txbQuantidade.TabIndex = 29;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(280, 281);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(112, 24);
            this.lblQuantidade.TabIndex = 30;
            this.lblQuantidade.Text = "Quantidade";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // terceirosBindingSource
            // 
            this.terceirosBindingSource.DataMember = "terceiros";
            this.terceirosBindingSource.DataSource = this.dataSet1;
            // 
            // terceirosTableAdapter
            // 
            this.terceirosTableAdapter.ClearBeforeFill = true;
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(284, 155);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ReadOnly = true;
            this.txbCliente.Size = new System.Drawing.Size(482, 22);
            this.txbCliente.TabIndex = 31;
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // dgvProdutosVenda
            // 
            this.dgvProdutosVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produtos,
            this.Quantidade,
            this.PrecoUnitario,
            this.valorUnit,
            this.valorTotalFinal});
            this.dgvProdutosVenda.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvProdutosVenda.Location = new System.Drawing.Point(284, 367);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.RowHeadersWidth = 51;
            this.dgvProdutosVenda.RowTemplate.Height = 24;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(714, 261);
            this.dgvProdutosVenda.TabIndex = 32;
            this.dgvProdutosVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Produtos
            // 
            this.Produtos.HeaderText = "Produtos";
            this.Produtos.MinimumWidth = 6;
            this.Produtos.Name = "Produtos";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.MinimumWidth = 6;
            this.PrecoUnitario.Name = "PrecoUnitario";
            // 
            // valorUnit
            // 
            this.valorUnit.HeaderText = "Valor";
            this.valorUnit.MinimumWidth = 6;
            this.valorUnit.Name = "valorUnit";
            // 
            // valorTotalFinal
            // 
            this.valorTotalFinal.HeaderText = "Valor Total";
            this.valorTotalFinal.MinimumWidth = 6;
            this.valorTotalFinal.Name = "valorTotalFinal";
            this.valorTotalFinal.ReadOnly = true;
            // 
            // btnLancarProduto
            // 
            this.btnLancarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnLancarProduto.FlatAppearance.BorderSize = 0;
            this.btnLancarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnLancarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnLancarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarProduto.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancarProduto.ForeColor = System.Drawing.Color.White;
            this.btnLancarProduto.Location = new System.Drawing.Point(870, 300);
            this.btnLancarProduto.Name = "btnLancarProduto";
            this.btnLancarProduto.Size = new System.Drawing.Size(128, 30);
            this.btnLancarProduto.TabIndex = 33;
            this.btnLancarProduto.Text = "Lançar";
            this.btnLancarProduto.UseVisualStyleBackColor = false;
            this.btnLancarProduto.Click += new System.EventHandler(this.btnLancarProduto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(722, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbDataEntrega
            // 
            this.mtbDataEntrega.Location = new System.Drawing.Point(550, 308);
            this.mtbDataEntrega.Mask = "00/00/0000";
            this.mtbDataEntrega.Name = "mtbDataEntrega";
            this.mtbDataEntrega.Size = new System.Drawing.Size(151, 22);
            this.mtbDataEntrega.TabIndex = 35;
            this.mtbDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data de entrega";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorTotal.Location = new System.Drawing.Point(870, 650);
            this.txbValorTotal.Multiline = true;
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(128, 48);
            this.txbValorTotal.TabIndex = 37;
            this.txbValorTotal.TextChanged += new System.EventHandler(this.txbValorTotal_TextChanged);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 783);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbDataEntrega);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLancarProduto);
            this.Controls.Add(this.dgvProdutosVenda);
            this.Controls.Add(this.btnPesquisarCliente);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.btnSalvarCadastroFunc);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Venda";
            this.Text = "Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Venda_FormClosing);
            this.Load += new System.EventHandler(this.Venda_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnSalvarCadastroFunc;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Button btnPesquisarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.BindingSource terceirosBindingSource;
        private DataSet1TableAdapters.terceirosTableAdapter terceirosTableAdapter;
        public System.Windows.Forms.TextBox txbCliente;
        public System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.Button btnLancarProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbDataEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalFinal;
        private System.Windows.Forms.TextBox txbValorTotal;
    }
}