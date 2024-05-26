using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

       
        private void servicios_Load(object sender, EventArgs e)
        {
            usuarios inusuarios = new usuarios();
                if (usuarios.idusuario != 0)
                {
                    
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
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceBD_Click(object sender, EventArgs e)
        {
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceRed_Click(object sender, EventArgs e)
        {
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
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }

        private void serviceSeg_Click(object sender, EventArgs e)
        {
            recursos Obj = new recursos();
            Obj.Show();
            this.Hide();
        }
    }
}
