using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double dato1, double dato2, char operacion)
        {
            double resultado = 0;

            switch(operacion)
            {
                case '+':
                    resultado= dato1 + dato2;
                    break;

                case '-':
                    resultado= dato1 - dato2;
                    break;

                case '*':
                    resultado= dato1 * dato2;
                    break;                 

                case '/':
                    if(Validar(dato2))
                    {
                        return dato1 / dato2;
                    }
                    else
                        Console.Write("No se puede dividir por 0!!");
                    break;

                default:
                    Console.Write("Operador invalido!!");
                    break;
            }

            return resultado;
        }

        private static bool Validar(double dato2)
        {
            if (dato2 == 0)
                return false;

            return true;
        }
    }
}
