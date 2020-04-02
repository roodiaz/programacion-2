using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores. */

namespace Clase02_ejercicios
{
    public class Validacion //nombre de clase con mayuscula primero
    {
        // estatico
        public static bool ValidarInt(int valor, int min, int max) //nombre del metodo con mayuscula primero
        {
            if (valor > max || valor < min)
                return false;

            return true;
            
        }
    }
}
