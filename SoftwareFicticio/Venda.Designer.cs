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
            this.btnSalvarVenda = new System.Windows.Forms.Button();
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
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.dgvProdutosVenda = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLancarProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtbDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.txbIdCliente = new System.Windows.Forms.TextBox();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.txbIdVenda = new System.Windows.Forms.TextBox();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.dataSet2 = new SoftwareFicticio.DataSet2();
            this.terceirosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.terceirosTableAdapter1 = new SoftwareFicticio.DataSet2TableAdapters.terceirosTableAdapter();
            this.btnSalvarAlterarVenda = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource1)).BeginInit();
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
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSalvarVenda.FlatAppearance.BorderSize = 0;
            this.btnSalvarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarVenda.ForeColor = System.Drawing.Color.White;
            this.btnSalvarVenda.Location = new System.Drawing.Point(870, 714);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarVenda.TabIndex = 16;
            this.btnSalvarVenda.Text = "Salvar";
            this.btnSalvarVenda.UseVisualStyleBackColor = false;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
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
            this.btnPesquisarCliente.Location = new System.Drawing.Point(653, 169);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(115, 22);
            this.btnPesquisarCliente.TabIndex = 18;
            this.btnPesquisarCliente.Text = "Pesquisar";
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(327, 247);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(441, 22);
            this.txbProduto.TabIndex = 20;
            this.txbProduto.TextChanged += new System.EventHandler(this.txbProduto_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(282, 141);
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
            this.lblProduto.Location = new System.Drawing.Point(282, 220);
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
            this.lblPreco.Location = new System.Drawing.Point(482, 295);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(63, 24);
            this.lblPreco.TabIndex = 23;
            this.lblPreco.Text = "Preço";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(486, 322);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.ReadOnly = true;
            this.txbPreco.Size = new System.Drawing.Size(67, 22);
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
            this.btnPesquisarProduto.Location = new System.Drawing.Point(653, 247);
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
            this.label1.Location = new System.Drawing.Point(868, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Data emissão";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(872, 169);
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
            this.txbQuantidade.Location = new System.Drawing.Point(286, 322);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(108, 22);
            this.txbQuantidade.TabIndex = 29;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(282, 295);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(112, 24);
            this.lblQuantidade.TabIndex = 30;
            this.lblQuantidade.Text = "Quantidade";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(327, 169);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ReadOnly = true;
            this.txbCliente.Size = new System.Drawing.Size(441, 22);
            this.txbCliente.TabIndex = 31;
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // dgvProdutosVenda
            // 
            this.dgvProdutosVenda.AllowUserToAddRows = false;
            this.dgvProdutosVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutosVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.Produtos,
            this.Quantidade,
            this.valorUnit,
            this.valorTotalFinal});
            this.dgvProdutosVenda.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvProdutosVenda.Location = new System.Drawing.Point(286, 399);
            this.dgvProdutosVenda.Name = "dgvProdutosVenda";
            this.dgvProdutosVenda.RowHeadersWidth = 51;
            this.dgvProdutosVenda.RowTemplate.Height = 24;
            this.dgvProdutosVenda.Size = new System.Drawing.Size(714, 261);
            this.dgvProdutosVenda.TabIndex = 32;
            this.dgvProdutosVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "id";
            this.idProduto.MinimumWidth = 6;
            this.idProduto.Name = "idProduto";
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
            this.btnLancarProduto.Location = new System.Drawing.Point(872, 314);
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
            this.button1.Location = new System.Drawing.Point(727, 714);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtbDataEntrega
            // 
            this.mtbDataEntrega.Location = new System.Drawing.Point(872, 247);
            this.mtbDataEntrega.Mask = "00/00/0000";
            this.mtbDataEntrega.Name = "mtbDataEntrega";
            this.mtbDataEntrega.Size = new System.Drawing.Size(128, 22);
            this.mtbDataEntrega.TabIndex = 35;
            this.mtbDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(868, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data entrega";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorTotal.Location = new System.Drawing.Point(284, 703);
            this.txbValorTotal.Multiline = true;
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(174, 68);
            this.txbValorTotal.TabIndex = 37;
            this.txbValorTotal.TextChanged += new System.EventHandler(this.txbValorTotal_TextChanged);
            // 
            // txbIdCliente
            // 
            this.txbIdCliente.Location = new System.Drawing.Point(286, 169);
            this.txbIdCliente.Name = "txbIdCliente";
            this.txbIdCliente.ReadOnly = true;
            this.txbIdCliente.Size = new System.Drawing.Size(35, 22);
            this.txbIdCliente.TabIndex = 38;
            this.txbIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Location = new System.Drawing.Point(286, 247);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.ReadOnly = true;
            this.txbIdProduto.Size = new System.Drawing.Size(35, 22);
            this.txbIdProduto.TabIndex = 39;
            this.txbIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbIdProduto.TextChanged += new System.EventHandler(this.txbIdProduto_TextChanged);
            // 
            // txbIdVenda
            // 
            this.txbIdVenda.Location = new System.Drawing.Point(686, 322);
            this.txbIdVenda.Name = "txbIdVenda";
            this.txbIdVenda.ReadOnly = true;
            this.txbIdVenda.Size = new System.Drawing.Size(35, 22);
            this.txbIdVenda.TabIndex = 40;
            this.txbIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbIdVenda.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.AutoSize = true;
            this.lblIdVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenda.Location = new System.Drawing.Point(682, 295);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(86, 24);
            this.lblIdVenda.TabIndex = 41;
            this.lblIdVenda.Text = "Id venda";
            this.lblIdVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terceirosBindingSource1
            // 
            this.terceirosBindingSource1.DataMember = "terceiros";
            this.terceirosBindingSource1.DataSource = this.dataSet2;
            // 
            // terceirosTableAdapter1
            // 
            this.terceirosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSalvarAlterarVenda
            // 
            this.btnSalvarAlterarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSalvarAlterarVenda.FlatAppearance.BorderSize = 0;
            this.btnSalvarAlterarVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarAlterarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvarAlterarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlterarVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlterarVenda.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAlterarVenda.Location = new System.Drawing.Point(870, 714);
            this.btnSalvarAlterarVenda.Name = "btnSalvarAlterarVenda";
            this.btnSalvarAlterarVenda.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarAlterarVenda.TabIndex = 42;
            this.btnSalvarAlterarVenda.Text = "Salvar";
            this.btnSalvarAlterarVenda.UseVisualStyleBackColor = false;
            this.btnSalvarAlterarVenda.Click += new System.EventHandler(this.btnSalvarAlterarVenda_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 783);
            this.Controls.Add(this.btnSalvarAlterarVenda);
            this.Controls.Add(this.lblIdVenda);
            this.Controls.Add(this.txbIdVenda);
            this.Controls.Add(this.txbIdProduto);
            this.Controls.Add(this.txbIdCliente);
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
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Venda";
            this.Text = "Venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Venda_FormClosing);
            this.Load += new System.EventHandler(this.Venda_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        public System.Windows.Forms.TextBox txbCliente;
        public System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.DataGridView dgvProdutosVenda;
        private System.Windows.Forms.Button btnLancarProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbValorTotal;
        public System.Windows.Forms.TextBox txbIdCliente;
        public System.Windows.Forms.TextBox txbIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalFinal;
        public System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.TextBox txbIdVenda;
        private System.Windows.Forms.Label lblIdVenda;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource terceirosBindingSource1;
        private DataSet2TableAdapters.terceirosTableAdapter terceirosTableAdapter1;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.MaskedTextBox mtbDataEntrega;
        public System.Windows.Forms.Button btnSalvarAlterarVenda;
        public System.Windows.Forms.Button btnSalvarVenda;
    }
}