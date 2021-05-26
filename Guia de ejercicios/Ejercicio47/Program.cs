using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<Equipo> futbol = new Torneo<Equipo>("Primera division");
            Torneo<Equipo> basquet = new Torneo<Equipo>("NBA");

            EquipoFutbol f1 = new EquipoFutbol("river", DateTime.Today);
            EquipoFutbol f2 = new EquipoFutbol("independiente", DateTime.Today);
            EquipoFutbol f3 = new EquipoFutbol("san lorenzo", DateTime.Today);

            EquipoBasquet b1 = new EquipoBasquet("spurs", DateTime.Today);
            EquipoBasquet b2 = new EquipoBasquet("chicago", DateTime.Today);
            EquipoBasquet b3 = new EquipoBasquet("lakers", DateTime.Today);

            basquet += b1;
            basquet += b2;
            basquet += b3;
            basquet += b1;  //repetido

            futbol += f1;
            futbol += f2;
            futbol += f3;
            futbol += f1;  //repetido          

            Console.WriteLine("########### Futbol ########## ");
            Console.WriteLine(futbol.Mostrar());
            Console.WriteLine(futbol.JugarPartido);

            Console.WriteLine("########### basquet ########## ");
            Console.WriteLine(basquet.Mostrar());
            Console.WriteLine(basquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
