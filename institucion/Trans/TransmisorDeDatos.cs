using institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Trans
{
    public class TransmisorDeDatos
    {
        // pointer to a function
        public delegate string Formatter(string input);

        public void FormatearYEnviar(institute ente, Formatter localFormatter, string nombre)
        {
            var rawString = $"{ente.CodigoInterno}:{ente.ContruirLLaveSecreta(nombre)}";

            rawString = localFormatter(rawString);

            Send(rawString);

        }

        private void Send(string rawString)
        {
            Console.WriteLine("Transmision de datos:" + rawString);

            
        }

        //public string MyFormatter(string input) { }
    }
}
