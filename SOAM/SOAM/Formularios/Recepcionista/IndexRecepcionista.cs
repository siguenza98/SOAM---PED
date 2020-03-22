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
        //la cola de espera de la recepcionista
        public Queue<Consulta> cola = new Queue<Consulta>();
        

        public IndexRecepcionista()
        {
            InitializeComponent();
        }

        private void IndexRecepcionista_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
           
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
            frm.cola = cola;
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
           Consulta consultaDespachada =  cola.Dequeue();
            actualizarTabla();
        }

       

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            cola.Clear();
            actualizarTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}
