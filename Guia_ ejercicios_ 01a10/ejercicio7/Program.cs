using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;

            Console.Write("Ingresar dia/mes/año de nacimiento: ");
            DateTime fechaIngresada = DateTime.Parse(Console.ReadLine());

            int difDia = fechaActual.Day - fechaIngresada.Day;
            int difMes = fechaActual.Month - fechaIngresada.Month;
            int difAnio = fechaActual.Year - fechaIngresada.Year;

            /* 365 dias por anio, cada 4 años 1 dia mas =
              365.25 dias en 4 años

              365.25 / 12 meses = 30.44 dias promedio por mes          
           */

           double diasTrans = (difAnio * 365.25) + (difMes * 30.44) + (difDia);

           Console.Write("Dias vividos: {0}", diasTrans);
           Console.ReadKey();



           /*string dia, mes, anio;
           int diaNac, mesNac, anioNac;
           DateTime fechaActual = DateTime.Now;

           Console.Write("Ingrese dia de nacimiento: ");
           dia = Console.ReadLine();
           Console.Write("Ingrese mes de nacimiento: ");
           mes = Console.ReadLine();
           Console.Write("Ingrese año de nacimiento: ");
           anio = Console.ReadLine();

           diaNac = Convert.ToInt32(dia);
           mesNac = Convert.ToInt32(mes);
           anioNac = Convert.ToInt32(anio);

           int difDia = fechaActual.Day - diaNac;
           int difMes = fechaActual.Month - mesNac;
           int difAnio = fechaActual.Year - anioNac;

           /* 365 dias por anio, cada 4 años 1 dia mas =
              365.25 dias en 4 años

              365.25 / 12 meses = 30.44 dias promedio por mes          
           *

           double diasTrans = (difAnio*365.25) + (difMes*30.44) + (difDia);

           Console.Write("Dias vividos: {0}", diasTrans);
           Console.ReadKey(); */
        }
    }
}
