using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Ejemplo_01
{
    public partial class form_ventana : Form
    {
        public form_ventana()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombre = caja_nombre.Text;
            MessageBox.Show("Bienvenido a POO " + nombre + ", este es tu primer formulario");
        }//fin funcion btn_guardar

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina la aplicacion
        }//fin funcion click btn_salir
        
    }
}
