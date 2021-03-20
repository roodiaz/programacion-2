using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 1";

            int num;
            int max = 0;
            int min = 0;
            int cont = 0;
            float promedio = 0;
            string valor;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("INGRESE NUMERO {0}: ", i);
                valor = Console.ReadLine();

                while (!int.TryParse(valor, out num))
                {
                    Console.Write("INGRESE NUMERO {0}: ", i);
                    valor = Console.ReadLine();
                }

                if (i == 1)
                {
                    max = num;
                    min = num;
                }
                else if (num > max)
                    max = num;
                else
                    min = num;

                cont += num;
                promedio = (float)cont / 5;

            }

            Console.Write("\nnumero maximo: {0}\nnumero minimo: {1}\npromedio total: {2}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
