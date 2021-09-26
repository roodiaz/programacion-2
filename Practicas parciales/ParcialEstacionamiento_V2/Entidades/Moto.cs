using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entidades
{
    public class Moto: Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport}

        private ETipo tipo;
        private static double valorHora;

        public override double CostoEstadia
        {
            get { return this.CargoEstacionamiento(); }
        }

        public override string Descripcion
        {
            get { return this.tipo.ToString(); }
        }

        public double ValorHora
        {
            set
            {
                if (value > 0)
                    Moto.valorHora = value;
            }
        }

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            :base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        protected new double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento() * Moto.valorHora;
        }

        protected new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO\n");
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"\nTipo: {this.Descripcion}");
            
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
