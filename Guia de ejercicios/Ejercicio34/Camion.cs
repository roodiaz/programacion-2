using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Camion
    {
        private short cantidadRuedas; 
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas; 
        private int pesoCarga;

        public Camion(short ruedas, short puertas, Colores color, short marchas, int carga)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
            this.cantidadMarchas = marchas;
            this.pesoCarga = carga;
        }
    }

   
}
