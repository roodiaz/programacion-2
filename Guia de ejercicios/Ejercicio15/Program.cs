using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operacion;

            Console.Write("Ingrese primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese operacion a realizar (+,-,*,/): ");
            operacion = Convert.ToChar(Console.ReadLine());

            Console.Clear();
            Console.Write("\nEl resultado de la operacion es {0}",Class1.Calcular(num1,num2,operacion));
            Console.ReadKey();
        }
    }
}
