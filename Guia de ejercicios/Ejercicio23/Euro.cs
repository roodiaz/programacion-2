using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Euro
    {
        private static double CotizRespectoDolar;
        private double cantidad;

        #region constructores
        static Euro()
        {
            Euro.CotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Euro.CotizRespectoDolar = cotizacion;
        }
        #endregion

        #region getters
        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Euro.CotizRespectoDolar; }
        #endregion

        //setter
        public static void SetCotizacion(double cotiz)
        {
            Euro.CotizRespectoDolar = cotiz;
        }

        #region operadores
        /// <summary>
        /// Transforma un Double a Euro
        /// </summary>
        /// <param name="e"></param>
        public static implicit operator Euro(double euro)
        {
            Euro e = new Euro(euro);
            return e;
        }

        /// <summary>
        /// Transforma un Euro a Dolar
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() / Euro.GetCotizacion());
            return d;
        }

        /// <summary>
        /// Transforma un Euro a Pesos
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Peso(Euro e)
        {
            Dolar d = (Dolar)e; //reutilizo codigo, casteo euro a dolar
            Peso p = (Peso)d; //reutilizo codigo, casteo dolar a peso 

            return p;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
            return euro;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            Euro euro = new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
            return euro;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro euro = new Euro(Math.Abs(e.GetCantidad() - ((Euro)d).GetCantidad()));//para quitar signo - math.abs
            return euro;
        }

        public static Euro operator -(Euro e, Peso p)
        {
            Euro euro = new Euro(Math.Abs(e.GetCantidad() - ((Euro)p).GetCantidad()));
            return euro;
        }
        #endregion

        #region comparaciones
        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;

            if (e1.GetCantidad() == e2.GetCantidad())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e == ((Euro)d));
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == (Euro)d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e == (Euro)p);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return (e == (Euro)p);
        }
        #endregion
    }
}
