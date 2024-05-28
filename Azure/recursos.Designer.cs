namespace Azure
{
    partial class recursos
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
            this.Nombre_grupo = new System.Windows.Forms.ComboBox();
            this.gruporecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azureDataSet4 = new Azure.azureDataSet4();
            this.Nombre_tipo = new System.Windows.Forms.ComboBox();
            this.tiporecursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azureDataSet5 = new Azure.azureDataSet5();
            this.Nombre_region = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azureDataSet3 = new Azure.azureDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.regionTableAdapter = new Azure.azureDataSet3TableAdapters.regionTableAdapter();
            this.grupo_recursoTableAdapter = new Azure.azureDataSet4TableAdapters.grupo_recursoTableAdapter();
            this.tipo_recursoTableAdapter = new Azure.azureDataSet5TableAdapters.tipo_recursoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gruporecursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiporecursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre_grupo
            // 
            this.Nombre_grupo.DataSource = this.gruporecursoBindingSource;
            this.Nombre_grupo.DisplayMember = "nombre_grupo_recurso";
            this.Nombre_grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nombre_grupo.FormattingEnabled = true;
            this.Nombre_grupo.Location = new System.Drawing.Point(155, 54);
            this.Nombre_grupo.Name = "Nombre_grupo";
            this.Nombre_grupo.Size = new System.Drawing.Size(121, 21);
            this.Nombre_grupo.TabIndex = 28;
            this.Nombre_grupo.ValueMember = "id_grupo_recurso";
            // 
            // gruporecursoBindingSource
            // 
            this.gruporecursoBindingSource.DataMember = "grupo_recurso";
            this.gruporecursoBindingSource.DataSource = this.azureDataSet4;
            // 
            // azureDataSet4
            // 
            this.azureDataSet4.DataSetName = "azureDataSet4";
            this.azureDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nombre_tipo
            // 
            this.Nombre_tipo.DataSource = this.tiporecursoBindingSource;
            this.Nombre_tipo.DisplayMember = "nombre_tipo_recurso";
            this.Nombre_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nombre_tipo.FormattingEnabled = true;
            this.Nombre_tipo.Location = new System.Drawing.Point(295, 54);
            this.Nombre_tipo.Name = "Nombre_tipo";
            this.Nombre_tipo.Size = new System.Drawing.Size(121, 21);
            this.Nombre_tipo.TabIndex = 29;
            this.Nombre_tipo.ValueMember = "id_tipo_recurso";
            // 
            // tiporecursoBindingSource
            // 
            this.tiporecursoBindingSource.DataMember = "tipo_recurso";
            this.tiporecursoBindingSource.DataSource = this.azureDataSet5;
            // 
            // azureDataSet5
            // 
            this.azureDataSet5.DataSetName = "azureDataSet5";
            this.azureDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nombre_region
            // 
            this.Nombre_region.DataSource = this.regionBindingSource;
            this.Nombre_region.DisplayMember = "nombre_region";
            this.Nombre_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nombre_region.FormattingEnabled = true;
            this.Nombre_region.Location = new System.Drawing.Point(12, 54);
            this.Nombre_region.Name = "Nombre_region";
            this.Nombre_region.Size = new System.Drawing.Size(121, 21);
            this.Nombre_region.TabIndex = 30;
            this.Nombre_region.ValueMember = "id_region";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.azureDataSet3;
            // 
            // azureDataSet3
            // 
            this.azureDataSet3.DataSetName = "azureDataSet3";
            this.azureDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(127, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Efectuar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // grupo_recursoTableAdapter
            // 
            this.grupo_recursoTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_recursoTableAdapter
            // 
            this.tipo_recursoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azure.Properties.Resources.Captura_de_pantalla_2023_11_10_232409;
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // recursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nombre_region);
            this.Controls.Add(this.Nombre_tipo);
            this.Controls.Add(this.Nombre_grupo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "recursos";
            this.Text = "recursos";
            this.Load += new System.EventHandler(this.recursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gruporecursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiporecursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azureDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Nombre_grupo;
        private System.Windows.Forms.ComboBox Nombre_tipo;
        private System.Windows.Forms.ComboBox Nombre_region;
        private System.Windows.Forms.Button button1;
        private azureDataSet3 azureDataSet3;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private azureDataSet3TableAdapters.regionTableAdapter regionTableAdapter;
        private azureDataSet4 azureDataSet4;
        private System.Windows.Forms.BindingSource gruporecursoBindingSource;
        private azureDataSet4TableAdapters.grupo_recursoTableAdapter grupo_recursoTableAdapter;
        private azureDataSet5 azureDataSet5;
        private System.Windows.Forms.BindingSource tiporecursoBindingSource;
        private azureDataSet5TableAdapters.tipo_recursoTableAdapter tipo_recursoTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}