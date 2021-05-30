using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        /*Generar la clase OtraClase con un método de instancia, donde se instancie un objeto
MiClase y se capture la excepción anterior. Este método generará una excepción propia
llamada MiException y la lanzará.*/

        public void CapturarExMiClase()
        {
            try
            {
               new MiClase(string.Empty);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("mi excepcion", e);
            }
        
        }
    }
}
