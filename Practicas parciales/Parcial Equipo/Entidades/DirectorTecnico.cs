using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        private int aniosExperiencia;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="experiencia"></param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int experiencia)
            :base(nombre, apellido, edad, dni)
        {
            this.aniosExperiencia = experiencia;
        }

        /// <summary>
        /// 
        /// </summary>
        public int AñosExperiencia
        {
            get
            {
                return this.aniosExperiencia;
            }

            set
            {
                if(value>=0)
                    this.aniosExperiencia = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            if (this.Edad < 65 && this.aniosExperiencia > 2)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"Años de experiencia: {this.aniosExperiencia}\n");

            return sb.ToString();
        }
    }
}
