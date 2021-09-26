using System;
using System.Text;
using System.Globalization;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto }

        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set
            {
                if (value > this.HoraIngreso)
                    this.horaEgreso = value;
 
            }
        }

        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        public string Patente
        {
            get { return this.patente; }
            set
            {
                if (this.ValidarPatente(value))
                    this.patente = value;

            }
        }

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        private bool ValidarPatente(string patente)
        {
            return (patente.Length >= 6 && patente.Length < 8);
        }

        protected virtual double CargoEstacionamiento()
        {
            double horas=0;

            if(this.horaEgreso > this.horaIngreso)
                horas= (this.HoraEgreso - this.HoraIngreso).TotalHours;

            return horas;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {this.Patente}\n");
            sb.AppendLine($"Ingreso: {this.horaIngreso}\n");           

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
