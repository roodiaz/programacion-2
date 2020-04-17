using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2,"river");
            Jugador j2 = new Jugador(411,"martn",5,2);
            Jugador j3 = new Jugador(411, "refafa", 10, 6);

            if (equipo + j2)
                Console.WriteLine("ok");
            else
                Console.WriteLine("no");

            if (equipo + j3)
                Console.WriteLine("ok");
            else
                Console.WriteLine("no");

            if (equipo + j1)
                Console.WriteLine("ok");
            else
                Console.WriteLine("no");

            Console.WriteLine(equipo.MostrarEquipo(equipo));

            Console.ReadKey();

        }
    }
}
