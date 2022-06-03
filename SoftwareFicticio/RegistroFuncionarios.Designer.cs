namespace SoftwareFicticio
{
    partial class RegistroFuncionarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cbxTipoContrato = new System.Windows.Forms.ComboBox();
            this.txbSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnSalvaRegistroFunc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 100);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(626, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "FUNCIONÁRIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 391);
            this.panel2.TabIndex = 8;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContrato.Location = new System.Drawing.Point(873, 204);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(158, 24);
            this.lblTipoContrato.TabIndex = 23;
            this.lblTipoContrato.Text = "Tipo de Contrato";
            // 
            // cbxTipoContrato
            // 
            this.cbxTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoContrato.FormattingEnabled = true;
            this.cbxTipoContrato.Items.AddRange(new object[] {
            "CLT",
            "PJ"});
            this.cbxTipoContrato.Location = new System.Drawing.Point(877, 231);
            this.cbxTipoContrato.Name = "cbxTipoContrato";
            this.cbxTipoContrato.Size = new System.Drawing.Size(188, 24);
            this.cbxTipoContrato.TabIndex = 22;
            // 
            // txbSalario
            // 
            this.txbSalario.Location = new System.Drawing.Point(642, 161);
            this.txbSalario.Name = "txbSalario";
            this.txbSalario.Size = new System.Drawing.Size(161, 22);
            this.txbSalario.TabIndex = 21;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(638, 134);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(80, 24);
            this.lblSalario.TabIndex = 20;
            this.lblSalario.Text = "Salário:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(252, 231);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(304, 22);
            this.txbEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(250, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 24);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(873, 134);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(59, 24);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(248, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 24);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // cbxSexo
            // 
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbxSexo.Location = new System.Drawing.Point(877, 159);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(188, 24);
            this.cbxSexo.TabIndex = 15;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(252, 161);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(304, 22);
            this.txbNome.TabIndex = 14;
            // 
            // btnSalvaRegistroFunc
            // 
            this.btnSalvaRegistroFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSalvaRegistroFunc.FlatAppearance.BorderSize = 0;
            this.btnSalvaRegistroFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvaRegistroFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnSalvaRegistroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaRegistroFunc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaRegistroFunc.ForeColor = System.Drawing.Color.White;
            this.btnSalvaRegistroFunc.Location = new System.Drawing.Point(937, 302);
            this.btnSalvaRegistroFunc.Name = "btnSalvaRegistroFunc";
            this.btnSalvaRegistroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvaRegistroFunc.TabIndex = 15;
            this.btnSalvaRegistroFunc.Text = "Salvar";
            this.btnSalvaRegistroFunc.UseVisualStyleBackColor = false;
            this.btnSalvaRegistroFunc.Click += new System.EventHandler(this.btnSalvarCadastroFunc_Click);
            // 
            // RegistroFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 392);
            this.Controls.Add(this.btnSalvaRegistroFunc);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroFuncionarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroFuncionarios_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cbxTipoContrato;
        private System.Windows.Forms.TextBox txbSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnSalvaRegistroFunc;
    }
}