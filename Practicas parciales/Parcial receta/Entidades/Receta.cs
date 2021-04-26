using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Receta
    {
        public enum Tipo
        {
            Clasica,
            Especial
        }

        private List<Ingrediente> ingredientes;
        private int CapacidadDelContenedor;
        private static Tipo preparacion;

        static Receta()
        {
            Receta.preparacion = Tipo.Clasica;
        }

        private Receta()
        {
            this.ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad)
            :this()
        {
            this.CapacidadDelContenedor = capacidad;
        }

        public Tipo TipoDePreparacion
        {
            set
            {
                Receta.preparacion = value;
            }
        }

        private int CapacidadLibre()
        {
            int libre = CapacidadDelContenedor;

            foreach (Ingrediente item in this.ingredientes)
            {
                libre = libre - item.Cantidad;
            }

            return libre;
        }

        private int CapacidadLibre(Ingrediente planta)
        {
            return CapacidadLibre() - planta.Cantidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Receta: {Receta.preparacion}");
            sb.AppendLine($"Capacidad Libre: {this.CapacidadLibre()}");
            sb.AppendLine($"Capacidad Total: {this.CapacidadDelContenedor}");
            sb.AppendLine($"Lista de ingredientes:");

            foreach (Ingrediente item in this.ingredientes)
            {
                sb.AppendLine(item.Informacion());
            }

            sb.AppendLine("\n\n");

            return sb.ToString();

        }

        public static bool operator +(Receta r, Ingrediente i)
        {
            if(!(r is null) && !(i is null))
            {
                if(r.CapacidadLibre(i) >= 0)
                {
                    r.ingredientes.Add(i);
                    return true;
                }
            }

            return false;
        }

    }
}
