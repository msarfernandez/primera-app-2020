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
    public partial class frmVentanaDos : Form
    {
        public frmVentanaDos()
        {
            InitializeComponent();
        }

        private void frmVentanaDos_Load(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Color = "Roojo";

            Gato g = new Gato();
            g.Color = "Cafe";

            Gato g2 = new Gato();
            g2.Color = "Negro";

            Perro p1 = new Perro();
            p1.Color = "Fuego";


            List<Animal> listaAnimales = new List<Animal>();
            listaAnimales.Add(g2);
            listaAnimales.Add(p1);
            listaAnimales.Add(g);
            listaAnimales.Add(a);

            foreach (Animal animal in listaAnimales)
            {
                MessageBox.Show(animal.comunicarse());
            }

        }
    }
}
