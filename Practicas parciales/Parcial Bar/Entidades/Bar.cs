using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton;

        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }

        public static Bar GetBar()
        {
            if (Bar.singleton is null)
            {
                Bar.singleton = new Bar();
            }

            return Bar.singleton;
        }

        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        public static bool operator +(Bar b, Empleado e)
        {
            if (!(b is null) && !(e is null))
            {
                foreach (Empleado i in b.empleados)
                {
                    if (i != e)
                    {
                        b.empleados.Add(e);
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator +(Bar b, Gente g)
        {
            if (!(b is null) && !(g is null))
            {
                foreach (Gente genteEnBar in b.gente)
                {
                    if (b.gente.Count < (b.empleados.Count * 10) && genteEnBar != g)
                    {
                        b.gente.Add(g);
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            return $"Cantidad empleados: {this.empleados.Count} Cantidad gente: {this.gente.Count}";
        }
    }
}
