using System;
using System.ComponentModel;
using System.Windows.Forms;

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

            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;

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
            if (textBoxCiudad.Text.Equals("") || textBoxDescripcion.Text.Equals("") || textBoxLugar.Text.Equals("") || textBoxPrecio.Text.Equals("") ||
    textBoxTitulo.Text.Equals(""))
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

        private void CreaModEventos_Load(object sender, EventArgs e)
        {
            textBoxPrecio.Enabled = false;
            comunitatsBindingSource.DataSource = ConsultaOrm.Select();

            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            co = comunidades[comboBoxComunidad.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
        }

        private void CreaModEventos_Activated(object sender, EventArgs e)
        {
              
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

        
    }
}
