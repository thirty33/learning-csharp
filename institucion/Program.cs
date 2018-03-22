using institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestion de Institucion");
            var alumno1 = new Alumno("joel", "suarez")
            { Id = 1, Edad = 36, NickName = "JOEKS", Telefono = "22333222", Email = "joelsuarez.1101@gmail.com" };
            //alumno1.Nombre = "joel suarez";

            //var persona1 = new Persona() { Id = 1, Nombre = "Joel Suarez", Apellido = "suarez", Edad = 36, Telefono = "22333222" };
            var profesor = new Profesor() { Id = 1, Nombre = "Joel Suarez", Apellido = "suarez", Edad = 36, Telefono = "22333222", Catedra = "Matematicas" };
            Console.WriteLine("Virtual override");
            Console.WriteLine(profesor.ImprimirEdad);


            Persona a = profesor;
            Persona b = alumno1;

            Console.WriteLine("Foreach");
            Persona[] lista = new Persona[3];
            lista[0] = new Alumno("carlos", "ruiz") { Id = 1, Edad = 36, NickName = "JOEKS", Telefono = "22333222", Email = "joelsuarez.1101@gmail.com" };
            lista[1] = new Profesor() { Id = 2, Nombre = "miguel", Apellido = "suarez", Edad = 36, Telefono = "22333222", Catedra = "Matematicas" };
            lista[2] = new Profesor() { Id = 3, Nombre = "juvencio", Apellido = "sanchez", Edad = 36, Telefono = "22333222", Catedra = "Fisica" };

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());

                institute ente = p;
                ente.ContruirLLaveSecreta("Hola");
            }

            a = b;
            Console.WriteLine(alumno1.Nombre);
            Console.WriteLine(Persona.ContadorPersona);

            Console.WriteLine("Resumenes");
            Console.WriteLine(alumno1.ConstruirResumen());
            Console.WriteLine(profesor.ConstruirResumen());


            Console.WriteLine("Estructuras");
            CursoStruct c = new CursoStruct(70);
            c.Curso = "101-B";


            CursoStruct newC = new CursoStruct();
            newC.Curso = "564-A";

            var cursoFreak = c;
            cursoFreak.Curso = "666-g";

            Console.WriteLine($"Curso c = {c.Curso}");
            Console.WriteLine($"Curso freak = {cursoFreak.Curso}");

            Console.WriteLine("Clases");
            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "101-B";


            var newC_class = new CursoStruct();
            newC_class.Curso = "564-A";

            var cursoFreak_class = c_class;
            cursoFreak_class.Curso = "666-g";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso freak = {cursoFreak_class.Curso}");


            Console.WriteLine("retornando valores por referencia");
            var anum = 15;
            Console.WriteLine(alumno1.RetornarVal(ref anum));
            Console.WriteLine(anum);


            Console.ReadLine();

           
        }
    }
}
