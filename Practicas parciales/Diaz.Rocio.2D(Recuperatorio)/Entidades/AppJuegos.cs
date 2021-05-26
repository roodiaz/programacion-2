using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos:Aplicacion
    {
        /// <summary>
        /// propiedad de lectura de tamanio de app
        /// </summary>
        protected override int Tamanio
        {
            get { return this.tamanioMb; }
        }

        /// <summary>
        /// constructor de aplicaciones de juego
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sisOp"></param>
        /// <param name="tamanio"></param>
        public AppJuegos(string nombre, ESistemaOperativo sisOp, int tamanio)
            :base(nombre,sisOp,tamanio)
        {

        }
    }
}
