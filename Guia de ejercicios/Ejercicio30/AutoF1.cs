using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    public class AutoF1
    {
        private short cantidadCumbustible;
        private short vueltasRestantes;
        private short numero;
        private string escuderia;
        private bool enCompetencia;

        #region constructores
        public AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCumbustible = 0;
            this.vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia) 
            : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region getters/setters
        public short GetCombustible() { return this.cantidadCumbustible; }
        public void SetCombustible(short combustible) { this.cantidadCumbustible = combustible; }

        public short GetVueltas() { return this.vueltasRestantes; }
        public void SetVueltas(short vueltas) { this.vueltasRestantes = vueltas; }
        
        public bool GetCompetencia() { return this.enCompetencia; }
        public void SetCompetencia(bool competencia) { this.enCompetencia = competencia; }

        #endregion

        #region operadores
        //b. Dos autos serán iguales si el número y escudería son iguales.
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        #endregion

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Escuderia {this.escuderia}");
            sb.AppendLine($"Numero {this.numero}");
            sb.AppendLine($"En competencia {GetCompetencia()}");
            sb.AppendLine($"Vueltas restantes {GetVueltas()}");
            sb.AppendLine($"Combustible restante {GetCombustible()}");

            return sb.ToString();
        }
    }
}
