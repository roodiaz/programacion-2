using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banano: Planta
    {
        private string codigo;

        public Banano(string nombre, int tamaño, string codigo)
            :base(nombre, tamaño)
        {
            this.codigo = codigo;
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFrutos
        {
            get { return true; }
        }

        public override string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDatos());
            sb.Append($"Código internacional {this.codigo}\n");

            return sb.ToString();
        }
    }
}
