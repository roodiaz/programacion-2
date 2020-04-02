using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). */

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int fin;
            string aux;
            string aux1;

            Console.Write("Ingrese año de inicio: ");
            aux = Console.ReadLine();

            while (!int.TryParse(aux, out inicio))
            {
                Console.Clear();
                Console.Write("Ingrese año de inicio: ");
                aux = Console.ReadLine();
            }

            Console.Write("Ingrese año de fin: ");
            aux1 = Console.ReadLine();

            while (!int.TryParse(aux1, out fin))
            {
                Console.Clear();
                Console.Write("Ingrese año de fin: ");
                aux1 = Console.ReadLine();
            }

            Console.Clear();

            for(int i=inicio; i<=fin; i++)
            {
                if(i%4 == 0 || (i%100 ==0 && i%400 ==0))                                                   
                        Console.WriteLine(i);                                 
            }

            Console.ReadKey();
        }
    }
}
