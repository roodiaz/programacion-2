using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main(). */

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado;
            double trianguloBase;
            double trianguloAlt;
            double circulo;
         

            Console.Write("Ingrese opcion para calcular" +"\n\n"+
                          "1. cuadrado" + "\n"+
                          "2. triangulo"+ "\n"+
                          "3. circulo"  + "\n\n"+
                          "opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese lado del cuadrado: ");
                    cuadrado = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del cuadrado " + CalculoDeArea.CalcularCuadraro(cuadrado));
                    break;

                case 2:
                    Console.Write("Ingrese base de triangulo: ");
                    trianguloBase = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese altura de triangulo:");
                    trianguloAlt = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del triangulo " + CalculoDeArea.CalcularTriangulo(trianguloBase,trianguloAlt));
                    break;

                case 3:
                    Console.Write("Ingrese radio del circulo: ");
                    circulo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nArea del circulo " + CalculoDeArea.CalcularCirculo(circulo));
                    break;

                default:
                    Console.Write("Opcion invalida!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
