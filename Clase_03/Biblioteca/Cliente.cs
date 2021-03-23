using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        /*
            De instancia o no estático --> this.
            Estático --> NombreDeLaClase.

            si declaro una clase estatica todos sus miembros tienen que ser estaticos, 
            no se pueden generar objetos a partir de clases estaticas
            desde lo que no es estático puedo acceder a lo estático, pero al revés no

            El constructor por defecto es el constructor que tienen todas las clases si no se declara otro explícitamente. 
            Es público y no recibe argumentos. Inicializa todos los atributos en su valor por defecto.
         
        */

        private string nombre;
        private string apellido;

        //CONSTRUCTOR: llevan el mismo nombre que la clase
        public Cliente(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }


        //SETTERS: modificar atributos
        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        //GETTER: leer atributos y/o devolver algo
        public string ObtenerNombreCompleto()
        {
            //return nombre + " " + apellido;
            return $"{this.nombre} {this.apellido}";

        }
    }
}
