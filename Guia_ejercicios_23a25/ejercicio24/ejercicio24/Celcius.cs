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
    public class Celcius
    {
        private double grados;

        #region constructores
        public Celcius()
        {
            this.grados = 0;
        }
        
        public Celcius(double grados)
        {
            grados = Math.Round(grados, 2);
            this.grados = grados;
        }
        #endregion

        public double GetGrados()
        {
            return this.grados;
        }

        #region conversiones
        public static implicit operator Celcius(double c)
        {
            Celcius c1 = new Celcius(c);
            return c1;
        }

        /// <summary>
        /// convierte celcius a fahrenheit
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator Fahrenheit(Celcius c)
        {
            ///* F = C * (9/5) + 32
            Fahrenheit f = new Fahrenheit(c.GetGrados()*9/5+32);
            return f;
        }

        /// <summary>
        /// convierte celcius a kelvin
        /// </summary>
        /// <param name="c"></param>
        public static explicit operator Kelvin(Celcius c)
        {
            //K = (F + 459.67) * 5/9 */
            Fahrenheit f = (Fahrenheit)c; //primero casteo a f
            Kelvin k = (Kelvin)f; // casteo de f a k(ya hecho en clase f)
            return k;
        }
        #endregion

        #region suma/resta
        public static double operator +(Celcius c1, Celcius c2)
        {
            return c1.GetGrados() + c2.GetGrados();
        }

        public static double operator +(Celcius c, Kelvin k)
        {
            return c.GetGrados() + ((Celcius)k).GetGrados();
        }

        public static double operator +(Celcius c, Fahrenheit f)
        {
            return c.GetGrados() + ((Celcius)f).GetGrados();
        }

        public static double operator -(Celcius c1, Celcius c2)
        {
            return c1.GetGrados() - c2.GetGrados();
        }

        public static double operator -(Celcius c, Kelvin k)
        {
            return c.GetGrados() - ((Celcius)k).GetGrados();
        }

        public static double operator -(Celcius c, Fahrenheit f)
        {
            return c.GetGrados() - ((Celcius)f).GetGrados();
        }

        #endregion


    }
}
