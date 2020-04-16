using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetBin()
        {
            return this.numero;
        }

        #region conversiones
        public static implicit operator NumeroBinario(string b)
        {
            NumeroBinario b1 = new NumeroBinario(b);
            return b1;
        }

        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static explicit operator NumeroDecimal(NumeroBinario b)
        {
            int longBin = (b.GetBin()).Length; //leo longitud del string ingresado
            char[] array = (b.GetBin()).ToCharArray();//convierto string en array char
            Array.Reverse(array); // binario se lee de derecha a izquierda, invierto array
            double resultado = 0;
            
            for (int i = 0; i < longBin; i++)
            {
                if (array[i] == '1')//si es 1 hago potencia y sumo, si es 0 salto proceso
                {
                    resultado += Math.Pow(2, i);
                }
            }

            NumeroDecimal d = new NumeroDecimal(resultado);
            return d;
        }
        #endregion

        #region operadores

        public static NumeroBinario operator +(NumeroBinario b, NumeroDecimal d)
        {
            NumeroDecimal num = (NumeroDecimal)b; //convierto el bin en decimal apra sumar
            NumeroDecimal num1 =new NumeroDecimal( num.GetDecimal() + d.GetDecimal());

            NumeroBinario aux = (NumeroBinario)num1; //convierto el resultado de la suma en binario
            return aux;
            
        }

        public static NumeroBinario operator -(NumeroBinario b, NumeroDecimal d)
        {
            NumeroDecimal num = (NumeroDecimal)b; //convierto el bin en decimal apra sumar
            NumeroDecimal num1 = new NumeroDecimal(num.GetDecimal() - d.GetDecimal());

            NumeroBinario aux = (NumeroBinario)num1; //convierto el resultado de la suma en binario
            return aux;

        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            NumeroBinario b1 = (NumeroBinario)d;

            return b.GetBin() == b1.GetBin();
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            NumeroBinario b1 = (NumeroBinario)d;

            return !(b.GetBin() == b1.GetBin());
        }

        #endregion
    }
}
