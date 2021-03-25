using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private static double CotizRespectoDolar;
        private double cantidad;

        #region
        static Euro()
        {
            Euro.CotizRespectoDolar = 1.08;
        }

        private Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        private Euro(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Euro.CotizRespectoDolar = cotizacion;
        }
        #endregion
    }
}
