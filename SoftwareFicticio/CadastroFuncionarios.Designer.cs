namespace SoftwareFicticio
{
    partial class CadastroFuncionarios
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
            this.pnlTopSide = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlLeftSIDE = new System.Windows.Forms.Panel();
            this.btnSalvarCadastroFunc = new System.Windows.Forms.Button();
            this.dgvConsultaFuncionario = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataatualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.funcionarioTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.funcionarioTableAdapter();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbxTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlTopSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopSide
            // 
            this.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTopSide.Controls.Add(this.label5);
            this.pnlTopSide.Location = new System.Drawing.Point(175, 0);
            this.pnlTopSide.Name = "pnlTopSide";
            this.pnlTopSide.Size = new System.Drawing.Size(925, 60);
            this.pnlTopSide.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(642, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "FUNCIONÁRIOS";
            // 
            // pnlLeftSIDE
            // 
            this.pnlLeftSIDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeftSIDE.Location = new System.Drawing.Point(-1, 0);
            this.pnlLeftSIDE.Name = "pnlLeftSIDE";
            this.pnlLeftSIDE.Size = new System.Drawing.Size(177, 639);
            this.pnlLeftSIDE.TabIndex = 3;
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
            this.btnSalvarCadastroFunc.Location = new System.Drawing.Point(912, 577);
            this.btnSalvarCadastroFunc.Name = "btnSalvarCadastroFunc";
            this.btnSalvarCadastroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvarCadastroFunc.TabIndex = 14;
            this.btnSalvarCadastroFunc.Text = "Novo";
            this.btnSalvarCadastroFunc.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // dgvConsultaFuncionario
            // 
            this.dgvConsultaFuncionario.AutoGenerateColumns = false;
            this.dgvConsultaFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.tipocontratoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataatualizacaoDataGridViewTextBoxColumn});
            this.dgvConsultaFuncionario.DataSource = this.funcionarioBindingSource;
            this.dgvConsultaFuncionario.Location = new System.Drawing.Point(229, 213);
            this.dgvConsultaFuncionario.Name = "dgvConsultaFuncionario";
            this.dgvConsultaFuncionario.ReadOnly = true;
            this.dgvConsultaFuncionario.RowHeadersWidth = 51;
            this.dgvConsultaFuncionario.RowTemplate.Height = 24;
            this.dgvConsultaFuncionario.Size = new System.Drawing.Size(811, 341);
            this.dgvConsultaFuncionario.TabIndex = 15;
            this.dgvConsultaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaFuncionario_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "salario";
            this.salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipocontratoDataGridViewTextBoxColumn
            // 
            this.tipocontratoDataGridViewTextBoxColumn.DataPropertyName = "tipo_contrato";
            this.tipocontratoDataGridViewTextBoxColumn.HeaderText = "tipo_contrato";
            this.tipocontratoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipocontratoDataGridViewTextBoxColumn.Name = "tipocontratoDataGridViewTextBoxColumn";
            this.tipocontratoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
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
            this.btnExcluir.Location = new System.Drawing.Point(758, 577);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 48);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnAlterar.Location = new System.Drawing.Point(602, 577);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(128, 48);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbxTipoContrato
            // 
            this.cbxTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoContrato.FormattingEnabled = true;
            this.cbxTipoContrato.Items.AddRange(new object[] {
            "CLT",
            "PJ"});
            this.cbxTipoContrato.Location = new System.Drawing.Point(852, 173);
            this.cbxTipoContrato.Name = "cbxTipoContrato";
            this.cbxTipoContrato.Size = new System.Drawing.Size(188, 24);
            this.cbxTipoContrato.TabIndex = 12;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContrato.Location = new System.Drawing.Point(848, 146);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(158, 24);
            this.lblTipoContrato.TabIndex = 13;
            this.lblTipoContrato.Text = "Tipo de Contrato";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexo.Location = new System.Drawing.Point(852, 101);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(188, 24);
            this.cbxSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(848, 76);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Sexo:";
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(626, 103);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(161, 22);
            this.txbSalario.TabIndex = 11;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(622, 76);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 24);
            this.lblSalario.TabIndex = 10;
            this.lblSalario.Text = "Salário:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(227, 173);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(304, 22);
            this.txbEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(225, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 24);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(227, 103);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(304, 22);
            this.txbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(223, 76);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 24);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // CadastroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 637);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvConsultaFuncionario);
            this.Controls.Add(this.btnSalvarCadastroFunc);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.cbxTipoContrato);
            this.Controls.Add(this.txbSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.pnlLeftSIDE);
            this.Controls.Add(this.pnlTopSide);
            this.Name = "CadastroFuncionarios";
            this.Text = "Cadastro de Funcionários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroFuncionarios_FormClosing);
            this.Load += new System.EventHandler(this.CadastroFuncionarios_Load);
            this.pnlTopSide.ResumeLayout(false);
            this.pnlTopSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopSide;
        private System.Windows.Forms.Panel pnlLeftSIDE;
        private System.Windows.Forms.Button btnSalvarCadastroFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvConsultaFuncionario;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DataSet1TableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataatualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cbxTipoContrato;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
    }
}