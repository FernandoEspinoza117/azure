namespace Azure
{
    partial class crear_usuario
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.NombreU = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.NombreC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tipo_usuario = new System.Windows.Forms.ComboBox();
            this.tipousuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azureDataSet = new Azure.azureDataSet();
            this.tipo_usuarioTableAdapter = new Azure.azureDataSetTableAdapters.tipo_usuarioTableAdapter();
            this.azureDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azureDataSet1 = new Azure.azureDataSet1();
            this.tipousuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_usuarioTableAdapter1 = new Azure.azureDataSet1TableAdapters.tipo_usuarioTableAdapter();
            this.azureDataSet2 = new Azure.azureDataSet2();
            this.tipousuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_usuarioTableAdapter2 = new Azure.azureDataSet2TableAdapters.tipo_usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(96, 68);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 13);
            this.Nombre.TabIndex = 20;
            this.Nombre.Text = "Nombre completo";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(82, 240);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(313, 33);
            this.Contraseña.TabIndex = 19;
            // 
            // NombreU
            // 
            this.NombreU.Location = new System.Drawing.Point(82, 136);
            this.NombreU.Multiline = true;
            this.NombreU.Name = "NombreU";
            this.NombreU.Size = new System.Drawing.Size(313, 33);
            this.NombreU.TabIndex = 18;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(82, 188);
            this.Correo.Multiline = true;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(313, 33);
            this.Correo.TabIndex = 15;
            // 
            // NombreC
            // 
            this.NombreC.Location = new System.Drawing.Point(82, 84);
            this.NombreC.Multiline = true;
            this.NombreC.Name = "NombreC";
            this.NombreC.Size = new System.Drawing.Size(313, 33);
            this.NombreC.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre de usuario";
            // 
            // Tipo_usuario
            // 
            this.Tipo_usuario.DataSource = this.tipousuarioBindingSource2;
            this.Tipo_usuario.DisplayMember = "tipo_usuario";
            this.Tipo_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo_usuario.FormattingEnabled = true;
            this.Tipo_usuario.Location = new System.Drawing.Point(82, 298);
            this.Tipo_usuario.Name = "Tipo_usuario";
            this.Tipo_usuario.Size = new System.Drawing.Size(121, 21);
            this.Tipo_usuario.TabIndex = 27;
            this.Tipo_usuario.ValueMember = "id_tipo_usuario";
            // 
            // tipousuarioBindingSource
            // 
            this.tipousuarioBindingSource.DataMember = "tipo_usuario";
            this.tipousuarioBindingSource.DataSource = this.azureDataSet;
            // 
            // azureDataSet
            // 
            this.azureDataSet.DataSetName = "azureDataSet";
            this.azureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_usuarioTableAdapter
            // 
            this.tipo_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // azureDataSetBindingSource
            // 
            this.azureDataSetBindingSource.DataSource = this.azureDataSet;
            this.azureDataSetBindingSource.Position = 0;
            // 
            // azureDataSet1
            // 
            this.azureDataSet1.DataSetName = "azureDataSet1";
            this.azureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipousuarioBindingSource1
            // 
            this.tipousuarioBindingSource1.DataMember = "tipo_usuario";
            this.tipousuarioBindingSource1.DataSource = this.azureDataSet1;
            // 
            // tipo_usuarioTableAdapter1
            // 
            this.tipo_usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // azureDataSet2
            // 
            this.azureDataSet2.DataSetName = "azureDataSet2";
            this.azureDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipousuarioBindingSource2
            // 
            this.tipousuarioBindingSource2.DataMember = "tipo_usuario";
            this.tipousuarioBindingSource2.DataSource = this.azureDataSet2;
            // 
            // tipo_usuarioTableAdapter2
            // 
            this.tipo_usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // crear_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 387);
            this.Controls.Add(this.Tipo_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.NombreU);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.NombreC);
            this.Controls.Add(this.button1);
            this.Name = "crear_usuario";
            this.Text = "crear_usuario";
            this.Load += new System.EventHandler(this.crear_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipousuarioBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox NombreU;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox NombreC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Tipo_usuario;
        private azureDataSet azureDataSet;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource;
        private azureDataSetTableAdapters.tipo_usuarioTableAdapter tipo_usuarioTableAdapter;
        private System.Windows.Forms.BindingSource azureDataSetBindingSource;
        private azureDataSet1 azureDataSet1;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource1;
        private azureDataSet1TableAdapters.tipo_usuarioTableAdapter tipo_usuarioTableAdapter1;
        private azureDataSet2 azureDataSet2;
        private System.Windows.Forms.BindingSource tipousuarioBindingSource2;
        private azureDataSet2TableAdapters.tipo_usuarioTableAdapter tipo_usuarioTableAdapter2;
    }
}