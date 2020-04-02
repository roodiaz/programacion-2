using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cuadrado;
            int cubo;
            string aux;

            Console.Write("Ingrese numero mayor a 0: ");
            aux = Console.ReadLine();

            while(!int.TryParse(aux, out num) || num < 0)
            {
                Console.Clear();
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Ingrese numero mayor a 0: ");
                aux = Console.ReadLine();
            }
            
            cuadrado =(int) Math.Pow(num, 2); // elevo numero al cuadrado
            cubo = (int )Math.Pow(num, 3); // elevo numero al cubo

            Console.Clear();

            Console.Write("{0} elevado al cuadrado es {1}\n{0} elevado al cubo es {2}",num,cuadrado,cubo);     
            Console.ReadKey();
        }
    }
}
