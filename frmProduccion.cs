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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

       

        private void cbxLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            


             
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader LeerCantidad = new StreamReader("./localidad.txt");

            while (!LeerCantidad.EndOfStream)
            {
                cbxLocalidad.Items.Add(LeerCantidad.ReadLine().ToString());
            }

            LeerCantidad.Close();



            StreamReader LeerCultivos = new StreamReader("./cultivos.txt");

            while (!LeerCultivos.EndOfStream)
            {
                cbxCultivo.Items.Add(LeerCultivos.ReadLine().ToString());
            }

            LeerCultivos.Close();



        }

        private void btnCrearProd_Click(object sender, EventArgs e)
        {
            

            File.Create("./produccion.txt");

            
            
        }

        private void btnacepta_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("./produccion.txt", true);

            Escribir.WriteLine(Convert.ToString("Cantidad:" + txtCantidad.Text) + "\nCultivo:" + cbxCultivo.Text+ "\nLocalidad:" + cbxLocalidad.Text);
            Escribir.Close();

            MessageBox.Show("La produccion se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            txtCantidad.Text = "";
        }
    }
}
