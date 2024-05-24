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
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
        }
        private SqlConnection cn = ConexionBD.GetConnection();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void factura_Load(object sender, EventArgs e)
        {
            SqlConnection connection = ConexionBD.GetConnection();
            String Query = " select nombre_usuario,estado_recurso, nombre_tipo_servicio, precio_servicio from facturacion\r\ninner join recurso on facturacion.id_recurso=recurso.id_recurso\r\ninner join  usuario on recurso.id_usuario=usuario.id_usuario\r\ninner join grupo_recurso on recurso.id_grupo_recurso=grupo_recurso.id_grupo_recurso\r\ninner join tipo_recurso on recurso.id_tipo_recurso=tipo_recurso.id_tipo_recurso\r\ninner join servicio on recurso.id_servicio=servicio.id_servicio\r\ninner join region on recurso.id_region=region.id_region\r\ninner join tipo_usuario on usuario.id_tipo_usuario=tipo_usuario.id_tipo_usuario\r\ninner join estado_cuenta on usuario.id_estado_cuenta=estado_cuenta.id_estado_cuenta\r\ninner join rol_permiso on tipo_usuario.id_rol_permiso=rol_permiso.id_rol_permiso\r\ninner join tipo_servicio on servicio.id_tipo_servicio=tipo_servicio.id_tipo_servicio\r\ninner join inscripcion_curso on servicio.id_inscripcion_curso=inscripcion_curso.id_inscripcion_curso\r\ninner join curso on inscripcion_curso.id_curso=curso.id_curso";
            SqlDataAdapter sda = new SqlDataAdapter(Query, connection);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VerFactura.DataSource = ds.Tables[0];
            ConexionBD.CloseConnection();
        }
    }
}
