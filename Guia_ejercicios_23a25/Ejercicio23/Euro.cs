using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    class Euro
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 0.92;
        }

        public Euro(double cantidad)
        {
            cantidad = Math.Round(cantidad, 2);
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotiz)
        {
            Euro.cotizRespectoDolar = cotiz;
        }
        #endregion

        #region Conversiones
        /// <summary>
        /// Transforma un Double a Euro
        /// </summary>
        /// <param name="e"></param>
        public static implicit operator Euro(double e)
        {
            Euro aux = new Euro(e);
            return aux;
        }

        /// <summary>
        /// Transforma un Euro a Dolar
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Dolar(Euro e)
        {
            Dolar d = new Dolar(e.GetCantidad() / Euro.cotizRespectoDolar);
            return d;
        }

        /// <summary>
        /// Transforma un Euro a Pesos
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Pesos(Euro e)
        {
            Dolar d = (Dolar)e; //casteo a dolares primero
            Pesos p = (Pesos)d;
            return p;
        }
        #endregion

        #region Operadores Suma-Resta
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro e1 = new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
            return e1;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro e1 = new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
            return e1;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro e1 = new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
            return e1;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro e1 = new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
            return e1;
        }
        #endregion

        #region Comparaciones
        public static bool operator == (Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator == (Euro e, Dolar d)
        {
            return (e == (Euro)d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (e == (Euro)p);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        #endregion
    }
}
