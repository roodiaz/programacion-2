using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            #region Datos alumnos
            alumno1.nombre = "Lucas";
            alumno1.apellido = "Sosa";
            alumno1.legajo = 4314;

            alumno2.nombre = "Florencia";
            alumno2.apellido = "Simon";
            alumno2.legajo = 6424;

            alumno3.nombre = "Rocio";
            alumno3.apellido = "Diaz";
            alumno3.legajo = 5235;
            #endregion

            
            alumno1.Estudiar(2,4);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());

            alumno2.Estudiar(9,4);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());

            alumno3.Estudiar(7, 9);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
