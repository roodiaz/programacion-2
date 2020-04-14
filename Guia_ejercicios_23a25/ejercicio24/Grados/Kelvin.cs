using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* F = C * (9/5) + 32
C = (F-32) * 5/9
F = K *( 9/5) – 459.67
K = (F + 459.67) * 5/9 */

namespace Grados
{
    public class Kelvin
    {
        private double grados;

        #region constructores
        public Kelvin()
        {
            this.grados = 0;
        }

        public Kelvin(double grados)
        {
            grados = Math.Round(grados, 2);
            this.grados = grados;
        }
        #endregion

        public Double GetGrados()
        {
            return this.grados;
        }

        #region conversiones
        static public implicit operator Kelvin(double k)
        {
            Kelvin k1 = new Kelvin(k);
            return k1;
        }
        
        /// <summary>
        /// convierte kelvin a fahrenheit
        /// </summary>
        /// <param name="k"></param>
        static public explicit operator Fahrenheit(Kelvin k)
        {
            //F = K * 9/5 – 459.67
            Fahrenheit f = new Fahrenheit(k.GetGrados()*9/5-459.67);
            return f;
        }

        /// <summary>
        /// convierte kelvil a celcius
        /// </summary>
        /// <param name="k"></param>
        static public explicit operator Celcius(Kelvin k)
        {
            //C = (F-32) * 5/9
            Fahrenheit f = (Fahrenheit)k; //casteo primero a f, ya esta hecho arriba
            Celcius c = (Celcius)f; // casteo ya realizado en clase de f
            return c;
        }
        #endregion

        #region suma/resta
        public static double operator +(Kelvin k1, Kelvin k2)
        {
            return k1.GetGrados() + k2.GetGrados();
        }

        public static double operator +(Kelvin k, Celcius c)
        {
            return k.GetGrados() + ((Kelvin)c).GetGrados();
        }

        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k.GetGrados() + ((Kelvin)f).GetGrados();
        }

        public static double operator -(Kelvin k1, Kelvin k2)
        {
            return k1.GetGrados() - k2.GetGrados();
        }

        public static double operator -(Kelvin k, Celcius c)
        {
            return k.GetGrados() - ((Kelvin)c).GetGrados();
        }

        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k.GetGrados() - ((Kelvin)f).GetGrados();
        }
        #endregion
    }
}
