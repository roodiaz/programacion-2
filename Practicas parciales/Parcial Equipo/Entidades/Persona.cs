using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool ValidarAptitud();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.Nombre}\n");
            sb.Append($"Apellido: {this.Apellido}\n");
            sb.Append($"Edad: {this.Edad}\n");
            sb.Append($"Dni: {this.Dni}\n");

            return sb.ToString();
        }
    }
}
