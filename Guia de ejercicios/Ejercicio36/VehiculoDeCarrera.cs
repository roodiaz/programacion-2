using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
      
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia=value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Escuderia = escuderia;
            this.Numero = numero;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
            this.EnCompetencia = false;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nEscuderia: {this.Escuderia}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");          
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible}");
            if(this.EnCompetencia)
             sb.AppendLine("En competencia: Si");
            else
                sb.AppendLine("En competencia: No");

            return sb.ToString();
        }

    }
}
