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
        BindingList<menors> llistaMenors = new BindingList<menors>();
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.SelectComunidades());
        BindingList<provincies> provinciasArray = new BindingList<provincies>(ConsultaOrm.SelectProvinciasTodas());
        BindingList<localitats> localidadesArray = new BindingList<localitats>(ConsultaOrm.SelectLocalidadesTodas());


        comunitats co = new comunitats();
        provincies pr = new provincies();
        Boolean modificar;
        public Modificar_Socios(Boolean modificar)
        {
            InitializeComponent();
            this.modificar = modificar;
            comboBoxComunidades.Enabled = false;
            checkBoxBaja.Checked = false;
            buttonModificar.Text = "Crear";
        }

        public Modificar_Socios(Boolean modificar, socis socioModificar)
        {
            InitializeComponent();
            this.modificar = modificar;
            this.socioModificar = socioModificar;
            comboBoxComunidades.Enabled = false;
            textBoxNum.Enabled = false;
            if (modificar)
            {
                usuaris usuarioSocio = new usuaris();
                usuarioSocio = ConsultaOrm.SelectUsuarioSocio(socioModificar);
                if (usuarioSocio!=null)
                {
                    rolsBindingSource1.DataSource = ConsultaOrm.SelectRoles();
                    comboBoxRoles.SelectedIndex = usuarioSocio.id_rol - 4;
                    //falta guardar la comunidad del admin
                }
                //localitats localidad2 = new localitats();
                //provincies prov2 = new provincies();
                //comunitats cominades2 = new comunitats();
                //for (int i = 0; i < comunidades.Count; i++)
                //{
                //    if(comunidades[i].id = ConsultaOrm.IndexSelectComunidad()
                //    comunidades2 =
                //}
                textBoxNum.Text = string.Empty + socioModificar.num;
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
                

                

                if (usuarioSocio!=null)
                {
                    textBoxNombreUsuario.Text = usuarioSocio.username;
                }
                
                

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


                usuaris usuarioModificar = ConsultaOrm.SelectUsuarioSocio(socioModificar);
                //no funcionará, debería ir de 1 a 3, no de 4 a 6 (0,1,2) -> (4,5,6)

                usuarioModificar.id_rol = comboBoxRoles.SelectedIndex + 4;
                usuarioModificar.rols = ConsultaOrm.SelectRol(comboBoxRoles.SelectedIndex + 4);
                usuarioModificar.id_socio = socioModificar.id;
                usuarioModificar.contrasenya = socioModificar.contrasenya;
                usuarioModificar.email = socioModificar.email;
                //debe crearse un campo para el nombre de usuario en creaModSocios
                usuarioModificar.username = textBoxNombreUsuario.Text;
                ConsultaOrm.UpdateUsuario(usuarioModificar);
            }
            else
            {
                //CREAR
                //POR AHORA NO SE COMPRUEBA NADA
                socis nuevoSocio = new socis();

                //NOT NULL OBLIGADOS
                localitats loc = new localitats();
                loc = (localitats)comboBoxLocalidad.SelectedItem;
                nuevoSocio.num = Int32.Parse(textBoxNum.Text);
                nuevoSocio.nom = textBoxNombre.Text;
                nuevoSocio.actiu = checkBoxActivo.Checked;
                nuevoSocio.telefon1 = textBoxTelefono1.Text;

                nuevoSocio.email = textBoxEmail.Text;
                nuevoSocio.dni = textBoxDNI.Text;
                nuevoSocio.data_alta = dateTimePickerAlta.Value;
                nuevoSocio.permis_app = false;
                nuevoSocio.id_localitat = loc.id;

                //PUEDEN SER NULL
                nuevoSocio.cognoms = textBoxApellidos.Text;
                nuevoSocio.codi_postal = textBoxCP.Text;
                nuevoSocio.telefon2 = textBoxTelefono2.Text;
                nuevoSocio.contrasenya = textBoxPassw.Text;
                nuevoSocio.data_baixa = dateTimePickerBaja.Value;
                nuevoSocio.data_naixement = dateTimePickerNacimiento.Value;

                ConsultaOrm.InsertSocio(nuevoSocio);
                nuevoSocio = ConsultaOrm.SelectSocio(nuevoSocio);

                //-------------------------------------------
                usuaris usuarioSocio = new usuaris();

                //SUMAR UNO PARA QUE SEA 1...3 EN LUGAR DE 0...2
                //hacer reset gente
                usuarioSocio.id_rol = comboBoxRoles.SelectedIndex+4;
                usuarioSocio.id_socio = nuevoSocio.id;
                usuarioSocio.rols = ConsultaOrm.SelectRol(comboBoxRoles.SelectedIndex + 4);
                usuarioSocio.contrasenya = nuevoSocio.contrasenya;
                usuarioSocio.email = nuevoSocio.email;
                //debe crearse un campo para el nombre de usuario en creaModSocios
                usuarioSocio.username = textBoxNombreUsuario.Text;
                ConsultaOrm.InsertUsuario(usuarioSocio);
                //--------------------------------------------
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
          
                comunitatsBindingSource.DataSource = ConsultaOrm.SelectComunidades();
            
                rolsBindingSource1.DataSource = ConsultaOrm.SelectRoles();
            
            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);

            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);
            if (modificar)
            {
                localitats localidMod = new localitats();
                provincies provMod = new provincies();
                comunitats comuMod = new comunitats();
                for (int x = 0; x < localidadesArray.Count; x++)
                {
                    if (localidadesArray[x].id == socioModificar.id_localitat)
                    {
                         localidMod = localidadesArray[x];
                    }
                }
                for (int i = 0; i < provinciasArray.Count; i++)
                {
                    if(provinciasArray[i].id == localidMod.id_provincia)
                    {
                        provMod = provinciasArray[i];
                    }
                }

                for (int y = 0; y < comunidades.Count; y++)
                {
                    if(comunidades[y].id == provMod.id_comunitat)
                    {
                        comuMod = comunidades[y];
                    }
                }

                comboBoxComunidad.SelectedItem = comuMod;
                comboBoxProvincia.SelectedItem = provMod;
                comboBoxLocalidad.SelectedItem = localidMod;
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
           // rolsBindingSource1.DataSource = ConsultaOrm.SelectRoles();
            if (comboBoxRoles.SelectedIndex.Equals(1) || comboBoxRoles.SelectedIndex.Equals(2))
            {
                //rolsBindingSource1.DataSource = ConsultaOrm.SelectRoles();
                comboBoxComunidades.Enabled = true;
                comunitatsBindingSource.DataSource = ConsultaOrm.SelectComunidadesNombres();
            }
        }

        private void nomMenorText_Click(object sender, EventArgs e)
        {
          
        }

        private void verMenorBtt_Click(object sender, EventArgs e)
        {
            VerMenores verM = new VerMenores(llistaMenors);
            verM.ShowDialog();
        }

        private void crearMenorBtn_Click(object sender, EventArgs e)
        {
           // CrearModMenor formMenor = new CrearModMenor(true);
            //formMenor.ShowDialog();
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);
        }

        private void comboBoxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);

            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);
        }

        private void ModificarLocalidadButton_Click(object sender, EventArgs e)
        {
            Editar_Localidades añadir = new Editar_Localidades();

            añadir.ShowDialog();
        }
    }
}
