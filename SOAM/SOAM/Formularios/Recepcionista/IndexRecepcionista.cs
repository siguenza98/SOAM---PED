using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAM.Clases;

namespace SOAM.Formularios.Recepcionista
{
    public partial class IndexRecepcionista : Form
    {
        Queue<Paciente> cola = new Queue<Paciente>();
        

        public IndexRecepcionista()
        {
            InitializeComponent();
        }

        private void IndexRecepcionista_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Paciente p = new Paciente();
            p.Nombre = "Nombre";
            cola.Enqueue(p);
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            dgvCola.DataSource = null;
            dgvCola.DataSource = cola.ToList();
            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            crearConsulta frm = new crearConsulta();
            this.Hide();
            frm.Show();
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            crearExpediente frm = new crearExpediente();
            this.Hide();
            frm.Show();
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            cola.Dequeue();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {

        }
    }
}
