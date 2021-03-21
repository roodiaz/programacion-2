using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio numero 7";

            DateTime fechaActual = DateTime.Now;
            DateTime fechaIngresada;
            int difDia;
            int difMes;
            int difAño;
            double diasVividos;

            Console.Write("ingrese fecha de nacimiento (formato dd/mm/aaaa): ");
            fechaIngresada = DateTime.Parse(Console.ReadLine());

            difDia =fechaActual.Day - fechaIngresada.Day;
            difMes = fechaActual.Month - fechaIngresada.Month;
            difAño = fechaActual.Year - fechaIngresada.Year;

            /*
              366 dias cada 4 años
              365*3 + 366 = 1461 dias cada 4 años
              1461 dias/4años=365,25
             
              365,25 dias /12 meses=30,44 dias promedio por mes
             */

            diasVividos = (difAño * 365.25) + (difMes * 30.44) + difDia;

            Console.WriteLine("total de dias vividos: {0}", diasVividos);
            Console.ReadKey();
        }
    }
}
