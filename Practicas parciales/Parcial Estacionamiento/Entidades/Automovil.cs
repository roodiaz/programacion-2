using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil: Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            :base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            :this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo {this.GetType().Name}");
            sb.AppendLine($"Ingreso {this.ingreso}");
            sb.AppendLine($"Patente {this.Patente}");
            sb.AppendLine($"Color {this.color}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int intervalo = DateTime.Now.Hour - this.ingreso.Hour;
            int costoEstadia = intervalo * Automovil.valorHora;

            sb.Append($"Ticket ");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Value: {costoEstadia}\n\n");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }
    }
}
