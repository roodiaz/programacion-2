using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 12";

            char c;
            int num;
            int suma=0;
            string aux;

            do
            {
                Console.Write("ingrese numero: ");
                aux = Console.ReadLine();

                while(!int.TryParse(aux, out num))
                {
                    Console.Write("ERROR\ningrese numero: ");
                    aux = Console.ReadLine();
                }

                suma += num;

                Console.Write("desea continuar ingresando numeros? s/n: ");
                c = char.Parse(Console.ReadLine());
                Console.Clear();

            } while (ValidarS_N(c));

            Console.Write("la suma de los numeros ingresados es: {0}", suma);
            Console.ReadKey();

        }

        static public bool ValidarS_N(char c)
        {
            bool retorno = false;

            if (char.ToLower(c) == 's')
                retorno= true;

            return retorno;
        }
    }
}
