using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(int). Convierte un número de entero a binario.
int BinarioDecimal(string). Convierte un número binario a entero. */

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {                                
            Console.Write("Ingrese numero decimal: ");
            int dec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese numero binario: ");
            string bin = Console.ReadLine();

            Console.Clear();
            Console.Write("Numero "+dec+" a binario es "+Conversor.DecimalBinario(dec)+"\n"+
                          "Numero "+bin+" a decimal es "+Conversor.BinarioDecimal(bin));

            Console.ReadKey();
        }

        
    }
}
