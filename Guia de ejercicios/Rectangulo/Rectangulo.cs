using System;
using System.Text;

namespace CalculoRectangulo
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        float basee;
        float altura;

        /*
            v1               v2
              ---------------    
              |             |
              |             |
              |             |
              ---------------
             v4             v3
        */
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = new Punto(vertice1.GetX(), vertice1.GetY());
            this.vertice3 = new Punto(vertice3.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());

            basee = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());

        }

        public float GetArea() { return this.area; }

        public float GetPerimetro() { return this.perimetro; }

        public float Area()
        {
            
            if (GetArea() == 0)          
                this.area = basee * altura;

            return GetArea();
        }

        public float Perimetro()
        {
            if (GetPerimetro() == 0)
                this.perimetro = (basee + altura) * 2;

            return GetPerimetro();
        }

        public static string MostrarDatos(Rectangulo datos)
        {
            StringBuilder cadenaAMostrar = new StringBuilder();

            cadenaAMostrar.AppendLine("INFORMACION RECTANGULO: ");
            cadenaAMostrar.AppendLine(string.Format("\nVertice 1 ({0},{1})", datos.vertice1.GetX(), datos.vertice1.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 2 ({0},{1})", datos.vertice2.GetX(), datos.vertice3.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 3 ({0},{1})", datos.vertice3.GetX(), datos.vertice3.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 4 ({0},{1})", datos.vertice4.GetX(), datos.vertice4.GetY()));
            cadenaAMostrar.AppendLine(string.Format("\nArea del rectangulo " + datos.GetArea()));
            cadenaAMostrar.AppendLine(string.Format("Perimetro del rectangulo " + datos.GetPerimetro()));

            return cadenaAMostrar.ToString();
        }

    }
}
