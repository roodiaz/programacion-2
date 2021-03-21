using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Class1
    {
        static public string DecimalToBinario(int valor)
        {
            string binario=string.Empty;

            while(valor>0)
            {
                valor = valor / 2;
                binario = binario + valor % 2;//concateno el resto a la cadena
            }

            return binario;
        }
      
        static public int BinarioToDecimal(string valor)
        {
            char[] arrayEnteros = valor.ToCharArray();
            Array.Reverse(arrayEnteros);
            double numDec=0;
            //los binarios se convierte de derecha a izquiera, invierto cadena

            for(int i=0; i < valor.Length; i++)
            {
                if (arrayEnteros[i] == '1')
                {
                    numDec += Math.Pow(2, i);
                }
            }

            return (int)numDec;

           
        }
    }
}
