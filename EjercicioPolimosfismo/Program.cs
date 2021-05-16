using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Calculadora_de_formas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> lista = new List<Figura>();
            Circulo circulo = new Circulo(15);
            Cuadrado cuadrado = new Cuadrado(6);
            Rectangulo rectangulo = new Rectangulo(6, 4);

            lista.Add(circulo);
            lista.Add(cuadrado);
            lista.Add(rectangulo);

            foreach (Figura figura in lista)
            {
                Console.WriteLine($"========= Figura {lista.IndexOf(figura) + 1} ==========");
                Console.WriteLine(figura.GetType());
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine($"Área: {Math.Round(figura.CalcularSuperficie(), 2)}");
                Console.WriteLine($"Perímetro: {Math.Round(figura.CalcularPerimetro(), 2)}");
                Console.WriteLine($"========== Figura {lista.IndexOf(figura) + 1} ===========\n");
            }

            Console.ReadKey();
        }
    }
}
