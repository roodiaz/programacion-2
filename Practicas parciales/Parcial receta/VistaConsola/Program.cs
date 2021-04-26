using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Receta receta= new Receta(45);

            bool pudo = receta + new Rucula("Eruca sativa", 10);
            pudo = receta + new Rucula("Diplotaxis muralis", 15);
            pudo = receta + new QuesoAzul("Roquefort", 3,
            QuesoAzul.Procedencia.Francia);
            pudo = receta + new QuesoAzul("Clásico", 5);
            pudo =receta + new Pera("Dulce", 12, "Williams");
            if (receta + new Pera("Seca", 1, "Blanquilla"))
            {
                Console.WriteLine("ERROR!");
            }

            Console.ReadKey();
        }
    }
}
