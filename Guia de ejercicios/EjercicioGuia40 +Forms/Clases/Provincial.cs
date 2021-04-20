using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        #region
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.Origen, miFranja, llamada.Duracion, llamada.Destino)
        {
        }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nLlamada Provincial \n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);
            sb.AppendFormat("{0}\n", this.franjaHoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float costo;

            switch (this.franjaHoraria)
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

                default:
                    return 0f;
            }

            return costo * duracion;
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        #endregion
    }
}
