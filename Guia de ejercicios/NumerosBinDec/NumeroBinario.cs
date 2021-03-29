using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorNumeros;

namespace NumerosBinDec
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        //conversiones
        public static implicit operator NumeroBinario(string num)
        {
            NumeroBinario bin = new NumeroBinario(num);
            return bin;
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b.numero;
        }

        //sobrecarga operadores
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double dec = Conversor.BinarioToDecimal((string)b) + (double)d;
            string bin = Conversor.DecimalToBinario((int)dec);
            //casteo a int porque con double muestra basura

            return bin;
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double dec = Conversor.BinarioToDecimal((string)b) - (double)d;
            string bin = Conversor.DecimalToBinario((int)dec);
            //casteo a int porque con double muestra basura

            return bin;
        }

        //operadores de comparacion
        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            bool retorno = false;

            if ((string)b == Conversor.DecimalToBinario((int)d))
                retorno = true;

            return retorno;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }
    }
}
