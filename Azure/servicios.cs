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
    public partial class servicios : Form
    {
        public servicios()
        {
            InitializeComponent();
            
        }
        
        public static int idservicios = 0;
        public static string nombreusuario;


        private void servicios_Load(object sender, EventArgs e)
        {
            usuarios inusuarios = new usuarios();
            SqlConnection connection = ConexionBD.GetConnection();
            string querynombre = "SELECT nombre_usuario FROM usuario WHERE id_usuario = "+usuarios.idusuario;
            SqlCommand cmdnombre = new SqlCommand(querynombre, connection); 
            object resultnombre = cmdnombre.ExecuteScalar();
            nombreusuario = Convert.ToString(resultnombre);

                if (usuarios.idusuario != 0)
                {
                   label8.Text = nombreusuario;
                   label8.Visible = true;
                   ver_fact.Visible = true;
                   iniciarses.Visible = false;
                   servececomp.Enabled = true;
                   serviceAlm.Enabled = true;
                   serviceBD.Enabled = true;    
                   serviceRed.Enabled = true;
                   serviceSeg.Enabled = true;
                   ServiceOPS.Enabled = true;
                } 
                else
                {
                    label8.Visible = false;
                   ver_fact.Visible = false;
                   iniciarses.Visible = true;
                   servececomp.Enabled = false;
                   serviceAlm.Enabled = false;
                   serviceBD.Enabled = false;
                   serviceRed.Enabled = false;
                   serviceSeg.Enabled = false;
                   ServiceOPS.Enabled = false;

                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios inusuarios = new usuarios();
            inusuarios.Show();
            this.Hide();
        }

        private void servececomp_Click(object sender, EventArgs e)
        {
            idservicios = 1;
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceBD_Click(object sender, EventArgs e)
        {
             idservicios = 3;
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceRed_Click(object sender, EventArgs e)
        {
             idservicios = 4;
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void ServiceOPS_Click(object sender, EventArgs e)
        {

            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceAlm_Click(object sender, EventArgs e)
        {
             idservicios = 2;
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceSeg_Click(object sender, EventArgs e)
        {
            idservicios = 10;
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void ver_fact_Click(object sender, EventArgs e)
        {
            factura fr = new factura();
            fr.Show();
            this.Hide();
        }
    }
}
