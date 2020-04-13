using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grados;



namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = new Fahrenheit(100);
            Celcius c = new Celcius(37.778);
            Kelvin k = new Kelvin(310.928);


            #region Prueba conversiones Fahrenheit
            //Celcius c1 = (Celcius)f;
            //Kelvin k1 = (Kelvin)f;

            //Console.WriteLine("{0}° fahrenheit es igual a {1:N2}° celcius",f.GetGrados(),c1.GetGrados());
            //Console.WriteLine("{0}° fahrenheit es igual a {1:N2}° kelvin", f.GetGrados(), k1.GetGrados());
            #endregion

            #region prueba conversiones kelvin
            //Celcius c1 = (Celcius)k;
            //Fahrenheit f1 = (Fahrenheit)k;

            //Console.WriteLine("{0:N2}° kelvin es igual a {1:N2}° celcius", k.GetGrados(), c1.GetGrados());
            //Console.Write("{0:N2}° kelvin es igual a {1:N2}° fahrenheit", k.GetGrados(), f1.GetGrados());
            #endregion

            #region prueba conversiones celcius
            //Kelvin k1 = (Kelvin)c;
            //Fahrenheit f1 = (Fahrenheit)c;

            //Console.WriteLine("{0:N2}° celcius es igual a {1:N2}° kelvin", c.GetGrados(), k1.GetGrados());
            //Console.Write("{0:N2}° celcius es igual a {1:N2}° fahrenheit", c.GetGrados(), f1.GetGrados());
            #endregion

            #region prueba sumas/resta fahrenheit
            Fahrenheit sumaCelcius = f + c;
            Fahrenheit sumaKelvin = f + k;
            Fahrenheit restaCelcius = f - c;
            Fahrenheit restaKelvin = f - k;

            Console.WriteLine(sumaCelcius.GetGrados());
            Console.WriteLine(sumaKelvin.GetGrados());
            Console.WriteLine(restaCelcius.GetGrados());
            Console.Write(restaKelvin.GetGrados());
            #endregion
            Console.ReadKey();
        }
    }
}
