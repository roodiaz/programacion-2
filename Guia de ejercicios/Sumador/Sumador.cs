using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    public class Sumador
    {
        private int cantidadSumas;

        #region constructores
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }
        #endregion

        #region metodos
        public long Sumar(long a, long b)
        {
            this.cantidadSumas ++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return $"{a} {b}";
        }
        #endregion

        #region conversores
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        #endregion

        #region sobrecarga de operadores
        public static bool operator|(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
                retorno = true;

            return retorno;
        }

        public static long operator+(Sumador s1, Sumador s2)
        {
            //reutilizo conversor 
            return (int)s1 + (int)s2;
        }
        #endregion
    }
}
