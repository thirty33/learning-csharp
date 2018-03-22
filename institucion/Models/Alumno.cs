using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    class Alumno : Persona
    {
        public EstadosAlumno Estado { get; set; }
        public string Email { get; set; }
        private int Inasistencias { get; set; }
        public string NickName { get; set; }

        public string ListaInasistencias() { return Inasistencias.ToString(); }

        public string NumParticipaciones() { return Participaciones.ToString(); }

        public Alumno(string nombre, string apellido) { Nombre = nombre; Apellido = apellido; }

        public int RetornarVal (ref int x) { x = x + 1;  return x; }
        public int RetornarValWReference(int x) { x = x + 1; return x; }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto}, {NickName}, {Telefono}";
        }
    }
}
