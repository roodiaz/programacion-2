using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ejercicio numero 6";

            int inicio;
            int fin;
            string aux;
            string aux2;
            bool flag = false;

            Console.Write("ingrese año de inicio: ");
            aux = Console.ReadLine();

            Console.Write("ingrese año de fin: ");
            aux2 = Console.ReadLine();

            while (!int.TryParse(aux, out inicio) || !int.TryParse(aux2, out fin))
            {
                Console.Clear();

                Console.Write("Error\ningrese año de inicio: ");
                aux = Console.ReadLine();

                Console.Write("ingrese año de fin: ");
                aux2 = Console.ReadLine();
            }

            Console.Clear();

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 4 == 0)
                    flag = true;            
                if (i % 400 == 0 && i%100==0)
                        flag = true;                

                if (flag == true)
                {
                    Console.WriteLine("{0} es un año bisiesto", i);
                    flag = false;
                }

            }

            Console.ReadKey();
        }
    }
}
