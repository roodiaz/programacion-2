using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Rectangulo: Figura
    {
        private double baase;
        private double altura;

        public Rectangulo(double baase, double altura)
        {
            this.baase = baase;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this.baase * this.altura / 2;
        }

        public override double CalcularPerimetro()
        {
            return (this.baase + this.altura) * 2;
        }
    }
}
