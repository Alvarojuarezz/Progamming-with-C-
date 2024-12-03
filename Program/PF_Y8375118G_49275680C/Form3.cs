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

namespace PF_Y8375118G_49275680C
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_cer_ses_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["Form1"].Show();
        }

        private void btn_personalizar_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form4 form = new Form4();
            form.Show();

            // Establecer la conexión con la base de datos
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion = new SqlConnection(connectionString);

            string query = "SELECT Nombre, Precio FROM Masas WHERE Cantidad > 0";
            SqlCommand command = new SqlCommand(query, conexion);

            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                form.cb_masas.Items.Add(reader["Nombre"].ToString() + "........." + reader["Precio"].ToString().Trim() + "€");
            }

            reader.Close();
            conexion.Close();


            // Establecer la conexión con la base de datos
            string connectionString2 = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion2 = new SqlConnection(connectionString2);

            string query2 = "SELECT Nombre, Precio FROM Ingredientes WHERE Cantidad > 0";
            SqlCommand command2 = new SqlCommand(query2, conexion2);

            conexion2.Open();
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                form.cbl_ingredientes.Items.Add(reader2["Nombre"].ToString() + "........." + reader2["Precio"].ToString().Trim() + "€");
            }

            reader2.Close();
            conexion2.Close();


            // Establecer la conexión con la base de datos
            string connectionString3 = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion3 = new SqlConnection(connectionString3);

            string query3 = "SELECT Nombre, Precio FROM Especias WHERE Cantidad > 0";
            SqlCommand command3 = new SqlCommand(query3, conexion3);

            conexion3.Open();
            SqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                form.cbl_especias.Items.Add(reader3["Nombre"].ToString() + "........." + reader3["Precio"].ToString().Trim() + "€");
            }

            reader3.Close();
            conexion3.Close();


            // Establecer la conexión con la base de datos
            string connectionString4 = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion4 = new SqlConnection(connectionString4);

            string query4 = "SELECT Nombre, Precio FROM Salsas WHERE Cantidad > 0";
            SqlCommand command4 = new SqlCommand(query4, conexion4);

            conexion4.Open();
            SqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                form.cb_salsas.Items.Add(reader4["Nombre"].ToString() + "........." + reader4["Precio"].ToString().Trim() + "€");
            }

            reader4.Close();
            conexion4.Close();
        }

        private void btn_pizzas_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form5 form = new Form5();
            form.Show();
            // Establecer la conexión con la base de datos
            string connectionString = "server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI";
            SqlConnection conexion = new SqlConnection(connectionString);

            string query = "SELECT Nombre, Precio FROM Pizzas WHERE Cantidad > 0";
            SqlCommand command = new SqlCommand(query, conexion);

            conexion.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                form.cb_pizzas.Items.Add(reader["Nombre"].ToString() + "........." + reader["Precio"].ToString().Trim() + "€");
            }

            reader.Close();
            conexion.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
