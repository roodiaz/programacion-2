using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio46
{
    public class AutoF1: VehiculoDeCarrera
    {
        private short caballoDeFuerza;

        public short CaballoDeFuerza
        {
            get { return this.caballoDeFuerza; }
            set { this.caballoDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia)
            :base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballoDeFuerza)
            : this(numero, escuderia)
        {
            this.caballoDeFuerza = caballoDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballoDeFuerza}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {
            return (f1.Numero == f2.Numero && f1.Escuderia == f2.Escuderia && f1.CaballoDeFuerza == f2.CaballoDeFuerza);             
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }
        
    }
}
