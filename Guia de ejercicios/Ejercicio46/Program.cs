using Ejercicio46;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia CompetenciaAutos = new Competencia(10, 8, Competencia.TipoCompetencia.F1);
            Competencia CompetenciaMotos = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            MotoCross m1 = new MotoCross(1, "Honda", 160);


            Console.WriteLine("#### Agrego autos ####\n");
            try
            {
                if (CompetenciaAutos + f1)
                    Console.WriteLine($"Agregado a la competencia");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine($"No Agregado a la competencia");
            }
           
            /* --------------------------------------------------------------------- */
            Console.WriteLine("\n\n#### Agrego Motos ####\n");        
            try
            {
                if (CompetenciaMotos + m1)
                    Console.WriteLine($"Agregado a la competencia");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine($"No Agregado a la competencia");
            }
            /*-----------------------------------------------------------*/
            Console.WriteLine("\n\n#### Agrego auto a competencia moto ####\n");         
            try
            {
                if (CompetenciaMotos + f1)
                    Console.WriteLine($"Agregado a la competencia");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine($"No Agregado a la competencia");
            }

            /*-----------------------------------------------------------*/
            Console.WriteLine("\n\n#### Agrego moto a competencia auto ####\n");         
            try
            {
                if (CompetenciaAutos + m1)
                    Console.WriteLine($"Agregado a la competencia");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine($"No Agregado a la competencia");
            }

            Console.ReadKey();
        }
    }
}
