using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente: Persona
    {
        public Gente(short edad)
            : base("", edad)
        {

        }

        public override bool Validar()
        {
            return this.Edad > 18;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
