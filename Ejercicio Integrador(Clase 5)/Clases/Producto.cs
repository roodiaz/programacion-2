using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProductos(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");
            sb.AppendLine($"Codigo de barra: {p.codigoDeBarra}");

            return sb.ToString();
       
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        //Igualdad (Producto, Producto). Retornará true, si las marcas 
        //y códigos de barras son iguales, false, caso contrario.
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if(!(p1 is null || p2 is null))//sino estan vacios
            {
                if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
                    retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        //gualdad (Producto, string). Retornará true, si la marca del producto coincide 
        //con la cadena pasada por parámetro, false,caso contrario.
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca; //si son iguales retorna true
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
