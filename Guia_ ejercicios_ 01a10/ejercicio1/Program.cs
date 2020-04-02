using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.*/

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //int i = 0;
            int total = 0;
            int mayor=0;
            int menor =0;
            string aux;
            float promedio;
       
            for(int i=1; i<=5; i++)
            {
                Console.Write("Ingrese numero {0}: ",i);
                aux = Console.ReadLine();

                while(!int.TryParse(aux, out num))
                {
                    Console.Clear();
                    Console.WriteLine("Error! Ingrese numero valido!");
                    Console.Write("Ingrese numero {0}: ",i);
                    aux = Console.ReadLine();
                }

                if(i==1)
                {
                    mayor = num;
                    menor = num;
                }
                if (num > mayor)
                    mayor = num;

                if (num < menor)
                    menor = num;

                total += num;

            }
            promedio =(float) total / 5;

            Console.Clear();
            Console.WriteLine("El numero mayor es {0}\nEl numero menor es {1}\nEl promedio es de {2}", mayor,menor,promedio);
            Console.ReadKey();
        }
    }
}
