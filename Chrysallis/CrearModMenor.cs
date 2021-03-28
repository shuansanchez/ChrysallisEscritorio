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
        BindingList<menors> llistaMenors;
        String relacionMenor;

        public CrearModMenor(BindingList<menors> llistaMenors, String relacionMenor)
        {
            InitializeComponent();
            this.llistaMenors = llistaMenors;
            this.relacionMenor = relacionMenor;
        }

        private void CrearModMenor_Load(object sender, EventArgs e)
        {

        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            menors m1 = new menors();
            menors_socis relacio = new menors_socis();
            relacio.relacio= relacioMenor.Text.ToString();
            m1.nom = nomText.Text.ToString();
            m1.menors_socis.Add(relacio);

            relacionMenor= relacioMenor.Text.ToString();
            //llistaMenors.Add(m1);
            this.Close();
        }
    }
}
