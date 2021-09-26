using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        public float GanaciaPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciaPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganacia = 0;

            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                            ganacia += ((Local)item).CostoLlamada;
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                            ganacia += ((Provincial)item).CostoLLamada;
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (item is Local)
                            ganacia += ((Local)item).CostoLlamada;
                        else if (item is Provincial)
                            ganacia += ((Provincial)item).CostoLLamada;
                        break;
                }              
            }

            return ganacia;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"#############    CENTRALITA: {this.razonSocial}    ##############\n");
            sb.AppendLine($"Ganancias llamadas local: {this.GanaciaPorLocal}");
            sb.AppendLine($"Ganancias llamadas provincial: {this.GananciaPorProvincial}");
            sb.AppendLine($"Ganancias totales: {this.GananciaPorTotal}\n");
            sb.AppendLine($"#############    LISTA LLAMADAS    ##############");
            foreach (Llamada item in this.Llamadas)
            {
                sb.Append(item.Mostrar());
            }

            return sb.ToString();
        }

    }
}