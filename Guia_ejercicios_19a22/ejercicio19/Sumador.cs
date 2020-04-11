using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Sumador
    {
        private int CantidadSumas;

        #region Constructores

        public Sumador(int CantidadSumas)
        {
            this.CantidadSumas = CantidadSumas;
        }

        public Sumador() : this(0)
        {

        }
        #endregion

        #region Metodos

        public long Sumar(long a, long b)
        {
            this.CantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.CantidadSumas++;
            return string.Format("{0} {1}", a, b);
        }
        #endregion

        #region Conversiones
        public static explicit operator int (Sumador s)
        {
            return s.CantidadSumas;
        }
        #endregion

        #region Operadores
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas + s2.CantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.CantidadSumas == s2.CantidadSumas)
                retorno = true;

            return retorno;
        }
        #endregion

    }
}
