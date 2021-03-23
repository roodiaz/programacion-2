﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascotas
    {
        
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;

        public Mascotas(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;

        }

        public void AgregarVacuna(Vacuna vacuna)
        {
            if(this.vacunas is null)
            {
                this.vacunas = new Vacuna[1];
            }
            else
            {
                int nuevoTamanio = this.vacunas.Length + 1;

                //aumento tamño de array
                Array.Resize(ref this.vacunas, nuevoTamanio);
            }

            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if(this.vacunas[i] is null)
                {
                    this.vacunas[i] = vacuna;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"nombre: {this.nombre}, especie: {this.especie}, fecha nacimiento: {this.fechaNacimiento.ToShortDateString()}";

            if(this.vacunas != null)
            {
                retorno += "vacunas: \n";
                foreach (Vacuna vacuna in this.vacunas)
                {
                    if(vacuna !=null)
                        retorno += vacuna.ObtenerNombre();
                }
            }

            return retorno;
        }
     
    }
}
