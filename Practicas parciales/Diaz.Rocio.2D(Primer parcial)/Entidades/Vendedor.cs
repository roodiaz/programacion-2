using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        /// <summary>
        /// Constructor entidades tipo vendedor
        /// </summary>
        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        /// <summary>
        /// Constructor entidades tipo vendedor
        /// </summary>
        /// <param name="nombre">nombre del vendedor</param>
        public Vendedor(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Recorre la lisa de ventas para mostrar informacio
        /// </summary>
        /// <param name="v">lista a recorrer</param>
        /// <returns>el informe de ventas</returns>
        public static string InformeDeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            double ganancias = 0;

            sb.AppendLine($"NOMBRE VENDEDOR: {v.nombre}");
            sb.AppendLine("VENTAS: ");

            foreach (Publicacion item in v.ventas)
            {
                sb.AppendLine(item.Informacion());
                ganancias += item.Importe;
            }

            sb.AppendLine($"GANANCIAS TOTALES: {ganancias}");


            return sb.ToString();
        }

        /// <summary>
        /// agrega una nueva pubalicion a la lsita e ventas
        /// </summary>
        /// <param name="v">lista de ventas</param>
        /// <param name="p">publicacion a vender</param>
        /// <returns>true si pudo agregar publiacion a las ventas, false sino</returns>
        public static bool operator +(Vendedor v, Publicacion p)
        {
            if (p.Stock >0)
            {
                
                p.Stock--;
                v.ventas.Add(p);
                return true;
            }

            return false;
        }
    }
}
