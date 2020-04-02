using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int max=0;
            int min=0;
            double promedio = 0;
            int cont = 0;

            for(int i=1; i<=10; i++)
            {
                Console.Write("Ingrese numero: ");
                num = Int32.Parse(Console.ReadLine());

                while(!Validacion.ValidarInt(num,-100,100))
                {
                    Console.Write("Ingrese numero: ");
                    num = Int32.Parse(Console.ReadLine());
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

                cont += num;
                promedio =(double) cont / 10;
            }

            Console.Clear();
            Console.Write("Numero max " + max + "\n" +
                          "Numero min " + min + "\n" +
                          "Promedio "   + promedio +"\n");
                           
            Console.ReadKey();
        }
    }
}
