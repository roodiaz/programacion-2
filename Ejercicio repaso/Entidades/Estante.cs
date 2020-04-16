using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] arrayProductos;

        private Estante(int capacidad)
        {
            this.arrayProductos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.arrayProductos;
        }

        public static string MostrarEstantes(Estante e)
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine($"Ubicacion estante: {e.ubicacionEstante}");
            mostrar.AppendLine("Productos: ");

            foreach (Producto item in e.arrayProductos)
            {
                if (!(item is null))
                    mostrar.AppendLine(Producto.MostrarProducto(item));
            }

            return mostrar.ToString();
        }      

        public static bool operator==(Estante e, Producto p)
        {
            return (e.arrayProductos.Contains(p));
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;

            if(e!=p)
            {
                for(int i=0; i<e.arrayProductos.Length; i++)
                {
                    if(e.arrayProductos[i] is null)
                    {
                        e.arrayProductos[i] = p;
                        return true;
                    }
                }
            }

            return retorno;
        }

        public static Estante operator-(Estante e, Producto p)
        {
            if(e==p)
            {
                for (int i = 0; i < e.arrayProductos.Length; i++)
                {
                    if (e.arrayProductos[i] == p)
                    {
                        e.arrayProductos[i] = null;
                    }
                }
            }

            return e;
        }
    }
}
