using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        private int cilandra;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;
        }

        public Moto(string patente, int cilandra)
            : base(patente)
        {
            this.ruedas = 2;
            this.cilandra = cilandra;
        }

        public Moto(string patente, int cilandra, short ruedas)
            :this(patente, cilandra)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilandra, short ruedas, int valorHora)
            : this(patente, cilandra, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo {this.GetType().Name}");
            sb.AppendLine($"Ingreso {this.ingreso}");
            sb.AppendLine($"Patente {this.Patente}");
            sb.AppendLine($"Ruedas {this.ruedas}");
            sb.AppendLine($"Cilindrada {this.cilandra}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int intervalo = DateTime.Now.Hour - this.ingreso.Hour;
            int costoEstadia = intervalo * Moto.valorHora;

            sb.Append($"Ticket ");
            sb.Append(this.ConsultarDatos());
            sb.AppendLine($"Value: {costoEstadia}\n\n");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }
    }
}
