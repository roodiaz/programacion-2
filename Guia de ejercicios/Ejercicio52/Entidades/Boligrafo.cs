using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }


        // Escribir reducirá la tinta en 0.3 por cada carácter escrito.
        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)(texto.Length * 0.3);
            return new EscrituraWrapper(texto, this.colorTinta);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2}", "Boligrafo", this.Color, this.UnidadesDeEscritura);

            return sb.ToString();
        }
    }
}
