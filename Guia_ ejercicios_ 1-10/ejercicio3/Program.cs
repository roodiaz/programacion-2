using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string aux;

            Console.Write("Ingrese numero mayor a 0: ");
            aux = Console.ReadLine();

            while(!int.TryParse(aux, out num) || num < 1)
            {
                Console.Clear();
                Console.Write("Ingrese numero mayor a 1: ");
                aux = Console.ReadLine();
            }

            for(int i=1; i<=num; i++)
            {
                int cont = 0;

                for(int j=1; j<=i; j++)
                {
                    if(i % j == 0) 
                        cont++;    //divisible por 1 y si mismo aumenta contador                         
                }

                if(cont == 2)           
                    Console.WriteLine(i);               
            }

            Console.ReadKey();
        }
    }
}
