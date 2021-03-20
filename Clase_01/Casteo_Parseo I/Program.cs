using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Casteo Explicito: Podría implicar pérdida de información y 
            necesito usar el operador de casteo "(int), por ejemplo"

    Casteo Implícito: No debería implicar pérdida de información 
            y no estoy obligado a usar el operador de casteo
     
*/
namespace _1._Primera_clase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            int valorEntero = 10;

            string numeroString = Console.ReadLine();
            //readline levanta lo que ingresa el usuario, siempre devuelve un string

            //parseo: interprentar un texto y convertirlo a otra cosa
            int suma = valorEntero + int.Parse(numeroString);

            Console.WriteLine(suma);


            /*-----------------------------------------------------------*/


            float numeroDecimal = (float)25.35;
            double numDec = 25.6;
            // double numero mas grande que soporta mayor precision


            //casteo explicito: convertir un tipo a otro tipo compatible(ej float a int, son numeros)
            int numeroEntero = (int)numeroDecimal;

            Console.WriteLine(numeroEntero);
            Console.WriteLine(numeroDecimal);

            //casteo implicito: no hace falta indicar entre () la conversion
            numeroDecimal = suma;


            //ctrl F5
            Console.ReadKey();
        }

    }
}

