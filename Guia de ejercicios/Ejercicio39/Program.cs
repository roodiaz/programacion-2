using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            SobreSobreescrito test = new SobreSobreescrito();

            Console.WriteLine(test.MiPropiedad);
            Console.WriteLine(test.MiMetodo());


            Console.ReadKey();
        }
    }
}
