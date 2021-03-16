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
    public partial class Modificar_Socios : Form
    {
        public Modificar_Socios()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text.Equals("") || textBoxCP.Text.Equals("") || textBoxDireccion.Text.Equals("") || textBoxID.Text.Equals("") ||
textBoxNombre.Text.Equals("") || textBoxEmail.Text.Equals("") || textBoxTelefono.Text.Equals("") || textBoxCiudad.Text.Equals("") ||
textBoxDNI.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por introducir");
            }
            else
            {
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
