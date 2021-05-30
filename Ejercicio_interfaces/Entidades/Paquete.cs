using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Paquete
    {
        protected string codigoSeguimiento;
        protected double costoEnvio;
        protected string destino;
        protected string origen;
        protected double peso;

        public abstract bool Prioridad { get; }

        public Paquete(double peso, string codigoSeguimiento, string origen, string destino, double costoEnvio)
        {
            this.peso = peso;
            this.codigoSeguimiento = codigoSeguimiento;
            this.origen = origen;
            this.destino = destino;
            this.costoEnvio = costoEnvio;

        }

        public virtual string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Costo envio: {this.costoEnvio}");
            sb.AppendLine($"Peso: {this.peso}");
            sb.AppendLine($"Codigo seguimiento: {this.codigoSeguimiento}");

            return sb.ToString();
        }
    }
}
