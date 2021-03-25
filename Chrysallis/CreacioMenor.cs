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
    public partial class CreacioMenor : Form
    {
        public CreacioMenor(BindingList<menors> llistaMenors)
        {
            InitializeComponent();
        }

        private void CreacioMenor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menors m = new menors();
            String nom = nomText.Text.ToString();
            String relacio = relacionText.Text.ToString();
            //no tenim classe menor, com crearlo per fer add i retornar la llista

            this.Close();
        }
    }
}
