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

    public partial class VerMenores : Form
    {

        BindingList<menors> llistaMenors;
        public VerMenores(BindingList<menors> llistaMenors)


        {
            InitializeComponent();
            this.llistaMenors = llistaMenors;
           // gridMenors.AutoGenerateColumns = false;
        }

        private void VerMenores_Load(object sender, EventArgs e)
        {
            gridMenors.DataSource = llistaMenors;
        }
    }
}
