using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese una frase: ");
            string frase = Console.ReadLine();

            Console.Write("ingrese letra a buscar: ");
            char caracter = Console.ReadKey().KeyChar;

            Console.Clear();


            int cantidad = contadorLetras2(frase, caracter);

            Console.WriteLine("la cantidad de letras {0} en el texto {1} es de {2}", caracter, frase, cantidad);

            Console.ReadKey();

        }

        static int contadorLetras(string texto, char letra)
        {
            int cont = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.ToCharArray()[i] == letra)
                {
                    cont++;
                }
            }

            return cont;

        }

        static int contadorLetras2(string texto, char letra)
        {
            int cont = 0;

            foreach (char item in texto.ToCharArray())
            {
                if (Char.ToUpper(item) == Char.ToUpper(letra))
                {
                    cont++;
                }
            }

            return cont;

        }

        static int contadorLetras3(string texto, char letra)
        {
            int cont = 0;
            int i = 0;

            while (i < texto.Length)
            {
                if (texto.ToCharArray()[i] == letra)
                {
                    cont++;
                }
            }

            return cont;

        }
    }
}

