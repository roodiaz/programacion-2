using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[0] = "h";
            miLibro[1] = "o";
            miLibro[2] = "l";
            miLibro[8] = "a";
            miLibro[2] = "L";

            Console.WriteLine($"{miLibro[0]}{miLibro[1]}{miLibro[2]}{miLibro[8]}");
            Console.ReadKey();
        }
    }
}
