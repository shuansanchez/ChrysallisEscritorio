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
    public partial class Control_Administradores : Form
    {
        public Control_Administradores()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            Añadir_Administrador adminNuevo = new Añadir_Administrador(true);
            adminNuevo.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Añadir_Administrador adminMod = new Añadir_Administrador(false);
            adminMod.ShowDialog();
        }
    }
}
