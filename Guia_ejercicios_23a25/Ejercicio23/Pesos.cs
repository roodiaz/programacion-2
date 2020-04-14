using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Pesos
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region Constructores
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 64.74;
        }

        public Pesos(double cantidad)
        {
            cantidad = Math.Round(cantidad, 2);
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotiz)
        {
            Pesos.cotizRespectoDolar = cotiz;
        }
        #endregion

        #region Conversiones
        /// <summary>
        /// Transforma un Double a Peso
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator Pesos(double p)
        {
            Pesos aux = new Pesos(p);
            return aux;
        }

        /// <summary>
        /// Transforma un Peso a Euro
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Euro(Pesos p)
        {
            Dolar d = (Dolar)p;//casteo a dolares primero
            Euro e = (Euro)d;
            return e;
        }

        /// <summary>
        /// Transforma un Peso a Dolar
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Dolar(Pesos p)
        {
            Dolar d = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return d;
        }
        #endregion

        #region Operadores Suma-Resta
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos p1 = new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
            return p1;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos p1 = new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
            return p1;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos p1 = new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
            return p1;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos p1 = new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
            return p1;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p == (Pesos)d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return (p == (Pesos)e);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        #endregion
    }

}