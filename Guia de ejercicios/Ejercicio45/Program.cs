using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                OtraClase aux = new OtraClase();
                aux.CapturarExMiClase();
            }
            catch (MiExcepcion e)
            {
                //e.	MiException será capturada en el Main,
                // mostrando el mensaje de error que esta almacena por pantalla
                // y los mensajes de todas las excepciones almacenadas en sus innerException.
                Console.WriteLine(e.Message);
                Exception ie = e.InnerException; //guardo la IE

                while (!Object.ReferenceEquals(ie, null))
                {
                    Console.WriteLine(ie.Message);
                    ie = ie.InnerException;
                }
            }

            Console.ReadKey();
        }

    }
}
