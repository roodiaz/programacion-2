using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarCompetencia(Competencia c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad vueltas {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad competidores {this.cantidadCompetidores}");
            sb.AppendLine($"Competiodes: ");

            foreach (AutoF1 item in c.competidores)
            {
                sb.AppendLine(item.MostrarAuto());
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c.competidores.Contains(a));
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool todoOk = false;
            Random rnd = new Random();

            if (c.competidores.Count < c.cantidadCompetidores)
            {
                if (c != a)
                {
                    a.SetCompetencia(true);
                    a.SetVueltas(c.cantidadVueltas);
                    a.SetCombustible((short)rnd.Next(15, 100));
                    todoOk = true;
                }

            }

            return todoOk;
        }
    }
}
