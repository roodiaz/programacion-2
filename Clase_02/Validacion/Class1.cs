using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion
{
    public class Class1
    {

        public static bool Validar(int valor, int min, int max)
        {
            if(valor > max || valor < min)
            {
                return false;
            }

            return true;
        }
    }
}
