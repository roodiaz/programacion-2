using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesado : Paquete, IAduana, IAfip
    {
        private bool prioridad;

        public override bool Prioridad
        {
            get { return this.prioridad; }
        }

        public Pesado(double peso, string codigoSeguimiento, string origen, string destino, double costoEnvio, bool prioridad)
        : base(peso, codigoSeguimiento, origen, destino, costoEnvio)
        {
            this.prioridad = prioridad;
        }

        double IAduana.CalcularImpuesto()
        {
            return this.costoEnvio * 0.35;
        }

        double IAfip.CalcularImpuesto()
        {
            return this.costoEnvio * 0.25;
        }

        public override string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.InformacionPaquete());
            if (this.prioridad)
                sb.AppendLine($"Prioridad: Alta");
            else
                sb.AppendLine($"Prioridad: Baja");

            sb.AppendLine($"Impuesto AFIP: {((IAfip)this).CalcularImpuesto()}");
            sb.AppendLine($"Impuesto Aduana: {((IAduana)this).CalcularImpuesto()}");

            return sb.ToString();
        }

    }
}
