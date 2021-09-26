using System;
using System.Text;

namespace Entidades
{
    public class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas}
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\nLLAMADA:");
            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Nro Destino: ¨{this.NroDestino}");
            sb.AppendLine($"Nro Origen: {this.NroOrigen}");         

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            if (l1.Duracion < l2.Duracion)
                return 1;
            else if (l1.Duracion > l2.Duracion)
                return -1;
            else
                return 0;
        }
    }
}
