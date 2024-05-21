namespace Azure
{
    partial class usuarios
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.ckmostrar = new System.Windows.Forms.CheckBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btniniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btniniciar.Location = new System.Drawing.Point(200, 175);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 17;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // ckmostrar
            // 
            this.ckmostrar.AutoSize = true;
            this.ckmostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.ckmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckmostrar.Location = new System.Drawing.Point(240, 123);
            this.ckmostrar.Name = "ckmostrar";
            this.ckmostrar.Size = new System.Drawing.Size(60, 17);
            this.ckmostrar.TabIndex = 16;
            this.ckmostrar.Text = "Ocultar";
            this.ckmostrar.UseVisualStyleBackColor = false;
            this.ckmostrar.CheckedChanged += new System.EventHandler(this.ckmostrar_CheckedChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.txtcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcontra.Location = new System.Drawing.Point(134, 120);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 15;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusuario.Location = new System.Drawing.Point(134, 81);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 14;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.lblcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcontra.Location = new System.Drawing.Point(51, 120);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(61, 13);
            this.lblcontra.TabIndex = 13;
            this.lblcontra.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(69, 81);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 12;
            this.lblusuario.Text = "Usuario";
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 278);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.ckmostrar);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusuario);
            this.Name = "usuarios";
            this.Text = "usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.CheckBox ckmostrar;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblusuario;
    }
}