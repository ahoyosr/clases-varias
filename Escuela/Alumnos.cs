using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            //Se llama el m{etodo getDocumentType para obtener el set de datos
            var result = getDocumentType();
            
            //Se setean los datos obtenidos en result dentro eel combo 
            cboTipoDocumento.DataSource = result;
            cboTipoDocumento.Refresh();
            cboTipoDocumento.SelectedIndex = -1;

            //Llamamos a la funcion Saludar
            //var saludo = Saludar();
            //MessageBox.Show(saludo);

            DecirHola();


        }

        private string[] getDocumentType()
        {
            string[] vstrTipoDocumento = new string[3];
            vstrTipoDocumento[0] = "C.C";
            vstrTipoDocumento[1] = "T.I";
            vstrTipoDocumento[2] = "Pasaporte";
            return vstrTipoDocumento;
        }

        public string Saludar()
        {
            return "Hola ";
        }

        public void DecirHola()
        {
            MessageBox.Show("Hola");
        }



    }
}
