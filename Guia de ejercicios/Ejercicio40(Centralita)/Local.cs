using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        #region Constructores

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.Origen, llamada.Destino)
        {
            this.costo = costo;
        }
        public Local(string origen, string destino, float duracion, float costo)
            : base(duracion, origen, destino)
        {
            this.costo = costo;
        }


        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nLlamada LOCAL \n");
            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo:{0:0.00} \n", this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return (this.costo * Duracion);
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        #endregion
    }
}
