using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espaciopDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            :this()
        {
            this.nombre = nombre;
            this.espaciopDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre {e.nombre}");
            sb.AppendLine($"Espacio disponible {e.espaciopDisponible}");
            sb.AppendLine($"Lista de vehiculos: ");
            sb.AppendLine("\n");

            foreach (Vehiculo item in e.vehiculos)
            {
                sb.Append(item.ConsultarDatos());
                sb.AppendLine("\n\n");
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            if (!(e is null) && !(v is null))
            {
                foreach (Vehiculo item in e.vehiculos)
                {
                    if (item == v)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v)
            {
                
                    if (e.vehiculos.Count < e.espaciopDisponible)
                    {
                        e.vehiculos.Add(v);
                    }
                             
            }

            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if (e == v)
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }

            return "El vehículo no es parte del estacionamiento";
        }

    }
}
