using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Y8375118G_49275680C
{
    internal class Class1
    {
        public static int factura = 0;
        public string nombre;
        public static string usuario;
        public Class1()
        {

        }
        public void log(String texto)
        {
            StreamWriter fichero = new StreamWriter(@"..\Log.txt", true);
            fichero.WriteLine(texto);
            fichero.Close();
            fichero.Dispose();
        }

        public int getFactura()
        {
            return factura;
        }

        public void setFactura()
        {
            factura++;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nom)
        {
            nombre = nom;
        }

        public string getUsuario()
        {
            return usuario;
        }

        public void setUsuario(string user)
        {
            usuario = user;
        }
    }
}
