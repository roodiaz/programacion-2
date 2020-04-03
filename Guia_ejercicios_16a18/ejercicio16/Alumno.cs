using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
nombre, apellido y legajo a cada uno de ellos.
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado". */

namespace ejercicio16
{
    class Alumno
    {
        #region variables
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;
        #endregion

        static Random notaAleatoria;

        static Alumno()
        {        
           notaAleatoria = new Random();           
        }

        public void Estudiar(byte notaUno, byte notaDos) //para acceder a los atributos privados
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }

        public void CalcularFinal()// Calcula la nota final aleatoriamente 
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = notaAleatoria.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
               
        }

        public string Mostrar()
        {
            string retorno = "Apellido: " + apellido + "\n" +
                             "Nombre: " + nombre + "\n" +
                             "Legajo: " + legajo + "\n" +
                             "Nota 1: " + nota1 + "\n" +
                             "Nota 2: " + nota2 + "\n";

            if (this.notaFinal != -1)
            {
                retorno = retorno + "Nota final: " + notaFinal+ "\n\n";                      
            }
            else
            {
                retorno = retorno + "Nota final: Alumno desaprobado\n\n";
            }
            return retorno;
        }


    }
    
}
