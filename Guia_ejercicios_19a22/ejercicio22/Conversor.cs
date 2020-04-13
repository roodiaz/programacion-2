using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class Conversor
    {
        /// <summary>
        /// Convierte un número de entero a binario.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string DecimalBinario(int num)
        {
            string resultado = string.Empty;

            while (num > 0)
            {
                num = num / 2;
                resultado = resultado + num % 2;
            }

            return resultado;
        }

        /// <summary>
        /// Convierte un número binario a entero.
        /// </summary>
        /// <param name="bin"></param>
        /// <returns></returns>
        public static double BinarioDecimal(string bin) 
        {
            int longBin = bin.Length; //leo longitud del string ingresado
            char[] array = bin.ToCharArray();//convierto string en array char
            Array.Reverse(array); // binario se lee de derecha a izquierda, invierto array
            double resultado = 0;

            for (int i = 0; i < longBin; i++)
            {
                if (array[i] == '1')//si es 1 hago potencia y sumo, si es 0 salto proceso
                {
                    resultado += Math.Pow(2, i);
                }
            }

            return resultado;
        }
    }
}

