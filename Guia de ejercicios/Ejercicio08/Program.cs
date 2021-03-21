using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 08";

            //variables datos
            double[] valorHora = new double[15];
            double[] antiguedad = new double[15];
            double[] cantHoras = new double[15];
            string[] nombreEmp = new string[15];

            //variables calculos
            double[] totalBruto = new double[15];//(valorHora*cantHoras)+(antiguedad*150)
            double[] totalNeto = new double[15];//totalBruto-totalDescuento
            double[] totalDescuento = new double[15];//totalBruto*13/100

            char seguir;
            int cont = 0;

            Console.Write("------ INGRESO DATOS DE EMPLEADO ------\n\n");
            
            for(int i = 0; i <= 15; i++)
            {
                //ingreso de datos
                Console.Write("nombre: ");
                nombreEmp[i] = Console.ReadLine();
                Console.Write("valor hora: ");
                valorHora[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("cantidad horas trabajadas: ");
                cantHoras[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("antiguedad: ");
                antiguedad[i] = Convert.ToInt32(Console.ReadLine());

                //calculos
                totalBruto[i] = (valorHora[i] * cantHoras[i]) + (150 * antiguedad[i]);
                totalDescuento[i] = (totalBruto[i] * 13) / 100;
                totalNeto[i] = totalBruto[i] - totalDescuento[i];

                Console.Write("\nseguir ingresando datos? s/n: ");
                seguir = char.Parse(Console.ReadLine());

                if (char.ToLower(seguir) == 'n')
                    break;

                Console.Clear();
                cont++;
                    
            }

            Console.Clear();
            Console.Write("------ DATOS EMPLEADOS ------\n\n");

            for(int i=0; i<=cont; i++)
            {
                Console.Write("nombre: {0}\n" +
                              "valor x hora: {1}\n" +
                              "total bruto: {2}\n" +
                              "total descuentos(13%): {3}\n" +
                              "total neto: {4}\n",
                               nombreEmp[i],valorHora[i],totalBruto[i],
                               totalDescuento[i],totalNeto[i]);
            }

            Console.ReadKey();
        }
    }
}
