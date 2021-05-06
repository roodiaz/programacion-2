using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {

        /*Capturar la excepción del metodp estatico en un constructor de instancia y relanzarla hacia
        otro constructor de instancia.*/
        public MiClase()
        {
            try
            {
                MiClase.LanzarDivideByZero();
                //atrapo exepcion lanzada por metodo estatico
            }
            catch (DivideByZeroException e)
            {
                throw e;
                //relanzo exepcion sin instanciarla de nuevo porque ya fue instanvciada en el metodo
            }
        }

        
        /*En este segundo constructor instanciará otro objeto del tipo MiClase capturando su
excepción. Crear una excepción propia llamada UnaException (utilizar innerException para
almacenar la excepción original) y volver a lanzarla.*/
        public MiClase(string nulo/*parametro sin uso, solo para poder sobrecargar*/)
        {
            try
            {
                MiClase clase = new MiClase();
            }
            catch (DivideByZeroException e)
            {

                throw new UnaExcepcion("una exepcion",e);
                //caputuro la excepcion e y la guardo en una nueva excepcion para volver a lanzarla
            }
        }

        //Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        public static void LanzarDivideByZero()
        {
            throw new DivideByZeroException();
            //instancio nueva exepcion y la lanzo
        }


    }
}
