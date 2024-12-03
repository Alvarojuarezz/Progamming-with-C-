using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PF_Y8375118G_49275680C
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            Class1 log = new Class1();
            string[] lineas2 = tb_lista_pizzas.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string linea in lineas2)
            {
                string[] elementos = linea.Split(new string[] { "........." }, StringSplitOptions.RemoveEmptyEntries);
                string nombreProducto = elementos[0].Trim();
                try
                {
                    using (SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI"))
                    {
                        conexion.Open();
                        using (SqlCommand comandosql = new SqlCommand())
                        {
                            comandosql.Connection = conexion;
                            comandosql.CommandText = "UPDATE Pizzas SET Cantidad = Cantidad - 1 WHERE Nombre = @valor1";
                            comandosql.Parameters.AddWithValue("@valor1", nombreProducto);
                            comandosql.ExecuteNonQuery();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error al actualizar la base de datos");
                }
            }

            // Creamos una instancia de Excel
            Excel.Application excel = new Excel.Application();

            // Creamos una nueva hoja de trabajo
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets.Add();

            // Copiamos el texto del TextBox a la hoja de trabajo
            string[] lineas = tb_lista_pizzas.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int fila = 1;

            foreach (string linea in lineas)
            {
                worksheet.Cells[fila, 1] = linea;
                log.log(linea);
                fila++;
            }

            worksheet.Cells[fila, 1] = "\r\n";
            log.log("\r\n");
            fila++;

            worksheet.Cells[fila, 1].NumberFormat = "@";
            worksheet.Cells[fila, 1] = tb_preciofinal.Text;
            fila++;
            log.log(tb_preciofinal.Text);
            log.log("\r\n");

            // Establecer la conexión con la base de datos
            string connectionString2 = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion2 = new SqlConnection(connectionString2);

            string query2 = "SELECT Nombre, Apellidos FROM Usuarios WHERE Usuario = @valor1";
            SqlCommand command2 = new SqlCommand(query2, conexion2);
            command2.Parameters.AddWithValue("@valor1", log.getUsuario());

            conexion2.Open();
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                worksheet.Cells[fila, 1] = "Nombre del cliente: " + reader2["Nombre"].ToString() + " " + reader2["Apellidos"].ToString();
                log.log("Nombre del cliente: " + reader2["Nombre"].ToString() + " " + reader2["Apellidos"].ToString());
                fila++;
            }

            DateTime fechaActual = DateTime.Now;
            worksheet.Cells[fila, 1] = "\r\n" + fechaActual + "\r\n\r\n";
            log.log("\r\n" + fechaActual + "\r\n------------------------------\r\n");

            reader2.Close();
            conexion2.Close();

            // Seleccionamos la columna A
            Excel.Range columnaA = worksheet.Range["A:A"];

            // Establecemos el ancho de la columna en 20 unidades
            columnaA.ColumnWidth = 30;

            // Guardamos el archivo
            try
            {
                workbook.SaveAs(@"C:\Users\juare\OneDrive\Escritorio\Alvaro\UCAM\ASIGNATURAS\2º\PVA\PRÁCTICAS\Práctica Final\PF_Y8375118G_49275680C\Factura" + log.getFactura().ToString());
                log.setFactura();
                // Cerramos el archivo y liberamos los recursos
                workbook.Close();
                excel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                worksheet = null;
                workbook = null;
                excel = null;
                GC.Collect(); // Recolección de basura para liberar la memoria utilizada por Excel
                MessageBox.Show("Factura guardada con éxito");
                Close();
                Application.OpenForms["Form3"].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anadir_Click(object sender, EventArgs e)
        {
            btn_comprar.Enabled = true;
            if (tb_lista_pizzas.Text == "")
            {
                tb_lista_pizzas.Text = cb_pizzas.SelectedItem.ToString();
            }
            else
            {
                tb_lista_pizzas.Text = tb_lista_pizzas.Text + "\r\n" + cb_pizzas.SelectedItem.ToString();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Form3"].Show();
        }

        private void cb_pizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*btn_anadir.Enabled = true;
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand comandosql = new SqlCommand("SELECT Imagen FROM Pizzas WHERE Nombre = @valor1", connection);

                string[] nombre = cb_pizzas.SelectedItem.ToString().Split(new string[] { "........." }, StringSplitOptions.RemoveEmptyEntries);
                string nombreProducto = nombre[0].Trim();
                comandosql.Parameters.AddWithValue("@valor1", nombreProducto);
                connection.Open();
                SqlDataReader reader = comandosql.ExecuteReader(); 
                
                if (reader.Read())
                {
                    byte[] imagenBytes = (byte[])reader["Imagen"];
                    MemoryStream ms = new MemoryStream(imagenBytes);
                    Image imagen = Image.FromStream(ms);
                    pb_pizzas.Image = imagen;
                }
                reader.Close();
                connection.Close();
            }*/
        }

        private void tb_lista_pizzas_TextChanged(object sender, EventArgs e)
        {
            string[] lineas = tb_lista_pizzas.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            decimal precioTotal = 0;
            foreach (string linea in lineas)
            {
                string[] elementos = linea.Split(new string[] { "........." }, StringSplitOptions.RemoveEmptyEntries);
                string nombreProducto = elementos[0].Trim();
                string precioProducto = elementos[1].Trim();
                string precioProducto2 = precioProducto.Replace("€", "");
                decimal precio;
                if (decimal.TryParse(precioProducto2, out precio))
                {
                    precioTotal += precio;
                }
            }
            tb_preciofinal.Text = "Total: " + precioTotal + "€";
        }

        private void tb_preciofinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
