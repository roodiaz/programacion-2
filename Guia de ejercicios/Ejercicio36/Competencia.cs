using Ejercicio36;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private TipoCompetencia tipo;
        private List<VehiculoDeCarrera> competidores;

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo)
            : this()
        {
            this.CantidadVueltas = cantVueltas;
            this.CantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo de competicion: {this.Tipo}");
            sb.AppendLine($"Cantidad vueltas {this.CantidadVueltas}");
            sb.AppendLine($"Cantidad competidores {this.CantidadCompetidores}");
            sb.AppendLine($"Competidores ");

            foreach (VehiculoDeCarrera item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }

            return sb.ToString();

        }
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if (!(c.competidores is null) && !(v is null))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (c.Tipo == TipoCompetencia.F1 && v is AutoF1)
                    {
                        if ((AutoF1)item == (AutoF1)v)
                        {
                            return true;
                        }
                    }

                    else if (c.Tipo == TipoCompetencia.MotoCross && v is MotoCross)
                    {
                        if ((MotoCross)item == (MotoCross)v)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random rnd = new Random();

            if (!(c.competidores is null) && !(v is null))
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    if (!(c == v))
                    {
                        if ((c.Tipo == TipoCompetencia.F1 && v is AutoF1) ||
                            (c.Tipo == TipoCompetencia.MotoCross && v is MotoCross))
                        {
                            v.EnCompetencia = true;
                            v.VueltasRestantes = c.cantidadVueltas;
                            v.CantidadCombustible = (short)rnd.Next(15, 100);
                            c.competidores.Add(v);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (!(c.competidores is null) && !(v is null))
            {
                if (c == v)
                {
                    c.competidores.RemoveAt(c.competidores.IndexOf(v));
                    return true;
                }
            }

            return false;
        }
    }
}
