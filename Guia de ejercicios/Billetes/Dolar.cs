using Billetes;
using System;

namespace Billetes
{
    public class Dolar
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

        #region getters
        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Dolar.cotizRespectoDolar; }
        #endregion

        #region operadores
        /// <summary>
        /// Transforma un Dolar a Euro
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro(d.GetCantidad() * Euro.GetCotizacion());
            return e;
        }

        /// <summary>
        /// Transforma un Dolar a Pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Peso(Dolar d)
        {
            Peso p = new Peso(d.GetCantidad() * Peso.GetCotizacion());
            return p;
        }

        /// <summary>
        /// Transforma un Double a Dolares
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(double dolar)
        {
            Dolar d = new Dolar(dolar);
            return d;
        }

        public static Dolar operator+(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
            return dolar;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar dolar = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
            return dolar;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(Math.Abs(d.GetCantidad() - ((Dolar)e).GetCantidad()));
            return dolar;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar dolar = new Dolar(Math.Abs(d.GetCantidad() - ((Dolar)p).GetCantidad()));
            return dolar;
        }

        public static bool operator==(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.GetCantidad() == d2.GetCantidad())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Dolar d1,Dolar d2)
        {
            return !(d1 == d2);//reutilizo codigo
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d == ((Dolar)e));
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == ((Dolar)e));
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d == ((Dolar)p));
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == ((Dolar)p));
        }

        #endregion


    }
}
