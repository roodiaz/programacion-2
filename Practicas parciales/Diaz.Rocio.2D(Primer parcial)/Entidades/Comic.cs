using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic: Publicacion
    {
        private bool esColor;

        /// <summary>
        /// constructor entidades tipo comic
        /// </summary>
        /// <param name="nombre">nombre del comic</param>
        /// <param name="esColor">color del comic</param>
        /// <param name="stock">stock del comic</param>
        /// <param name="valor">importe del comic</param>
        public Comic(string nombre, bool esColor, int stock, float valor)
            : base(nombre, stock,valor)
        {
            this.esColor = esColor;
        }

        /// <summary>
        /// retorne true si es a color
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }
    }
}
