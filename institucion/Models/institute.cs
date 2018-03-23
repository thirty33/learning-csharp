using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    public interface institute
    {
        string CodigoInterno { get; set; }

        string ContruirLLaveSecreta(string NombreEnte);
    }
}
