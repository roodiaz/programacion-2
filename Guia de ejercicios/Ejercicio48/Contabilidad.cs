using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    public class Contabilidad<T,U>
        where T: Documento
        where U: Documento, new()
    {
        //T: factura
        //U: recibo

        private List<T> egreso;
        private List<U> ingreso;

        public Contabilidad()
        {
            this.egreso = new List<T>();
            this.ingreso = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egreso.Add(egreso);

            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingreso.Add(ingreso);

            return c;
        }
    }
}
