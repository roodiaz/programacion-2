using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {

        private const int MEDIDA = 400;//mililitros

        /// <summary>
        /// 
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(capacidadML, marca, contenidoML)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Medida: {MEDIDA}");
            sb.Append(base.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medida"></param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {

            if (medida <= this.contenidoML)
            {
                this.contenidoML = (this.contenidoML - medida);
            }
            else if (medida > this.contenidoML)
            {
                this.contenidoML = 0;
            }


            return this.contenidoML;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()//tiene que devolver lo que queda de contenido en botella
        {
            return (this.ServirMedida(MEDIDA));
        }


    }
}
