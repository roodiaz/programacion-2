using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.*/

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool estado = false;
            int numMax;
            int centro=1;
            int totalAC = 0;
            int totalDC = 0;
            string aux;

            Console.Write("Ingrese numero mayor a 0: ");
            aux = Console.ReadLine();

            while(!int.TryParse(aux,out numMax))
            {
                Console.Clear();
                Console.Write("Ingrese numero mayor a 0: ");
                aux = Console.ReadLine();
            }

            Console.Clear();

            do
            {
                for (int i = 1; i < centro; i++)
                {
                    totalAC += i;
                }

                for (int j = centro + 1; j < centro * 2; j++)
                {
                    if (totalAC == totalDC)
                    {
                        Console.WriteLine("{0} es un centro numerico", centro);
                        estado = true;
                        break;
                    }
                    else
                    {
                        totalDC += j;
                    }
                }
                
                centro += 1; //reinicio contadores
                totalAC = 0;
                totalDC = 0;

            } while (centro < numMax);

            if (estado != true)
                Console.WriteLine("No hay centros numericos en ese rango");
                                    
            Console.ReadKey();
        }
    }
}
