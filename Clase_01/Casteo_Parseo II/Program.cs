using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casteo_parseo_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            string dato = Console.ReadLine();

            float valorFloat = float.Parse(dato);

            Console.WriteLine(QuitarParteEntera(valorFloat));
            Console.WriteLine(valorFloat);


            Console.ReadKey();
        }

        static float QuitarParteEntera(float numero)
        {
            //casteo a entero
            int numeroEntero = (int)numero;

            //resto el entero
            return numero - numeroEntero;
        }
    }
}

