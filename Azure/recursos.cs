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
    public partial class recursos : Form
    {
        public recursos()
        {
            InitializeComponent();
        }

        private void Tipo_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet5.tipo_recurso' Puede moverla o quitarla según sea necesario.
            this.tipo_recursoTableAdapter.Fill(this.azureDataSet5.tipo_recurso);
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet4.grupo_recurso' Puede moverla o quitarla según sea necesario.
            this.grupo_recursoTableAdapter.Fill(this.azureDataSet4.grupo_recurso);
            // TODO: esta línea de código carga datos en la tabla 'azureDataSet3.region' Puede moverla o quitarla según sea necesario.
            this.regionTableAdapter.Fill(this.azureDataSet3.region);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            factura Obj = new factura();
            Obj.Show();
            this.Hide();
        }
    }
}
