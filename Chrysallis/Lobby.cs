using System;
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
    public partial class Lobby : Form
    {
        usuaris u = new usuaris();
        public Lobby(usuaris u )
        {
            InitializeComponent();
            this.u = u;
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            Control_de_Eventos nuevoGestionaEventos = new Control_de_Eventos(u);
            nuevoGestionaEventos.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Control_de_Usuarios nuevoGestionaUsuarios = new Control_de_Usuarios(u);
            nuevoGestionaUsuarios.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

        }
    }
}
