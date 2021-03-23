using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Clientes
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascotas[] mascotas;

        public Clientes(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void AgregarMascota(Mascotas mascota)
        {
            if (this.mascotas is null)
            {
                this.mascotas = new Mascotas[1];
            }
            else
            {
                int nuevoTamanio = this.mascotas.Length + 1;

                //aumento tamño de array
                Array.Resize(ref this.mascotas, nuevoTamanio);
            }

            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if (this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"nombre: {this.nombre}, apellido: {this.apellido}";

            if (this.mascotas != null)
            {
                retorno += "mascotas: \n";
                foreach (Mascotas mascota in this.mascotas)
                {
                    if (mascota != null)
                        retorno += mascota;
                }
            }

            return retorno;
        }
    }
}
