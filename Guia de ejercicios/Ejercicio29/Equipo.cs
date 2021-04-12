using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        private List<Jugador> jugadores;
        private short cantidadDeJugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool esta = false;

            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        esta = true;
                        break;
                    }                
                }
                if (!esta)
                {
                    e.jugadores.Add(j);
                    return true;
                }
            }

            return false;
        }

        public string MostrarEquipo(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del equipo: {this.nombre}");
            sb.AppendLine($"Cantidad de jugadores: {this.cantidadDeJugadores}");
            sb.AppendLine($"Jugadores: \n");

            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.MostrarJugador());
            }

            return sb.ToString();
        }
    }
}
