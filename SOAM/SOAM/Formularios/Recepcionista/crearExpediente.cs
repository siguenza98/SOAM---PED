using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAM.Formularios.Recepcionista;

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
    }
}
