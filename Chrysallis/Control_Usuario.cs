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
    public partial class Control_Usuario : Form
    {
        public Control_Usuario()
        {
            InitializeComponent();
        }

        private void Control_Usuario_Activated(object sender, EventArgs e)
        {
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = ConsultaOrm.SelectUsuarios();
            dataGridViewUsers.AutoGenerateColumns = true;
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                usuaris userElegido = (usuaris)dataGridViewUsers.SelectedRows[0].DataBoundItem;
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                     ConsultaOrm.DeleteUser(userElegido);
                    dataGridViewUsers.DataSource = ConsultaOrm.SelectUsuarios();
                }
            }
        }
    }
}
