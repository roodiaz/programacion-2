using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Persona
    {
        private int dni;

        public Empleado(string nombre, short edad)
            :base(nombre, edad)
        {
            this.dni = -1;
        }

        public Empleado(string nombre, short edad, int dni)
            :this(nombre, edad)
        {
            this.dni = dni;
        }

        public override bool Validar()
        {
            if (this.Edad >= 21 && this.Nombre.Length >= 2)
                return true;

            return false;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.Edad == e2.Edad && e2.Nombre == e2.Nombre)
                return true;

            return false;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

    }
}
