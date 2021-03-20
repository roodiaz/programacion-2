using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "ejercicio numero 5";

            int num;
            string valor;
            int sumaAtras=0;
            int sumaDelante=0;
            int centro = 1;
            bool flag = false;


            //ingreso de datos
            Console.Write("ingrese numero para calcular los centros: ");
            valor = Console.ReadLine();

            while (!int.TryParse(valor, out num) || num<1)
            {
                Console.Clear();
                Console.Write("ERROR\ningrese numero para calcular los centros: ");
                valor = Console.ReadLine();
            }


            //calculo de centros
            while (centro < num)
            {
                centro++;
                sumaAtras = 0;
                sumaDelante = 0;

                for (int i=1; i < centro; i++)
                {
                    sumaAtras +=  i;
                }

                for(int j=centro+1; j<=sumaAtras; j++)
                {
                    if (sumaAtras==sumaDelante||sumaDelante > sumaAtras)
                        break;

                    sumaDelante += j;
                }

                if (sumaAtras == sumaDelante)
                {
                    Console.WriteLine("Es centro numerico: {0}", centro);
                    flag = true;
                }                                
             
            }

            if (!flag)
                Console.WriteLine("\nno hay centros numericos en ese rango");

            Console.ReadKey();
        }
    }
}
