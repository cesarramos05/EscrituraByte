using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbyte = 0, car;

            try
            {
                //Crear flujo del archivo

                fs = new FileStream("Text.txt",FileMode.Create,FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo: ");
                while ((car = Console.Read())!= '\r' && (nbyte < buffer.Length)) 
                {
                    buffer[nbyte] = (byte)car;
                    nbyte++;

                }

                fs.Write(buffer, 0, nbyte);

                Console.ReadKey();

            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
