using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PuestoDeAtencion
    {
       public enum Puesto
        {
            caja1,
            caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            //primero incremento en 1 y despues retorno
            get { return ++numeroActual; }
        }

        public bool AtenderCliente(Cliente c)
        {
            Thread.Sleep(500);
            return true;
        }
    }
}
