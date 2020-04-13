using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* F = C * (9/5) + 32
C = (F-32) * 5/9
F = K * 9/5 – 459.67
K = (F + 459.67) * 5/9 */

namespace Grados
{
    class Fahrenheit
    {
        private double grados;

        #region constructores
        public Fahrenheit()
        {
            this.grados = 0;
        }

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }
        #endregion

        public double GetGrados()
        {
            return this.grados;
        }

        #region conversiones
        public static implicit operator Fahrenheit(double f)
        {
            Fahrenheit f1 = new Fahrenheit(f);
            return f1;
        }

        /// <summary>
        /// Convierte fahrenheite a celcius
        /// </summary>
        /// <param name="f"></param>
        public static explicit operator Celcius(Fahrenheit f)
        {
            //C = (F - 32) * 5 / 9

            Celcius c = new Celcius((f.GetGrados() - 32) * 5 / 9);
            return c;
        }

        /// <summary>
        /// Convierte fahrenheite a kelvin
        /// </summary>
        /// <param name="f"></param>
        public static explicit operator Kelvin(Fahrenheit f)
        {
            // K = (F + 459.67) * 5 / 9 

            Kelvin k = new Kelvin((f.GetGrados() + 459.67) * 5 / 9);
            return k;
        }
        #endregion

        #region suma/resta
        public static double operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetGrados() + f2.GetGrados();
        }

        public static double operator +(Fahrenheit f, Celcius c)
        {
            return f.GetGrados() + ((Fahrenheit)c).GetGrados();
        }

        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f.GetGrados() + ((Fahrenheit)k).GetGrados();
        }

        public static double operator -(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetGrados() - f2.GetGrados();
        }

        public static double operator -(Fahrenheit f, Celcius c)
        {
            return f.GetGrados() - ((Fahrenheit)c).GetGrados();
        }

        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f.GetGrados() - ((Fahrenheit)k).GetGrados();
        }
        #endregion
    }
}
