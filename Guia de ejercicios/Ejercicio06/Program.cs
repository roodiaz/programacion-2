using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ejercicio numero 6";

            int inicio;
            int fin;
            string aux;
            string aux2;

            Console.Write("ingrese año de inicio: ");
            aux = Console.ReadLine();

            Console.Write("ingrese año de fin: ");
            aux2 = Console.ReadLine();

            while (int.TryParse(aux, out inicio)|| int.TryParse(aux2, out fin))
            {
                Console.Clear();

                Console.Write("Error\ningrese año de inicio: ");
                aux = Console.ReadLine();

                Console.Write("ingrese año de fin: ");
                aux2 = Console.ReadLine();
            }


            Console.ReadKey();
        }
    }
}
