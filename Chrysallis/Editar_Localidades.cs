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
    public partial class Editar_Localidades : Form
    {
       

        public Editar_Localidades()
        {
            InitializeComponent();
        }

        private void Editar_Localidades_Load(object sender, EventArgs e)
        {
           
            dataGridViewLocalidades.DataSource = ConsultaOrm.SelectMostrarLoc();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AñadirLocalidad localidadForm = new AñadirLocalidad();
            localidadForm.ShowDialog();
            dataGridViewLocalidades.DataSource = ConsultaOrm.SelectMostrarLoc();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewLocalidades.SelectedRows.Count > 0)
            {
                BindingList<localitats> localidades = new BindingList<localitats>(ConsultaOrm.SelectMostrarLoc());
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {

                    //aqui borramos 
                    localitats borrar = (localitats)dataGridViewLocalidades.CurrentRow.DataBoundItem;
                    ConsultaOrm.DeleteLocalidad(borrar);
                    dataGridViewLocalidades.DataSource = ConsultaOrm.SelectMostrarLoc();
                }
            }
        }

        private void Editar_Localidades_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
