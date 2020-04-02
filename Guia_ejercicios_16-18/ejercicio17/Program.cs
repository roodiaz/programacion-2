using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinta;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {

            Boligrafo bluePen = new Boligrafo(0, ConsoleColor.Blue);
            Boligrafo redPen = new Boligrafo(5, ConsoleColor.Red);
            string opcion;
            string dibujo;

            do
            {
                Console.Write("1. Azul\n2. Rojo\n\nOpcion: ");
                opcion = Console.ReadLine();

            } while (!(opcion != "1" || opcion != "2"));

            Console.Clear();

            switch(opcion)
            {
                case "1":
                    Console.WriteLine("Cantidad de tinta disponible: " + bluePen.GetTinta());
                    Console.Write("\nIngrese cantidad de tinta a gastar: ");
                    short gasto = Convert.ToByte(Console.ReadLine());

                    if (bluePen.Pintar(gasto, out dibujo))
                    {
                        Console.Write("\nDibujo:");
                        Console.ForegroundColor = bluePen.GetColor();
                        Console.WriteLine(dibujo);
                    }
                    else                   
                        Console.Write("\nNo hay suficiente tinta");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\nAplicando recarga de tinta...");
                    bluePen.Recargar();
                    Console.WriteLine("\nCantidad de tinta actual: " + bluePen.GetTinta());

                    break;

                case "2":
                    Console.WriteLine("Cantidad de tinta disponible: " + redPen.GetTinta());
                    Console.Write("\nIngrese cantidad de tinta a gastar: ");
                    short gastoRed = Convert.ToByte(Console.ReadLine());

                    if (redPen.Pintar(gastoRed, out dibujo))
                    {
                        Console.Write("\nDibujo:");
                        Console.ForegroundColor = redPen.GetColor();
                        Console.WriteLine(dibujo);
                    }
                    else
                        Console.Write("\nNo hay suficiente tinta");

                    Console.WriteLine("\n\nAplicando recarga de tinta...");
                    redPen.Recargar();
                    Console.WriteLine("\nCantidad de tinta actual: " + redPen.GetTinta());
                    break;
            }

            Console.ReadKey();
        }
    }
}
