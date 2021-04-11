using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace Chrysallis
{
    public partial class CreaModEventos : Form
    {
        //provisional 
        OpenFileDialog rutaCarpeta = new OpenFileDialog();


        /*************************************/
        String rutaImagen;
        BindingList<provincies> provinciasArray = new BindingList<provincies>(ConsultaOrm.SelectProvinciasTodas());
        BindingList<localitats> localidadesArray = new BindingList<localitats>(ConsultaOrm.SelectLocalidadesTodas());
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.SelectComunidades());
        comunitats co = new comunitats();
        provincies pr = new provincies();
        localitats loc = new localitats();
        esdeveniments modificaEvento = new esdeveniments();
        Boolean modificar, documento, imagen;
        public CreaModEventos(Boolean creacion)
        {
            InitializeComponent();

            dateTimePickerHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraInicio.CustomFormat = "HH:mm"; // Only use hours and minutes
            dateTimePickerHoraInicio.ShowUpDown = true;

            dateTimePickerHoraFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraFinal.CustomFormat = "HH:mm";
            dateTimePickerHoraFinal.ShowUpDown = true;

            //POR DEFECTO NO HAY DOCUMENTO NI IMAGEN
            documento = false;
            imagen = false;

            if (creacion)
            {
                //añadiremos
                this.modificar = !creacion;
            }
            else
            {
                //modificaremos
                buttonImagen.Text = "Cargar imagen";
            }
        }

        public CreaModEventos(Boolean creacion, esdeveniments modificaEvento)
        {
            InitializeComponent();

            dateTimePickerHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraInicio.CustomFormat = "HH:mm"; // Only use hours and minutes
            dateTimePickerHoraInicio.ShowUpDown = true;

            dateTimePickerHoraFinal.Format = DateTimePickerFormat.Custom;
            dateTimePickerHoraFinal.CustomFormat = "HH:mm";
            dateTimePickerHoraFinal.ShowUpDown = true;

            this.modificaEvento = modificaEvento;
            if (!creacion)
            {
                this.modificar = !creacion;
                //modificaremos
                buttonImagen.Text = "Cargar imagen";
                textBoxTitulo.Text = modificaEvento.titol;
                textBoxDescripcion.Text = modificaEvento.descripcio;
                dateTimePickerFechaInicio.Value = modificaEvento.data.Date;
                dateTimePickerFechaFinal.Value = modificaEvento.data_max.Value;
                comboBoxComunidad.SelectedItem = modificaEvento.comunitats.id;
                textBoxDireccion.Text = modificaEvento.adreca;
                textBoxLatitud.Text = modificaEvento.latitud;
                textBoxLongitud.Text = modificaEvento.longitud;
                dateTimePickerHoraInicio.Value = Convert.ToDateTime(modificaEvento.hora.ToString());
                dateTimePickerHoraFinal.Value = Convert.ToDateTime(modificaEvento.hora_max.ToString());

                if (ConsultaOrm.SelectDocumentoEvento(modificaEvento).Count > 0)
                {
                    documents docuModif = ConsultaOrm.SelectDocumentoEvento(modificaEvento)[0];
                    labelArchivo.Text = docuModif.nom;
                }

            }
        }

        private esdeveniments copiaDatos(esdeveniments eventoPasar)
        {
            esdeveniments modificado = new esdeveniments();
            DateTime dt = dateTimePickerHoraInicio.Value;                     //Se recoge el valor de hora formato dateTimePicker (fecha)
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);  //Se pasa a formato TimeSpan (hora)

            DateTime dtMax = dateTimePickerHoraFinal.Value;
            TimeSpan stMax = new TimeSpan(dtMax.Hour, dtMax.Minute, dtMax.Second);
            //Insert versión 2----------------------------------

            eventoPasar.cont_assitents = 0;                             //al crear, siempre será cero
            eventoPasar.titol = textBoxTitulo.Text;
            eventoPasar.descripcio = textBoxDescripcion.Text;
            eventoPasar.adreca = textBoxDireccion.Text;
            eventoPasar.id_comunitat = co.id;
            eventoPasar.latitud = textBoxLatitud.Text;                                 //falta añadir este campo en el form
            eventoPasar.longitud = textBoxLongitud.Text;                                //falta añadir este campo en el form

            loc = (localitats)comboBoxLocalidad.SelectedItem;
            eventoPasar.id_localidad = loc.id;



            eventoPasar.pagament = !checkBoxGratis.Checked;             //esta variable tiene valor al REVÉS de la bd, de ahí el !

            //fecha y hora
            eventoPasar.data_max = dateTimePickerFechaFinal.Value;
            eventoPasar.data = dateTimePickerFechaInicio.Value;
            eventoPasar.hora = st;
            eventoPasar.hora_max = stMax;

            if (!checkBoxVirtual.Checked)                               //Si no es virtual, en enlace será NULL
            {
                eventoPasar.meet = "";
            }
            else
            {
                eventoPasar.meet = textBoxEnlace.Text;                  //Si es virtual, en enlace no será NULL
            }


            if (!checkBoxGratis.Checked)                                //Si no es gratis, el precio no será CERO
            {
                eventoPasar.preu = float.Parse(textBoxPrecio.Text);
            }
            else
            {
                eventoPasar.preu = 0;                                   //Si es gratis, el precio será CERO
            }

            if (!checkBoxMinima.Checked)                                //Si no hay mínimo, será CERO
            {
                eventoPasar.quantitat_mínima = 0;
            }
            else
            {
                eventoPasar.quantitat_mínima = Int32.Parse(textBoxminimo.Text);
            }

            if (!checkBoxmax.Checked)                                   //Si no hay máximo, será CERO
            {
                eventoPasar.quantitat_max = 0;
            }
            else
            {
                eventoPasar.quantitat_max = Int32.Parse(textBoxmax.Text);
            }


            modificado.id = eventoPasar.id;
            modificado = eventoPasar;
            return modificado;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

            co = comunidades[comboBoxComunidad.SelectedIndex];          //Se recoge la comunidad escogida en el comboBox
            if (modificar)
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Faltan datos por introducir");
                }
                else
                {
                    modificaEvento = copiaDatos(modificaEvento);
                    CargarIMGDOC();
                    ConsultaOrm.UpdateEvento();
                    this.Close();   //SE CERRARÁ EL FORMULARIO DE AÑADIR
                }
            }
            else //CREACION DE EVENTO
            {


                if (!ValidarCampos()) //arreglar
                {
                    MessageBox.Show("Faltan datos por introducir");
                }
                else
                {
                    modificaEvento = copiaDatos(modificaEvento);
                    //-------------------------------------------------------------
                    ConsultaOrm.InsertEvento(modificaEvento);
                    CargarIMGDOC();

                    this.Close();   //SE CERRARÁ EL FORMULARIO DE AÑADIR
                }

            }

        }

        private bool ValidarCampos()
        {
            bool validado = true;


            int result = DateTime.Compare(dateTimePickerFechaInicio.Value, dateTimePickerFechaFinal.Value);


            if (textBoxTitulo.Text == "")
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxTitulo, "Falta titulo por ingresar!");
            }

            else if (textBoxDireccion.Text == "")
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxDireccion, "Falta direccion por ingresar!");
            }

            else if (textBoxLatitud.Text == "")
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxLatitud, "Falta latitud por ingresar!");
            }

            else if (textBoxLongitud.Text == "")
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxLongitud, "Falta longitud por ingresar!");
            }

            else if (checkBoxMinima.Checked && textBoxminimo.Text.Equals(""))
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxminimo, "Faltan asistentes minimos por introducir!");
            }

            else if (checkBoxmax.Checked && textBoxmax.Text.Equals(""))
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxmax, "Faltan asistentes maximos por introducir!");
            }

            else if (checkBoxVirtual.Checked && textBoxEnlace.Text.Equals(""))
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxEnlace, "Falta enlace por introducir!");
            }

            else if (checkBoxGratis.Checked == false && textBoxPrecio.Text.Equals("") && !Int32.TryParse(textBoxPrecio.Text, out int resultadoGratis))
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(textBoxPrecio, "Falta precio por introducir!");
            }

            else if (result == 1)
            {
                errorProvider.Clear();
                validado = false;
                errorProvider.SetError(dateTimePickerFechaInicio, "Fecha de inicio erronea!");
            }
            return validado;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreaModEventos_Load(object sender, EventArgs e)
        {
            //COMPRUEBA LOS CHECKSBOX
            ComprobarCheck();


            comunitatsBindingSource.DataSource = ConsultaOrm.SelectComunidades();

            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);

            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);

            if (modificar)
            {
                //CARGAR EVENTO SIN IMAGEN
                if (modificaEvento.imatge == null)
                {

                    pictureBoxImagenEvento.Image = null;
                    buttonEliminarImg.Visible = false;

                }
                else
                {
                    //CARGA LA IMAGEN
                    byte[] img = (byte[])modificaEvento.imatge;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    pictureBoxImagenEvento.Image = Image.FromStream(ms);

                }
                //CARGAR LAS COMBOBOX LOCALIDAD COMUNIDAD PROVINCIA
                ComprobarComboBox();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            BuscarImagen();


        }

        //CARGAMOS LAS COMBOBOX DE COMUNIDAD PROVINCIA Y LOCALIDAD
        private void ComprobarComboBox()
        {
            localitats localidMod = new localitats();
            provincies provMod = new provincies();
            comunitats comuMod = new comunitats();
            for (int x = 0; x < localidadesArray.Count; x++)
            {
                if (localidadesArray[x].id == modificaEvento.id_localidad)
                {
                    localidMod = localidadesArray[x];
                }
            }
            for (int i = 0; i < provinciasArray.Count; i++)
            {
                if (provinciasArray[i].id == localidMod.id_provincia)
                {
                    provMod = provinciasArray[i];
                }
            }

            for (int y = 0; y < comunidades.Count; y++)
            {
                if (comunidades[y].id == provMod.id_comunitat)
                {
                    comuMod = comunidades[y];
                }
            }

            comboBoxComunidad.SelectedItem = comuMod;
            comboBoxProvincia.SelectedItem = provMod;
            comboBoxLocalidad.SelectedItem = localidMod;
        }
        private Boolean BuscarImagen()
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pictureBoxImagenEvento.Image = Image.FromFile(fo.FileName);
                imagen = true;

            }

            return imagen;

        }

        private void CargarIMGDOC()
        {
            if (imagen)
            {
                //AÑADE IMAGEN 
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBoxImagenEvento.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                try
                {
                    modificaEvento.imatge = ms.GetBuffer();

                }
                catch (FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }

            }

            if (documento)
            {
                //AÑADE DOCUMENTOS 
                documents nuevoDocumento = new documents();
                nuevoDocumento.id_esdeveniment = modificaEvento.id;
                nuevoDocumento.nom = Path.GetFileName(rutaImagen);
                nuevoDocumento.ruta = rutaCarpeta.FileName;
                ConsultaOrm.InsertDocumento(nuevoDocumento);
            }//INSERCIÓN
        }

        private void ComprobarCheck()
        {
            if (modificaEvento.pagament == true)
            {
                checkBoxGratis.Checked = false;
                textBoxPrecio.Enabled = true;
                textBoxPrecio.Text = modificaEvento.preu.ToString();
            }
            else
            {
                textBoxPrecio.Enabled = false;
                checkBoxGratis.Checked = true;
            }

            if (modificaEvento.quantitat_max != 0 && modificar == true)
            {
                checkBoxmax.Checked = true;
                textBoxmax.Enabled = true;
                textBoxmax.Text = modificaEvento.quantitat_max.ToString();
            }
            else
            {

                textBoxmax.Enabled = false;
                checkBoxmax.Checked = false;
            }

            if (modificaEvento.quantitat_mínima != 0 && modificar == true)
            {
                checkBoxMinima.Checked = true;
                textBoxminimo.Enabled = true;
                textBoxminimo.Text = modificaEvento.quantitat_mínima.ToString();
            }
            else
            {

                textBoxminimo.Enabled = false;
                checkBoxMinima.Checked = false;
            }

            if (modificaEvento.meet != "" && modificar == true)
            {
                textBoxEnlace.Enabled = true;
                checkBoxVirtual.Checked = true;
                textBoxEnlace.Text = modificaEvento.meet;
            }
            else
            {

                textBoxEnlace.Enabled = false;
                checkBoxVirtual.Checked = false;
            }
        }

        private void ArchivoBuscar_Click(object sender, EventArgs e)
        {
            if (compruebaArchivo())
            {
                //añadimos a la label de archivo
                labelArchivo.Text = Path.GetFileName(rutaImagen);
                documento = true;
            }
        }
        private bool compruebaArchivo()        //PROVISIONAL
        {
            bool correcto = false;

            using (rutaCarpeta = new OpenFileDialog())
            {
                rutaCarpeta.Filter = "Image files (*.pdf,  *.doc, *.docx, *.txt, *.xls, *.xlsx, *.ppt, *.pptx, *.zip, *.rar) | *.jpg; *.doc; *.docx; *.txt; *.xls; *.xlsx; *.ppt; *.pptx; *.zip; *.rar";
                rutaCarpeta.Multiselect = false;
                if (rutaCarpeta.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
                {
                    rutaImagen = rutaCarpeta.FileName;

                    correcto = true;
                }
            }
            return correcto;
        }

        private void checkBoxGratis_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxGratis.Checked)
            {
                textBoxPrecio.Enabled = true;
            }
            else
            {
                textBoxPrecio.Text = "";
                textBoxPrecio.Enabled = false;
            }
        }
        private void checkBoxVirtual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVirtual.Checked)
            {
                textBoxEnlace.Enabled = true;
            }
            else
            {
                textBoxEnlace.Text = "";
                textBoxEnlace.Enabled = false;
            }
        }

        private void checkBoxMinima_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinima.Checked)
            {
                textBoxminimo.Enabled = true;
            }
            else
            {
                textBoxminimo.Text = "";
                textBoxminimo.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmax.Checked)
            {
                textBoxmax.Enabled = true;
            }
            else
            {
                textBoxmax.Text = "";
                textBoxmax.Enabled = false;
            }
        }

        private void buttonEliminarImg_Click(object sender, EventArgs e)
        {
            modificaEvento.imatge = null;
            pictureBoxImagenEvento.Image = null;

            ConsultaOrm.UpdateEvento();
        }



        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            pr = (provincies)comboBoxProvincia.SelectedItem;
            localitatsBindingSource.DataSource = ConsultaOrm.SelectLocalidades(pr.id);
        }

        private void AñadirLocalidad_Click(object sender, EventArgs e)
        {
            Editar_Localidades añadir = new Editar_Localidades();

            añadir.ShowDialog();
        }
    }
}
