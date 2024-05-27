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
    public partial class recursos : Form
    {
        private SqlConnection cn = ConexionBD.GetConnection();
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
            try
            {
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("dd-MM-yyyy");
                SqlCommand cmdLastID = new SqlCommand("SELECT MAX(id_recurso) FROM recurso", cn);
                int lastID = (int)cmdLastID.ExecuteScalar();
                int newID = lastID + 1;
                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT facturacion ON;\r\ninsert into recurso (id_recurso, estado_recurso, fecha_creacion_recurso, descripcion_recurso, id_usuario1, id_grupo_recurso, id_tipo_recurso, id_servicio, id_region) values(@ID, @ER, @FC, @DR, @IU, @IG,@IT, @IS, @IR)", cn);
                cmd.Parameters.AddWithValue("@ID", newID);
                cmd.Parameters.AddWithValue("@ER", "Activo");
                cmd.Parameters.AddWithValue("@FC", fechaFormateada);
                cmd.Parameters.AddWithValue("@DR", "Azure Virtual Machines te permite implementar y administrar máquinas virtuales en la nube");
                cmd.Parameters.AddWithValue("@IU", usuarios.idusuario);
                cmd.Parameters.AddWithValue("@IG", Nombre_grupo.SelectedValue);
                cmd.Parameters.AddWithValue("@IT", Nombre_tipo.SelectedValue);
                cmd.Parameters.AddWithValue("@IS", servicios.idservicios);
                cmd.Parameters.AddWithValue("@IR", Nombre_region.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra realizada con exito");
                ConexionBD.CloseConnection();
                factura Obj = new factura();
                Obj.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
