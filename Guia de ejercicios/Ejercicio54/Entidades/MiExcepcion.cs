using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
            :base("mi excepcion")
        {
            
        }

        public MiExcepcion(string mensaje)
           : base(mensaje)
        {
        }

        public MiExcepcion(string mensaje, Exception innerException)
            : base(mensaje, null)
        {
        }
    }
}
