using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected ESistemaOperativo sistemaOp;
        protected int tamanioMb;

        /// <summary>
        /// Propiedad que devuelve tipo de sistema de la app
        /// </summary>
        public ESistemaOperativo SistemaOperativo
        {
            get { return this.sistemaOp; }
        }

        /// <summary>
        /// propiedad abstracta que debe implementarse en las clases derivadas
        /// </summary>
        protected abstract int Tamanio { get; }

        /// <summary>
        /// constructor de aplicacion
        /// </summary>
        /// <param name="nombre">nombre de app</param>
        /// <param name="sisOp">s.o de app</param>
        /// <param name="tamanio">tamanio de app</param>
        protected Aplicacion(string nombre, ESistemaOperativo sisOp,int tamanio)
        {
            this.nombre = nombre;
            this.sistemaOp = sisOp;
            this.tamanioMb = tamanio;
        }

        /// <summary>
        /// retorna informacion de aplicacion
        /// </summary>
        /// <returns></returns>
        public virtual string InfoApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE APP: {this.nombre}");
            sb.Append($"SISTEMA OPERATIVO: {this.SistemaOperativo}\n");
            sb.AppendFormat("TAMANIO: {0}", this.Tamanio);

            return sb.ToString();
        }

        /// <summary>
        /// retorno solo nombre de la app
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// devuelve aplicacion con mayor tamanio
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion aux = null;

            if (!(listaApp is null))
            {                
                int max = 0;

                foreach (Aplicacion item in listaApp)
                {
                    if (item.Tamanio > max)
                    {
                        max = item.Tamanio;
                        aux = item;
                        
                    }                     
                }
            }

            return aux;
        } 

        /// <summary>
        /// retorna true si la app existe en el lista, false sino
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
                foreach (Aplicacion item in listaApp)
                {
                    if (item.nombre == app.nombre)
                        return true;
                }

            return false;
        }

        /// <summary>
        /// retorna true si la app no esta en la lista
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// aniade app a lista de apps si esta no se encuentra en la lista
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (!(listaApp is null) && !(app is null))
            {
                if(listaApp != app)
                {
                    listaApp.Add(app);
                    return true;
                }
                
            }

            return false;
        }
    }
}
