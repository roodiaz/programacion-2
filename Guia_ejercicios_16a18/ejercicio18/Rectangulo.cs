using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* a. La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4
(que corresponden a los cuatro vértices del rectángulo).
c. La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
obtener la distancia entre puntos).
d. Realizar los métodos getters para los atributos privados área y perímetro.
e. Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo
una vez, al llamar por primera vez a su correspondiente método getter. Luego se deberá
retornar siempre el mismo valor. */

namespace Geometria
{
    class Rectangulo
    {
        #region Atributos
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #endregion

        #region Constructor
        public Rectangulo (Punto vertice1, Punto vertice3)// v1 esta en diagonal al v3
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.area = 0;
            this.perimetro = 0;
        }
        #endregion

        #region Metodos
        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public float Area()
        {
            float basee, altura;          

            if(this.area == 0)
            {
                altura = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                basee = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = basee * altura;
            }

            return GetArea();
        }

        public float Perimetro()
        {
            float basee, altura;

            if(this.perimetro ==0)
            {
                altura = Math.Abs(this.vertice2.GetX() - this.vertice4.GetX());
                basee = Math.Abs(this.vertice2.GetY() - this.vertice4.GetY());
                this.perimetro = (basee + altura) * 2;
            }
            
            return GetPerimetro();
        }

        public static string MostrarDatos(Rectangulo datos)
        {
            StringBuilder cadenaAMostrar = new StringBuilder();

            cadenaAMostrar.AppendLine("INFORMACION TRIANGULO: ");
            cadenaAMostrar.AppendLine(string.Format("\nVertice 1 ({0},{1})", datos.vertice1.GetX(), datos.vertice1.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 2 ({0},{1})", datos.vertice2.GetX(), datos.vertice3.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 3 ({0},{1})", datos.vertice3.GetX(), datos.vertice3.GetY()));
            cadenaAMostrar.AppendLine(string.Format("Vertice 4 ({0},{1})", datos.vertice4.GetX(), datos.vertice4.GetY()));
            cadenaAMostrar.AppendLine(string.Format("\nArea del rectangulo "+datos.GetArea()));
            cadenaAMostrar.AppendLine(string.Format("Perimetro del rectangulo "+datos.GetPerimetro()));

            return cadenaAMostrar.ToString();
        }

        #endregion
    }
}
