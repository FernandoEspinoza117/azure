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
            SqlCommand queryobetenerid=new SqlCommand ("select id_usuario from usuario where nombre_usuario='" + txtusuario.Text + "'and contraseña_usuario='" + txtcontra.Text + "'", cn);
            int idusuario = 0;
            idusuario = Convert.ToInt32(queryobetenerid.ExecuteScalar());  
            


            SqlDataReader rd = cm.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Bienvenido " + txtusuario.Text);
                servicios fr = new servicios();
                fr.ShowDialog();
            }
            else
                MessageBox.Show("No se encontro el usuario " + txtusuario.Text + " revise si el usuario o la contraseña son correctos.");

            cn.Close();
            ConexionBD.CloseConnection();
            

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
