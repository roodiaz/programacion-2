using CalculoDeArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado;
            double trianguloBase;
            double trianguloAlt;
            double circulo;


            Console.Write("Ingrese opcion para calcular" + "\n\n" +
                          "1. cuadrado" + "\n" +
                          "2. triangulo" + "\n" +
                          "3. circulo" + "\n\n" +
                          "opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese lado del cuadrado: ");
                    cuadrado = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del cuadrado " + Class1.CalcularCuadrado(cuadrado));
                    break;

                case 2:
                    Console.Write("Ingrese base de triangulo: ");
                    trianguloBase = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese altura de triangulo:");
                    trianguloAlt = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del triangulo " + Class1.CalcularTriangulo(trianguloBase, trianguloAlt));
                    break;

                case 3:
                    Console.Write("Ingrese radio del circulo: ");
                    circulo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del circulo " + Class1.CalcularCirculo(circulo));
                    break;

                default:
                    Console.Write("Opcion invalida!!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
