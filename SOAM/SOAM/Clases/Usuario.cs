using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SOAM.Clases
{
    class Usuario
    {

        private int id_usuario;
        private String nombre;
        private String apellidos;
        private String username;
        private String correo;
        private int tipo;
        //public Departamento id_departamento;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Username { get => username; set => username = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        
        public static Usuario login(String username, String pass)
        {
            Usuario user = new Usuario();
            Conexion con = new Conexion();

            //encriptando lo ingresado por el usuario
            String passSHA = sha256(pass);

            
            MySqlCommand comando = new MySqlCommand("SELECT * FROM usuarios WHERE username = @username AND pass = @pass", con.Conn);
            comando.Parameters.Add(new MySqlParameter("@username", username));
            comando.Parameters.Add(new MySqlParameter("@pass", passSHA));

            try
            {
                con.abrirConexion();

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id_usuario = (int)reader["id_usuario"];
                        user.Nombre = reader["nombre"].ToString();
                        user.Apellidos = reader["apellidos"].ToString();
                        user.Tipo = (int)reader["tipo"];
                    }

                    return user;
                }

                return null;
            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un problema al verificar sus credenciales.");
                return null;
            }
            finally
            {
                con.cerrarConexion();
            }
        }


        //Método que permite encriptar un string a SHA256
        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


    }
}
