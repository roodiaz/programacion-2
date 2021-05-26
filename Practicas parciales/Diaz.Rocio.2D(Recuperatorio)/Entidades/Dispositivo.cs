using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum ESistemaOperativo { ANDROID, IOS }
    public static class Dispositivo
    {

        private static List<Aplicacion> appsInstaladas;
        private static ESistemaOperativo sistemaOp;

        /// <summary>
        /// constructor de clase de dispositivo
        /// </summary>
        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOp = ESistemaOperativo.ANDROID;
        }

        /// <summary>
        /// retorna informacin del dispositivos y sus apps isntaladas
        /// </summary>
        /// <returns></returns>
        public static string InformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("S.O DEL DISPOSITIVO {0}\n", sistemaOp);
            sb.AppendLine("APPS INSTALADAS: \n\n");

            foreach (Aplicacion item in appsInstaladas)
            {
                sb.AppendLine(item.InfoApp());
                sb.Append("---------------------------------\n\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// retorna true si puede agregar app a la lista, false sino
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool InstalarApp(Aplicacion app)
        {

            if (app.SistemaOperativo == sistemaOp)
            {
                return appsInstaladas + app;
            }

            return false;
        }
    }
}
