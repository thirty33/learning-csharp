using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    public abstract class Persona : institute
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

        public virtual int ImprimirEdad
        {
            get
            {
                return Edad;
            }
        }

        protected int Participaciones { get; set; }

        public string CodigoInterno
        {
            get;
            set;
        }

        public Persona ()
        {
            ContadorPersona++;
        }

        public abstract string ConstruirResumen();

        public string ContruirLLaveSecreta(string NombreEnte)
        {
            var rnd = new Random();
            return rnd.Next(1, 99888998).ToString();
            
        }
    }
}
