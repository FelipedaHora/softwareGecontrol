namespace SoftwareFicticio
{
    partial class RegistroAcessoSistema
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
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnSalvaRegistroFunc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(128, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 100);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(404, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "ACESSO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 394);
            this.panel2.TabIndex = 9;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(263, 246);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(304, 22);
            this.txbSenha.TabIndex = 25;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(378, 219);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 24);
            this.lblSalario.TabIndex = 24;
            this.lblSalario.Text = "Senha";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(378, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 24);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Login";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(263, 179);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(304, 22);
            this.txbLogin.TabIndex = 22;
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
            this.btnSalvaRegistroFunc.Location = new System.Drawing.Point(348, 310);
            this.btnSalvaRegistroFunc.Name = "btnSalvaRegistroFunc";
            this.btnSalvaRegistroFunc.Size = new System.Drawing.Size(128, 48);
            this.btnSalvaRegistroFunc.TabIndex = 26;
            this.btnSalvaRegistroFunc.Text = "Salvar";
            this.btnSalvaRegistroFunc.UseVisualStyleBackColor = false;
            this.btnSalvaRegistroFunc.Click += new System.EventHandler(this.btnSalvaRegistroFunc_Click);
            // 
            // RegistroAcessoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 392);
            this.Controls.Add(this.btnSalvaRegistroFunc);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroAcessoSistema";
            this.Text = "RegistroAcessoSistema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnSalvaRegistroFunc;
    }
}