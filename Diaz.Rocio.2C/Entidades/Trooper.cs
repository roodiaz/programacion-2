using System;
using System.Text;

namespace Entidades
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        /// <summary>
        /// propiedad abstracta de solo lectura para implementar en clases heradadas
        /// </summary>
        public abstract string Tipo { get; }
        
        /// <summary>
        /// Propiedad solo lectura de propiedad esClonr
        /// </summary>
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }

            set
            {
                this.esClon = value;
            }
        }

        public Blaster Armamento
        {
            get { return this.armamento; }
        }


       public Trooper(Blaster armamento)
          :this(armamento,false)
        {
            
        }

        public Trooper(Blaster armamento, bool esClon)
        {
            this.EsClon = esClon;
	    this.armamento = armamento;
        }

        /// <summary>
        /// imprime informacion sobre soldado
        /// </summary>
        /// <returns>string con la informacion</returns>
        public virtual string InfoTrooper()
        {
           // StringBuilder sb = new StringBuilder();

           // sb.AppendFormat("{0} armado con {1}, ",this.Tipo, this.Armamento);
           // if(this.esClon)
               // sb.AppendFormat("SI es clon ");
           // else
               // sb.AppendFormat("NO es clon ");

          return string.Format("{0} armado con {1}, {2} es clone",this.Tipo, this.Armamento, this.Esclon ? "SI" : "NO");


           // return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
              
        }
    }
}
