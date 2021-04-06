using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Estante
    {

        private Producto[] productos;
        private int ubicacionEstante;


        /*El constructor de instancia privado será el único que inicializará el array. 
          La sobrecarga pública del constructor inicializará la
          ubicación del estante, recibiendo como parámetro capacidad y ubicación.
          Reutilizar código.*/
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /*El método público de clase MostrarEstante, retornará una cadena con toda 
          la información del estante, incluyendo el
          detalle de cada uno de sus productos. Reutilizar código. */

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Estante: {e.ubicacionEstante}");

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.productos[i], null))//sino esta vacio
                    sb.AppendLine(Producto.MostrarProductos(e.productos[i]));
            }
            return sb.ToString();
        }

        /*
        Sobrecarga de operadores:
        Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        */
        public static bool operator ==(Estante e, Producto p)
        {

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /*Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y
        dicho producto no se encuentra en él; false, caso contrario. Reutilizar código.
        */

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)//retulizo sobrecarga
            {
                for (int i = 0; i < e.productos.Length; i++)//recorro lista de productos
                {
                    if(e.productos[i] is null)//si hay espacio en estante agrego producto
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }

            return false;

        }

        /*Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando el producto se encuentre en el
        listado. Reutilizar código.*/
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)//si el producto se encuentra en el estante
                {
                    e.productos[i] = null;
                    break;
                }
            }

            return e;
        }

    }
}
