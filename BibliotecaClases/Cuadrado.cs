using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public sealed class Cuadrado: Rectangulo
    {
        private double lado;

        public Cuadrado(double lado):base(lado,lado)
        {
            
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado...";
        }
      
    }
}
