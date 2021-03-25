using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using ejercicio19;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();

            Console.WriteLine("{0} {1}", s1.Sumar(5, 10), s1.Sumar("lucas", "sosa"));
            Console.WriteLine("{0} {1}", s2.Sumar(2, 8), s2.Sumar("rocio", "diaz"));

            //usa sobrecaraga de operadores para comparar dos objetos
            if (s1 | s2)
                Console.Write("funciona\n");
            else
                Console.Write("no funciona\n");

            //muestra atributos de s(cantidad de sumas);
            Console.Write(s1 + s2);

            Console.ReadKey();

        }
    }
}
