using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Constructores
        public Centralita(string razonSocial)
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = razonSocial;
        }
        #endregion

        
    }
}
