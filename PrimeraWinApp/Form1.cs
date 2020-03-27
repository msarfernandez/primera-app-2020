using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //esto se va a ejecutar cuando hagas click en el boton Saludar.
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes ingresar tu nomnbre");
            }
            else
            {
                MessageBox.Show("Hola " + txtNombre.Text);
            }
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Te damos la bienvenida a la super app", "HOLA!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text;
            
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("De verdad queres salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
