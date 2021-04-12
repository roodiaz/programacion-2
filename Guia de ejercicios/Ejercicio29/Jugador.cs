using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if (this.partidosJugados <= 0)
                return 0;
            else
                return this.promedioGoles= (float)this.totalGoles / this.partidosJugados; 
        }

        public string MostrarJugador()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.nombre} ");
            sb.Append($"DNI: {this.dni} ");
            sb.Append($"Partidos jugados: {this.partidosJugados} ");
            sb.Append($"Total goles: {this.totalGoles} ");
            sb.Append($"Promedio goles: {GetPromedioGoles()}\n");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
