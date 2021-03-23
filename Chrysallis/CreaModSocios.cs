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
        socis socioModificar;
        Boolean modificar;
        public Modificar_Socios(Boolean modificar)
        {
            InitializeComponent();
            this.modificar = modificar;
            checkBoxBaja.Checked = false;
        }

        public Modificar_Socios(Boolean modificar, socis socioModificar)
        {
            InitializeComponent();
            this.modificar = modificar;
            this.socioModificar = socioModificar;
            if (modificar)
            {
                
                textBoxNum.Text = socioModificar.num.ToString();
                textBoxNombre.Text = socioModificar.nom;
                textBoxApellidos.Text = socioModificar.cognoms;
                textBoxEmail.Text = socioModificar.email;
                textBoxTelefono1.Text = socioModificar.telefon1;
                textBoxTelefono2.Text = socioModificar.telefon2;
                textBoxDNI.Text = socioModificar.dni;
                //textBoxCiudad = socioModificar.id_localitat;
                textBoxCP.Text = socioModificar.codi_postal;
                checkBoxActivo.Checked = socioModificar.actiu;
                checkBoxApp.Checked = socioModificar.permis_app;
                checkBoxBaja.Checked = socioModificar.data_baixa.HasValue;
                textBoxPassw.Text = socioModificar.contrasenya;
                dateTimePickerNacimiento.Value = socioModificar.data_naixement.Value;
                dateTimePickerAlta.Value = socioModificar.data_alta;
                if (!socioModificar.data_baixa.HasValue)
                {
                    dateTimePickerBaja.Value = socioModificar.data_baixa.Value;
                }
                else
                {
                    dateTimePickerBaja.Value = DateTime.Today;
                }
                
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (modificar)
            {
                socioModificar.num = Int32.Parse(textBoxNum.Text);
                socioModificar.nom = textBoxNombre.Text;
                socioModificar.actiu = checkBoxActivo.Checked;
                socioModificar.telefon1 = textBoxTelefono1.Text;

                socioModificar.email = textBoxEmail.Text;
                socioModificar.dni = textBoxDNI.Text;
                socioModificar.data_alta = dateTimePickerAlta.Value;
                socioModificar.permis_app = false;
                socioModificar.id_localitat = 1; //malgrat de mar

                //PUEDEN SER NULL
                socioModificar.cognoms = textBoxApellidos.Text;
                socioModificar.codi_postal = textBoxCP.Text;
                socioModificar.telefon2 = textBoxTelefono2.Text;
                socioModificar.contrasenya = textBoxPassw.Text;
                socioModificar.data_baixa = dateTimePickerBaja.Value;
                socioModificar.data_naixement = dateTimePickerNacimiento.Value;

                ConsultaOrm.UpdateSocio(socioModificar);
            }
            else
            {
                //POR AHORA NO SE COMPRUEBA NADA
                socis nuevoSocio = new socis();

                //NOT NULL OBLIGADOS
                nuevoSocio.num = Int32.Parse(textBoxNum.Text);
                nuevoSocio.nom = textBoxNombre.Text;
                nuevoSocio.actiu = checkBoxActivo.Checked;
                nuevoSocio.telefon1 = textBoxTelefono1.Text;

                nuevoSocio.email = textBoxEmail.Text;
                nuevoSocio.dni = textBoxDNI.Text;
                nuevoSocio.data_alta = dateTimePickerAlta.Value;
                nuevoSocio.permis_app = false;
                nuevoSocio.id_localitat = 1; //malgrat de mar

                //PUEDEN SER NULL
                nuevoSocio.cognoms = textBoxApellidos.Text;
                nuevoSocio.codi_postal = textBoxCP.Text;
                nuevoSocio.telefon2 = textBoxTelefono2.Text;
                nuevoSocio.contrasenya = textBoxPassw.Text;
                nuevoSocio.data_baixa = dateTimePickerBaja.Value;
                nuevoSocio.data_naixement = dateTimePickerNacimiento.Value;

                ConsultaOrm.InsertSocio(nuevoSocio);
            }
            this.Close();
        }

        private void checkBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBaja.Checked)
            {
                dateTimePickerBaja.Enabled = true;
            }
            else
            {
                dateTimePickerBaja.Enabled = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Socios_Load(object sender, EventArgs e)
        {
            rolsBindingSource.DataSource = ConsultaOrm.SelectRoles();
        }
    }
}
