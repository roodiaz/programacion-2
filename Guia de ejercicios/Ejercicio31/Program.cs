using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            PuestoDeAtencion puesto = new PuestoDeAtencion(PuestoDeAtencion.Puesto.caja1);

            Negocio negocio = new Negocio("he");

            Cliente clientes = new Cliente(0, "E");

            string a = "A";

            for (int i = 0; i < 10; i++)
            {
                clientes = new Cliente(i, a += a);
                Console.WriteLine("{0}", clientes.Nombre);
                Console.WriteLine(negocio.Cliente);
                negocio.Cliente = clientes;
            }

            Console.ReadKey();

        }
    }
}
