using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PF_Y8375118G_49275680C
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Comprobar()
        {
            bool elementosSeleccionados = false;
            foreach (object item in cbl_especias.Items)
            {
                if (cbl_especias.CheckedItems.Contains(item))
                {
                    elementosSeleccionados = true;
                    break;
                }
            }

            if (!elementosSeleccionados)
            {
                foreach (object item in cbl_ingredientes.Items)
                {
                    if (cbl_ingredientes.CheckedItems.Contains(item))
                    {
                        elementosSeleccionados = true;
                        break;
                    }
                }
            }

            if (!elementosSeleccionados && cb_masas.SelectedItem == null && cb_salsas.SelectedItem == null)
            {
                btn_comprar.Enabled = false;
            }
            else
            {
                btn_comprar.Enabled = true;
            }
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (cbl_especias.SelectedItems.Count == 0 || cbl_ingredientes.SelectedItems.Count == 0 || cb_masas.SelectedItem == null || cb_salsas.SelectedItem == null)
            {
                MessageBox.Show("Hay que seleccionar al menos un elemento en cada campo");
            }
            else
            {
                Class1 log = new Class1();

                string[] lineas2 = tb_precio.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
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
                                comandosql.CommandText = "UPDATE Especias SET Cantidad = Cantidad - 1 WHERE Nombre = @valor1";
                                comandosql.Parameters.AddWithValue("@valor1", nombreProducto);
                                comandosql.ExecuteNonQuery();

                                comandosql.CommandText = "UPDATE Ingredientes SET Cantidad = Cantidad - 1 WHERE Nombre = @valor1";
                                comandosql.ExecuteNonQuery();

                                comandosql.CommandText = "UPDATE Masas SET Cantidad = Cantidad - 1 WHERE Nombre = @valor1";
                                comandosql.ExecuteNonQuery();

                                comandosql.CommandText = "UPDATE Salsas SET Cantidad = Cantidad - 1 WHERE Nombre = @valor1";
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
                string[] lineas = tb_precio.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
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
                worksheet.Cells[fila, 1] = "PRECIO TOTAL:";
                log.log("PRECIO TOTAL:");
                fila++;

                worksheet.Cells[fila, 1].NumberFormat = "@";
                worksheet.Cells[fila, 1] = tb_total.Text;
                fila++;
                log.log(tb_total.Text);
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
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Form3"].Show();
        }

        private void tb_precio_TextChanged(object sender, EventArgs e)
        {
            string[] lineas = tb_precio.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            decimal precioTotal = 0;
            foreach (string linea in lineas)
            {
                if (linea != "INGREDIENTES:" && linea != "ESPECIAS:" && linea != "MASA:" && linea != "SALSA:")
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
            }
            tb_total.Text = precioTotal.ToString() + "€";
        }

        private void cb_salsas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbl_especias.SelectedItems.Count == 0 && cbl_ingredientes.SelectedItems.Count == 0 && cb_masas.SelectedItem == null && cb_salsas.SelectedItem == null)
            {
                btn_comprar.Enabled = false;
            }
            else
            {
                btn_comprar.Enabled = true;

            }
            // Concatenar los elementos seleccionados en el CheckedListBox 1
            string elementosSeleccionados1 = "";
            foreach (object itemChecked in cbl_ingredientes.CheckedItems)
            {
                elementosSeleccionados1 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados1 = elementosSeleccionados1.TrimEnd('\r', '\n');

            // Concatenar los elementos seleccionados en el CheckedListBox 2
            string elementosSeleccionados2 = "";
            foreach (object itemChecked in cbl_especias.CheckedItems)
            {
                elementosSeleccionados2 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados2 = elementosSeleccionados2.TrimEnd('\r', '\n');

            // Obtener los valores seleccionados de los ComboBox
            string valorComboBox1 = cb_masas.SelectedItem != null ? cb_masas.SelectedItem.ToString() : "";
            string valorComboBox2 = cb_salsas.SelectedItem != null ? cb_salsas.SelectedItem.ToString() : "";

            // Concatenar los resultados en un solo string
            string resultado = "INGREDIENTES:\r\n" + elementosSeleccionados1 + "\r\n\r\nESPECIAS:\r\n" + elementosSeleccionados2 + "\r\n\r\nMASA:\r\n" + valorComboBox1 + "\r\n\r\nSALSA:\r\n" + valorComboBox2;

            // Asignar el resultado al TextBox
            tb_precio.Text = resultado;
            Comprobar();
        }

        private void cbl_especias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Concatenar los elementos seleccionados en el CheckedListBox 1
            string elementosSeleccionados1 = "";
            foreach (object itemChecked in cbl_ingredientes.CheckedItems)
            {
                elementosSeleccionados1 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados1 = elementosSeleccionados1.TrimEnd('\r', '\n');

            // Concatenar los elementos seleccionados en el CheckedListBox 2
            string elementosSeleccionados2 = "";
            foreach (object itemChecked in cbl_especias.CheckedItems)
            {
                elementosSeleccionados2 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados2 = elementosSeleccionados2.TrimEnd('\r', '\n');

            // Obtener los valores seleccionados de los ComboBox
            string valorComboBox1 = cb_masas.SelectedItem != null ? cb_masas.SelectedItem.ToString() : "";
            string valorComboBox2 = cb_salsas.SelectedItem != null ? cb_salsas.SelectedItem.ToString() : "";

            // Concatenar los resultados en un solo string
            string resultado = "INGREDIENTES:\r\n" + elementosSeleccionados1 + "\r\n\r\nESPECIAS:\r\n" + elementosSeleccionados2 + "\r\n\r\nMASA:\r\n" + valorComboBox1 + "\r\n\r\nSALSA:\r\n" + valorComboBox2;

            // Asignar el resultado al TextBox
            tb_precio.Text = resultado;
            Comprobar();
        }

        private void cbl_ingredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
                        // Concatenar los elementos seleccionados en el CheckedListBox 1
            string elementosSeleccionados1 = "";
            foreach (object itemChecked in cbl_ingredientes.CheckedItems)
            {
                elementosSeleccionados1 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados1 = elementosSeleccionados1.TrimEnd('\r', '\n');

            // Concatenar los elementos seleccionados en el CheckedListBox 2
            string elementosSeleccionados2 = "";
            foreach (object itemChecked in cbl_especias.CheckedItems)
            {
                elementosSeleccionados2 += itemChecked.ToString() + "\r\n";
            }
            elementosSeleccionados2 = elementosSeleccionados2.TrimEnd('\r', '\n');

            // Obtener los valores seleccionados de los ComboBox
            string valorComboBox1 = cb_masas.SelectedItem != null ? cb_masas.SelectedItem.ToString() : "";
            string valorComboBox2 = cb_salsas.SelectedItem != null ? cb_salsas.SelectedItem.ToString() : "";

            // Concatenar los resultados en un solo string
            string resultado = "INGREDIENTES:\r\n" + elementosSeleccionados1 + "\r\n\r\nESPECIAS:\r\n" + elementosSeleccionados2 + "\r\n\r\nMASA:\r\n" + valorComboBox1 + "\r\n\r\nSALSA:\r\n" + valorComboBox2;

            // Asignar el resultado al TextBox
            tb_precio.Text = resultado;
            Comprobar();

        }
    }
}
