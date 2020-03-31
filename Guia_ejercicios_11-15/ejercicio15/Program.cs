using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO. */

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char operacion;

            Console.Write("Ingrese primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIngrese segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIngrese operacion a realizar (+,-,*,/): ");
            operacion = Convert.ToChar(Console.ReadLine());

            Console.Clear();
            Console.Write("\nEl resultado de la operacion es " + Calculadora.Calcular(num1, num2, operacion));
            Console.ReadKey();
        }
    }
}
