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
    public partial class Eventos : Form
    {

        String rutaImagen;
        OpenFileDialog rutaCarpeta = new OpenFileDialog();
        string fechaElegida;
        string horaElegida;
        public Eventos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Archivo_Click(object sender, EventArgs e)
        {
            if (!compruebaArchivo() || rutaCarpeta.FileName.Equals(""))
            {
                MessageBox.Show("No se ha modificado el evento", "Archivo vacío o incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
            {
                labelArchivo.Text = rutaCarpeta.SafeFileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!compruebaFoto() || rutaCarpeta.FileName.Equals(""))
            {
                MessageBox.Show("No se ha modificado el evento", "Archivo vacío o incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
            {
                pictureBoxEvento.ImageLocation = rutaImagen;
            }
        }

        private bool compruebaFoto()
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

        private bool compruebaArchivo()
        {
            bool correcto = false;

            using (rutaCarpeta = new OpenFileDialog())
            {
                rutaCarpeta.Filter = "Image files (*.pdf,  *.odt, *.xls, *.xlsx, *.ppt, *.pptx, *.txt) | *.pdf; *.odt; *.xls; *.xlsx; *.ppt;*.pptx; *.txt";
                rutaCarpeta.Multiselect = false;
                if (rutaCarpeta.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(rutaCarpeta.FileName))
                {

                    rutaImagen = rutaCarpeta.FileName;
                    correcto = true;
                }
            }
            return correcto;
        }

        private void Eventos_Activated(object sender, EventArgs e)
        {
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.CustomFormat = "HH:mm";
            dateTimePickerHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerHora.ShowUpDown = true;
        }

        private void dateTimePickerFechaEvento_ValueChanged(object sender, EventArgs e)
        {
            fechaElegida = dateTimePickerFechaEvento.Value.ToShortDateString();
        }

        private void dateTimePickerHora_ValueChanged(object sender, EventArgs e)
        {
            horaElegida = dateTimePickerHora.Value.ToString();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
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

        private void compruebaDatosEvento()
        {
            if (!fechaElegida.Equals(DateTime.MinValue) && !horaElegida.Equals(DateTime.MinValue))
            {
                
            }
        }
    }
}
