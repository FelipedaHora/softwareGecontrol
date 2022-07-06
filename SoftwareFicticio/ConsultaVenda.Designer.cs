namespace SoftwareFicticio
{
    partial class ConsultaVenda
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblConsultaVenda = new System.Windows.Forms.Label();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.btnExcluirCadastroFunc = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblNova = new System.Windows.Forms.Button();
            this.vendaTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.vendaTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataSet2 = new SoftwareFicticio.DataSet2();
            this.vendapadraoviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendapadraoviewTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendapadraoviewTableAdapter();
            this.vendapadraoviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendapadraoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendapadraoTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendapadraoTableAdapter();
            this.vendapadraoview2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendapadraoview2TableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendapadraoview2TableAdapter();
            this.dgvConsultaVenda = new System.Windows.Forms.DataGridView();
            this.idvendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idterceirosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeronfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoview2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 722);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTop.Controls.Add(this.lblConsultaVenda);
            this.pnlTop.Location = new System.Drawing.Point(163, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 100);
            this.pnlTop.TabIndex = 5;
            // 
            // lblConsultaVenda
            // 
            this.lblConsultaVenda.AutoSize = true;
            this.lblConsultaVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaVenda.ForeColor = System.Drawing.Color.White;
            this.lblConsultaVenda.Location = new System.Drawing.Point(711, 27);
            this.lblConsultaVenda.Name = "lblConsultaVenda";
            this.lblConsultaVenda.Size = new System.Drawing.Size(159, 45);
            this.lblConsultaVenda.TabIndex = 0;
            this.lblConsultaVenda.Text = "VENDAS";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluirCadastroFunc
            // 
            this.btnExcluirCadastroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnExcluirCadastroFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastroFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnExcluirCadastroFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnExcluirCadastroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastroFunc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastroFunc.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCadastroFunc.Location = new System.Drawing.Point(789, 642);
            this.btnExcluirCadastroFunc.Name = "btnExcluirCadastroFunc";
            this.btnExcluirCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnExcluirCadastroFunc.TabIndex = 17;
            this.btnExcluirCadastroFunc.Text = "Excluir";
            this.btnExcluirCadastroFunc.UseVisualStyleBackColor = false;
            this.btnExcluirCadastroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(634, 642);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(128, 48);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.lblAlterar_Click);
            // 
            // lblNova
            // 
            this.lblNova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.lblNova.FlatAppearance.BorderSize = 0;
            this.lblNova.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblNova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblNova.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNova.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNova.ForeColor = System.Drawing.Color.White;
            this.lblNova.Location = new System.Drawing.Point(942, 642);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(128, 48);
            this.lblNova.TabIndex = 19;
            this.lblNova.Text = "Inserir";
            this.lblNova.UseVisualStyleBackColor = false;
            this.lblNova.Click += new System.EventHandler(this.lblNova_Click);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendapadraoviewBindingSource
            // 
            this.vendapadraoviewBindingSource.DataMember = "vendapadraoview";
            this.vendapadraoviewBindingSource.DataSource = this.dataSet2;
            // 
            // vendapadraoviewTableAdapter
            // 
            this.vendapadraoviewTableAdapter.ClearBeforeFill = true;
            // 
            // vendapadraoviewBindingSource1
            // 
            this.vendapadraoviewBindingSource1.DataMember = "vendapadraoview";
            this.vendapadraoviewBindingSource1.DataSource = this.dataSet2;
            // 
            // vendapadraoBindingSource
            // 
            this.vendapadraoBindingSource.DataMember = "vendapadrao";
            this.vendapadraoBindingSource.DataSource = this.dataSet2;
            // 
            // vendapadraoTableAdapter
            // 
            this.vendapadraoTableAdapter.ClearBeforeFill = true;
            // 
            // vendapadraoview2BindingSource
            // 
            this.vendapadraoview2BindingSource.DataMember = "vendapadraoview2";
            this.vendapadraoview2BindingSource.DataSource = this.dataSet2;
            // 
            // vendapadraoview2TableAdapter
            // 
            this.vendapadraoview2TableAdapter.ClearBeforeFill = true;
            // 
            // dgvConsultaVenda
            // 
            this.dgvConsultaVenda.AllowUserToAddRows = false;
            this.dgvConsultaVenda.AllowUserToDeleteRows = false;
            this.dgvConsultaVenda.AutoGenerateColumns = false;
            this.dgvConsultaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvendaDataGridViewTextBoxColumn,
            this.idterceirosDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn,
            this.numeronfDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn,
            this.datapedidoDataGridViewTextBoxColumn1,
            this.dataentregarDataGridViewTextBoxColumn1});
            this.dgvConsultaVenda.DataSource = this.vendapadraoviewBindingSource;
            this.dgvConsultaVenda.Location = new System.Drawing.Point(232, 129);
            this.dgvConsultaVenda.Name = "dgvConsultaVenda";
            this.dgvConsultaVenda.ReadOnly = true;
            this.dgvConsultaVenda.RowHeadersWidth = 51;
            this.dgvConsultaVenda.RowTemplate.Height = 24;
            this.dgvConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaVenda.Size = new System.Drawing.Size(838, 478);
            this.dgvConsultaVenda.TabIndex = 22;
            this.dgvConsultaVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaVenda_CellContentClick_1);
            // 
            // idvendaDataGridViewTextBoxColumn
            // 
            this.idvendaDataGridViewTextBoxColumn.DataPropertyName = "idvenda";
            this.idvendaDataGridViewTextBoxColumn.HeaderText = "Código Venda";
            this.idvendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idvendaDataGridViewTextBoxColumn.Name = "idvendaDataGridViewTextBoxColumn";
            this.idvendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idterceirosDataGridViewTextBoxColumn1
            // 
            this.idterceirosDataGridViewTextBoxColumn1.DataPropertyName = "id_terceiros";
            this.idterceirosDataGridViewTextBoxColumn1.HeaderText = "Código Cliente";
            this.idterceirosDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idterceirosDataGridViewTextBoxColumn1.Name = "idterceirosDataGridViewTextBoxColumn1";
            this.idterceirosDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "CPF/CPNJ";
            this.cpfcnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeronfDataGridViewTextBoxColumn
            // 
            this.numeronfDataGridViewTextBoxColumn.DataPropertyName = "numero_nf";
            this.numeronfDataGridViewTextBoxColumn.HeaderText = "Número NF-E";
            this.numeronfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeronfDataGridViewTextBoxColumn.Name = "numeronfDataGridViewTextBoxColumn";
            this.numeronfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valortotalDataGridViewTextBoxColumn
            // 
            this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valortotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
            this.valortotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datapedidoDataGridViewTextBoxColumn1
            // 
            this.datapedidoDataGridViewTextBoxColumn1.DataPropertyName = "data_pedido";
            this.datapedidoDataGridViewTextBoxColumn1.HeaderText = "Data do Pedido";
            this.datapedidoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datapedidoDataGridViewTextBoxColumn1.Name = "datapedidoDataGridViewTextBoxColumn1";
            this.datapedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataentregarDataGridViewTextBoxColumn1
            // 
            this.dataentregarDataGridViewTextBoxColumn1.DataPropertyName = "data_entregar";
            this.dataentregarDataGridViewTextBoxColumn1.HeaderText = "Data de Entrega";
            this.dataentregarDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataentregarDataGridViewTextBoxColumn1.Name = "dataentregarDataGridViewTextBoxColumn1";
            this.dataentregarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 720);
            this.Controls.Add(this.dgvConsultaVenda);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluirCadastroFunc);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ConsultaVenda";
            this.Text = "ConsultaVenda";
            this.Load += new System.EventHandler(this.ConsultaVenda_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoview2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblConsultaVenda;
        private System.Windows.Forms.Button btnExcluirCadastroFunc;
        private System.Windows.Forms.Button lblNova;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DataSet1TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btnAlterar;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vendapadraoviewBindingSource;
        private DataSet2TableAdapters.vendapadraoviewTableAdapter vendapadraoviewTableAdapter;
        private System.Windows.Forms.BindingSource vendapadraoviewBindingSource1;
        private System.Windows.Forms.BindingSource vendapadraoBindingSource;
        private DataSet2TableAdapters.vendapadraoTableAdapter vendapadraoTableAdapter;
        private System.Windows.Forms.BindingSource vendapadraoview2BindingSource;
        private DataSet2TableAdapters.vendapadraoview2TableAdapter vendapadraoview2TableAdapter;
        private System.Windows.Forms.DataGridView dgvConsultaVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idterceirosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeronfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregarDataGridViewTextBoxColumn1;
    }
}