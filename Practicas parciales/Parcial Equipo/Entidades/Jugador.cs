using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador: Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <param name="posicion"></param>
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
                    : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        /// <summary>
        /// 
        /// </summary>
        public float Altura
        {
            get { return this.altura; }
        }

        /// <summary>
        /// 
        /// </summary>
        public float Peso
        {
            get { return this.peso; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Posicion Posicionn 
        {
            get { return this.posicion; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"Peso: {this.Peso}\n");
            sb.Append($"Altura: {this.Altura}\n");
            sb.Append($"Posicion: {this.Posicionn}\n");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            double imc = (this.peso / Math.Pow(this.altura, 2));

            if (imc >= 18.5 && imc <= 25)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            if (this.Edad <40 )
                return true;

            return false;
        }

    }
}
