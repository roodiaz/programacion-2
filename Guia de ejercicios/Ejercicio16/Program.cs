using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio16;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Federico", "Davila", "34567");
            Estudiante estudiante2 = new Estudiante("Mario", "Rampi", "85392");
            Estudiante estudiante3 = new Estudiante("Mauricio", "Davila", "91515");

            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(8);

            estudiante2.SetNotaPrimerParcial(6);
            estudiante2.SetNotaSegundoParcial(9);

            estudiante3.SetNotaPrimerParcial(5);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(
                estudiante1.Mostrar() + System.Environment.NewLine +
                estudiante2.Mostrar() + System.Environment.NewLine +
                estudiante3.Mostrar()
                );

            Console.ReadKey();
        }
    }
}
