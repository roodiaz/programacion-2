using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculoRectangulo;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {

            Punto vertice1 = new Punto(0, 4);
            Punto vertice3 = new Punto(5, 0);
          
            Rectangulo rec = new Rectangulo(vertice1, vertice3);

            rec.Area();
            rec.Perimetro();

            Console.WriteLine(Rectangulo.MostrarDatos(rec));

            Console.ReadKey();
        }
    }
}
