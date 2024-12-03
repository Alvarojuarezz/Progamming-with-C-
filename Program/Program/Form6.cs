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

namespace PF_Y8375118G_49275680C
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void cb_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_anadir.Enabled = true;
            lbl_1.Hide();
            lbl_2.Hide();
            lbl_3.Hide();
            lbl_4.Hide();
            lbl_5.Hide();
            lbl_nombre.Hide();

            tb_1.Hide();
            tb_2.Hide();
            tb_3.Hide();
            tb_4.Hide();
            tb_5.Hide();
            cb_nombre.Items.Clear();
            cb_nombre.Hide();

            if (cb_opciones.SelectedItem == null)
            {

            }
            else if (cb_opciones.SelectedItem.ToString() == "Ingredientes" || cb_opciones.SelectedItem.ToString() == "Especias" || cb_opciones.SelectedItem.ToString() == "Masas" || cb_opciones.SelectedItem.ToString() == "Salsas")
            {
                lbl_1.Text = "Nombre";
                lbl_2.Text = "Precio";
                lbl_3.Text = "Cantidad";

                btn_anadir.Text = "Añadir";

                int labelX = tb_1.Left + (tb_1.Width - lbl_1.Width) / 2;
                int labelY = tb_1.Top - lbl_1.Height;
                lbl_1.Location = new Point(labelX, labelY);

                int labelX2 = tb_2.Left + (tb_2.Width - lbl_2.Width) / 2;
                int labelY2 = tb_2.Top - lbl_2.Height;
                lbl_2.Location = new Point(labelX2, labelY2);

                int labelX3 = tb_3.Left + (tb_3.Width - lbl_3.Width) / 2;
                int labelY3 = tb_3.Top - lbl_3.Height;
                lbl_3.Location = new Point(labelX3, labelY3);

                lbl_1.Show();
                lbl_2.Show();
                lbl_3.Show();

                tb_1.Clear();
                tb_2.Clear();
                tb_3.Clear();
                tb_4.Clear();
                tb_5.Clear();

                tb_1.Show();
                tb_2.Show();
                tb_3.Show();
            }
            else if (cb_opciones.SelectedItem.ToString() == "Pizzas")
            {
                lbl_1.Text = "Nombre";
                lbl_2.Text = "Precio";
                lbl_3.Text = "Cantidad";
                lbl_4.Text = "Imagen";

                btn_anadir.Text = "Añadir";

                int labelX = tb_1.Left + (tb_1.Width - lbl_1.Width) / 2;
                int labelY = tb_1.Top - lbl_1.Height;
                lbl_1.Location = new Point(labelX, labelY);

                int labelX2 = tb_2.Left + (tb_2.Width - lbl_2.Width) / 2;
                int labelY2 = tb_2.Top - lbl_2.Height;
                lbl_2.Location = new Point(labelX2, labelY2);

                int labelX3 = tb_3.Left + (tb_3.Width - lbl_3.Width) / 2;
                int labelY3 = tb_3.Top - lbl_3.Height;
                lbl_3.Location = new Point(labelX3, labelY3);

                int labelX4 = tb_4.Left + (tb_4.Width - lbl_4.Width) / 2;
                int labelY4 = tb_4.Top - lbl_4.Height;
                lbl_4.Location = new Point(labelX4, labelY4);

                lbl_1.Show();
                lbl_2.Show();
                lbl_3.Show();
                lbl_4.Show();

                tb_1.Clear();
                tb_2.Clear();
                tb_3.Clear();
                tb_4.Clear();
                tb_5.Clear();

                tb_1.Show();
                tb_2.Show();
                tb_3.Show();
                tb_4.Show();
            }
            else if (cb_opciones.SelectedItem.ToString() == "Usuarios (Registrar)")
            {
                lbl_1.Text = "Nombre";
                lbl_2.Text = "Apellidos";
                lbl_3.Text = "Usuario";
                lbl_4.Text = "Contraseña";
                lbl_5.Text = "Es_admin";

                int labelX = tb_1.Left + (tb_1.Width - lbl_1.Width) / 2;
                int labelY = tb_1.Top - lbl_1.Height;
                lbl_1.Location = new Point(labelX, labelY);

                int labelX2 = tb_2.Left + (tb_2.Width - lbl_2.Width) / 2;
                int labelY2 = tb_2.Top - lbl_2.Height;
                lbl_2.Location = new Point(labelX2, labelY2);

                int labelX3 = tb_3.Left + (tb_3.Width - lbl_3.Width) / 2;
                int labelY3 = tb_3.Top - lbl_3.Height;
                lbl_3.Location = new Point(labelX3, labelY3);

                int labelX4 = tb_4.Left + (tb_4.Width - lbl_4.Width) / 2;
                int labelY4 = tb_4.Top - lbl_4.Height;
                lbl_4.Location = new Point(labelX4, labelY4);

                int labelX5 = tb_5.Left + (tb_5.Width - lbl_5.Width) / 2;
                int labelY5 = tb_5.Top - lbl_5.Height;
                lbl_5.Location = new Point(labelX5, labelY5);

                btn_anadir.Text = "Añadir";

                lbl_1.Show();
                lbl_2.Show();
                lbl_3.Show();
                lbl_4.Show();
                lbl_5.Show();

                tb_1.Clear();
                tb_2.Clear();
                tb_3.Clear();
                tb_4.Clear();
                tb_5.Clear();

                tb_1.Show();
                tb_2.Show();
                tb_3.Show();
                tb_4.Show();
                tb_5.Show();
            }
            else if (cb_opciones.SelectedItem.ToString() == "Usuarios (Modificar)")
            {
                lbl_1.Text = "Nombre";
                lbl_2.Text = "Apellidos";
                lbl_3.Text = "Usuario";
                lbl_4.Text = "Contraseña";
                lbl_5.Text = "Es_admin";

                int labelX = tb_1.Left + (tb_1.Width - lbl_1.Width) / 2;
                int labelY = tb_1.Top - lbl_1.Height;
                lbl_1.Location = new Point(labelX, labelY);

                int labelX2 = tb_2.Left + (tb_2.Width - lbl_2.Width) / 2;
                int labelY2 = tb_2.Top - lbl_2.Height;
                lbl_2.Location = new Point(labelX2, labelY2);

                int labelX3 = tb_3.Left + (tb_3.Width - lbl_3.Width) / 2;
                int labelY3 = tb_3.Top - lbl_3.Height;
                lbl_3.Location = new Point(labelX3, labelY3);

                int labelX4 = tb_4.Left + (tb_4.Width - lbl_4.Width) / 2;
                int labelY4 = tb_4.Top - lbl_4.Height;
                lbl_4.Location = new Point(labelX4, labelY4);

                int labelX5 = tb_5.Left + (tb_5.Width - lbl_5.Width) / 2;
                int labelY5 = tb_5.Top - lbl_5.Height;
                lbl_5.Location = new Point(labelX5, labelY5);

                btn_anadir.Text = "Modificar";

                lbl_1.Show();
                lbl_2.Show();
                lbl_3.Show();
                lbl_4.Show();
                lbl_5.Show();
                lbl_nombre.Show();

                tb_1.Show();
                tb_2.Show();
                tb_3.Show();
                tb_4.Show();
                tb_5.Show();

                // Establecer la conexión con la base de datos
                string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
                SqlConnection conexion = new SqlConnection(connectionString);

                string query = "SELECT Usuario FROM Usuarios";
                SqlCommand command = new SqlCommand(query, conexion);

                conexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cb_nombre.Items.Add(reader["Usuario"].ToString());
                }

                reader.Close();
                conexion.Close();


                cb_nombre_SelectedIndexChanged(null, null);

                cb_nombre.Show();

            }
            else
            {

            }
        }

        private void btn_anadir_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI"))
            {
                conexion.Open();
                using (SqlCommand comandosql = new SqlCommand())
                {
                    if (cb_opciones.SelectedItem.ToString() == "Especias")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Especias] ([Nombre], [Precio], [Cantidad]) VALUES (@valor1, CAST(@valor2 AS Money), @valor3)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Ingredientes")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Ingredientes] ([Nombre], [Precio], [Cantidad]) VALUES (@valor1, CAST(@valor2 AS Money), @valor3)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Masas")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Masas] ([Nombre], [Precio], [Cantidad]) VALUES (@valor1, CAST(@valor2 AS Money), @valor3)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Salsas")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Salsas] ([Nombre], [Precio], [Cantidad]) VALUES (@valor1, CAST(@valor2 AS Money), @valor3)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Pizzas")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Pizzas] ([Nombre], [Precio], [Cantidad], [Imagen]) VALUES (@valor1, CAST(@valor2 AS Money), @valor3, @valor4)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());

                        // Leer la imagen desde el archivo y convertirla a un array de bytes
                        byte[] imagenBytes = File.ReadAllBytes(tb_4.Text);
                        comandosql.Parameters.AddWithValue("@valor4", imagenBytes);

                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Usuarios (Registrar)")
                    {
                        comandosql.Connection = conexion;
                        comandosql.CommandText = "INSERT INTO [dbo].[Usuarios] ([Usuario], [Nombre], [Apellidos], [Contrasena], [Es_admin]) VALUES (@valor1, @valor2, @valor3, @valor4, @valor5)";
                        comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor4", tb_4.Text.TrimEnd());
                        comandosql.Parameters.AddWithValue("@valor5", tb_5.Text.TrimEnd());
                        comandosql.ExecuteNonQuery();
                    }
                    else if (cb_opciones.SelectedItem.ToString() == "Usuarios (Modificar)")
                    {
                        if (tb_5.Text.Trim() == "1" || tb_5.Text.Trim() == "0")
                        {
                            comandosql.Connection = conexion;
                            comandosql.CommandText = "UPDATE Usuarios SET Nombre = @valor1, Apellidos = @valor2, Usuario = @valor3, Contrasena = @valor4, Es_admin = @valor5 WHERE Usuario = @valor6";
                            comandosql.Parameters.AddWithValue("@valor1", tb_1.Text.TrimEnd());
                            comandosql.Parameters.AddWithValue("@valor2", tb_2.Text.TrimEnd());
                            comandosql.Parameters.AddWithValue("@valor3", tb_3.Text.TrimEnd());
                            comandosql.Parameters.AddWithValue("@valor4", tb_4.Text.TrimEnd());
                            comandosql.Parameters.AddWithValue("@valor5", tb_5.Text.TrimEnd());
                            comandosql.Parameters.AddWithValue("@valor6", cb_nombre.SelectedItem.ToString().TrimEnd());
                            comandosql.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("El campo Es_admin debe ser 1 o 0");
                        }
                    }
                }
            }
            lbl_1.Hide();
            lbl_2.Hide();
            lbl_3.Hide();
            lbl_4.Hide();
            lbl_5.Hide();
            lbl_nombre.Hide();

            tb_1.Hide();
            tb_2.Hide();
            tb_3.Hide();
            tb_4.Hide();
            tb_5.Hide();
            cb_nombre.Items.Clear();
            cb_nombre.Hide();

            cb_opciones.SelectedIndex = -1;

            btn_anadir.Enabled = false;
            btn_anadir.Text = "Añadir";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Form1"].Show();
        }

        private void cb_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_nombre.SelectedItem != null)
            {
                // Establecer la conexión con la base de datos
                string connectionString2 = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
                SqlConnection conexion2 = new SqlConnection(connectionString2);

                string query2 = "SELECT Usuario, Nombre, Apellidos, Contrasena, Es_admin FROM Usuarios WHERE Usuario = @valor1";
                SqlCommand command2 = new SqlCommand(query2, conexion2);
                command2.Parameters.AddWithValue("@valor1", cb_nombre.SelectedItem.ToString());

                conexion2.Open();
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    tb_1.Text = (reader2["Nombre"].ToString());
                    tb_2.Text = (reader2["Apellidos"].ToString());
                    tb_3.Text = (reader2["Usuario"].ToString());
                    tb_4.Text = (reader2["Contrasena"].ToString());
                    tb_5.Text = (reader2["Es_admin"].ToString());
                }

                reader2.Close();
                conexion2.Close();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
