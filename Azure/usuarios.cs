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
        public static int idusuario=0;

        public void btniniciar_Click(object sender, EventArgs e)
        {
                        
            
           
            SqlCommand cm = new SqlCommand("select nombre_usuario, contraseña_usuario from usuario where nombre_usuario='" + txtusuario.Text + "'and contraseña_usuario='" + txtcontra.Text + "'", cn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Bienvenido " + txtusuario.Text);
                rd.Close();
                SqlCommand queryobetenerid = new SqlCommand("select id_usuario from usuario where nombre_usuario='" + txtusuario.Text + "'and contraseña_usuario='" + txtcontra.Text + "'", cn);
                usuarios.idusuario = Convert.ToInt32(queryobetenerid.ExecuteScalar());
                ConexionBD.CloseConnection();
                servicios fr = new servicios();
                fr.ShowDialog();
                
            }
            else
                MessageBox.Show("No se encontro el usuario " + txtusuario.Text + " revise si el usuario o la contraseña son correctos.");

            
            

            
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
