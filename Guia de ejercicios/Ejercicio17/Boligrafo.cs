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
        private ConsoleColor color;
        private short tinta;
        public const short cantidadTintaMaxima = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            if(tinta > cantidadTintaMaxima)
            {
                this.tinta = 100;
            }
            else
            {
                this.tinta = tinta;          
            }

            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private void SetTinta(short tinta)
        {
            if (tinta >= 0 || tinta <= cantidadTintaMaxima)
                this.tinta = tinta;
            else
                this.tinta = Convert.ToByte(GetTinta() - tinta);
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = string.Empty;

            if (GetTinta() > 0)
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
