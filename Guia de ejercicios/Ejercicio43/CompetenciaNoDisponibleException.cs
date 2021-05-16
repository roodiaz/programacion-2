using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    public class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
            set { this.nombreClase = value; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
            set { this.nombreMetodo = value; }
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje, clase,metodo, null)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"excepcion del metodo {this.nombreMetodo} de la clase {this.nombreClase}");
            sb.AppendLine("error al agregar vehiculo");
            sb.AppendLine($"detalles {this.InnerException}");
            return base.ToString();
        }
    }
}
