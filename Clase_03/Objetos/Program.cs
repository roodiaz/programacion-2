using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente("rocio","diaz");

            string nombreCompleto= cliente.ObtenerNombreCompleto();
            Console.WriteLine(nombreCompleto);

            Console.ReadKey();
           
        }
    }
}
