using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBoligrafo
{
    public class Boligrafo
    {
        const short cantidadMaximaTinta=100;
        private ConsoleColor color;
        private short tinta;

        //constructor
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        //getter
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        //setter
        private void SetTinta(short tinta)
        {
            if (tinta >= 0 || tinta <= cantidadMaximaTinta)
                this.tinta = tinta;
            else
                this.tinta = Convert.ToByte(GetTinta() - tinta);
        }

        //metodos
        public void Recargar()
        {
            SetTinta(cantidadMaximaTinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = string.Empty;

            if(GetTinta() > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    if (GetTinta() > 0)
                    {
                        dibujo += "*";
                        pudoPintar = true;
                    }
                    else
                        break;

                    this.tinta--;
                }
            }

            return pudoPintar;
        }

    }
}
