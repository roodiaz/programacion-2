using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Llamada:
b. La clase Llamada, tendrá todos sus atributos con el modificador protected. Crear las
propiedades de sólo lectura para exponer estos atributos.
c. OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para
ordenar una lista de llamadas de forma ascendente.
d. Mostrar es un método de instancia. Utiliza StringBuilder.*/

namespace CentralitaHerencia
{
    public class Llamada
    {   
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLLamada { Local, Provincial, Todas}

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string Destino
        {
            get { return this.nroDestino; }
        }

        public string Origen
        {
            get { return this.nroOrigen; }
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Duracion llamada: {Duracion}\n");
            sb.Append($"Nro destino: {Destino}\n");
            sb.Append($"Nro origen: {Origen}\n");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            if (l1.duracion < l2.duracion)
                return 1;
            else if (l1.duracion > l2.duracion)
                return -1;
            else
                return 0;
        }
        #endregion
    }
}
