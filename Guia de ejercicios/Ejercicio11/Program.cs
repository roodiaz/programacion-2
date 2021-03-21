using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 11";

            string aux;
            int num;
            int max = 0;
            int min = 0;
            double promedio = 0;

            for(int i=1; i<=10; i++)
            {
                Console.Write("ingrese numero {0}: ",i);
                aux = Console.ReadLine();

                while (!int.TryParse(aux, out num) || !Validar(num, 100, -100))
                {
                    Console.Write("ERROR!!\ningrese numero {0}: ",i);
                    aux = Console.ReadLine();
                }

                if (i == 1)
                {
                    min = num;
                    max = num;
                }
                else if (num <= min)
                    min = num;
                else
                    max = num;

                promedio += num;
            }

            promedio = promedio / 10;

            Console.Clear();
            Console.Write("numero maximo: {0}\n" +
                          "numero  minimo: {1}\n" +
                          "promedio total: {2}",max, min, promedio);

            Console.ReadKey();
            
        }

        static public bool Validar(int valor, int max, int min)
        {
            bool retorno=true;

            if (valor < min || valor > max)
                retorno = false; 

            return retorno;
        }
    }
}
