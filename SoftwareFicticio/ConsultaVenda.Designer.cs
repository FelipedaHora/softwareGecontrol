﻿namespace SoftwareFicticio
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
            this.dgvConsultaVenda = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idterceirosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeronfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataemissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentregarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SoftwareFicticio.DataSet1();
            this.btnExcluirCadastroFunc = new System.Windows.Forms.Button();
            this.lblAlterar = new System.Windows.Forms.Button();
            this.lblNova = new System.Windows.Forms.Button();
            this.vendaTableAdapter = new SoftwareFicticio.DataSet1TableAdapters.vendaTableAdapter();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            // dgvConsultaVenda
            // 
            this.dgvConsultaVenda.AutoGenerateColumns = false;
            this.dgvConsultaVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idterceirosDataGridViewTextBoxColumn,
            this.numeronfDataGridViewTextBoxColumn,
            this.datapedidoDataGridViewTextBoxColumn,
            this.dataemissaoDataGridViewTextBoxColumn,
            this.dataentregarDataGridViewTextBoxColumn,
            this.valortotalDataGridViewTextBoxColumn});
            this.dgvConsultaVenda.DataSource = this.vendaBindingSource;
            this.dgvConsultaVenda.Location = new System.Drawing.Point(226, 131);
            this.dgvConsultaVenda.Name = "dgvConsultaVenda";
            this.dgvConsultaVenda.RowHeadersWidth = 51;
            this.dgvConsultaVenda.RowTemplate.Height = 24;
            this.dgvConsultaVenda.Size = new System.Drawing.Size(844, 480);
            this.dgvConsultaVenda.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idterceirosDataGridViewTextBoxColumn
            // 
            this.idterceirosDataGridViewTextBoxColumn.DataPropertyName = "id_terceiros";
            this.idterceirosDataGridViewTextBoxColumn.HeaderText = "id_terceiros";
            this.idterceirosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idterceirosDataGridViewTextBoxColumn.Name = "idterceirosDataGridViewTextBoxColumn";
            // 
            // numeronfDataGridViewTextBoxColumn
            // 
            this.numeronfDataGridViewTextBoxColumn.DataPropertyName = "numero_nf";
            this.numeronfDataGridViewTextBoxColumn.HeaderText = "numero_nf";
            this.numeronfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeronfDataGridViewTextBoxColumn.Name = "numeronfDataGridViewTextBoxColumn";
            // 
            // datapedidoDataGridViewTextBoxColumn
            // 
            this.datapedidoDataGridViewTextBoxColumn.DataPropertyName = "data_pedido";
            this.datapedidoDataGridViewTextBoxColumn.HeaderText = "data_pedido";
            this.datapedidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datapedidoDataGridViewTextBoxColumn.Name = "datapedidoDataGridViewTextBoxColumn";
            // 
            // dataemissaoDataGridViewTextBoxColumn
            // 
            this.dataemissaoDataGridViewTextBoxColumn.DataPropertyName = "data_emissao";
            this.dataemissaoDataGridViewTextBoxColumn.HeaderText = "data_emissao";
            this.dataemissaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataemissaoDataGridViewTextBoxColumn.Name = "dataemissaoDataGridViewTextBoxColumn";
            // 
            // dataentregarDataGridViewTextBoxColumn
            // 
            this.dataentregarDataGridViewTextBoxColumn.DataPropertyName = "data_entregar";
            this.dataentregarDataGridViewTextBoxColumn.HeaderText = "data_entregar";
            this.dataentregarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataentregarDataGridViewTextBoxColumn.Name = "dataentregarDataGridViewTextBoxColumn";
            // 
            // valortotalDataGridViewTextBoxColumn
            // 
            this.valortotalDataGridViewTextBoxColumn.DataPropertyName = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.HeaderText = "valor_total";
            this.valortotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valortotalDataGridViewTextBoxColumn.Name = "valortotalDataGridViewTextBoxColumn";
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
            // lblAlterar
            // 
            this.lblAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.lblAlterar.FlatAppearance.BorderSize = 0;
            this.lblAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAlterar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterar.ForeColor = System.Drawing.Color.White;
            this.lblAlterar.Location = new System.Drawing.Point(634, 642);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(128, 48);
            this.lblAlterar.TabIndex = 18;
            this.lblAlterar.Text = "Alterar";
            this.lblAlterar.UseVisualStyleBackColor = false;
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
            this.lblNova.Text = "Nova";
            this.lblNova.UseVisualStyleBackColor = false;
            this.lblNova.Click += new System.EventHandler(this.lblNova_Click);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 720);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.btnExcluirCadastroFunc);
            this.Controls.Add(this.dgvConsultaVenda);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ConsultaVenda";
            this.Text = "ConsultaVenda";
            this.Load += new System.EventHandler(this.ConsultaVenda_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblConsultaVenda;
        private System.Windows.Forms.DataGridView dgvConsultaVenda;
        private System.Windows.Forms.Button btnExcluirCadastroFunc;
        private System.Windows.Forms.Button lblAlterar;
        private System.Windows.Forms.Button lblNova;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DataSet1TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idterceirosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeronfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentregarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotalDataGridViewTextBoxColumn;
    }
}