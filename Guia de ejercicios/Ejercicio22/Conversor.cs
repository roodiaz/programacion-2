using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumeros
{
    public class Conversor
    {
        static public string DecimalToBinario(int valor)
        {
            string binario=string.Empty;

            while(valor>0)
            {            
                binario = valor % 2 +binario;//concateno el resto a la cadena
                valor = valor / 2;
            }
      
            return binario;
        }
      
        static public double BinarioToDecimal(string valor)
        {
            double numDec = 0;
            char[] arrayEnteros = valor.ToCharArray();//convierto string en array
            Array.Reverse(arrayEnteros);
            //los binarios se convierte de derecha a izquiera, invierto cadena

            for(int i=0; i < valor.Length; i++)
            {
                if (arrayEnteros[i] == '1')//si es 1 hago potencio sino salteo
                {
                    numDec += Math.Pow(2, i);
                }
            }

            return numDec;       
        }
    }
}
