using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        /// <summary>
        /// propiedad de solo lectura que devuelve lista de soldadps
        /// </summary>
        public List<Trooper> Troopers
        {
            get { return this.troopers; }
        }


        /// <summary>
        /// constructor privado que inicializa lista de soldados
        /// </summary>
        private EjercitoImperial()
        {
            this.troopers = new List<Trooper>();
        }

        public EjercitoImperial(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// sobrecarga de operador + para agregar soldados al ejercito
        /// </summary>
        /// <param name="e">objeto tipo ejercito</param>
        /// <param name="t">objeto tipo trooper</param>
        /// <returns>obj ejercito con su lista actualizada</returns>
        public static EjercitoImperial operator+(EjercitoImperial e, Trooper t)
        {
            if(e.Troopers.Count < e.capacidad)
            {
                e.troopers.Add(t);
            }

            return e;
        }

        public static EjercitoImperial operator -(EjercitoImperial e, Trooper t)
        {
            foreach(Trooper item in e.Troopers)
            {
                if (item.Equals(t))
                {
                    e.troopers.Remove(t);                
                    break;
                }
            }

            return e;
        }
    }
}
