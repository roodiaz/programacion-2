using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Moto
    {
        private short cantidadRuedas;
        private short cantidadPuerta;
        private Colores color;
        private short cilindrada;

        public Moto(short ruedas, short puertas, Colores color, short cilindrada)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuerta = puertas;
            this.color = color;
            this.cilindrada = cilindrada;
        }
    }
}
