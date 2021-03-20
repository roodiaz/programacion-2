using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 4";

            int divisores = 0;
            int cont = 0;

            for (int i=1; i<10000; i++)
            {
                
                for (int j=1; j < i; j++)
                {
                    if (i % j == 0)
                        divisores += j;

                }

                if(i==divisores)
                {
                    Console.WriteLine(i);
                    cont++;

                    if (cont == 4)
                        break;
                }

                divisores = 0;
                    
            }

            Console.ReadKey();
        }
    }
}
