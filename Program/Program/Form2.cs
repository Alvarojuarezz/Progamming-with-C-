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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_registrarse2_Click(object sender, EventArgs e)
        {
            if (txt_apellidos.Text == "" || txt_contrasena2.Text == "" || txt_nombre.Text == "" || txt_usuario2.Text == "")
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                // Establecer la conexión con la base de datos
                SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");

                // Crear el comando SqlCommand con la consulta INSERT
                SqlCommand comandosql = new SqlCommand();

                conexion.Open(); 
                comandosql.Connection = conexion;
                comandosql.CommandText = "INSERT INTO usuarios VALUES(@valor1, @valor2, @valor3, @valor4, 0)";
                comandosql.Parameters.AddWithValue("@valor1", txt_nombre.Text);
                comandosql.Parameters.AddWithValue("@valor2", txt_apellidos.Text);
                comandosql.Parameters.AddWithValue("@valor3", txt_usuario2.Text);
                comandosql.Parameters.AddWithValue("@valor4", txt_contrasena2.Text);
                SqlDataReader midatareader = comandosql.ExecuteReader();
                midatareader.Close();
                conexion.Close();
                MessageBox.Show("Usuario registrado");
                Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
