using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        /// <summary>
        /// Constructor entidades tipo Publicacion
        /// </summary>
        /// <param name="nombre">nombre de la publicacion</param>
        public Publicacion (string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor entidades tipo Publicacion
        /// </summary>
        /// <param name="nombre">nombre de la publicacion</param>
        /// <param name="stock">stock de publicacion</param>
        public Publicacion(string nombre, int stock)
            :this(nombre)
        {
            this.Stock = stock;
        }

        /// <summary>
        /// Constructor entidades tipo Publicacion
        /// </summary>
        /// <param name="nombre">nombre de la publicacion</param>
        /// <param name="stock">stock de publicacion</param>
        /// <param name="importe">importe de publicacion</param>
        public Publicacion(string nombre, int stock, float importe)
            :this(nombre, stock)
        {
            this.importe = importe;
        }

        /// <summary>
        /// Retorna si la publicacion es a color
        /// </summary>
        protected abstract bool EsColor{ get; }

        /// <summary>
        /// Retorno si hay stock disponible
        /// </summary>
        public virtual bool HayStock
        {
            get
            {
                if (this.Importe > 0 && this.Stock > 0)
                    return true;

                return false;
            }
        }

        /// <summary>
        /// REtorna importe de publicacion
        /// </summary>
        public float Importe
        {
            get { return this.importe; }
        }

        /// <summary>
        /// REtorna cantidad e stock disponible
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if (value >= 0)
                    this.stock = value;
            }
        }

        /// <summary>
        /// Muestra informacion de la publicacion
        /// </summary>
        /// <returns>informacion de la publicacion</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"  /STOCK: {this.Stock}");
            if (this.EsColor)
            {
                sb.AppendLine($"  /COLOR: Si");
            }
            else
            {
                sb.AppendLine($"  /COLOR: No");
            }
            
            sb.AppendLine($"  /VALOR: {this.Importe}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescribe metodo ToString
        /// </summary>
        /// <returns>nombre de la publicacion</returns>
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
