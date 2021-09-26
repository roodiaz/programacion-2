using System;
using System.Text;

namespace Entidades
{
    public abstract class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas}
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada{ get; }

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

        protected virtual string Mostrar()
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
                return -1;
            else if (l1.Duracion > l2.Duracion)
                return 1;
            else
                return 0;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2))
            {
                if (l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
