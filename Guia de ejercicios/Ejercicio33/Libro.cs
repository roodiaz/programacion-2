using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int i]
        {
            get {

                //si la pagina existe la retorna
                if (i >= 0 && i < this.paginas.Count())
                    return this.paginas[i];
                else
                    //sino existe retorna vacio
                    return string.Empty;
            
            }

            set {

                if (this.paginas is null)
                    //si la lista esta vacia creo una
                    this.paginas = new List<string>();
                if (i < this.paginas.Count() && i > 0)
                    //si la pagina ya existe guardo y/o sobreescribo
                    this.paginas[i] = value;//value es el valor que se pasa
                else
                    //sino existe la pagina agrego una nueva
                    this.paginas.Add(value);
            
            }

        }
    }
}
