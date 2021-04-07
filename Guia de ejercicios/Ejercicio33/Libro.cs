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

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get {

                //si la pagina existe la retorna
                if (i >= 0 && i < this.paginas.Count())
                    return this.paginas[i];
                else
                    //si no existe retorna vacio
                    return string.Empty;
            
            }

            set {

                if (i >= 0 && i < this.paginas.Count())
                    //si la pagina ya existe guardo y/o sobreescribo
                    this.paginas[i] = value;//value es el valor que se pasa
                else
                    //si no existe agrego el elemento al final de la lsita
                    this.paginas.Add(value);
            
            }

        }
    }
}
