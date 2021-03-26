using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        #region constructores
        static Peso()
        { Peso.cotizRespectoDolar = 66; }

        public Peso(double cantidad)
        { this.cantidad = cantidad; }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        { Peso.cotizRespectoDolar = cotizacion; }
        #endregion

        #region getters
        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Peso.cotizRespectoDolar; }
        #endregion

        #region operadores
        /// <summary>
        /// Transforma un Double a Peso
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator Peso(double peso)
        {
            Peso p = new Peso(peso);
            return p;
        }

        /// <summary>
        /// Transforma un Peso a Dolar
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(Peso p)
        {
            Dolar d = p.GetCantidad() / Peso.GetCotizacion();
            return d;
        }

        /// <summary>
        /// Transforma un Peso a Euro
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator Euro(Peso p)
        {
            Dolar d = (Dolar)p; //reutilizo codigo casteo a dolar;
            Euro e = (Euro)d; //reutilizo codigo casteo de dolar a euro;

            return e;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso peso = new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
            return peso;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            Peso peso = new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
            return peso;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            Peso peso = new Peso(Math.Abs(p.GetCantidad() - ((Peso)e).GetCantidad()));
            return peso;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            Peso peso = new Peso(Math.Abs(p.GetCantidad() - ((Peso)d).GetCantidad()));
            return peso;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;

            if (p1.GetCantidad() == p2.GetCantidad())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return (p == (Peso)d);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == (Peso)d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p == (Peso)e);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == (Peso)e);
        }
        #endregion
    }
}
