using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoDeTexto
    {
        public static bool Guardar(string path, string infoToSave)
        {
            if (!String.IsNullOrWhiteSpace(path))
            {
                using (StreamWriter sw = new StreamWriter($"{path}"))
                {
                    sw.WriteLine(infoToSave);
                    return true;
                }
            }

            return false;
        }

        public static string Leer(string path)
        {
            string fileContent = string.Empty;

            if (!String.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    fileContent = sr.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException("No existe el archivo!!");
            }

            return fileContent;
        }
    }
}
