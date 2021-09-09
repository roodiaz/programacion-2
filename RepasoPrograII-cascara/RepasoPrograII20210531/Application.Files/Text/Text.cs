using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Files.Text
{
    public class Text<T> : IFile<T>
    {
        //TODO: listo

        public bool Read(string file, out T data)
        {
            throw new NotImplementedException();
        }


        public bool Save(string file, T data)
        {
            StreamWriter writer = null;

            try
            {
                using (StreamWriter write = new StreamWriter(file, true))
                {
                    write.WriteLine(data);
                    return true;
                }
            }
            catch(Exception e)
            {
                throw new Exception("Error al escribir el archivo");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }
    }
}
