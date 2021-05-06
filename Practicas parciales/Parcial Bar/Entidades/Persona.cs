using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        protected Persona(string nombre, short edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public short Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                if(value >0)
                    this.edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                    this.nombre = value;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo: {this.GetType().Name}");

            if (!(String.IsNullOrWhiteSpace(this.Nombre)))
            {
                sb.AppendLine($"Nombre: {this.Nombre}");
            }
            if (!(String.IsNullOrWhiteSpace(this.Nombre)))
            {
                sb.AppendLine($"Edad: {this.Edad}");
            }

            return sb.ToString();
        }

        public abstract bool Validar();

        public static explicit operator string(Persona p)
        {
            return p.Mostrar();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
