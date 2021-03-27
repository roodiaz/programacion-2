using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Kelvin
    {
        private double grados;

        public Kelvin() { this.grados = 0; }

        public Kelvin(double grados) { this.grados = grados; }

        public double GetGrados() { return this.grados; }

        public static implicit operator Kelvin(double k)
        {
            Kelvin k1 = new Kelvin(k);
            return k1;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = new Fahrenheit((k.GetGrados()) * 9/5 - 459.67);
            return f;
        }

        public static explicit operator Celcius(Kelvin k)
        {
            Fahrenheit f = (Fahrenheit)k;//paso de k a f (casteo anterior)
            Celcius c = (Celcius)f;//reutilizo co

            return c;
        }

        public static Kelvin operator+(Kelvin k, Fahrenheit f)
        {
            Kelvin retorno = (k.GetGrados() + ((Kelvin)f).GetGrados());
            return retorno;
        }

        public static Kelvin operator +(Kelvin k, Celcius c)
        {
            Kelvin retorno = (k.GetGrados() + ((Kelvin)c).GetGrados());
            return retorno;
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            Kelvin retorno = (k.GetGrados() - ((Kelvin)f).GetGrados());
            return retorno;
        }

        public static Kelvin operator -(Kelvin k, Celcius c)
        {
            Kelvin retorno = (k.GetGrados() - ((Kelvin)c).GetGrados());
            return retorno;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool retorno = false;

            if (k1.GetGrados() == k2.GetGrados())
                retorno = true;

            return retorno;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (k == ((Kelvin)f));
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == ((Kelvin)f));
        }

        public static bool operator ==(Kelvin k, Celcius c)
        {
            return (k == ((Kelvin)c));
        }

        public static bool operator !=(Kelvin k, Celcius c)
        {
            return !(k == ((Kelvin)c));
        }
    }
}
