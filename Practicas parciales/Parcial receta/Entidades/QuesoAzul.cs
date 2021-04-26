using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class QuesoAzul: Ingrediente
    {
        public enum Procedencia 
        { 
            Francia, Argentina, Italia 
        }

        private Procedencia procedencia;

        public QuesoAzul(string descripcion, int cantidad)
            : base(descripcion, cantidad)
        {
            
        }

        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia)
            : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }

        public override string Proceso
        {
            get
            {
                return "desgranar";
            }
        }

        public override string UnidadDeMedida
        {
            get
            {
                return "gramos";
            }
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Procedente de {this.procedencia}\n");

            return sb.ToString();
        }
    }
}
