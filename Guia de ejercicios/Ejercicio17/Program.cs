using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseBoligrafo;

namespace Ejercicio17
{
    class Program
    {
                static void Main(string[] args)
        {
            Boligrafo bluePen = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo redPen = new Boligrafo(50, ConsoleColor.Red);
            string opcion;
            string dibujo;
            string recarga;

            do
            {
                Console.Clear();

                Console.Write(
                    "1. Azul\n" +
                    "2. Rojo\n" +
                    "3. Salir\n\n" +
                    "Opcion: "
                    );

                opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Cantidad de tinta disponible: " + bluePen.GetTinta());
                        Console.Write("\nIngrese cantidad de tinta a gastar: ");
                        short gasto = Convert.ToByte(Console.ReadLine());

                        if (bluePen.Pintar(gasto, out dibujo))
                        {
                            Console.Write("\nTinta gastada:");
                            Console.ForegroundColor = bluePen.GetColor();
                            Console.WriteLine(dibujo);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Cantidad de tinta disponible: " + bluePen.GetTinta());
                        }
                        else
                        {
                            Console.Write("\nNo hay suficiente tinta, aplicar recarga de tinta? S/N: ");
                            recarga = Console.ReadLine().ToUpper();
                            
                            while(recarga != "S" && recarga != "N")
                            {
                                Console.Write("\nAplicar recarga de tinta? S/N: ");
                                recarga = Console.ReadLine();
                            }

                            if(recarga == "S")
                            {
                                Console.WriteLine("\n\nAplicando recarga de tinta...");
                                bluePen.Recargar();
                                Console.WriteLine("\nCantidad de tinta actual: " + bluePen.GetTinta());
                            }
                            else
                            {
                                break;
                            }                          
                        }
                        break;

                    case "2":
                        Console.WriteLine("Cantidad de tinta disponible: " + redPen.GetTinta());
                        Console.Write("\nIngrese cantidad de tinta a gastar: ");
                        short gastoRed = Convert.ToByte(Console.ReadLine());

                        if (redPen.Pintar(gastoRed, out dibujo))
                        {
                            Console.Write("\nTinta gastada:");
                            Console.ForegroundColor = redPen.GetColor();
                            Console.WriteLine(dibujo);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Cantidad de tinta disponible: " + redPen.GetTinta());
                        }
                        else
                        {
                            Console.Write("\nNo hay suficiente tinta, aplicar recarga de tinta? S/N: ");
                            recarga = Console.ReadLine().ToUpper();

                            while (recarga != "S" && recarga != "N")
                            {
                                Console.Write("\nAplicar recarga de tinta? S/N: ");
                                recarga = Console.ReadLine();
                            }

                            if (recarga == "S")
                            {
                                Console.WriteLine("\n\nAplicando recarga de tinta...");
                                redPen.Recargar();
                                Console.WriteLine("\nCantidad de tinta actual: " + redPen.GetTinta());
                            }
                            else
                            {
                                break;
                            }
                        }

                        break;
                }

                Console.ReadKey();

            } while (opcion != "3");

        }

    }
}
