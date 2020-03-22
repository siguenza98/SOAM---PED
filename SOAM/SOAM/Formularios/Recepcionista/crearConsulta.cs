using SOAM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAM.Formularios.Recepcionista
{
    public partial class crearConsulta : Form
    {
        public Queue<Consulta> cola = new Queue<Consulta>();

        public crearConsulta()
        {
            InitializeComponent();
            this.CenterToScreen();

            cmbPrioridad.Items.Add('1'); // prioridad mas alta
            cmbPrioridad.Items.Add('2');
            cmbPrioridad.Items.Add('3');// prioridad mas baja

            //departamentos de prueba

            cmbDep.Items.Add("Oncologia");
            cmbDep.Items.Add("Medicina General");
            cmbDep.Items.Add("Odontologia");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IndexRecepcionista frm = new IndexRecepcionista();
            frm.cola = cola;
            frm.Show();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Consulta consulta = new Consulta();

                consulta.Prioridad = Int32.Parse(cmbPrioridad.Text);
                consulta.Departamento = cmbDep.Text;
                consulta.Id_paciente = Paciente.obtenerPaciente(txtDUI.Text);

         
                cola.Enqueue(consulta);
       

                MessageBox.Show("Se ha agregado la consulta a la cola.");
            }

        }

        private bool validar()
        {
            bool validado = true;

           
            if (String.IsNullOrEmpty(txtDUI.Text))
            {
                validado = false;
                errorProvider1.SetError(txtDUI, "El Dui no puede ser vacio.");

            }
            else
            {
                string regex = @"^\d{8}-\d$";
                Match resultado = Regex.Match(txtDUI.Text, regex);

                if (!resultado.Success)
                {
                    validado = false;
                    errorProvider1.SetError(txtDUI, "El Dui debe ser ingresado con el formato 12345678-9.");

                }
                else if (!Paciente.verificarPacienteExiste(txtDUI.Text))
                {
                    validado = false;
                    errorProvider1.SetError(txtDUI, "Ese DUI no concuerda con ningún expediente registrado.");
                }
            }



            return validado;
        }

        private void crearConsulta_Load(object sender, EventArgs e)
        {
          

        }
    }
}
