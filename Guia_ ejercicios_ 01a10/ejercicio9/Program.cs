using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas. */

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;           

            Console.Write("Ingrese altura de piramide mayor a 0: ");
            altura = Int32.Parse(Console.ReadLine());

            while(altura < 0)
            {
                Console.Clear();
                Console.Write("Ingrese altura de piramide mayor a 0: ");
                altura = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            for(int i=1; i<=altura; i++)//controla altura
            {
                for(int j=0; j<i; j++) //controla cantidad astericos x linea
                {
                    Console.Write("*");
                }               

               Console.WriteLine(); //hace salto de linea entre asteriscos
            }

            Console.ReadKey();
        }
    }
}
