using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraWinApp
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        //puedo mas atributos, de este tipo: property

        // o puedo tener metodos...


        public virtual string comunicarse()
        {
            return "GRRRRRRR";
        }

    }
}
