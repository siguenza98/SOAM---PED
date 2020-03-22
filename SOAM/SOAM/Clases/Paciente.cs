using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAM.Clases
{
    public class Paciente
    {
        private int id_paciente;
        private string nombre;
        private string apellidos;
        private string dui;
        private DateTime fecha_nac;
        private double peso;
        private double altura;

        public int Id_paciente { get { return id_paciente; } set { id_paciente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Dui { get { return dui; } set { dui = value; } }
        public DateTime Fecha_nac { get { return fecha_nac; } set { fecha_nac = value; } }
        public double Peso { get { return peso; } set { peso = value; } }
        public double Altura { get { return altura; } set { altura = value; } }

        public static int agregarPaciente(Paciente paciente)
        {
            Conexion con = new Conexion();
            int filas = 0;

            MySqlCommand comando = new MySqlCommand("INSERT INTO pacientes VALUES(@id, @nombre, @apellidos, @dui, @fecha_nac, @peso, @altura)", con.Conn);

            comando.Parameters.Add(new MySqlParameter("@id", ""));
            comando.Parameters.Add(new MySqlParameter("@nombre", paciente.Nombre));
            comando.Parameters.Add(new MySqlParameter("@apellidos", paciente.Apellidos));
            comando.Parameters.Add(new MySqlParameter("@dui", paciente.Dui));
            comando.Parameters.Add(new MySqlParameter("@fecha_nac", paciente.Fecha_nac));
            comando.Parameters.Add(new MySqlParameter("@peso", paciente.Peso));
            comando.Parameters.Add(new MySqlParameter("@altura", paciente.Altura));


            con.abrirConexion();

            try
            {
                filas = comando.ExecuteNonQuery();
                return filas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema." + ex.ToString());

                return 0;
            }
            finally
            {
                con.cerrarConexion();
            }
            
        }

        public static int modificarPaciente(Paciente paciente)
        {
            Conexion con = new Conexion();
            int filas = 0;

            MySqlCommand comando = new MySqlCommand("INSERT INTO pacientes VALUES(@nombre, @apellidos, @dui, @fecha_nac, @peso, @altura)", con.Conn);

            comando.Parameters.Add(new MySqlParameter("@nombre", paciente.Nombre));
            comando.Parameters.Add(new MySqlParameter("@apellidos", paciente.Apellidos));
            comando.Parameters.Add(new MySqlParameter("@dui", paciente.Dui));
            comando.Parameters.Add(new MySqlParameter("@fecha_nac", paciente.Fecha_nac));
            comando.Parameters.Add(new MySqlParameter("@peso", paciente.Peso));
            comando.Parameters.Add(new MySqlParameter("@altura", paciente.Altura));


            con.abrirConexion();


            try
            {
                filas = comando.ExecuteNonQuery();
                return filas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return 0;
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public static bool verificarPacienteExiste(string dui)
        {
            Conexion con = new Conexion();
            con.abrirConexion();

            MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) FROM pacientes WHERE dui = @dui", con.Conn);
            comando.Parameters.Add(new MySqlParameter("@dui", dui));

            try
            {
                var filas = Convert.ToInt32(comando.ExecuteScalar());
                if (filas > 0)
                {
                    //existe
                    return true;
                }
                else
                {
                    //no existe
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.cerrarConexion();
            }

        }

        

        public static Paciente obtenerPaciente(string dui)
        {
            Conexion con = new Conexion();
            Paciente paciente = new Paciente();
            int filas = 0;

            MySqlCommand comando = new MySqlCommand("SELECT * FROM pacientes WHERE dui = @dui", con.Conn);

            comando.Parameters.Add(new MySqlParameter("@dui", dui));
           
            con.abrirConexion();

            try
            {
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    paciente.Id_paciente = (int)reader["id_paciente"];
                    paciente.Nombre = reader["nombre"].ToString();
                    paciente.Apellidos = reader["apellidos"].ToString();
                    paciente.Dui = reader["dui"].ToString();
                    paciente.Fecha_nac = Convert.ToDateTime(reader["fecha_nac"].ToString());
                    paciente.Peso = (double)reader["peso"];
                    paciente.Altura = (double)reader["altura"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema." + ex.ToString());
            }

            finally
            {
                con.cerrarConexion();
               
            }
            return paciente;

        }

    
    }
}
