using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Salon : institute
    {
        public string CodigoInterno
        {
            get;
            set;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public string ContruirLLaveSecreta(string NombreEnte)
        {
            return "SAL ON";
        }
    }
}
