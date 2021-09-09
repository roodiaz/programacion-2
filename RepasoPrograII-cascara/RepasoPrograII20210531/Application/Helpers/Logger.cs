using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Files.Text;

namespace Application.Helpers
{
    public static class Logger
    {
        public static void LogException(string log)
        {
            // TODO: listo
            // implementar. Debe registara fecha,hora y mensaje de cada excepcion en un archivo de text, 
            //El archivo se tiene que guardar en el escritorio
            try
            {
                log += $"Fecha: {DateTime.Now}";
                Text<string> logger = new Text<string>();
                logger.Save(Environment.SpecialFolder.Desktop.ToString(), log);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
