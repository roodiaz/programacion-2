using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumeros
{
    public class Conversor
    {
        public static string DecimalBinario(int num) //Convierte un número de entero a binario.
        {
            string resultado = string.Empty;

            while (num > 0)
            {
                resultado = num % 2 + resultado;
                num = num / 2;
            }

            return resultado;
        }

        public static double BinarioDecimal(string bin) //Convierte un número binario a entero.
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
