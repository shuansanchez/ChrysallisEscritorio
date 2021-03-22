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
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.Select());
        comunitats co = new comunitats();
        public CreaModEventos(Boolean creacion)
        {
            InitializeComponent();

            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerHora.CustomFormat = "HH:mm"; // Only use hours and minutes
            dateTimePickerHora.ShowUpDown = true;

            if (creacion)
            {
                //añadiremos
            }
            else
            {
                //modificaremos
                buttonImagen.Text = "Cargar imagen";
            }
        }   

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!compruebaDatos()) //arreglar
            {
                MessageBox.Show("Faltan datos por introducir");
            }
            else
            {
                    co = comunidades[comboBoxComunidad.SelectedIndex];
                    DateTime dt = dateTimePickerHora.Value;
                    TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                    //suerte
                    esdeveniments eventoPasar = new esdeveniments(textBoxTitulo.Text, textBoxDescripcion.Text, dateTimePickerFecha.Value,st,
                        textBoxDireccion.Text, co.id, null, null, 0, Int32.Parse(textBoxmax.Text), Int32.Parse(textBoxminimo.Text), Int32.Parse(textBoxPrecio.Text), checkBoxGratis.Checked,
                        dateTimePickerFecha.MinDate, 0, null);
                    ConsultaOrm.Insert(eventoPasar);
                    this.Close();
              
            }
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
            textBoxPrecio.Enabled = false;
            textBoxEnlace.Enabled = false;
            comunitatsBindingSource.DataSource = ConsultaOrm.Select();

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
                pictureBoxImagenEvento.ImageLocation = rutaImagen; ;
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
                //añadimos a la label
                //labelArchivo.Text = rutaCarpeta.FileName;
                labelArchivo.Text = Path.GetFileName(rutaImagen);
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

        private void dateTimePickerHora_ValueChanged(object sender, EventArgs e)
        {

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
