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
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).BeginInit();
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
            this.pnlLeft.Size = new System.Drawing.Size(200, 484);
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
            this.btnSalvarCadastroFunc.Location = new System.Drawing.Point(870, 390);
            this.btnSalvarCadastroFunc.Name = "btnSalvarCadastroFunc";
            this.btnSalvarCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroFunc.TabIndex = 16;
            this.btnSalvarCadastroFunc.Text = "Salvar";
            this.btnSalvarCadastroFunc.UseVisualStyleBackColor = false;
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
            this.mtbData.Size = new System.Drawing.Size(59, 22);
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
            this.txbCliente.Size = new System.Drawing.Size(482, 22);
            this.txbCliente.TabIndex = 31;
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 483);
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
            this.Name = "Venda";
            this.Text = "Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Venda_FormClosing);
            this.Load += new System.EventHandler(this.Venda_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).EndInit();
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
    }
}