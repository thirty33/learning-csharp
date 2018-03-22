using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Models
{
    public class CursoClass
    {
        const string NombreDefectoCurso = "no asignado";
        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public readonly short max_capacidad;

        public CursoClass(short max)
        {
            max_capacidad = max;
            curso = NombreDefectoCurso;
        }


    }
}
