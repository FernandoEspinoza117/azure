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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private SqlConnection cn = ConexionBD.GetConnection();

        private void btniniciar_Click(object sender, EventArgs e)
        {

            cn.Open();
            SqlCommand cm = new SqlCommand("select nombre_usuario, contraseña_usuario from usuario where nombre_usuario='" + txtusuario.Text + "'and contraseña_usuario='" + txtcontra.Text + "'", cn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Bienvenido " + txtusuario.Text);
                servicios fr = new servicios();
                fr.ShowDialog();
            }
            else
                MessageBox.Show("No se encontro el usuario " + txtusuario.Text + " revise si el usuario o la contraseña son correctos.");
<<<<<<< HEAD
            cn.Close();
            ConexionBD.CloseConnection();
            
=======
>>>>>>> 831bd7d5d1ca80e130b63a21eefd8c0607c8bc29
        }

        private void ckmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmostrar.Checked)
            {
                txtcontra.PasswordChar = '*';
            }
            else
            {
                txtcontra.PasswordChar = '\0';
            }
        }
    }
    
}
