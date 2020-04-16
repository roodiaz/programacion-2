using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private int totalGoles;
        private int partidosJugados;
        private float promedioGoles;
        private string nombre;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles()
        {
            if(this.partidosJugados == 0)
                this.promedioGoles = 0;
            else
               this.promedioGoles = (float)this.totalGoles / this.partidosJugados;

            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine($"Nombre {this.nombre}");
            cadena.AppendLine($"DNI {this.dni}");
            cadena.AppendLine($"Partidos jugandos {this.partidosJugados}");
            cadena.AppendLine($"Total goles {this.totalGoles}");
            cadena.AppendLine($"Promedio goles {this.GetPromedioGoles()}");

            return cadena.ToString();
        }

        public static bool operator==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }

    }
}
