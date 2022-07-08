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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.mtbDataEmissaoDe = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataEmissaoAte = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbDataEntregaDe = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataEntregaAte = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbxPesquisa = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendapadraoview2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVenda)).BeginInit();
            this.gpbxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlLeft.Location = new System.Drawing.Point(1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 784);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlTop.Controls.Add(this.lblConsultaVenda);
            this.pnlTop.Location = new System.Drawing.Point(201, 1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(902, 100);
            this.pnlTop.TabIndex = 5;
            // 
            // lblConsultaVenda
            // 
            this.lblConsultaVenda.AutoSize = true;
            this.lblConsultaVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaVenda.ForeColor = System.Drawing.Color.White;
            this.lblConsultaVenda.Location = new System.Drawing.Point(521, 26);
            this.lblConsultaVenda.Name = "lblConsultaVenda";
            this.lblConsultaVenda.Size = new System.Drawing.Size(348, 45);
            this.lblConsultaVenda.TabIndex = 0;
            this.lblConsultaVenda.Text = "CONSULTA VENDAS";
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
            this.btnExcluirCadastroFunc.Location = new System.Drawing.Point(789, 723);
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
            this.btnAlterar.Location = new System.Drawing.Point(634, 723);
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
            this.lblNova.Location = new System.Drawing.Point(942, 723);
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
            this.dgvConsultaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVenda.Location = new System.Drawing.Point(232, 385);
            this.dgvConsultaVenda.Name = "dgvConsultaVenda";
            this.dgvConsultaVenda.ReadOnly = true;
            this.dgvConsultaVenda.RowHeadersWidth = 51;
            this.dgvConsultaVenda.RowTemplate.Height = 24;
            this.dgvConsultaVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaVenda.Size = new System.Drawing.Size(838, 317);
            this.dgvConsultaVenda.TabIndex = 22;
            this.dgvConsultaVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaVenda_CellContentClick_1);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(365, 79);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(446, 29);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mtbDataEmissaoDe
            // 
            this.mtbDataEmissaoDe.Location = new System.Drawing.Point(46, 79);
            this.mtbDataEmissaoDe.Mask = "00/00/0000";
            this.mtbDataEmissaoDe.Name = "mtbDataEmissaoDe";
            this.mtbDataEmissaoDe.Size = new System.Drawing.Size(98, 29);
            this.mtbDataEmissaoDe.TabIndex = 1;
            this.mtbDataEmissaoDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataEmissaoDe.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataEmissaoAte
            // 
            this.mtbDataEmissaoAte.Location = new System.Drawing.Point(46, 147);
            this.mtbDataEmissaoAte.Mask = "00/00/0000";
            this.mtbDataEmissaoAte.Name = "mtbDataEmissaoAte";
            this.mtbDataEmissaoAte.Size = new System.Drawing.Size(98, 29);
            this.mtbDataEmissaoAte.TabIndex = 2;
            this.mtbDataEmissaoAte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataEmissaoAte.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "De:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Até:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbDataEntregaDe
            // 
            this.mtbDataEntregaDe.Location = new System.Drawing.Point(230, 79);
            this.mtbDataEntregaDe.Mask = "00/00/0000";
            this.mtbDataEntregaDe.Name = "mtbDataEntregaDe";
            this.mtbDataEntregaDe.Size = new System.Drawing.Size(98, 29);
            this.mtbDataEntregaDe.TabIndex = 6;
            this.mtbDataEntregaDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataEntregaDe.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataEntregaAte
            // 
            this.mtbDataEntregaAte.Location = new System.Drawing.Point(230, 147);
            this.mtbDataEntregaAte.Mask = "00/00/0000";
            this.mtbDataEntregaAte.Name = "mtbDataEntregaAte";
            this.mtbDataEntregaAte.Size = new System.Drawing.Size(98, 29);
            this.mtbDataEntregaAte.TabIndex = 7;
            this.mtbDataEntregaAte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataEntregaAte.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "De:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Até:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data de Entrega";
            // 
            // gpbxPesquisa
            // 
            this.gpbxPesquisa.Controls.Add(this.label8);
            this.gpbxPesquisa.Controls.Add(this.textBox2);
            this.gpbxPesquisa.Controls.Add(this.btnPesquisar);
            this.gpbxPesquisa.Controls.Add(this.label7);
            this.gpbxPesquisa.Controls.Add(this.label6);
            this.gpbxPesquisa.Controls.Add(this.label4);
            this.gpbxPesquisa.Controls.Add(this.label5);
            this.gpbxPesquisa.Controls.Add(this.mtbDataEntregaAte);
            this.gpbxPesquisa.Controls.Add(this.mtbDataEntregaDe);
            this.gpbxPesquisa.Controls.Add(this.label3);
            this.gpbxPesquisa.Controls.Add(this.label2);
            this.gpbxPesquisa.Controls.Add(this.label1);
            this.gpbxPesquisa.Controls.Add(this.mtbDataEmissaoAte);
            this.gpbxPesquisa.Controls.Add(this.mtbDataEmissaoDe);
            this.gpbxPesquisa.Controls.Add(this.txtCliente);
            this.gpbxPesquisa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxPesquisa.Location = new System.Drawing.Point(232, 107);
            this.gpbxPesquisa.Name = "gpbxPesquisa";
            this.gpbxPesquisa.Size = new System.Drawing.Size(838, 262);
            this.gpbxPesquisa.TabIndex = 23;
            this.gpbxPesquisa.TabStop = false;
            this.gpbxPesquisa.Text = "Pesquisar por :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Produto";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 29);
            this.textBox2.TabIndex = 25;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(683, 198);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 48);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // ConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 783);
            this.Controls.Add(this.gpbxPesquisa);
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
            this.gpbxPesquisa.ResumeLayout(false);
            this.gpbxPesquisa.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.MaskedTextBox mtbDataEmissaoDe;
        private System.Windows.Forms.MaskedTextBox mtbDataEmissaoAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDataEntregaDe;
        private System.Windows.Forms.MaskedTextBox mtbDataEntregaAte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpbxPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}