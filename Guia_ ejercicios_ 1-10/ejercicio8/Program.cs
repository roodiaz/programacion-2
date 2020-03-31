using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas. */

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables        
            char seguir;
            int cont = 0;
            double []valorHora=new double[30];
            double []antiguedad = new double[30];
            double []horasTrabajadas = new double[30];
            string []nombre = new string[30];

            //calculos
            double[] totalDesc = new double[30];// total bruto *13 \100
            double[] totalNeto = new double[30];// total bruto - total descuento
            double[] totalBruto = new double[30];//(precio hora*cantidad horas)+(150*años antiguedad)

            for (int i=0; i<30; i++)
            {
                //pedir datos
                Console.Write("Ingrese nombre de empleado: ");
                nombre[i] = Console.ReadLine();

                Console.Write("Ingrese valor por hora: ");
                valorHora[i] = double.Parse(Console.ReadLine());

                Console.Write("Ingrese antiguedad(años): ");
                antiguedad[i] = double.Parse(Console.ReadLine());

                Console.Write("Ingrese horas trabajas en el mes: ");
                horasTrabajadas[i] = double.Parse(Console.ReadLine());

                //calculos             
                totalBruto[i] = (valorHora[i] * horasTrabajadas[i]) + (antiguedad[i]* 150);
                totalDesc[i]=totalBruto[i]*13 /100;
                totalNeto[i] = totalBruto[i] - totalDesc[i];

                Console.Write("\n\nSeguir ingresando datos? s/n: ");
                seguir = char.Parse(Console.ReadLine());

                if (seguir== 'n' || seguir == 'N')
                    break;

                cont++;
                Console.Clear();
            }

            Console.Clear();
            Console.Write("     ----- DATOS DE EMPLEADOS -----\n\n");
            

            for (int i=0; i<=cont; i++)
            {
                Console.Write("Nombre: "     + nombre[i]     + "\n" +
                              "Antiguedad: " + antiguedad[i] + "\n" +
                              "Valor/Hora: " + valorHora[i]  + "\n" +
                              "Bruto: "      + totalBruto[i] + "\n" +
                              "Neto: "       + totalNeto[i]  + "\n" +
                              "Descuentos: " + totalDesc[i]  + "\n");
            }

            Console.ReadKey();

        }
    }
}
