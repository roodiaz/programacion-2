using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    class NumeroDecimal
    {
        private double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetDecimal()
        {
            return this.numero;
        }

        #region conversiones
        public static implicit operator NumeroDecimal(double d)
        {
            NumeroDecimal d1 = new NumeroDecimal(d);
            return d1;
        }

        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            string resultado = string.Empty;
            int num = (int)(d.GetDecimal());
            
            while (num > 0)
            {             
                resultado = num % 2+resultado ;
                num = num / 2;
            }

            NumeroBinario b = new NumeroBinario(resultado);

            return b;
        }
        #endregion

        #region operadores
        public static NumeroDecimal operator +(NumeroDecimal d, NumeroBinario b)
        {
            NumeroDecimal num = (NumeroDecimal)b; //convierto el bin en decimal apra sumar
            NumeroDecimal num1 = new NumeroDecimal(num.GetDecimal() + d.GetDecimal());
           
            return num1;
        }

        public static NumeroDecimal operator -(NumeroDecimal d, NumeroBinario b)
        {
            NumeroDecimal num = (NumeroDecimal)b; //convierto el bin en decimal apra sumar
            NumeroDecimal num1 = new NumeroDecimal(num.GetDecimal() - d.GetDecimal());

            return num1;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            NumeroDecimal d1 = (NumeroDecimal)b;

            return d.GetDecimal() == d1.GetDecimal();
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            NumeroDecimal d1 = (NumeroDecimal)b;

            return !(d.GetDecimal() == d1.GetDecimal());
        }
        #endregion
    }
}
