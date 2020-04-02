using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisores = 0;
            int cont = 0;

            for(int i=1; i<10000; i++)
            {
                for(int j=1; j<i; j++)
                {
                    if (i % j == 0)
                        divisores += j;
                }

                if(i == divisores)//si el divisor sumo la misma cantidad que el i actual muestro
                {
                    Console.WriteLine(i);
                    cont++;

                    if (cont == 4) // encuentra 4 numeros perfectos, sale del bucle
                        break;
                }
                   
                divisores = 0;
            }
           
            Console.ReadKey();
        }
    }
}
