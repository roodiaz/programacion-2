using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Baraja
    {
        private Carta[] baraja;

        private Baraja()
        {
            baraja = new Carta[48];

            for (int i = 0; i < 4; i++)//4 filas 4 palos
            {
                for (int j = 0; j < 12; j++)//12 columnas 12 valores de carta
                {
                    baraja[(i * 12) + j] =new Carta((Carta.Valor)j, (Carta.Palo)i);//guardo cartas en el indice
                }
            }
        }

        public void MostrarBaraja()
        {
            StringBuilder sb = new StringBuilder();

            //for (int i = 0; i <this.baraja.Length; i++)
            //{
            //    sb.AppendLine(this.baraja[i].ObtenerNombre());
            //    sb.AppendLine("\n");
            //}

            foreach (Carta item in this.baraja)
            {
                sb.AppendLine(item.ObtenerNombre());
                sb.AppendLine("\n");
            }

            Console.WriteLine(sb.ToString());
        }

        public Carta RobarCarta()
        {
            Carta cartaRobada = null;

            if (!(this.baraja is null))
            {
                cartaRobada= this.baraja[baraja.Length - 1];//robo la ultima carta de la baraja
                Array.Resize(ref this.baraja, this.baraja.Length - 1);
                //primer parametro array unidimensional a redimensionar
                //segundo parametro nuevo tamaño de array
            }

            return cartaRobada;

        }

      
        public bool AgregarCarta(Carta nuevaCarta)
        {
            bool todoOk = false;

            if (this.baraja.Length < 48)
            {
                Array.Resize(ref this.baraja, this.baraja.Length + 1);//agrando array
                this.baraja[this.baraja.Length - 1] = nuevaCarta;

                todoOk = true;
            }

            return todoOk;
        }
         
        



    }
}
