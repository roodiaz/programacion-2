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

        public static Fahrenheit operator+(Fahrenheit f, Celcius c)
        {
            Fahrenheit retorno = (f.GetGrados() + ((Fahrenheit)c).GetGrados());
            return retorno;
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            Fahrenheit retorno = (f.GetGrados() + ((Fahrenheit)k).GetGrados());
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit f, Celcius c)
        {
            Fahrenheit retorno = (f.GetGrados() - ((Fahrenheit)c).GetGrados());
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            Fahrenheit retorno = (f.GetGrados() - ((Fahrenheit)k).GetGrados());
            return retorno;
        }

        public static bool operator==(Fahrenheit f1, Fahrenheit f2)
        {
            bool retorno= false;

            if (f1.GetGrados() == f2.GetGrados())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fahrenheit f, Celcius c)
        {
            return (f == ((Fahrenheit)c));
        }

        public static bool operator !=(Fahrenheit f, Celcius c)
        {
            return !(f == ((Fahrenheit)c));
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f == ((Fahrenheit)k));
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == ((Fahrenheit)k));
        }
    }
}
