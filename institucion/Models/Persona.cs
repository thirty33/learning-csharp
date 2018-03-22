using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Persona
    {
        public static int ContadorPersona = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto
        {
            get
            {
                //return string.Format("{0} {1}", Nombre, Apellido); formatear ctrl + k, ctrl + d
                return $"{this.Nombre} {this.Apellido}";
            }
        }

        protected int Participaciones { get; set; }

        public Persona ()
        {
            ContadorPersona++;
        }



    }
}
