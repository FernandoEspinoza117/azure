using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public class CrearPDF
    {
    private PrintPreviewDialog printPreviewDialog;
    private DataGridView VerFacturas; // Nueva propiedad para almacenar SalaryDGV

    public void ImprimirDesdeNombre(DataGridView VerFactura, PrintDocument printDocument)
    {
        if (VerFactura.SelectedRows.Count > 0)
        {
            VerFacturas = VerFactura; // Asignar SalaryDGV a la propiedad

            printDocument.PrintPage += (sender, args) => Doc_PrintPage(sender, args, VerFactura);
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        else
        {
            MessageBox.Show("No hay ninguna fila seleccionada para imprimir.");
        }
    }

    private void Doc_PrintPage(object sender, PrintPageEventArgs e, DataGridView VerFactura)
    {
        if (VerFactura.SelectedRows.Count > 0)
        {
            e.Graphics.DrawString("Programadores de Libre Comercio Ltd", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Red, new Point(360, 25));
            e.Graphics.DrawString("Sistema de de compras Service Azure 1.0", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Blue, new Point(50, 75));

            string Nombre_usuario = VerFactura.SelectedRows[0].Cells[0].Value.ToString();
            string Estado_del_Recurso = VerFactura.SelectedRows[0].Cells[1].Value.ToString();
            string Nombre_tipo_servicio = VerFactura.SelectedRows[0].Cells[2].Value.ToString();
            string Precio_servicio = VerFactura.SelectedRows[0].Cells[3].Value.ToString();
           

            e.Graphics.DrawString("Nombre_usuario: " + Nombre_usuario, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("Estado_del_Recurso: " + Estado_del_Recurso, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 125));
            e.Graphics.DrawString("Nombre_tipo_servicio: " + Nombre_tipo_servicio, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("Precio_servicio: " + Precio_servicio, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 175));
            
            e.Graphics.DrawString("Desarollado por estudiantes de UNICAES", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Crimson, new Point(50, 450));
            e.Graphics.DrawString("Version Final", new Font("Times New Roman", 17, FontStyle.Bold), Brushes.Crimson, new Point(50, 475));
        }
        else
        {
            MessageBox.Show("No hay ninguna fila seleccionada para imprimir.");
        }
    }
}

