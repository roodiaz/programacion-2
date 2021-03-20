using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 3";

            int num;
            string valor;

            Console.Write("ingrese numero para mostrar todos los numeros primos: ");
            valor = Console.ReadLine();

            while(!int.TryParse(valor,out num) || num<0)
            {
                Console.Clear();
                Console.Write("ERROR\ningrese numero para mostrar todos los numeros primos: ");
                valor = Console.ReadLine();
            }

            for(int i = 0; i <= num; i++)
            {
                int cont = 0;

                for (int j = 1;j <=i; j++){

                    if (i % j == 0)
                        cont++;

                }

                if (cont == 2)
                    Console.WriteLine(i);
                  
            }

            Console.ReadKey();
        }
    }
}
