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
    public partial class Control_de_Eventos : Form
    {
        public Control_de_Eventos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            CreaModEventos nuevoEvento = new CreaModEventos(true);
            nuevoEvento.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            CreaModEventos cambiaEvento = new CreaModEventos(false);
            cambiaEvento.ShowDialog();
        }
    }
}
