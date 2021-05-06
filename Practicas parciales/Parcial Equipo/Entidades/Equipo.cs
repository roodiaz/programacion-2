using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaxJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        /// <summary>
        /// 
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        public Equipo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// 
        /// </summary>
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    this.directorTecnico = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            int defensor = 0;
            int delantero = 0;
            int arquero = 0;
            int central = 0;

            if (e.jugadores.Count == 6)
            {
                foreach (Jugador item in e.jugadores)
                {
                    switch (item.Posicionn)
                    {
                        case Posicion.Arquero:
                            arquero++;
                            break;
                        case Posicion.Central:
                            central++;
                            break;
                        case Posicion.Defensor:
                            defensor++;
                            break;
                        case Posicion.Delantero:
                            delantero++;
                            break;
                    }
                }

                if (delantero >= 1 && defensor >= 1 && arquero == 1 && central >= 1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre equipo: {e.Nombre}");
            if (!(e.directorTecnico is null))
            {
                sb.AppendLine($"Director tecnioc: { e.directorTecnico.Mostrar()}");
            }
            else
            {
                sb.AppendLine("Sin DT Asignado\n");
            }

            sb.AppendLine("Jugadores:");
            foreach (Jugador jugador in e.jugadores)
            {
                sb.Append(jugador.Mostrar());
                sb.AppendLine("############\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.jugadores.Contains(j);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < Equipo.cantidadMaxJugadores)
            {
                if (j.ValidarAptitud() && j.ValidarEstadoFisico())
                {
                    e.jugadores.Add(j);
                }
            }

            return e;
        }
    }
}
