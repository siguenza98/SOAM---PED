﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAM.Clases;
using SOAM.Formularios;

namespace SOAM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text.Trim();
            String pass = txtPass.Text.Trim();
            Usuario user = Usuario.login(username, pass);

            //credenciales correctas
            if (user != null)
            {
                //admin
                if (user.Tipo == 1) {
                    MessageBox.Show("Usted es un admin.");
                    //FormAdmin.Show();
                    //this.Hide();
                }

                //doctor
                else if (user.Tipo == 2)
                {
                    MessageBox.Show("Usted es un doctor.");
                    //FormDoctor.Show();
                    //this.Hide();
                }

                //recepcionista
                else
                {
                    MessageBox.Show("Usted es una recepcionista.");
                    //FormRecep.Show();
                    //this.Hide();
                }


            }
            //credenciales incorrectas
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.");

            }
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("neris culero");
            //FormDoctor.Show();
            //this.Hide();
        }
    }
}
