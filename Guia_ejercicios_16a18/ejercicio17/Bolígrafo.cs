using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinta
{
    class Boligrafo
    {
        #region atributos
        const short cantidadTintaMaxima= 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region metodos
        /// <summary>
        /// Retorna el valor del color.
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Retorna el valor de la tinta.
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Valida el nivel de tinta.
        /// </summary>
        /// <param name="tinta"></param>
        public void SetTinta (short tinta)
        {
            if(tinta >= 0 && tinta <= 100)
            {
                this.tinta = tinta;
            }
            else if(tinta < 0)
            {
                this.tinta -= tinta;
            }
        }

        /// <summary>
        /// Coloca la tinta a su nivel máximo.
        /// </summary>
        public void Recargar()
        {
            SetTinta(100);
        }

        /// <summary>
        /// Pinta.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns>True = se pudo pintar || False = No se pudo pintar</returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = string.Empty;

            if (this.tinta > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    if (this.tinta > 0)
                        dibujo += "*";
                    else
                        break;

                    this.tinta--;

                }     

                    SetTinta((short)(this.tinta - gasto));
                    pudoPintar = true;
            }                          

            return pudoPintar;
        }

        #endregion

        #region constructor
        /// <summary>
        /// Setea los campos: color y tinta
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="color"></param>
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

            return;
        }
        #endregion

    }
}
