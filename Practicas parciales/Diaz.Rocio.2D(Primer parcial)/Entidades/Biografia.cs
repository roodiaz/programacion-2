using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        /// <summary>
        /// constructor entidades tipo biografia
        /// </summary>
        /// <param name="nombre">nombre de la biografia</param>
        public Biografia(string nombre)
            : base(nombre)
        {

        }

        /// <summary>
        /// constructor entidades tipo biografia
        /// </summary>
        /// <param name="nombre">nombre de la biografia</param>
        /// <param name="stock">cantidad de stock de la biografia</param>
        public Biografia(string nombre, int stock)
            : base(nombre, stock)
        {
            
        }

        /// <summary>
        /// constructor entidades tipo biografia
        /// </summary>
        /// <param name="nombre">nombre de la biografia</param>
        /// <param name="stock">cantidad de stock de la biografia</param>
        /// <param name="importe">importa de la biografia</param>
        public Biografia(string nombre, int stock, float importe)
            : base(nombre, stock, importe)
        {
            
        }

        /// <summary>
        /// devuelve color de la biografia
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// devuelve true si hay stock, false sino
        /// </summary>
        public override bool HayStock
        {
            get
            {
                if (this.Stock > 0)
                    return true;

                return false;
            }
        }

        /// <summary>
        /// instancia nueva biografia y asigna nombre
        /// </summary>
        /// <param name="nombre">nombre de la biografia</param>
        public static explicit operator Biografia(string nombre)
        {
             Biografia bio = new Biografia(nombre);

            return bio;

        }
            
    }
}
