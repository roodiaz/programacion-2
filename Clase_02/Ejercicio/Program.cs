using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string stringNum;
            int max=0;
            int min=0;
            int cont=0;
            double promedio=0;          

            for(int i=1; i<=10; i++)
            {
                Console.Write("Ingrese numero {0}: ",i);
                stringNum = Console.ReadLine();

                if (int.TryParse(stringNum, out num))
                {
                    while (Class1.Validar(num, -100, 100) == false)
                    {
                        Console.Write("Error. Ingrese numero {0}: ", i);
                        stringNum = Console.ReadLine();

                        if (int.TryParse(stringNum, out num))
                            if (Class1.Validar(num, -100, 100))
                                break;

                    }

                    if (i == 1)
                    {
                        max = num;
                        min = num;
                    }
                    else if (num <= min)
                        min = num;
                    else
                        max = num;


                    cont += num;
                    promedio = (double)cont / 10;

                }

            }

            Console.Clear();

            Console.Write("numero mayor: {0} \n" +
                          "numero menor: {1} \n" +
                          "promedio total: {2} \n",max,min,promedio);

            Console.ReadKey();
        }
    }
}
