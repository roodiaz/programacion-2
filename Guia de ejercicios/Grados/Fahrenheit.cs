using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit() { this.grados = 0; }

        public Fahrenheit(double grados) { this.grados = grados; }

        public double GetGrados() { return this.grados; }

        public static implicit operator Fahrenheit(double f)
        {
            Fahrenheit f1 = new Fahrenheit(f);
            return f1;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = new Kelvin((f.GetGrados()+459.67)*5/9);
            return k;
        }

        public static explicit operator Celcius(Fahrenheit f)
        {
            Celcius c = new Celcius((f.GetGrados()-32)*5/9);
            return c;
        }
    }
}
