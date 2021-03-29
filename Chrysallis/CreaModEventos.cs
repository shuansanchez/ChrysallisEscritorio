using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Chrysallis
{
    public partial class CreaModEventos : Form
    {
        //provisional 
        OpenFileDialog rutaCarpeta = new OpenFileDialog();
        String rutaImagen;

        /*************************************/
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.SelectComunidades());
        comunitats co = new comunitats();
        esdeveniments modificaEvento = new esdeveniments();
        Boolean modificar, documento;
        public CreaModEventos(Boolean creacion)
        {
            InitializeComponent();

            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerHora.CustomFormat = "HH:mm"; // Only use hours and minutes
            dateTimePickerHora.ShowUpDown = true;
            documento = false;
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

            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerHora.CustomFormat = "HH:mm"; // Only use hours and minutes
            dateTimePickerHora.ShowUpDown = true;

            this.modificaEvento = modificaEvento;
            if (!creacion)
            {
                this.modificar = !creacion;
                //modificaremos
                buttonImagen.Text = "Cargar imagen";
                textBoxTitulo.Text = modificaEvento.titol;
                textBoxDescripcion.Text = modificaEvento.descripcio;
                textBoxEnlace.Text = modificaEvento.meet;
                dateTimePickerFecha.Value = modificaEvento.data.Date;
                //dateTimePickerHora.Value = modificaEvento.hora.;
                comboBoxComunidad.SelectedItem = modificaEvento.comunitats.id;
                //comboBoxProvincia.SelectedItem=modificaEvento.provincia??
                //textBoxLocalidad.Text=modificaEvento.
                textBoxDireccion.Text = modificaEvento.adreca;
                textBoxmax.Text =modificaEvento.quantitat_max.ToString();
                textBoxPrecio.Text = modificaEvento.quantitat_mínima.ToString();
                textBoxLatitud.Text = modificaEvento.latitud;
                textBoxLongitud.Text = modificaEvento.longitud;
                //FALTA ARCHIVO E IMAGEN TAMBIEN
            }
        }

        private esdeveniments copiaDatos(esdeveniments eventoPasar)
        {
            esdeveniments modificado = new esdeveniments();
            DateTime dt = dateTimePickerHora.Value;                     //Se recoge el valor de hora formato dateTimePicker (fecha)
            TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);  //Se pasa a formato TimeSpan (hora)
            //Insert versión 2----------------------------------
            eventoPasar.cont_assitents = 0;                             //al crear, siempre será cero
            eventoPasar.titol = textBoxTitulo.Text;
            eventoPasar.descripcio = textBoxDescripcion.Text;
            eventoPasar.adreca = textBoxDireccion.Text;
            eventoPasar.id_comunitat = co.id;

            eventoPasar.latitud = textBoxLatitud.Text;                                 //falta añadir este campo en el form
            eventoPasar.longitud = textBoxLongitud.Text;                                //falta añadir este campo en el form


            eventoPasar.imatge = 0;                                     //¿cuando hay foto toma valor? ¿cuál?


            eventoPasar.pagament = !checkBoxGratis.Checked;             //esta variable tiene valor al REVÉS de la bd, de ahí el !

            //fecha y hora
            eventoPasar.data_max = dateTimePickerFecha.MinDate;
            eventoPasar.data = dateTimePickerFecha.Value;
            eventoPasar.hora = st;

            if (!checkBoxVirtual.Checked)                               //Si no es virtual, en enlace será NULL
            {
                eventoPasar.meet = null;
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
                modificaEvento=copiaDatos(modificaEvento);
                ConsultaOrm.UpdateEvento(modificaEvento);
            }
            else
            {
                if (!compruebaDatos()) //arreglar
                {
                    MessageBox.Show("Faltan datos por introducir");
                }
                else
                {
                    DateTime dt = dateTimePickerHora.Value;                     //Se recoge el valor de hora formato dateTimePicker (fecha)
                    TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);  //Se pasa a formato TimeSpan (hora)

                    modificaEvento=copiaDatos(modificaEvento);
                    //-------------------------------------------------------------
                    //modificaEvento.imatge = ;
                    ConsultaOrm.InsertEvento(modificaEvento);                            //INSERCIÓN

                    if (documento)
                    {
                        //AÑADE DOCUMENTOS CORRECTAMENTE
                        documents nuevoDocumento = new documents();
                        nuevoDocumento.id_esdeveniment = modificaEvento.id;
                        nuevoDocumento.nom = Path.GetFileName(rutaImagen);
                        nuevoDocumento.ruta = rutaCarpeta.FileName;
                        ConsultaOrm.InsertDocumento(nuevoDocumento);
                    }
                    
                }
            
                    
            }
            this.Close();                                           //SE CERRARÁ EL FORMULARIO DE AÑADIR
        }

        private bool compruebaDatos()
        {
            Boolean correcto = false;
            /* if(!textBoxTitulo.Text.Equals("")||!textBoxLocalidad.Text.Equals("") || !textBoxDireccion.Text.Equals(""))
             {
                 //campos de texto correctos
                 if (!checkBoxGratis.Checked && !textBoxPrecio.Text.Equals("") && Int32.TryParse(textBoxPrecio.Text, out int resultadoGratis))
                 {//si no gratis i hi ha preu

                     if (checkBoxMinima.Checked && textBoxminimo.Text.Equals("") && Int32.TryParse(textBoxminimo.Text, out int resultadoMin))
                     {//si hi ha minima i hi ha text
                         if (checkBoxmax.Checked && textBoxmax.Text.Equals("") && Int32.TryParse(textBoxmax.Text, out int resultadoMax))
                         {//si hi ha maxima i hi ha text
                             if (checkBoxVirtual.Checked && textBoxEnlace.Text.Equals(""))
                             {
                                 correcto = true;
                             }
                             else
                             {
                                 MessageBox.Show("Enlace mal");
                             }
                         }
                         else
                         {
                             MessageBox.Show("Maximo mal");
                         }
                     }
                     else
                     {
                         MessageBox.Show("Minimo mal");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Precio mal");
                 }
             }
             else
             {
                 MessageBox.Show("Titulo Localidad Direccion mal");
             }*/
            correcto = true;
            return correcto;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreaModEventos_Load(object sender, EventArgs e)
        {
            textBoxminimo.Enabled = false;
            textBoxmax.Enabled = false;
            textBoxPrecio.Enabled = false;
            textBoxEnlace.Enabled = false;
            comunitatsBindingSource.DataSource = ConsultaOrm.SelectComunidades();

           
            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
        }

        private void checkBoxGratis_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBoxGratis.Checked)
            {
                textBoxPrecio.Enabled = true;
            }
            else
            {
                textBoxPrecio.Enabled = false;
            }
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            if (compruebaImagen())
            {
                //añadimos al picturebox
                pictureBoxImagenEvento.ImageLocation = rutaImagen;
            }
        }

        private bool compruebaImagen()      //PROVISIONAL
        {
            bool correcto = false;

            using (rutaCarpeta = new OpenFileDialog())
            {
                rutaCarpeta.Filter = "Image files (*.jpg,  *.png) | *.jpg; *.png";
                rutaCarpeta.Multiselect = false;
                if (rutaCarpeta.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
                {

                    rutaImagen = rutaCarpeta.FileName;
                    correcto = true;
                }
            }
            return correcto;
        }

        private void ArchivoBuscar_Click(object sender, EventArgs e) 
        {
            if (compruebaArchivo()){
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

        private void checkBoxVirtual_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVirtual.Checked)
            {
                textBoxEnlace.Enabled = true;
            }
            else
            {
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
                textBoxmax.Enabled = false;
            }
        }
    }
}
