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
      //  private float promedioGoles;
        private string nombre;

        #region constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
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
        #endregion

        #region Propiedades
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        { 
            get
            {          
                if (this.partidosJugados <= 0)
                    return 0;
                else
                    return (float)this.totalGoles / this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value >= 0 && value < int.MaxValue)
                    this.dni = value;
                else
                    this.dni = -1;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine($"Nombre {Nombre}");
            cadena.AppendLine($"DNI {Dni}");
            cadena.AppendLine($"Partidos jugandos {PartidosJugados}");
            cadena.AppendLine($"Total goles {TotalGoles}");
            cadena.AppendLine($"Promedio goles {PromedioGoles}");

            return cadena.ToString();
        }

        #region Operadores
        public static bool operator==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
        #endregion
    }
}
