using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class CreaModEventos : Form
    {
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.Select());
        comunitats co = new comunitats();
        public CreaModEventos(Boolean creacion)
        {
            InitializeComponent();
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
            if(checkBoxGratis.Checked == false)
            {
                textBoxPrecio.Enabled = true;
            }
            else
            {
                textBoxPrecio.Enabled = false;
            }
        }
    }
}
