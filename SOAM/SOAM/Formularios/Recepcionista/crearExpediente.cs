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
using SOAM.Formularios.Recepcionista;
using SOAM.Clases;

namespace SOAM.Formularios.Recepcionista
{
    public partial class crearExpediente : Form
    {
        public crearExpediente()
        {
            InitializeComponent();
        }

        private void crearExpediente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IndexRecepcionista frm = new IndexRecepcionista();
            frm.Show();
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validar())
            {
                Paciente paciente = new Paciente();
                paciente.Nombre = txtNombres.Text; 
                paciente.Apellidos = txtApellidos.Text;
                paciente.Dui = txtDUI.Text;
                paciente.Fecha_nac = dtpFechaNac.Value;
                paciente.Peso = double.Parse(txtPeso.Text);
                paciente.Altura = double.Parse(txtAltura.Text);

                //se agrego el paciente
                if (Paciente.agregarPaciente(paciente) == 1)
                {
                    MessageBox.Show("Se ha registrado el nuevo expediente con exito.");
                }
                // no se pudo agregar
                else
                {
                    MessageBox.Show("No se ha registrado el nuevo expediente.");

                }

            }
        }

        private bool validar()
        {
            bool validado = true;

            if (String.IsNullOrEmpty(txtNombres.Text))
            {
                validado = false;
                errorProvider1.SetError(txtNombres, "El nombre no puede ser vacio.");
            }


            if (String.IsNullOrEmpty(txtApellidos.Text))
            {
                validado = false;
                errorProvider1.SetError(txtApellidos, "Los apellidos no pueden ser vacios.");

            }

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
                else if(Paciente.verificarPacienteExiste(txtDUI.Text))
                {
                    validado = false;
                    errorProvider1.SetError(txtDUI, "Ese DUI ya existe.");
                }
            }


            if (String.IsNullOrEmpty(txtPeso.Text))
            {
                validado = false;
                errorProvider1.SetError(txtPeso, "El peso no puede ser vacio.");

            }
            else if (!double.TryParse(txtPeso.Text, out double num) && num <= 0)
            {
                validado = false;
                errorProvider1.SetError(txtPeso, "El peso debe ser un número mayor a cero.");

            }


            if (String.IsNullOrEmpty(txtAltura.Text))
            {
                validado = false;
                errorProvider1.SetError(txtAltura, "La altura no puede ser vacia.");

            }
            else if (!double.TryParse(txtAltura.Text, out double num) && num <= 0)
            {
                validado = false;
                errorProvider1.SetError(txtAltura, "La altura debe ser un número mayor a cero.");

            }

            return validado;
        }
    }
}
