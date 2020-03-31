using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor. */

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char salir;
            int num;
            int suma=0;

            do
            {              
                Console.Write("Ingrese numero: ");
                num = Int32.Parse(Console.ReadLine());

                suma += num;

                Console.Write("Seguir ingresando numeros? s/n: ");
                salir = char.Parse(Console.ReadLine());
               
                Console.Clear();

            } while(ValidarRespuesta.ValidaS_N(salir));

            Console.Write("Suma total " + suma);
            Console.ReadKey();
        }
    }
}
