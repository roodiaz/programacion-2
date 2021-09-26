using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        public override double CostoEstadia
        {
            get { return this.CargoEstacionamiento(); }
        }

        public override string Descripcion
        {
            get { return this.marca; }
        }

        public double ValorHora
        {
            set
            {
                if (value > 0)
                    Automovil.valorHora = value;
            }
        }

        static Automovil()
        {
            Automovil.valorHora = 120;
        }

        public Automovil(string patente, DateTime horaIngreso, string marca)
            : base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        protected new double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento() * Automovil.valorHora;        
        }

        protected new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL\n");
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"\nMarca: {this.Descripcion}");
            
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
