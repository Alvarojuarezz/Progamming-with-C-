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
    public partial class Form1 : Form
    {
        Class1 obj = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            Form2 Formulario = new Form2();
            Formulario.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (tb_contrasena.Text == "" || tb_usuario.Text == "")
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
            else
            {
                // Establecer la conexión con la base de datos

                SqlConnection conexion = new SqlConnection("server=(local)\\SQLEXPRESS;database=master; Integrated Security = SSPI");

                // Crear el comando SqlCommand con la consulta SELECT
                SqlCommand comandosql = new SqlCommand();

                try
                {
                    conexion.Open();
                    comandosql.Connection = conexion;
                    comandosql.CommandText = "SELECT Nombre, Apellidos, Usuario, Contrasena, Es_admin FROM usuarios WHERE usuario = @valor1 AND contrasena = @valor2";
                    comandosql.Parameters.AddWithValue("@valor1", tb_usuario.Text);
                    comandosql.Parameters.AddWithValue("@valor2", tb_contrasena.Text);
                    SqlDataReader midatareader = comandosql.ExecuteReader();
                    int esAdmin = 0;

                    // Lee la consulta obtenida
                    if (midatareader.Read())
                    {
                        esAdmin = Convert.ToInt32(midatareader["Es_admin"]);
                        obj.setNombre("Bienvenid@ " + midatareader["Nombre"].ToString());
                        obj.setUsuario(midatareader["Usuario"].ToString());
                    }

                    if (esAdmin == 1)
                    {
                        ActiveForm.Hide();
                        Form6 Form = new Form6();
                        Form.lbl_1.Hide();
                        Form.lbl_2.Hide();
                        Form.lbl_3.Hide();
                        Form.lbl_4.Hide();
                        Form.lbl_5.Hide();
                        Form.lbl_nombre.Hide();

                        Form.tb_1.Hide();
                        Form.tb_2.Hide();
                        Form.tb_3.Hide();
                        Form.tb_4.Hide();
                        Form.tb_5.Hide();
                        Form.cb_nombre.Hide();
                        Form.Show();
                    }
                    else
                    {
                        ActiveForm.Hide();
                        Form3 Form = new Form3();
                        Form.lbl_bienvenido.Text = obj.getNombre();
                        Form.Show();
                    }

                    midatareader.Close();
                    conexion.Close();

                    tb_usuario.Clear();
                    tb_contrasena.Clear();
                }
                catch
                {
                    MessageBox.Show("Usuario o contraseña no validos");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
