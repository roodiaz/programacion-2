using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto: Planta
    {

        public Arbusto(string nombre, int tamaño)
            : base(nombre, tamaño)
        {

        }

        public override bool TieneFlores
        {
            get { return false; }
        }

        public override bool TieneFrutos
        {
            get { return false; }
        }
    }
}
