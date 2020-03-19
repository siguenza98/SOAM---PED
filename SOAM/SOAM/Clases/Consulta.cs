using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAM.Clases
{
    class Consulta
    {
        private int id_consulta;
        private DateTime fecha_realizacion;
        private int prioridad;
        private string descripcion;
        private Paciente id_paciente;
        private Recepcionista id_usuario;

        public int Id_consulta { get { return id_consulta; } set {  id_consulta = value; } }
        public DateTime Fecha_realizacion { get  { return fecha_realizacion; } set { fecha_realizacion = value; } }
        public int Prioridad { get { return prioridad; } set { prioridad = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Paciente Id_paciente { get { return id_paciente; } set { id_paciente = value; } }
        public Recepcionista Id_usuario { get { return id_usuario; } set { id_usuario = value; } }

        public bool agregarConsulta(Consulta consulta)
        {
            bool agregado = false;

            return agregado;
        }
    }
}
