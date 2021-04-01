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
            //dataGridViewEventos.DataSource = ConsultaOrm.SelectEventos();
            dataGridViewEventos.DataSource = ConsultaOrm.SelectEventoPorNombre(textBoxFiltrar.Text);

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    List<valoracions> listaValoraciones = ConsultaOrm.SelectValoracionesEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                    if (listaValoraciones.Count <= 1)
                    {
                        //aqui borramos las valoraciones del evento a borrar
                        for(int i=0; i < listaValoraciones.Count; i++)
                        {
                            ConsultaOrm.DeleteValoracion(listaValoraciones[i]);
                        }
                        
                    }
                    ConsultaOrm.DeleteEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                    this.Control_de_Eventos_Load(sender, e);

                }
            }
        }

        private void Control_de_Eventos_Activated(object sender, EventArgs e)
        {
            dataGridViewEventos.ReadOnly = true;
            //dataGridViewEventos.DataSource = null;
           dataGridViewEventos.DataSource = ConsultaOrm.SelectEventoPorNombre(textBoxFiltrar.Text);
        }

        private void buttonSocios_Click(object sender, EventArgs e)
        {
            ControlValoraciones nuevoValoraciones = new ControlValoraciones(true, (esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
            nuevoValoraciones.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CreaModEventos nuevoEvento = new CreaModEventos(true);
            nuevoEvento.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreaModEventos cambiaEvento = new CreaModEventos(false, (esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
            cambiaEvento.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás seguro de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    List<valoracions> listaValoraciones = ConsultaOrm.SelectValoracionesEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                    if (listaValoraciones.Count <= 1)
                    {
                        //aqui borramos las valoraciones del evento a borrar
                        for (int i = 0; i < listaValoraciones.Count; i++)
                        {
                            ConsultaOrm.DeleteValoracion(listaValoraciones[i]);
                        }

                    }
                    if (ConsultaOrm.SelectDocumentoEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem).Count > 0)
                    {
                        ConsultaOrm.DeleteDocumento(ConsultaOrm.SelectDocumentoEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem)[0]);
                    }
                    ConsultaOrm.DeleteEvento((esdeveniments)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                    this.Control_de_Eventos_Load(sender, e);

                }
            }
        }

        private void textBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Equals(""))
            {
                dataGridViewEventos.DataSource = ConsultaOrm.SelectEventos();
            }
            else
            {
            switch (comboFiltros.SelectedIndex)
            {
                case 0:
                    esdevenimentsBindingSource.DataSource = ConsultaOrm.SelectEventoPorNombre(textBoxFiltrar.Text);
                    this.Control_de_Eventos_Load(sender, e);
                    break;
                case 1:
                        esdevenimentsBindingSource.DataSource = ConsultaOrm.SelectEventoPorCAutonoma(textBoxFiltrar.Text);
                        this.Control_de_Eventos_Load(sender, e);
                        break;
                case 2:
                        esdevenimentsBindingSource.DataSource = ConsultaOrm.SelectEventoPorCAutonoma(textBoxFiltrar.Text);
                        this.Control_de_Eventos_Load(sender, e);
                        break;
               
            }

            }
        

        
               
            
        }

        private void comboFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFiltrar.Visible = true;
      switch (comboFiltros.SelectedIndex)
            {


                case 0:
                    infoFiltroText.Text = "Nombre";
                    break;
                case 1:
                    infoFiltroText.Text = "Precio";
                    break;
                case 2:
                    infoFiltroText.Text = "Província";
                    break;


            }
        }

        private void infoFiltroText_Click(object sender, EventArgs e)
        {
      
        }
    }
}
