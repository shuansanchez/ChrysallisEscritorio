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

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            CreaModEventos nuevoEvento = new CreaModEventos(true);
            nuevoEvento.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            CreaModEventos cambiaEvento = new CreaModEventos(false, (esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
            cambiaEvento.ShowDialog();
        }

        private void Control_de_Eventos_Load(object sender, EventArgs e)
        {
            dataGridViewEventos.DataSource = ConsultaOrm.SelectEventos();
        }

       /* private void dataGridViewEventos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    ConsultaOrm.DeleteEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }*/

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                        ConsultaOrm.DeleteEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                        this.Control_de_Eventos_Load(sender, e);
                }
            }
        }

        private void Control_de_Eventos_Activated(object sender, EventArgs e)
        {
            dataGridViewEventos.ReadOnly = true;
            dataGridViewEventos.DataSource = null;
            dataGridViewEventos.DataSource = ConsultaOrm.SelectEventos();
        }
    }
}
