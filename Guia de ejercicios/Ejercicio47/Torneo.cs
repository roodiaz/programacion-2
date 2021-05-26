using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        //private List<Equipo> equipos;
        private string nombre;
        private static Random rnd = new Random();

        private Torneo()
        {
            this.equipos = new List<T>();
            //this.equipos=new List<Equipo>()
        }

        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"TORNEO: {this.nombre}");
            foreach (Equipo item in this.equipos)
            {
                sb.Append(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T t1, T t2)//t = Equipo
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Partidos: ");
            sb.AppendLine($"[{t1.Nombre} {rnd.Next(1, 11)}] - [{rnd.Next(1, 11)} {t2.Nombre}]");

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int e1 = rnd.Next(0, this.equipos.Count);
                int e2 = rnd.Next(0, this.equipos.Count);

                if (this.equipos.Count >= 1)
                {
                    while (e1 == e2)
                    {
                        e2 = rnd.Next(0, this.equipos.Count);
                    }
                    return CalcularPartido(this.equipos[e1], this.equipos[e2]);
                }

                return string.Empty;
            }
        }

        public static bool operator ==(Torneo<T> t, Equipo e)
        {
            foreach (T item in t.equipos)
            {
                if (item == e)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Torneo<T> t, Equipo e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, Equipo e)
        {
            if(t != e)
            {
                t.equipos.Add((T)e);
            }

            return t;
        }
    }
}
