using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraWinApp
{
    public class Gato : Animal
    {
        public string Origen { get; }
        public DateTime fechaNacimiento { get; set; }
        public Duenio PadreMadre { get; set; }


        // ejemplo de un atributo privado MAL
        private string otroAtributo;

        public Gato(string magia)
        {
            otroAtributo = magia;
        }

        //
        public Gato() { }


        //redefino
        public override string comunicarse()
        {
            return "MIAUUUU";
        }

        //esto es sobre cargar un metodo.
        public string comunicarse(string algoQueDecir)
        {
            return algoQueDecir;
        }
    }
}
