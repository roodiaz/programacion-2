using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversores;

namespace ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario b = new NumeroBinario("1001");
            NumeroDecimal d = new NumeroDecimal(9);

            #region prueba conversiones
            //NumeroDecimal d1 = (NumeroDecimal)b;
            //Console.WriteLine(d1.GetDecimal());
            //NumeroBinario b1 = (NumeroBinario)d;
            //Console.WriteLine(b1.GetBin());
            #endregion

            #region prueba suma resta
            NumeroBinario suma = b + d;
            NumeroBinario resta = b - d;
            Console.WriteLine("suma {0}\nresta {1}\n", suma.GetBin(), resta.GetBin());

            NumeroDecimal sumaD = d + b;
            NumeroDecimal restaD = d - b;
            Console.WriteLine("suma {0}\nresta {1}", sumaD.GetDecimal(), restaD.GetDecimal());
            #endregion

            if (b == d)
                Console.Write("iguales");
            else
                Console.Write("no iguales");

            Console.ReadKey();
        }
    }
}
