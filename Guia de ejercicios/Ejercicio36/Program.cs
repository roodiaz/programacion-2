using Ejercicio36;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia CompetenciaAutos = new Competencia(10, 8, Competencia.TipoCompetencia.F1);
            Competencia CompetenciaMotos = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f2 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f3 = new AutoF1(7, "McLaren", 510);

            MotoCross m1 = new MotoCross(1, "Honda", 160);
            MotoCross m2 = new MotoCross(1, "Honda", 160);
            MotoCross m3 = new MotoCross(69, "Yamaha", 159);


            Console.WriteLine("#### Agrego autos ####\n");
            if (CompetenciaAutos + f1)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            if (CompetenciaAutos + f3)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            //Agrego auto repetido
            if (CompetenciaAutos + f2)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            /* --------------------------------------------------------------------- */
            Console.WriteLine("\n\n#### Agrego Motos ####\n");

            if (CompetenciaAutos + m1)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");


            if (CompetenciaMotos + m1)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            if (CompetenciaMotos + m3)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");


            if (CompetenciaMotos + m2)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            /*-----------------------------------------------------------*/

            Console.WriteLine("\n\n#### Agrego auto a competencia moto ####\n");
            if (CompetenciaMotos + f1)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            Console.WriteLine("\n\n#### Agrego moto a competencia auto ####\n");
            if (CompetenciaAutos + m1)
                Console.WriteLine($"Agregado a la competencia");
            else
                Console.WriteLine($"No Agregado a la competencia");

            /*----------------------------------------------------------------------*/
            Console.WriteLine("\n\n### DATOS COMPETENCIAS #### \n");


            Console.WriteLine("Autos");
            Console.WriteLine(CompetenciaAutos.MostrarDatos());

   
            Console.WriteLine("Motos");
            Console.WriteLine(CompetenciaMotos.MostrarDatos());


            Console.ReadKey();
        }
    }
}
