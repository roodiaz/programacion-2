using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Trooper
    {
        private string vehiculo;


        public override string Tipo
        {
            get { return "Soldado de exploracion"; }
        }

        /// <summary>
        /// propiedad lectura y escritura
        /// asigna valor "indefinido" si se ingresa strng nulo
        /// </summary>
        public string Vehiculo
        {
            get
            {
                return this.vehiculo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    this.vehiculo = "Indefinido";
                else
                    this.vehiculo = value;
            }
        }

        public TrooperExplorador(string vehiculo)
            :base(Blaster.EC17)
        {
            this.Vehiculo = vehiculo;
        }

        public override string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.InfoTrooper());
            sb.Append($" - Vehículo: {this.Vehiculo}");

            return sb.ToString();
        }
    }
}
