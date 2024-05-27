using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure
{
    public partial class crear_usuario : Form
    {
        public crear_usuario()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private SqlConnection cn = ConexionBD.GetConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            if (NombreC.Text == "" || NombreU.Text == "" || Correo.Text == "" || Contraseña.Text == "")
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    DateTime fechaActual = DateTime.Now;
                    string fechaFormateada = fechaActual.ToString("dd-MM-yyyy");                   
                    SqlCommand cmdLastID = new SqlCommand("SELECT MAX(id_usuario) FROM usuario", cn);
                    int lastID = (int)cmdLastID.ExecuteScalar();
                    int newID = lastID + 1;
                    SqlCommand cmd = new SqlCommand("INSERT INTO usuario (id_usuario, nombre_usuario, contraseña_usuario, correo_usuario, nombre_completo, fecha_registro_usuario,id_estado_cuenta,id_tipo_usuario) VALUES (@ID, @NU, @CU, @CO, @NC, @FR, @IE, @IT)", cn);
                    cmd.Parameters.AddWithValue("@ID", newID);
                    cmd.Parameters.AddWithValue("@NU", NombreU.Text);
                    cmd.Parameters.AddWithValue("@CU", Contraseña.Text);
                    cmd.Parameters.AddWithValue("@CO", Correo.Text);
                    cmd.Parameters.AddWithValue("@NC",NombreC.Text );
                    cmd.Parameters.AddWithValue("@FR", fechaFormateada);
                    cmd.Parameters.AddWithValue("@IE", 1);
                    cmd.Parameters.AddWithValue("@IT", Tipo_usuario.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado");
                    ConexionBD.CloseConnection();
                    usuarios obj = new usuarios();
                    obj.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        

        private void crear_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet2.tipo_usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_usuarioTableAdapter2.Fill(this.azureDataSet2.tipo_usuario);
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet1.tipo_usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_usuarioTableAdapter1.Fill(this.azureDataSet1.tipo_usuario);
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet.tipo_usuario' Puede moverla o quitarla según sea necesario.


        }
    }
}
