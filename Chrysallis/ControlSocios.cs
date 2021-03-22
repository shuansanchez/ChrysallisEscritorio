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
    public partial class Control_de_Usuarios : Form
    {
        public Control_de_Usuarios()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            Añadir_Socio nuevoUsuario = new Añadir_Socio();
            nuevoUsuario.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Modificar_Socios cambiaSocio = new Modificar_Socios();
            cambiaSocio.ShowDialog();
        }

        private void Control_de_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridViewSocios.DataSource = ConsultaOrm.SelectSocios();
        }
    }
}
