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
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(),vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

        }
        #endregion

        #region Metodos
        public float Area()
        {
            float basee, altura;

            basee = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            altura =Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.area = basee * altura;
            return this.area;
        }

        public float Perimetro()
        {
            float basee, altura;

            basee = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.perimetro = (basee + altura) * 2;
            return this.perimetro;
        }


        public static string Mostrar(Rectangulo datosRec)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("INFORMACIO DEL RECTANGULO:");
            datos.AppendLine(string.Format("Area del rectangulo {0}. Perimetro del rectangulo {1}",datosRec.area,datosRec.perimetro));

            return datos.ToString();
        }
        #endregion
    }
}
