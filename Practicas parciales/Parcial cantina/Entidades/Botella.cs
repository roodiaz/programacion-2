using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        
        protected int capacidadML;//mililitros
        protected int contenidoML;//mililitros
        protected string marca;

        public enum Tipo { Plastico, Vidrio };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        protected Botella(int capacidadML, string marca, int contenidoML)
        {
            if(capacidadML < contenidoML)
            {
                contenidoML = capacidadML;
            }

            this.capacidadML = capacidadML;
            this.marca = marca;
            this.contenidoML = contenidoML;
        }

        /// <summary>
        /// 
        /// </summary>
        public int CapacidadLitros
        {
            get 
            { 
                return this.capacidadML / 1000; 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float PorcentajeContenido
        {
            get { return (this.contenidoML * 100) / this.capacidadML; }
        }
        public int Contenido
        {
            get { return this.contenidoML; }

            set { this.contenidoML = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract int ServirMedida();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Capacidad de botella {CapacidadLitros}");
            sb.Append($"Contenido de botella: {PorcentajeContenido}");
            sb.Append($"Marca de bebida: {this.marca}");

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GenerarInforme();
        }


    }
}
