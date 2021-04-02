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
    public partial class AñadirLocalidad : Form
    {
        BindingList<comunitats> comunidades = new BindingList<comunitats>(ConsultaOrm.SelectComunidades());
        comunitats co = new comunitats();
        public AñadirLocalidad()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            provincies provin = new provincies();
            localitats locali = new localitats();
            provin = (provincies)comboBoxProvincia2.SelectedItem;
            locali.id_provincia = provin.id;
            locali.nom = textBoxLocalidad.Text;
            ConsultaOrm.InsertLocalidad(locali);
            this.Close();
        }

        private void AñadirLocalidad_Load(object sender, EventArgs e)
        {
            comunitatsBindingSource.DataSource = ConsultaOrm.SelectComunidades();
            co = comunidades[comboBoxComunidad2.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);

        }

        private void comboBoxProvincia2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBoxComunidad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            co = comunidades[comboBoxComunidad2.SelectedIndex];
            provinciesBindingSource.DataSource = ConsultaOrm.SelectProvincias(co.id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
