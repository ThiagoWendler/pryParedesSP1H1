using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace pryParedesSP1H1
{
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }

        

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLoc = new frmLocalidad();
            frmLoc.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCult = new frmCultivos();
            frmCult.ShowDialog();
        }

      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (s == DialogResult.No)
            {

            }
        
        }

        private void cantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmCant = new frmProduccion();
            frmCant.ShowDialog();
        }
    }
}
