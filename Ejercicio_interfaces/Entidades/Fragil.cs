using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fragil : Paquete, IAduana
    {
        private bool prioridad;


        public override bool Prioridad
        {
            get { return this.prioridad; }
        }

        public Fragil(double peso, string codigoSeguimiento, string origen, string destino, double costoEnvio, bool prioridad)
        : base(peso, codigoSeguimiento, origen, destino, costoEnvio)
        {
            this.prioridad = prioridad;
        }

        public override string InformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.InformacionPaquete());
            if (this.prioridad)
                sb.AppendLine($"Prioridad: Alta");
            else
                sb.AppendLine($"Prioridad: Baja");

            sb.AppendLine($"Impuestos aduana: {this.CalcularImpuesto()}");

            return sb.ToString();
        }

        ///Implementa la interfaz IAduana, que retornara el impuesto al costo del envió (35%)
        public double CalcularImpuesto()
        {
            return this.costoEnvio * 0.35;
        }
    }
}
