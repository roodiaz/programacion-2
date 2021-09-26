using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            else
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;

            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"########## Estacionamiento {this.Nombre} ###########");
            sb.Append(vehiculo.ToString());
            sb.AppendLine($"Salida: {vehiculo.HoraEgreso.ToString()}");
            sb.AppendLine($"Costo estadia: {vehiculo.CostoEstadia.ToString("00.0")}");


            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {

            foreach (Vehiculo item in e.ListadoVehiculos)
            {
                if (v == item)
                {
                    return true;
                }

            }

            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static bool operator +(Estacionamiento e, Vehiculo v)
        {

            if (e.ListadoVehiculos.Count < e.capacidadEstacionamiento)
            {
                if (e != v)
                {
                    e.ListadoVehiculos.Add(v);
                    return true;
                }
            }

            return false;
        }

        public static bool operator -(Estacionamiento e, Vehiculo v)
        {          
                if (e == v)
                {
                    v.HoraEgreso = DateTime.Now;
                    e.ListadoVehiculos.Remove(v);
                    return true;
                }
                        
            return false;
        }
    }
}
