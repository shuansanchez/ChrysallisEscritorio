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
    public partial class ControlValoraciones : Form
    {
        bool evento;
        socis socioValoracion;
        esdeveniments eventoValoracion;
        public ControlValoraciones(bool evento, socis socioValoracion)
        {
            InitializeComponent();
            this.evento = evento;
            this.socioValoracion = socioValoracion;
        }

        public ControlValoraciones(bool evento, esdeveniments eventoValoracion)
        {
            InitializeComponent();
            this.evento = evento;
            this.eventoValoracion = eventoValoracion;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlValoraciones_Activated(object sender, EventArgs e)
        {
            if (!evento)
            {
                valoracionsBindingSource.DataSource = ConsultaOrm.SelectValoracionesSocio(socioValoracion);
            }
            else
            {
                valoracionsBindingSource.DataSource = ConsultaOrm.SelectValoracionesEvento(eventoValoracion);
            }
            
        }

        private void ControlValoraciones_Load(object sender, EventArgs e)
        {
            if (!evento)
            {
                valoracionsBindingSource.DataSource = ConsultaOrm.SelectValoracionesSocio(socioValoracion);
            }
            else
            {
                valoracionsBindingSource.DataSource = ConsultaOrm.SelectValoracionesEvento(eventoValoracion);
            }
        }
    }
}
