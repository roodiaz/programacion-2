using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
           : base(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca,Tipo.Vidrio, contenidoML)
        {
            
        }   

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Medida: {Cerveza.MEDIDA}");
            sb.Append(base.ToString());

            return sb.ToString();
        }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public override int ServirMedida()
        {
            int medida = (int)(MEDIDA * 0.8);

            if (medida <= this.contenidoML)
            {
               this.contenidoML = this.contenidoML - medida;
            }
            else if(medida > this.contenidoML)
            {
                this.contenidoML = 0;
            }

            return this.contenidoML;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)//return tipo
        {
            return cerveza.tipo;
        }

    }
}
