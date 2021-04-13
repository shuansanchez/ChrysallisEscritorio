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
    public partial class ControlMenores : Form
    {
        socis gestionarSocio;
        public ControlMenores(socis gestionarSocio)
        {
            InitializeComponent();
            this.gestionarSocio = gestionarSocio;
        }

        private void ControlMenores_Load(object sender, EventArgs e)
        {
            List<menors_socis> listaRelaciones = ConsultaOrm.SelectRelacionesSocio(gestionarSocio);
            List<menors> resultado = new List<menors>();
            for (int i = 0; i < listaRelaciones.Count; i++)
            {
                resultado.Add(ConsultaOrm.SelectRelacionSocio(listaRelaciones[i]));
            }
            menorsBindingSource.DataSource = resultado;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CrearModMenor creaMenor = new CrearModMenor(true, gestionarSocio);
            creaMenor.ShowDialog();
        }

        //obrir formulari omplint els camps amb la info de l'usuari
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CrearModMenor creaMenor = new CrearModMenor(false, gestionarSocio, (menors)dataGridViewMenores.SelectedRows[0].DataBoundItem);
            creaMenor.ShowDialog();
        }

        private void ControlMenores_Activated(object sender, EventArgs e)
        {
            List<menors_socis> listaRelaciones = ConsultaOrm.SelectRelacionesSocio(gestionarSocio);
            List<menors> resultado = new List<menors>();
            for (int i = 0; i < listaRelaciones.Count; i++)
            {
                resultado.Add(ConsultaOrm.SelectRelacionSocio(listaRelaciones[i]));
            }
            menorsBindingSource.DataSource = resultado;
        }

        private void toolStripButtonBorrarMenor_Click(object sender, EventArgs e)
        {

            DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogConfirmaBorra == DialogResult.OK)
            {
                menors borrar = (menors)dataGridViewMenores.CurrentRow.DataBoundItem;

                menors_socis borraRelacion = ConsultaOrm.SelectRelacion(gestionarSocio);

                //BORRABA DOBLE
                //ConsultaOrm.DeleteRelacion(borraRelacion);

                ConsultaOrm.DeleteMenor(borrar);
                this.ControlMenores_Activated(sender, e);
            }
             
        }

        private void dataGridViewMenores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
               // menors_socis _relacio = (menors_socis)dataGridViewMenores.Rows[e.RowIndex].DataBoundItem;
               //e.Value = _relacio.relacio;
            }
        }

        private void dataGridViewMenores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripCrearMenor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
