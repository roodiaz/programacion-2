using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        #region Constructores
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.Destino, llamada.Origen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : this((new Llamada(duracion, destino, origen)), costo)
        {

        }

        /*
           public Local( string origen, float duracion, string destino, float costo )
            : base(duracion, destino, origen)
             {
                this.costo = costo;
             }

        public Local( Llamada llamada, float costo )
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
            {

            }
        */
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nLlamada LOCAL \n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (this.costo * Duracion);
        }
        #endregion
    }
}
