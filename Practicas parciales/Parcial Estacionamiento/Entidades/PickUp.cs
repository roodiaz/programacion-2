using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp: Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora)
            : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo {this.GetType().Name}");
            sb.AppendLine($"Ingreso {this.ingreso}");
            sb.AppendLine($"Patente {this.Patente}");
            sb.AppendLine($"Modelo {this.modelo}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int intervalo = DateTime.Now.Hour - this.ingreso.Hour;
            int costoEstadia = intervalo * PickUp.valorHora;

            sb.Append($"Ticket ");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Value: {costoEstadia}\n\n");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
