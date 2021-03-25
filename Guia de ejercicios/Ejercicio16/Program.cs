using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();

            a1.nombre = "rocio";
            a1.apellido = "diaz";
            a1.legajo = 141415;

            a2.nombre = "florencia";
            a2.apellido = "simon";
            a2.legajo = 13551;

            a1.Estudiar(5, 7);
            a1.CalcularFinal();
            a2.Estudiar(3, 8);
            a2.CalcularFinal();

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());


            Console.ReadKey();
        }
    }
}
