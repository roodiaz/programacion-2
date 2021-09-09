using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical:Aplicacion
    {
        private List<string> listaCanciones;

        /// <summary>
        /// propiedad solo lectura tamanio de apo  musical
        /// </summary>
        protected override int Tamanio
        {
            get
            {              
                if(!(this.listaCanciones is null))
                {
                    int aux = this.tamanioMb;
                    return aux += this.listaCanciones.Count * 2;
                }
                else
                {
                    return this.tamanioMb = 0 ;
                }
            }
        }

        /// <summary>
        /// constructor de app musical
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sisOp"></param>
        /// <param name="tamanio"></param>
        public AppMusical(string nombre, ESistemaOperativo sisOp, int tamanio)
            : base(nombre, sisOp, tamanio)
        {
            this.listaCanciones = new List<string>();
        }

        /// <summary>
        /// constructor de app musical
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sisOp"></param>
        /// <param name="tamanio"></param>
        /// <param name="lista"></param>
        public AppMusical(string nombre, ESistemaOperativo sisOp, int tamanio, List<string> lista)
            : this(nombre, sisOp, tamanio)
        { 
            this.listaCanciones = lista;
        }

        /// <summary>
        /// retorna informacion de app  musical
        /// </summary>
        /// <returns></returns>
        public override string InfoApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.InfoApp());
            sb.Append("###### LISTA CANCIONES ######\n");

            foreach (string item in this.listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
