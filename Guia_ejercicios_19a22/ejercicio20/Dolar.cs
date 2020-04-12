using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private static double cotizRespectoDolar;
        private double cantidad;     

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar (double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region Conversiones
        /// <summary>
        /// Transforma un Double a Dolares
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }

        /// <summary>
        /// Transforma un Dolar a Euro
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro (Dolar d)
        {
            Euro e = new Euro(d.GetCantidad() * Euro.GetCotizacion());
            return e;
        }

        /// <summary>
        /// Transforma un Dolar a Pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Dolar d)
        {
            Pesos p = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return p;
        }
        #endregion

        #region Operadores Suma-Resta
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar d1 = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
            return d1;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar d1 = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
            return d1;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar d1 = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
            return d1;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar d1 = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
            return d1;
        }
        #endregion

        #region Comparaciones
        public static bool operator == (Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return (d == (Dolar)e);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d == (Dolar)p);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        #endregion
    }
}
