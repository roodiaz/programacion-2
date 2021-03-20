using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 2";

            string valor;
            int number;

            Console.Write("ingrese numero para calcular pontencia y cubo: ");
            valor = Console.ReadLine();

            while(!int.TryParse(valor, out number) || number<=0)
            {
                  Console.Write("ingrese numero valido para calcular pontencia y cubo: ");
                  valor = Console.ReadLine();

                 Console.Clear();

            }        
            
            Console.WriteLine("el cuadrado del numero {0} es {1}", number, Convert.ToInt32(Math.Pow(number, 2)));
            Console.WriteLine("el cubo del numero {0} es {1}", number, Convert.ToInt32(Math.Pow(number, 3)));

            Console.ReadKey();

        }
    }
}
