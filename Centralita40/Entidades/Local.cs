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

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen,llamada.Duracion, llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return (this.Duracion * this.costo);
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"Tipo llamada: {this.GetType()}");
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");
            sb.Append(base.Mostrar());
            sb.AppendLine("----------------------------------\n");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
