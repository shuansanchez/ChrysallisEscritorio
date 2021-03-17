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
    public partial class Añadir_Socio : Form
    {
        public Añadir_Socio()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            if(textBoxApellidos.Text.Equals("")|| textBoxCP.Text.Equals("") || textBoxDireccion.Text.Equals("") || textBoxID.Text.Equals("") ||
            textBoxNombre.Text.Equals("") || textBoxEmail.Text.Equals("") || textBoxTelefono.Text.Equals("") || textBoxLocalidad.Text.Equals("") ||
            textBoxDNI.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por introducir");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
