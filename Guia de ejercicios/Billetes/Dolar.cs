namespace Billetes
{
    class Dolar
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar=1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
            
        }
        #endregion

        #region getter
        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Dolar.cotizRespectoDolar; }
        #endregion


    }
}
