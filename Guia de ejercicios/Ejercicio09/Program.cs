using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 9";

            int altura;

            Console.Write("ingrese altura de piramide: ");
            altura = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 0; j <= (i * 2) - 1; j++)
                    Console.Write("*");

                Console.WriteLine();//hace los saltos de linea
            }

            Console.ReadKey();
        }
    }
}
