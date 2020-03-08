using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOAM.Clases
{
    class Conexion
    {

        private MySqlConnection conn;
        private string server;
        private string db;
        private string uid;
        private string pass;

        public MySqlConnection Conn { get { return conn; } set { conn = value; } }

        public Conexion()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            db = "soam";
            uid = "root";
            pass = "";
            string cadenaConexion;
            cadenaConexion = "SERVER=" + server + ";" + "DATABASE=" + db + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            conn = new MySqlConnection(cadenaConexion);
        }

        public bool abrirConexion()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se puede conectar con la base de datos.");
                        break;

                    case 1045:
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                        break;
                }
                return false;
            }
        }

        public bool cerrarConexion()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un problema al cerrar la conexión con la base de datos.");
                return false;
            }
        }
    }
}
