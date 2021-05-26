using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Factura f = new Factura(500);
            Recibo r = new Recibo(500);

            c += f;
            c += r;

            Console.ReadKey();
        }
    }
}
