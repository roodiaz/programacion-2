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
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nLlamada Provincial \n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);
            sb.AppendFormat("{0}\n", this.franjaHoraria);

            return sb.ToString();
        }

        /*
         CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
        de la misma. Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.
         */
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
        #endregion
    }
}
