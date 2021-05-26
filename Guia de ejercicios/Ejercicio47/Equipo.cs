using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE EQUIPO: {this.nombre}");
            sb.AppendLine($"FECHA CREACION: {this.fechaCreacion}");

            return sb.ToString();
        }

        public string Nombre
        {
            get { return this.nombre; }
        }


        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.fechaCreacion == e2.fechaCreacion && e1.nombre == e2.nombre);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
