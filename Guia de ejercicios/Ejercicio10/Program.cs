using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
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

            for (int i = 0; i <= altura; i++)
            {
                for (int j = 1; j <= (altura-i); j++)
                    Console.Write(" ");

                for (int k = 1; k <= (i * 2) - 1; k++)
                    Console.Write("*");


                Console.WriteLine();//hace los saltos de linea
            }

            Console.ReadKey();
        }
    }
}
