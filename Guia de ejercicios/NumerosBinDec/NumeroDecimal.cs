using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorNumeros;

namespace NumerosBinDec
{
    public class NumeroDecimal
    {
        double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNum()
        {
            return this.numero;
        }

        //conversiones
        public static implicit operator NumeroDecimal(double num)
        {
            NumeroDecimal dec = new NumeroDecimal(num);
            return dec;
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            int num = (int)d.numero;

            NumeroBinario bin = Conversor.DecimalToBinario(num);

            return bin;
        }

        //sobrecarga de operadores
        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double dec = (double)d + Conversor.BinarioToDecimal((string)b);

            return dec;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double dec = (double)d - Conversor.BinarioToDecimal((string)b);

            return dec;
        }

        //operadores de comparacion
        public static bool operator==(NumeroDecimal d, NumeroBinario b)
        {
            bool retorno = false;

            if((double)d == Conversor.BinarioToDecimal((string)b))
                retorno = true;

            return retorno;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d == b);
        }













    }
}
