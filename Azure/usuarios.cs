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

        private void btniniciar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source = SPARTAN117\SQLSERVER; Initial Catalog = azure; Persist Security Info = True; User ID = root2; Password = root2");
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
