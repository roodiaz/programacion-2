using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public int Add(string numero)
        {
            int suma = 0;

            if (!string.IsNullOrWhiteSpace(numero))
            {
                if (numero.StartsWith("//"))
                {
                    char separador = numero[2];
                    numero = numero.Substring(2).Replace(separador, ',');
                    //guardo nueva cadena son los dos primeros 
                    //reemplazo separador por ,
                }

                string[] numerosSeparados = numero.Split(',', '\n');

                for (int i = 0; i < numerosSeparados.Length; i++)
                {
                    int num = int.Parse(numerosSeparados[i]);

                    if (num < 0)
                        throw new NegativoNoPermitidoException($"{num}");

                    suma += num;

                }

                return suma;
            }

            return 0;
        }
    }
}
