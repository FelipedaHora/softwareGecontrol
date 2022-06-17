namespace SoftwareFicticio
{
    partial class VendaAuxiliar
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
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbIdVenda = new System.Windows.Forms.TextBox();
            this.vendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new SoftwareFicticio.DataSet2();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SoftwareFicticio.DataSet2TableAdapters.vendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource2, "id", true));
            this.txbID.Location = new System.Drawing.Point(92, 63);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 22);
            this.txbID.TabIndex = 0;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // txbIdVenda
            // 
            this.txbIdVenda.Location = new System.Drawing.Point(92, 110);
            this.txbIdVenda.Name = "txbIdVenda";
            this.txbIdVenda.Size = new System.Drawing.Size(100, 22);
            this.txbIdVenda.TabIndex = 1;
            this.txbIdVenda.TextChanged += new System.EventHandler(this.txbIdVenda_TextChanged);
            // 
            // vendaBindingSource2
            // 
            this.vendaBindingSource2.DataMember = "venda";
            this.vendaBindingSource2.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "venda";
            this.vendaBindingSource1.DataSource = this.dataSet2;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.dataSet2;
            this.vendaBindingSource.CurrentChanged += new System.EventHandler(this.vendaBindingSource_CurrentChanged);
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // VendaAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbIdVenda);
            this.Controls.Add(this.txbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VendaAuxiliar";
            this.Text = "VendaAuxiliar";
            this.Load += new System.EventHandler(this.VendaAuxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbID;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DataSet2TableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.TextBox txbIdVenda;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.BindingSource vendaBindingSource2;
    }
}