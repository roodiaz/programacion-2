using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local: Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion, llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            :this(new Llamada(duracion, destino, origen), costo)
        {

        }

        private float CalcularCosto()
        {
            return (this.Duracion * this.costo);
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"Tipo llamada: {this.GetType()}");
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");
            sb.Append(base.Mostrar());
            sb.AppendLine("----------------------------------\n");

            return sb.ToString();
        }
    }
}
