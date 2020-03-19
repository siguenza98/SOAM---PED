using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAM.Clases
{
    class Paciente
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

        public bool agregarPaciente(Paciente paciente)
        {
            bool agregado = false;

            return agregado;
        }

        public bool modificarPaciente(Paciente paciente)
        {
            bool agregado = false;

            return agregado;
        }
    }
}
