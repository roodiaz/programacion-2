using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamaño;

        public Planta(string nombre, int tamaño)
        {
            this.nombre = nombre;
            this.tamaño = tamaño;
        }

        public int Tamaño
        {
            get { return this.tamaño; }
        }

        public abstract bool TieneFlores { get; }

        public abstract bool TieneFrutos { get; }

        public virtual string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre': {this.nombre} - tiene un tamaño de {this.Tamaño}");

            if (this.TieneFlores)
                sb.Append(String.Format("Tiene flores"));
            else
                sb.Append(String.Format("No tiene flores\n"));

            if (this.TieneFrutos)
                sb.Append(String.Format("Tiene frutos"));
            else
                sb.Append(String.Format("No tiene frutos"));

            sb.Append("\n\n");

            return sb.ToString();
        }

    }
}
