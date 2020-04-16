using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
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

        public static string MostrarProducto(Producto p)
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine($"Marca {p.GetMarca()}");
            mostrar.AppendLine($"Precio {p.GetPrecio()}");
            mostrar.AppendLine($"Codigo de barra {p.codigoDeBarra}");

            return mostrar.ToString();
        }

        public static explicit operator string(Producto p)
        {
           return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (p.marca == marca);
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }
    }
}
