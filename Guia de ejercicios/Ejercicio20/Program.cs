using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar d = new Dolar(500);
            Euro e = new Euro(500, 0.85);
            Peso p = new Peso(500, 91.70);

            #region Prueba conversiones
            //Prueba conversion dolar a pesos/euros
            Console.Write("PRUEBA CONVERSIONES\n\n");
            Euro auxE = (Euro)d;
            Console.WriteLine("{0:N2} dolares es igual a {1:N2} euros", d.GetCantidad(), auxE.GetCantidad());
            Peso auxP = (Peso)d;
            Console.WriteLine("{0:N2} dolares es igual a {1:N2} pesos", d.GetCantidad(), auxP.GetCantidad());

            //Prueba conversion euros a pesos/dolar
            Dolar auxD = (Dolar)e;
            Console.WriteLine("\n{0:N2} euros es igual a {1:N2} dolares", d.GetCantidad(), auxD.GetCantidad());
            Peso auxP1 = (Peso)e;
            Console.WriteLine("{0:N2} euros es igual a {1:N2} pesos", d.GetCantidad(), auxP1.GetCantidad());

            //Prueba conversion pesos a dolar\euros
            Dolar auxD1 = (Dolar)p;
            Console.WriteLine("\n{0:N2} pesos es igual a {1:N2} dolares", d.GetCantidad(), auxD1.GetCantidad());
            Euro auxP2 = (Euro)p;
            Console.WriteLine("{0:N2} pesos es igual a {1:N2} euros", d.GetCantidad(), auxP2.GetCantidad());
            #endregion

            #region Prueba suma/resta entre monedas
            Peso sumaPesoDolar = p + d;
            Peso sumaPesoEuro = p + e;
            Peso restaPesoDolar = p - d;
            Peso restaPesoEuro = p - e;

            Console.WriteLine("\n\nPRUEBA SUMA/RESTA ENTRE MONEDAS\n");
            Console.WriteLine("Resultado peso + dolar {0:N2}", sumaPesoDolar.GetCantidad());
            Console.WriteLine("Resultado peso + euro {0:N2}", sumaPesoEuro.GetCantidad());
            Console.WriteLine("Resultado peso - dolar {0:N2}", restaPesoDolar.GetCantidad());
            Console.WriteLine("Resultado peso - euro {0:N2}\n", restaPesoEuro.GetCantidad());


            Dolar sumaDolarPeso = d + p;
            Dolar sumaDolarEuro = d + e;
            Dolar restaDolarPeso = d - p;
            Dolar restaDolarEuro = d - e;

            Console.WriteLine("Resultado dolar + pes {0:N2}", sumaDolarPeso.GetCantidad());
            Console.WriteLine("Resultado dolar + euro {0:N2}", sumaDolarEuro.GetCantidad());
            Console.WriteLine("Resultado dolar - peso {0:N2}", restaDolarPeso.GetCantidad());
            Console.WriteLine("Resultado dolar - euro {0:N2}\n", restaDolarEuro.GetCantidad());


            Euro sumaEuroPeso = e + p;
            Euro sumaEuroDolar = e + d;
            Euro restaEuroPeso = e - p;
            Euro restaEuroDolar = e - d;

            Console.WriteLine("Resultado euro + pes {0:N2}", sumaEuroPeso.GetCantidad());
            Console.WriteLine("Resultado euro + dolar {0:N2}", sumaEuroDolar.GetCantidad());
            Console.WriteLine("Resultado euro - peso {0:N2}", restaEuroPeso.GetCantidad());
            Console.WriteLine("Resultado euro - dolar {0:N2}\n", restaEuroDolar.GetCantidad());
            #endregion

            Console.ReadKey();
        }
    }
}
