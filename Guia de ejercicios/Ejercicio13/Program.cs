using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorNumeros;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 13";

            Console.Write("Ingrese numero decimal: ");
            int dec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese numero binario: ");
            string bin = Console.ReadLine();

            Console.Clear();
            Console.Write("decimal {0} convertido a binario es {1}\n" +
                          "binario {2} convertido a decimal es {3}",
                           dec,Conversor.DecimalBinario(dec),
                           bin,Conversor.BinarioDecimal(bin));

            Console.ReadKey();
        }
    }
}
