using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length == 6)
                    this.patente = value;
                else
                    this.patente = String.Empty;
            }
        }

        public abstract string ConsultarDatos();      

        public override string ToString()
        {
            return String.Format("Patente {0}", this.patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.ToString());
            sb.Append($"Fecha de ingreso {this.ingreso}\n");

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.Equals(v2) && v2.Equals(v1) && v1.Patente == v2.Patente)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
