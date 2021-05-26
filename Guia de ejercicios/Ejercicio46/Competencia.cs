using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio46
{
    public class Competencia
    {
        public enum TipoCompetencia { F1, MotoCross }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private TipoCompetencia tipo;
        private List<VehiculoDeCarrera> competidores;

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < this.competidores.Count)
                {
                    return this.competidores[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i < this.competidores.Count)
                {
                    this.competidores[i] = value;
                }
                else
                {
                    competidores.Add(value);
                }
            }
        }

        public List<VehiculoDeCarrera> Competidores {
            get { return this.competidores; }
        }

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
                if (c.Tipo == Competencia.TipoCompetencia.F1 && v.GetType() != typeof(AutoF1) ||
                    c.Tipo == Competencia.TipoCompetencia.MotoCross && v.GetType() != typeof(MotoCross))
                {
                    throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia.cs", "Validacion ==");
                }
            }
            else
            {
                foreach (VehiculoDeCarrera vehicle in c.competidores)
                {
                    if (vehicle == v)
                        return true;
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
                try
                {
                    if (c.competidores.Count < c.cantidadCompetidores)
                    {
                        if (!(c == v))
                        {
                            v.EnCompetencia = true;
                            v.VueltasRestantes = c.cantidadVueltas;
                            v.CantidadCombustible = (short)rnd.Next(15, 100);
                            c.competidores.Add(v);
                            return true;
                        }
                    }
                }
                catch (CompetenciaNoDisponibleException ex)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia.cs", "Operador +", ex);
                    
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
