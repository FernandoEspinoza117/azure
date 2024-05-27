namespace Azure
{
    partial class factura
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
            this.VerFactura = new System.Windows.Forms.DataGridView();
            this.imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // VerFactura
            // 
            this.VerFactura.AllowUserToAddRows = false;
            this.VerFactura.AllowUserToDeleteRows = false;
            this.VerFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerFactura.Location = new System.Drawing.Point(12, 12);
            this.VerFactura.Name = "VerFactura";
            this.VerFactura.ReadOnly = true;
            this.VerFactura.Size = new System.Drawing.Size(521, 289);
            this.VerFactura.TabIndex = 0;
            this.VerFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imprimir
            // 
            this.imprimir.Location = new System.Drawing.Point(340, 352);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(131, 23);
            this.imprimir.TabIndex = 1;
            this.imprimir.Text = "Imprimir Factura";
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(54, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Seguir Comprando";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.VerFactura);
            this.Name = "factura";
            this.Text = "factura";
            this.Load += new System.EventHandler(this.factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VerFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView VerFactura;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}