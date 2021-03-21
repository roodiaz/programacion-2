using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Class1

    {
        static public double Calcular(int num1, int num2, char operador)
        {
            double resultado=0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    if (Class1.Validar(num2))
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("no se puede dividir por 0");
                    break;

                default:
                    Console.WriteLine("error, operador invalido");
                    break;
            }

            return resultado;
        }

        static private bool Validar(int num2)
        {
            bool retorno = false;
           
            if (num2 != 0)
                retorno= true;

            return retorno;
        }



    }
}
