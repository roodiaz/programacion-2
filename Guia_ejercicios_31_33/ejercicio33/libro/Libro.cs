using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libro
{
    public class Libro
    {
        private List<string> paginas;

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < this.paginas.Count)
                    return this.paginas[index];
                else
                    return string.Empty;
            }
            set
            {
                if (this.paginas is null)
                    this.paginas = new List<string>();
                if (index < this.paginas.Count && index > 0)
                    this.paginas[index] = value;
                else
                    this.paginas.Add(value);
            }
        }
    }
}
