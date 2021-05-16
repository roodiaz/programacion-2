using BibliotecaClases;
using Clases;
using System;
using System.Text;

namespace EjercicioGuia37
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            // Mi central
            Centralita c = new Centralita("rocio center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.

            //La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            Console.WriteLine("AÑADO ll ");
            // c.Llamadas.Add(l1);
            try
            {
                c = c + l1;
            }
            catch (CentralitaException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},{1},{2}", ex.Message, ex.NombreClase, ex.NombreMetodo);
                Console.WriteLine(sb.ToString());
            }


            //repito llamada
            try
            {              
                c = c + l1;
            }
            catch (CentralitaException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},{1},{2}", ex.Message, ex.NombreClase, ex.NombreMetodo);
                Console.WriteLine(sb.ToString());
            }          

            Console.WriteLine("AÑADO 12 ");
            //c.Llamadas.Add(l2);
            
            try
            {
                c = c + l2;
            }
            catch (CentralitaException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},{1},{2}", ex.Message, ex.NombreClase, ex.NombreMetodo);
                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("AÑADO l3 ");
            //c.Llamadas.Add(l3);
            
            try
            {
                c = c + l3;
            }
            catch (CentralitaException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0},{1},{2}", ex.Message, ex.NombreClase, ex.NombreMetodo);
                Console.WriteLine(sb.ToString());
            }

            //Console.WriteLine("AÑADO l4 ");
            ////c.Llamadas.Add(l4);      
            //try
            //{
            //    c = c + l4;
            //}
            //catch (CentralitaException ex)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendFormat("{0},{1},{2}", ex.Message, ex.NombreClase, ex.NombreMetodo);
            //    Console.WriteLine(sb.ToString());
            //}

            Console.WriteLine("ORDENO");

            c.OrdenarLlamadas();

            Console.WriteLine(c.ToString());

            Console.WriteLine("_______Ganancia total provincial__________");
            Console.WriteLine(c.GananciaPorProvincial);
            Console.WriteLine("_______Ganancia total Local:___");
            Console.WriteLine(c.GananciaPorLocal);
            Console.WriteLine("_______Ganancia total__________");
            Console.WriteLine(c.GananciaPorTotal);

            Console.ReadKey();
        }
    }
}