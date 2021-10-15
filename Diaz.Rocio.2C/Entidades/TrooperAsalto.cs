using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Trooper
    {
        /// <summary>
        /// propiedad implementada de clase base
        /// solo lectura
        /// devuelve tipo de soldado
        /// </summary>
        public override string Tipo
        {
            get { return "Comando para misiones de infiltración"; }
        }

        public TrooperAsalto(Blaster armamento)
            : base(armamento,true)
        {
            
        }
    }
}
