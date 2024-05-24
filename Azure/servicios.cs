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
                MessageBox.Show("bienvenido");
            }
            else 
            {
                MessageBox.Show("no hay usuario");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios inusuarios = new usuarios();
            inusuarios.ShowDialog();
        }
    }
}
