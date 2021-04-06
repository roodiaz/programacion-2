using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoDeArea;

namespace CalculoDeArea
{
    public class Class1
    {
        static public double CalcularCuadrado(double lado)
        {
            return Math.Pow(2,lado);
        }

        static public double CalcularTriangulo(double datoBase,double altura)
        {
            return (datoBase * altura)/2;
        }

        static public double CalcularCirculo(double radio)
        {
            double resultado= Math.PI * (Math.Pow(2, radio));
            return Math.Round(resultado, 2); 
            //redondo a 2 decimales
        }




    }
}
