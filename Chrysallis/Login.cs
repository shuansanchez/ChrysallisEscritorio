﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TextboxContra.PasswordChar = '*';
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || TextboxContra.Text == "")
            {
                MessageBox.Show("Error, faltan datos");
            }
            else
            {
                usuaris usuarioLogueado = new usuaris();
                usuarioLogueado = ConsultaOrm.selectLogin(textBoxUser.Text, TextboxContra.Text);
                if (usuarioLogueado == null)
                {
                    MessageBox.Show("Admin no encontrado");
                }
                else
                {
                    if (usuarioLogueado.actiu == true)
                    {
                        Lobby nuevoLobby = new Lobby(usuarioLogueado);
                        nuevoLobby.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no se encuentra activo en este momento");
                    }
                }

            }
        }
    }
}
