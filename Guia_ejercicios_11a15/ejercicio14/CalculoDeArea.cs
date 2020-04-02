using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadraro(double dato)
        {
            return Math.Pow(dato,2);
        }

        public static double CalcularTriangulo(double datoBase, double altura)
        {
            return (datoBase*altura)/2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * (Math.Pow(radio, 2));
               
        }
    }
}
