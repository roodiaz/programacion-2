using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Celcius
    {
        private double grados;

        public Celcius() { this.grados = 0; }

        public Celcius(double grados) { this.grados = grados; }

        public double GetGrados() { return this.grados; }

        public static implicit operator Celcius(double c)
        {
            Celcius c1 = new Celcius(c);
            return c1;
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            Fahrenheit f = new Fahrenheit((c.GetGrados()) * 9/5 +32);
            return f;
        }

        public static explicit operator Kelvin(Celcius c)
        {
            Fahrenheit f = (Fahrenheit)c;//paso c a f
            Kelvin k = (Kelvin)f; //casteo de f a k(ya hecho en clase de f)

            return k;
        }

        public static Celcius operator+(Celcius c, Fahrenheit f)
        {
            Celcius retorno = (c.GetGrados() + ((Celcius)f).GetGrados());
            return retorno;
        }
        public static Celcius operator +(Celcius c, Kelvin k)
        {
            Celcius retorno = (c.GetGrados() + ((Celcius)k).GetGrados());
            return retorno;
        }

        public static Celcius operator -(Celcius c, Fahrenheit f)
        {
            Celcius retorno = (c.GetGrados() - ((Celcius)f).GetGrados());
            return retorno;
        }
        public static Celcius operator -(Celcius c, Kelvin k)
        {
            Celcius retorno = (c.GetGrados() - ((Celcius)k).GetGrados());
            return retorno;
        }

        public static bool operator ==(Celcius c1, Celcius c2)
        {
            bool retorno = false;

            if (c1.GetGrados() == c2.GetGrados())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Celcius c1, Celcius c2)
        {
            return !(c1 == c2);
        }

        public static bool operator ==(Celcius c, Fahrenheit f)
        {
            return (c == ((Celcius)f));
        }

        public static bool operator !=(Celcius c, Fahrenheit f)
        {
            return !(c == ((Celcius)f));
        }

        public static bool operator ==(Celcius c, Kelvin k)
        {
            return (c == ((Celcius)k));
        }

        public static bool operator !=(Celcius c, Kelvin k)
        {
            return !(c == ((Celcius)k));
        }
    }
}
