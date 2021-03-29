using NumerosBinDec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario b = "10101";//21
            NumeroDecimal d = 12;


            Console.WriteLine(b+d);//21+12= 33 /100001
            Console.WriteLine(b-d);//21-12 = 9 /1001

            Console.WriteLine("\n");

            Console.WriteLine(d+b);//21+12= 33 
            Console.WriteLine(d-b);//12-21 = -9 

            //comparaciones
            b = "1001";//9
            d = 9; //1001

            if (b == d)
                Console.Write("son iguales");
            else
                Console.WriteLine("son distintos\n");

            if (d==b)
                Console.Write("son iguales");
            else
                Console.WriteLine("son distintos");

            Console.ReadKey();
        }
    }
}
