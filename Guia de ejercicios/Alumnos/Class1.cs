using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        Random numeroAleatorio = new Random();

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
                this.notaFinal = numeroAleatorio.Next(1, 10);
            else
                this.notaFinal = -1;
        }

        public string Mostrar()
        {
            string retorno = $"nombre: {this. nombre}\n" +
                             $"apellido: {this.apellido}\n" +
                             $"legajo: {this.legajo}\n" +
                             $"primer parcial: {this.nota1}\n" +
                             $"segundo parcial: {this.nota2}\n";

            if (this.notaFinal != -1)
                retorno += $"nota final: {this.notaFinal}\n\n";
            else
                retorno += "nota final: desabrobado\n\n";

            return retorno;
        }   

    }
}
