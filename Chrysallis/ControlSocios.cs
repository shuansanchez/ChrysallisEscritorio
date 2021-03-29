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

        private void Control_de_Usuarios_Activated(object sender, EventArgs e)
        {
            dataGridViewSocios.ReadOnly = true;
            dataGridViewSocios.DataSource = null;
            dataGridViewSocios.DataSource = ConsultaOrm.SelectSocios();
            dataGridViewSocios.AutoGenerateColumns = true;
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ControlValoraciones nuevoValoraciones = new ControlValoraciones(false, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            nuevoValoraciones.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Modificar_Socios nuevoUsuario = new Modificar_Socios(false);
            nuevoUsuario.ShowDialog();
        }

        private void toolStripButtonModificar_Click(object sender, EventArgs e)
        {
            Modificar_Socios cambiaSocio = new Modificar_Socios(true, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            cambiaSocio.ShowDialog();
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            socis socioElegido = (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            if (dataGridViewSocios.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    List<valoracions> listaValoraciones = ConsultaOrm.SelectValoracionesSocio(socioElegido);
                    if (listaValoraciones.Count >= 1)
                    {
                        //aqui borramos las valoraciones del evento a borrar
                        for (int i = 0; i < listaValoraciones.Count; i++)
                        {
                            ConsultaOrm.DeleteValoracion(listaValoraciones[i]);
                        }
                    }
                    List<menors_socis> listaRelaciones = ConsultaOrm.SelectRelacionesSocio(socioElegido);
                    if (listaRelaciones.Count >= 1)
                    {
                        //aqui borramos las valoraciones del evento a borrar
                        for (int i = 0; i < listaRelaciones.Count; i++)
                        {
                            List<menors> listaMenor = ConsultaOrm.SelectRelacionMenor(listaRelaciones[i]);
                            ConsultaOrm.DeleteRelacion(listaRelaciones[i]);
                            ConsultaOrm.DeleteMenor(listaMenor[i]);
                        }
                    }
                    ConsultaOrm.DeleteSocio(socioElegido);
                    this.Control_de_Usuarios_Activated(sender, e);
                }
            }
        }

        private void buttonMenores_Click(object sender, EventArgs e)
        {
            ControlMenores gestionaMenores = new ControlMenores((socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            gestionaMenores.ShowDialog();
        }

        private void dataGridViewSocios_DoubleClick(object sender, EventArgs e)
        {
            toolStripButtonModificar_Click(sender, e);
        }
    }
}
