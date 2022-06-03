namespace SoftwareFicticio
{
    partial class CadastroTerceiros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvarCadastroTerc = new System.Windows.Forms.Button();
            this.dgvCadastroTerceiros = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terceirosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.terceirosTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.terceirosTableAdapter();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroTerceiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(216, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 100);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(650, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "TERCEIROS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 673);
            this.panel2.TabIndex = 5;
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
            this.btnSalvarCadastroTerc.Location = new System.Drawing.Point(905, 598);
            this.btnSalvarCadastroTerc.Name = "btnSalvarCadastroTerc";
            this.btnSalvarCadastroTerc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroTerc.TabIndex = 16;
            this.btnSalvarCadastroTerc.Text = "Novo";
            this.btnSalvarCadastroTerc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroTerc.Click += new System.EventHandler(this.btnSalvarCadastroTerc_Click);
            // 
            // dgvCadastroTerceiros
            // 
            this.dgvCadastroTerceiros.AutoGenerateColumns = false;
            this.dgvCadastroTerceiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroTerceiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfcnpjDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataatualizacaoDataGridViewTextBoxColumn});
            this.dgvCadastroTerceiros.DataSource = this.terceirosBindingSource;
            this.dgvCadastroTerceiros.Location = new System.Drawing.Point(240, 124);
            this.dgvCadastroTerceiros.Name = "dgvCadastroTerceiros";
            this.dgvCadastroTerceiros.ReadOnly = true;
            this.dgvCadastroTerceiros.RowHeadersWidth = 51;
            this.dgvCadastroTerceiros.RowTemplate.Height = 24;
            this.dgvCadastroTerceiros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastroTerceiros.Size = new System.Drawing.Size(793, 452);
            this.dgvCadastroTerceiros.TabIndex = 17;
            this.dgvCadastroTerceiros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroTerceiros_CellContentClick);
            this.dgvCadastroTerceiros.Click += new System.EventHandler(this.dgvCadastroTerceiros_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfcnpjDataGridViewTextBoxColumn
            // 
            this.cpfcnpjDataGridViewTextBoxColumn.DataPropertyName = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.HeaderText = "cpf_cnpj";
            this.cpfcnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfcnpjDataGridViewTextBoxColumn.Name = "cpfcnpjDataGridViewTextBoxColumn";
            this.cpfcnpjDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfcnpjDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            this.datacadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataatualizacaoDataGridViewTextBoxColumn
            // 
            this.dataatualizacaoDataGridViewTextBoxColumn.DataPropertyName = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.HeaderText = "data_atualizacao";
            this.dataatualizacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataatualizacaoDataGridViewTextBoxColumn.Name = "dataatualizacaoDataGridViewTextBoxColumn";
            this.dataatualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataatualizacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // terceirosBindingSource
            // 
            this.terceirosBindingSource.DataMember = "terceiros";
            this.terceirosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terceirosTableAdapter
            // 
            this.terceirosTableAdapter.ClearBeforeFill = true;
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
            this.btnExcluir.Location = new System.Drawing.Point(756, 598);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 48);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadastroTerceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 673);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvCadastroTerceiros);
            this.Controls.Add(this.btnSalvarCadastroTerc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroTerceiros";
            this.Text = "CadastroTerceiros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroTerceiros_FormClosing);
            this.Load += new System.EventHandler(this.CadastroTerceiros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroTerceiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terceirosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvarCadastroTerc;
        private System.Windows.Forms.DataGridView dgvCadastroTerceiros;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource terceirosBindingSource;
        private DataSet1TableAdapters.terceirosTableAdapter terceirosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluir;
    }
}