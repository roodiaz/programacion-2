using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Peso
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region
        static Peso() 
        { Peso.cotizRespectoDolar = 66; }

        public Peso(double cantidad) 
        { this.cantidad = cantidad; }

        public Peso(double cantidad, double cotizacion) : this(cantidad) 
        { Peso.cotizRespectoDolar = cotizacion; }
        #endregion

        #region
        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Peso.cotizRespectoDolar; }
        #endregion
    }
}
