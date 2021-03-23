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
           
            //POR AHORA NO SE COMPRUEBA NADA
            socis nuevoSocio = new socis();
           
            //NOT NULL OBLIGADOS
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
            nuevoSocio.cognoms = null;
            nuevoSocio.codi_postal = null;
            nuevoSocio.telefon2 = null;
            nuevoSocio.contrasenya = null;
            nuevoSocio.data_baixa = null;
            nuevoSocio.data_naixement = null;
           
            ConsultaOrm.InsertSocio(nuevoSocio);

            this.Close();
        }

    }
}
