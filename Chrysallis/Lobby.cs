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
        public Lobby()
        {
            InitializeComponent();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            Control_de_Eventos nuevoGestionaEventos = new Control_de_Eventos();
            nuevoGestionaEventos.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Control_de_Usuarios nuevoGestionaUsuarios = new Control_de_Usuarios();
            nuevoGestionaUsuarios.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
