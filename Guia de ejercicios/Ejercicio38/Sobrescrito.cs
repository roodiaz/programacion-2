using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Sobreescrito
    {
        /*a. Sobrescribir el método ToString para que retorne "¡Este es mi método ToString
sobrescrito!".
b. Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la
misma clase), false en caso contrario.
c. Sobrescribir el método GetHashCode para que retorne el número 1142510187.*/

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
