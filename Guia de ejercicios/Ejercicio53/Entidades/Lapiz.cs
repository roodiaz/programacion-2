﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }

        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {

            ((IAcciones)this).UnidadesDeEscritura -= (float)(texto.Length * 0.3);

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} {1} {2}", "Lapiz", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);

            return sb.ToString();
        }
    }
}
