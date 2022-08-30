using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
        public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            if(nota > 10 || nota < 1)
            {
                this.notaPrimerParcial = 1;
            }

            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 10 || nota < 1)
            {
                this.notaSegundoParcial = 1;
            }

            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 10);
            }

            return -1;
        }

        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            informacion.AppendLine($"{this.nombre}, {this.apellido}");
            informacion.AppendLine($"Legajo: {this.legajo}");
            informacion.AppendLine($"Primer parcial: {this.notaPrimerParcial}");
            informacion.AppendLine($"Segundo parcial: {this.notaSegundoParcial}");
            informacion.AppendLine($"Promedio: {this.CalcularPromedio()}");
            if(notaFinal != -1)
            {
                informacion.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                informacion.AppendLine("Alumno desaprobado");
            }

            return informacion.ToString();
        }
    }

}
