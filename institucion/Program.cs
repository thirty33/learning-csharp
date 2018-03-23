using institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using institucion.Trans;
using System.IO;
using institucion.DataAccess;

namespace institucion
{
    class Program
    {
        

        public void rutina1()
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

            Console.WriteLine("retornando valores por referencia");
            var anum = 15;
            Console.WriteLine(alumno1.RetornarVal(ref anum));
            Console.WriteLine(anum);

            Console.WriteLine("retornando valores sin referencia");
            Console.WriteLine(alumno1.RetornarValWReference(anum));
            Console.WriteLine(anum);

        }

        public void rutina2()
        {
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


            

            Console.WriteLine("Enumeraciones");
            var alumnoEst = new Alumno("gustavo", "alarcon")
            {
                Id = 1,
                Edad = 36,
                NickName = "JOEKS",
                Telefono = "22333222",
                Email = "joelsuarez.1101@gmail.com",
                Estado = EstadosAlumno.Activo
            };


            Console.WriteLine("el estado del alumno es" +
                alumnoEst.Estado);

            Console.WriteLine($"TIPO: {typeof(EstadosAlumno)}");
            Console.WriteLine($"TIPO: {typeof(Alumno)}");

            Console.WriteLine($"TIPO: {alumnoEst.GetType()}");
            Persona prueba = alumnoEst;
            Console.WriteLine($"TIPO prueba : {prueba.GetType()}");

            Console.WriteLine($"TIPO: {nameof(Alumno)}");
            Console.WriteLine($"TIPO: {sizeof(int)}");


            Console.WriteLine("Casteo de datos");
            // -32.000 - + 32.000
            short s = 32000;
            int i = 33000;

            //m decimal
            decimal d = 0.00000000000000000000025m;
            // d double
            double two = 0.0000000000000000043d;


            float f = 2.35f;
            Console.WriteLine(i);
            s = (short)i;
            Console.WriteLine(s);

            Console.WriteLine(f);
            i = (int)f;
            Console.WriteLine(i);

        }

        public void RutinaArreglos()
        {
            Console.WriteLine("Arreglos");
            Persona[] arregloPersonas = new Persona[5];
            Console.WriteLine(arregloPersonas.Length);

            arregloPersonas[0] = new Alumno("pedro", "fernandez") { Id = 1, Edad = 36, NickName = "JOEKS", Telefono = "22333222", Email = "joelsuarez.1101@gmail.com" };
            arregloPersonas[1] = new Profesor() { Nombre = "Fritz", Apellido = "Perls" };
            arregloPersonas[2] = new Alumno("", "fernandez");
            arregloPersonas[3] = new Alumno("Juan", "fernandez");
            arregloPersonas[4] = new Profesor() { Nombre = "albert", Apellido = "Camus" };

            for (int cont = 0; cont < arregloPersonas.Length; cont++)
            {
                if (arregloPersonas[cont] is Alumno)

                {
                    var al = (Alumno)arregloPersonas[cont];
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[cont].NombreCompleto);
                }

            }

        }

        private static void RutinaCollections()
        {
            System.Collections.ArrayList ListaPersonas = new System.Collections.ArrayList();
            var Persona2 = new Alumno("Juan", "fernandez");
            var Persona3 = new Alumno("Joel", "Suarez");
            ListaPersonas.Add(Persona2);
            ListaPersonas.Add(new Alumno("Carlos", "Martinez"));
            ListaPersonas.Add(Persona3);
            // One Object Type
            List<Persona> ListaPersonas2 = new List<Persona>();
            List<object> ListaGenerica = new List<object>();


            Console.WriteLine(ListaPersonas);
            for (int i = 0; i < ListaPersonas.Count; i++)
            {
                var per = ListaPersonas[i] as Persona;

                if (per != null)
                    Console.WriteLine(per.NombreCompleto);
            }

            foreach (var item in ListaPersonas)
            {
                if (item is Alumno)
                {
                    var al = (Alumno)item;
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);

                }

            }

        }

        static void Main(string[] args)
        {

            var profe = new Profesor() { Id = 4, Nombre = "oscar", Apellido = "perez", CodigoInterno = "Profe_smart" };

            var trasmitter = new TransmisorDeDatos();
            //asigancion de eventos
            // multicast delegate

            trasmitter.InformationSend += Trasmitter_InformationSend;
            trasmitter.InformationSend += (obj, evtargs) => { Console.WriteLine("segundo evento casteado"); };
            //trasmitter.FormatearYEnviar(profe, formatter,"Alex");
            //trasmitter.FormatearYEnviar(profe, formatter2, "Alex");

            // lambda functions
            trasmitter.FormatearYEnviar(profe, (s) => new string(s.Reverse().ToArray<char>()), "Alex");
            trasmitter.FormatearYEnviar(profe, formatter2, "Alex");

            // quitando eventos
            trasmitter.InformationSend -= Trasmitter_InformationSend;
            trasmitter.FormatearYEnviar(profe, formatter, "Alex");

            Console.WriteLine("Manipulacion de documentos");

            var listaProfesores = new List<Profesor>();

            string[] lineas = File.ReadAllLines("./Files/Profesores.txt");

            int localId = 0;
            foreach (var line in lineas)
            {
                listaProfesores.Add(new Profesor() { Nombre = line, Id = localId++ });
            }

            foreach (var prof in listaProfesores) {
                Console.WriteLine(prof.Nombre);
            }

            //binary files
            var archivo = File.Open("profesBinarios.bin",FileMode.OpenOrCreate );

            var binaryFile = new BinaryWriter(archivo);
            foreach (var prof in listaProfesores)
            {
                //var bytesNombre = Encoding.UTF8.GetBytes(prof.Nombre);
                //archivo.Write(bytesNombre, 0, bytesNombre.Length);

                binaryFile.Write(profe.Nombre);
                binaryFile.Write(profe.Id);
            }

            //liberar memoria
            binaryFile.Close();
            archivo.Close();


            Console.WriteLine("Conexion a base de Datos con Entity Frameworks");

            var db = new InstitucionDB();

            db.Profesores.AddRange(listaProfesores);
            db.SaveChanges();


            Console.ReadLine();

            

        }

        private static void Trasmitter_InformationSend(object sender, EventArgs e)
        {
            Console.WriteLine("Transmision de informacion");

        }

        //private static string formatter(string input)
        //{
        //    byte[] stringBytes = Encoding.UTF8.GetBytes(input);
        //    return Convert.ToBase64String(stringBytes);
        //}

        private static string formatter(string input) => Convert.ToBase64String(Encoding.UTF8.GetBytes(input));

        private static string formatter2(string input)
        {
            return new string(input.Reverse().ToArray<char>());
        }

        

    }
}
