﻿namespace Azure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.btniniciar = new System.Windows.Forms.Button();
            this.ckmostrar = new System.Windows.Forms.CheckBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btniniciar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btniniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btniniciar.Location = new System.Drawing.Point(268, 226);
            this.btniniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(100, 28);
            this.btniniciar.TabIndex = 17;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // ckmostrar
            // 
            this.ckmostrar.AutoSize = true;
            this.ckmostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.ckmostrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ckmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckmostrar.Location = new System.Drawing.Point(330, 148);
            this.ckmostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckmostrar.Name = "ckmostrar";
            this.ckmostrar.Size = new System.Drawing.Size(97, 27);
            this.ckmostrar.TabIndex = 16;
            this.ckmostrar.Text = "Ocultar";
            this.ckmostrar.UseVisualStyleBackColor = false;
            this.ckmostrar.CheckedChanged += new System.EventHandler(this.ckmostrar_CheckedChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.txtcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcontra.Location = new System.Drawing.Point(179, 148);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(132, 22);
            this.txtcontra.TabIndex = 15;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusuario.Location = new System.Drawing.Point(179, 100);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(132, 22);
            this.txtusuario.TabIndex = 14;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.lblcontra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcontra.Location = new System.Drawing.Point(63, 148);
            this.lblcontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(108, 23);
            this.lblcontra.TabIndex = 13;
            this.lblcontra.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(96, 98);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(75, 23);
            this.lblusuario.TabIndex = 12;
            this.lblusuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 342);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.ckmostrar);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "usuarios";
            this.Text = "usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}