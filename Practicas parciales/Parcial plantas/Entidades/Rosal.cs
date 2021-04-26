using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal: Planta
    {
        public enum Color 
        { 
            Roja, Blanca, Amarrilla, Rosa,Azul
        }

        private Color florColor;

        public Rosal(string nombre, int tamaño)
            : base(nombre, tamaño)
        {

        }

        public Rosal(string nombre, int tamaño, Color flor)
            : base(nombre, tamaño)
        {
            this.florColor = flor;
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override bool TieneFrutos
        {
            get { return false; }
        }

        public override string ResumenDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDatos());
            sb.Append($"Flores de color {this.florColor}\n");

            return sb.ToString();
        }
    }
}
