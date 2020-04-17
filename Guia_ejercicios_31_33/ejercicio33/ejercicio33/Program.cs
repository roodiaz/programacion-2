using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libro;

namespace ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro();

            miLibro[0] = "resplandor";
            miLibro[1] = "it";
            miLibro[2] = "harry potter";
            miLibro[8] = "pepapfa";

            Console.WriteLine($"{miLibro[0]}\n{miLibro[1]}\n{miLibro[2]}\n{miLibro[8]}");

            Console.ReadKey();
        }
    }
}
