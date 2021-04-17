using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Automovil
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short ruedas, short puertas, Colores color, short marchas, int pasajeros)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }
    }
}
