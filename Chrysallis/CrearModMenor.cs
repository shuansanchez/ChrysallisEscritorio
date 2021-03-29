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
    public partial class CrearModMenor : Form
    {
        bool crear;
        socis socioGestion;

        public CrearModMenor(bool crear, socis socioGestion)
        {
            InitializeComponent();
            this.crear = crear;
            this.socioGestion = socioGestion;
            if (!crear)
            {
                crearBtn.Text = "Modificar";
            }
        }
        public CrearModMenor(bool crear, socis socioGestion, menors menorGestion)
        {
            InitializeComponent();
            this.crear = crear;
            this.socioGestion = socioGestion;
            if (!crear)
            {
                crearBtn.Text = "Modificar";
            }
        }

        private void CrearModMenor_Load(object sender, EventArgs e)
        {
            if (!crear)
            {
                //carregar textbox si modifiquem
            }
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            menors m1 = new menors();
            m1.nom = nomText.Text.ToString();
            ConsultaOrm.InsertMenor(m1);

            menors_socis nuevaRelacion = new menors_socis();
            nuevaRelacion.relacio = relacioMenor.Text.ToString();

            nuevaRelacion.id_soci = socioGestion.id;
            nuevaRelacion.id_menor = m1.id;
            socioGestion.menors_socis.Add(nuevaRelacion);

            ConsultaOrm.InsertSocioMenor(nuevaRelacion);

            this.Close();
        }
    }
}
