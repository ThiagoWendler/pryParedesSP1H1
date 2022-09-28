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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void btnCrearLocalidad_Click(object sender, EventArgs e)
        {
            //Se crea el archivo (./localidad.txt)
            File.Create("./localidad.txt");



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Abro el Agregado de datos, y uso StreamWriter (salida de caracteres en una codificacion determinada)
            TextWriter Escribir = new StreamWriter("./localidad.txt", true);

            //Uso la variable "Escribir" para escribir en el archivo (./localidad.txt)
            Escribir.WriteLine(Convert.ToString(txtIdentificador.Text + " " + txtLocalidad.Text));
            Escribir.Close();


            MessageBox.Show("La localidad se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdentificador.Text = "";
            txtLocalidad.Text = "";
            txtLocalidad.Focus();



        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            //Si la textBoxLocalidad es diferente a nada, los botones btnAceptar y btnEliminar se activan
            if (txtLocalidad.Text != "")
            {
                btnAceptar.Enabled = true;

                btnEliminar.Enabled = true;
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DialogResult, que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: OK - Cancelar)
            DialogResult r = MessageBox.Show("¿Esta seguro que desea eliminar el archivo?" + "\nAtencion: Si elimina el archivo todo el contenido se perdera" + "\n¿Aun desea continuar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.OK)
            {
                //Elimina el archivo 
                File.Delete("./localidad.txt");

                //MessageBox para avisar que se elimino el archivo
                MessageBox.Show("Archivo eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Si el resultado del dialogo es "Cancel", el archivo no se elimina
            if (r == DialogResult.Cancel)
            {
                MessageBox.Show("Accion cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {

        }
    }
}
