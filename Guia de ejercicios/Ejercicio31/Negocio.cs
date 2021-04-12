using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoDeAtencion caja;
        private string nombre;
        private Queue<Cliente> clientes;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoDeAtencion(PuestoDeAtencion.Puesto.caja1);
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (!(clientes.Contains(value)))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n.clientes.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (!(n == c))
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.AtenderCliente(n.Cliente);
        }


    }
}
