using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja franjaHoraria;

        public float CostoLLamada
        {
            get { return this.CalcularCosto(); }
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja franja, Llamada llamada)
            : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo llamada: {this.GetType()}");
            sb.AppendLine($"Costo llamada: {this.CostoLLamada}");
            sb.Append(base.Mostrar());
            sb.AppendLine("----------------------------------\n");

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = 0.66f;
                    break;
            }

            return costo * this.Duracion;
        }
    }
}
