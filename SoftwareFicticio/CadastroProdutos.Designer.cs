namespace SoftwareFicticio
{
    partial class CadastroProdutos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbDescProduto = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUnidadeVenda = new System.Windows.Forms.ComboBox();
            this.btnSalvarCadastroFunc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCadastroProd = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.produtosTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.produtosTableAdapter();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 637);
            this.panel2.TabIndex = 4;
            // 
            // txbDescProduto
            // 
            this.txbDescProduto.Location = new System.Drawing.Point(240, 99);
            this.txbDescProduto.Name = "txbDescProduto";
            this.txbDescProduto.Size = new System.Drawing.Size(351, 22);
            this.txbDescProduto.TabIndex = 5;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(240, 177);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(204, 22);
            this.txbPreco.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(236, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(208, 24);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Descrição do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(816, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Unidade de venda:";
            // 
            // cbxUnidadeVenda
            // 
            this.cbxUnidadeVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadeVenda.FormattingEnabled = true;
            this.cbxUnidadeVenda.Items.AddRange(new object[] {
            "UN",
            "FD",
            "CX"});
            this.cbxUnidadeVenda.Location = new System.Drawing.Point(820, 99);
            this.cbxUnidadeVenda.Name = "cbxUnidadeVenda";
            this.cbxUnidadeVenda.Size = new System.Drawing.Size(188, 24);
            this.cbxUnidadeVenda.TabIndex = 10;
            this.cbxUnidadeVenda.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
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
            this.btnSalvarCadastroFunc.Location = new System.Drawing.Point(880, 577);
            this.btnSalvarCadastroFunc.Name = "btnSalvarCadastroFunc";
            this.btnSalvarCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroFunc.TabIndex = 15;
            this.btnSalvarCadastroFunc.Text = "Novo";
            this.btnSalvarCadastroFunc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(631, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "PRODUTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 60);
            this.panel1.TabIndex = 3;
            // 
            // dgvCadastroProd
            // 
            this.dgvCadastroProd.AutoGenerateColumns = false;
            this.dgvCadastroProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastroProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descprodutoDataGridViewTextBoxColumn,
            this.unidadevendaDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataatualizacaoDataGridViewTextBoxColumn});
            this.dgvCadastroProd.DataSource = this.produtosBindingSource;
            this.dgvCadastroProd.Location = new System.Drawing.Point(240, 215);
            this.dgvCadastroProd.Name = "dgvCadastroProd";
            this.dgvCadastroProd.ReadOnly = true;
            this.dgvCadastroProd.RowHeadersWidth = 51;
            this.dgvCadastroProd.RowTemplate.Height = 24;
            this.dgvCadastroProd.Size = new System.Drawing.Size(768, 346);
            this.dgvCadastroProd.TabIndex = 16;
            this.dgvCadastroProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroProd_CellContentClick);
            this.dgvCadastroProd.Click += new System.EventHandler(this.dgvCadastroProd_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descprodutoDataGridViewTextBoxColumn
            // 
            this.descprodutoDataGridViewTextBoxColumn.DataPropertyName = "desc_produto";
            this.descprodutoDataGridViewTextBoxColumn.HeaderText = "desc_produto";
            this.descprodutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descprodutoDataGridViewTextBoxColumn.Name = "descprodutoDataGridViewTextBoxColumn";
            this.descprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadevendaDataGridViewTextBoxColumn
            // 
            this.unidadevendaDataGridViewTextBoxColumn.DataPropertyName = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.HeaderText = "unidade_venda";
            this.unidadevendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadevendaDataGridViewTextBoxColumn.Name = "unidadevendaDataGridViewTextBoxColumn";
            this.unidadevendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataatualizacaoDataGridViewTextBoxColumn
            // 
            this.dataatualizacaoDataGridViewTextBoxColumn.DataPropertyName = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.HeaderText = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataatualizacaoDataGridViewTextBoxColumn.Name = "dataatualizacaoDataGridViewTextBoxColumn";
            this.dataatualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(735, 577);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 48);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 637);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvCadastroProd);
            this.Controls.Add(this.btnSalvarCadastroFunc);
            this.Controls.Add(this.cbxUnidadeVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.txbDescProduto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroProdutos";
            this.Text = "CadastroProdutos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroProdutos_FormClosing);
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbDescProduto;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUnidadeVenda;
        private System.Windows.Forms.Button btnSalvarCadastroFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCadastroProd;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadevendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluir;
    }
}