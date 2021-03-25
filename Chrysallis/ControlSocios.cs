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
            Modificar_Socios nuevoUsuario = new Modificar_Socios(false);
            nuevoUsuario.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Modificar_Socios cambiaSocio = new Modificar_Socios(true, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            cambiaSocio.ShowDialog();
        }

        private void Control_de_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridViewSocios.DataSource = ConsultaOrm.SelectSocios();
        }

        private void Control_de_Usuarios_Activated(object sender, EventArgs e)
        {
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.DataSource = null;
            dataGridViewSocios.DataSource = ConsultaOrm.SelectSocios();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSocios.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    ConsultaOrm.DeleteSocio((socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
                    this.Control_de_Usuarios_Load(sender, e);
                }
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ControlValoraciones nuevoValoraciones = new ControlValoraciones(false, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            nuevoValoraciones.ShowDialog();
        }
    }
}
