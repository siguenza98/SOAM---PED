using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAM.Formularios.Admin
{
    public partial class indexAdmin : Form
    {
        public indexAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Departamentos nuevo = new Departamentos();
            nuevo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctores nuevo = new Doctores();
            nuevo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepcionista nuevo = new Recepcionista();
            nuevo.Show();
            this.Hide();
        }
    }
}
