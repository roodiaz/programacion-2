using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int[] numeros = new int[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(-100,100);
            }

            //muestro todos los numeros del array
            for (int i = 0; i <numeros.Length; i++)
            {
                Console.Write($"{numeros[i]}, ");
            }

            //positivos ordenados de forma decreciente
            Array.Sort(numeros, delegate (int a, int b) { return b - a; });      
            Console.WriteLine("\n\nnumero positivos ordenados de forma decreciente:");
            for (int i = 0; i < numeros.Length; i++)
            { 
                if(numeros[i]>0)  
                     Console.Write($"{numeros[i]}, ");
            }

            //negativos ordenador de forma creciente
            Array.Sort(numeros);
            Console.WriteLine("\n\nnumers negativos ordenados de forma creciente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                    Console.Write($"{numeros[i]}, ");
            }

            Console.ReadKey();
        }
    }
}
