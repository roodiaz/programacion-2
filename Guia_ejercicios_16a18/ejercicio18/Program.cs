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
            
            Punto vertice1 = new Punto(15,4);
            Punto vertice3 = new Punto(7,12);
            // vertice2 (-1,4) vertice4(2,-3)
            Rectangulo rec = new Rectangulo(vertice1, vertice3);

            rec.Area();
            rec.Perimetro();
                
            Console.WriteLine(Rectangulo.MostrarDatos(rec));

            Console.ReadKey();
        }
    }
}
