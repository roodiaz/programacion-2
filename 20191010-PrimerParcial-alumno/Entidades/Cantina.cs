using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton=null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="espacios"></param>
        private Cantina(int espacios)
        {
            if (Cantina.singleton == null)
            {
                this.botellas = new List<Botella>();
            }
            
            this.espaciosTotales = espacios;
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="espacios"></param>
        /// <returns></returns>
        public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator +(Cantina c, Botella b)
        {
            if(c.botellas.Count() <= c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
