using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
             : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Local);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Todas);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Provincial);
            }
        }

        #endregion

        #region Metodos

        private float CalcularGanancia(Llamada.TipoLLamada tipo)
        {
            float ganancia = 0;

            //recorre llamdas realizas en lista
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLLamada.Local)
                {
                    if (llamada is Local)
                        ganancia += ((Local)llamada).CostoLlamada;
                }

                if (tipo == Llamada.TipoLLamada.Provincial)
                {
                    if (llamada is Provincial)
                        ganancia += ((Provincial)llamada).CostoLlamada;
                }

                if (tipo == Llamada.TipoLLamada.Todas)
                {
                    if (llamada is Local)
                        ganancia += ((Local)llamada).CostoLlamada;
                    if (llamada is Provincial)
                        ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }

            return ganancia;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Razon Social: {this.razonSocial}.\n");
            sb.Append($"Costo Total Local: {this.GananciasPorLocal}.\n");
            sb.Append($"Costo Total Provincial: {this.GananciasPorProvincial}.\n");
            sb.Append($"Costo Total Llamadas: {this.GananciasPorTotal}.\n");
            sb.Append("\nLlamadas:\n\n");
            foreach (Llamada llamada in Llamadas)
            {
                sb.Append(llamada.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada l1)
        {
            this.listaDeLlamadas.Add(l1);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Operadores   
        public static bool operator ==(Centralita c, Llamada l1)
        {
            if (!(c is null) && !(l1 is null))
            {
                foreach (Llamada llamada in c.listaDeLlamadas)
                {
                    if (llamada == l1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Centralita c, Llamada l1)
        {
            return !(c == l1);
        }

        public static Centralita operator +(Centralita c, Llamada l1)
        {
            if (!(c is null) && !(l1 is null))
            {
                if (c != l1)
                {
                    if ((l1 is Local) || (l1 is Provincial))
                    {
                        c.AgregarLlamada(l1);
                        return c;
                    }
                }
            }

            return c;
        }
        #endregion
    }
}
