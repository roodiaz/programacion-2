using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Punto punto1 = new Punto(-1,-3);
            Punto punto2 = new Punto(2,4);
            Rectangulo rec = new Rectangulo(punto1, punto2);

            rec.Area();
            rec.Perimetro();
                
            Console.WriteLine(Rectangulo.Mostrar(rec));

            Console.ReadKey();
        }
    }
}
