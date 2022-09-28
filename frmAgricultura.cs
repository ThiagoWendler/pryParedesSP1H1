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
            //Abre el formulario frmLoc
            //Se abre a traves de "ShowDialog" que es para que el usuario no pueda interactuar con el formulario principal (Parent)
            frmLocalidad frmLoc = new frmLocalidad();
            frmLoc.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre el formulario frmCult
            frmCultivos frmCult = new frmCultivos();
            frmCult.ShowDialog();
        }

      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //DialogResult, se basa en el resultado de la MessageBox
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado es si, la aplicacion se cierra
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
            //Abre el formulario frmCant
            frmProduccion frmCant = new frmProduccion();
            frmCant.ShowDialog();
        }
    }
}
