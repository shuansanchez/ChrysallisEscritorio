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
            /*List<menors_socis> listaRelaciones= ConsultaOrm.SelectRelacionesSocio(gestionarSocio);
            for(int i=0; i < listaRelaciones.Count; i++)
            {
                menorsBindingSource.DataSource = ConsultaOrm.SelectRelaciones(listaRelaciones[i], gestionarSocio);
            }*/
            
            //mostrar menores del socio con el id de gestionarSocio

            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CrearModMenor creaMenor = new CrearModMenor(true, gestionarSocio);
            creaMenor.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CrearModMenor creaMenor = new CrearModMenor(false, gestionarSocio, (menors)dataGridViewMenores.SelectedRows[0].DataBoundItem);
            creaMenor.ShowDialog();
        }

        private void ControlMenores_Activated(object sender, EventArgs e)
        {
            menorsBindingSource.DataSource = ConsultaOrm.SelectMenores();
        }

        private void toolStripButtonBorrarMenor_Click(object sender, EventArgs e)
        {
            menors borrar = (menors)dataGridViewMenores.SelectedRows[0].DataBoundItem;

            menors_socis borraRelacion = new menors_socis();
            borraRelacion.id_soci = gestionarSocio.id;
            borraRelacion.id_menor = borrar.id;
            borraRelacion.socis = gestionarSocio;
            borraRelacion.menors = borrar;
            borraRelacion.relacio = "";
            ConsultaOrm.DeleteSocioMenor(borraRelacion);

            ConsultaOrm.DeleteMenor(borrar);
        }

        private void dataGridViewMenores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //menors_socis _relacio = (menors_socis)dataGridViewMenores.Rows[e.RowIndex].DataBoundItem;
               // e.Value = _relacio.relacio;
            }
        }
    }
}
