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
            /*if (textBoxApellidos.Text.Equals("") || textBoxCP.Text.Equals("") || textBoxDireccion.Text.Equals("") || textBoxID.Text.Equals("") ||
textBoxNombre.Text.Equals("") || textBoxEmail.Text.Equals("") || textBoxTelefono.Text.Equals("") || textBoxCiudad.Text.Equals("") ||
textBoxDNI.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por introducir");
            }
            else
            {
                this.Close();
            }*/

            //POR AHORA NO SE COMPRUEBA NADA
            socis nuevoSocio = new socis();
           
            

            //NOT NULL OBLIGADOS
            nuevoSocio.id = 4000;
            nuevoSocio.num = Int32.Parse(textBoxID.Text);
            nuevoSocio.nom = textBoxNombre.Text;
            nuevoSocio.actiu = checkBoxActivo.Checked;
            nuevoSocio.telefon1 = textBoxTelefono.Text;
            nuevoSocio.email = textBoxEmail.Text;
            nuevoSocio.dni = textBoxDNI.Text;
            nuevoSocio.data_alta = DateTime.Today;
            nuevoSocio.permis_app = false;
            nuevoSocio.id_localitat = 1; //malgrat de mar

            //PUEDEN SER NULL
            nuevoSocio.cognoms = textBoxApellidos.Text;
            nuevoSocio.codi_postal = textBoxCP.Text;
            nuevoSocio.telefon2 = null;
            nuevoSocio.contrasenya = null;
            nuevoSocio.data_baixa = null;
            nuevoSocio.data_naixement = null;
           
            ConsultaOrm.InsertSocio(nuevoSocio);

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
