using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;

        public Ingrediente (string descripcion, int cantidad)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }

        public int Cantidad
        {
            get { return this.cantidad; }
        }

        public abstract string Proceso { get; }

        public abstract string UnidadDeMedida { get; }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.descripcion} en una cantidad de {this.Cantidad} {this.UnidadDeMedida}");
            sb.AppendLine($"Procesar {this.Proceso}\n");

            return sb.ToString();
        }
    }
}
