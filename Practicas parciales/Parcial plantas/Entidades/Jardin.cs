using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo { Terrozo, Arenozo}

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal = espacioTotal;
        }

        public Tipo TipoSuelo
        {
            set { this.TipoSuelo = value; }
        }

        private int EspacioOcupado()
        {
            int tamañoTotal=0;

            if(this.plantas != null)
            {
                foreach (Planta item in this.plantas)
                {
                    tamañoTotal += item.Tamaño;
                }
            }

            return tamañoTotal;
            
        }

        private int EspacioOcupado(Planta p)
        {
            int espacioOcupado = EspacioOcupado();

            return espacioOcupado + p.Tamaño;

        }

        public static bool operator +(Jardin j, Planta p)
        {
            if (j.EspacioOcupado(p) <= j.espacioTotal)
            {
                j.plantas.Add(p);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Composicion del jardin {Jardin.suelo} -");
            sb.Append($"Espacio ocupado {EspacioOcupado()} - ");

            if(this.plantas != null)
            {
                foreach  (Planta item in this.plantas)
                {
                    sb.Append(item.ResumenDatos()); //hace override de rosal y banano
                }
            }

            return sb.ToString();
        }

    }
}
