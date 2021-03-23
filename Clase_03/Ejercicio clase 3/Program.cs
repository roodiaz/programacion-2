using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veterinaria;

namespace Ejercicio_clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes cliente = new Clientes("rocio", "diaz");
            Mascotas perro = new Mascotas("perro", "firulais", new DateTime(2015, 08, 16));
            Mascotas gato = new Mascotas("gato", "uma", new DateTime(2018, 04, 19));
            Vacuna vacuna = new Vacuna("rabia");
            perro.AgregarVacuna(vacuna);


            cliente.AgregarMascota(perro);
            cliente.AgregarMascota(gato);

            Console.WriteLine(cliente.MostrarDatos());


            Console.ReadKey();

        }
    }
}
