﻿using institucion.Models;
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
            var alumno1 = new Alumno() { Id=1, Nombre="Joel Suarez", Apellido="suarez", Edad=36,Telefono="22333222", Email="joelsuarez.1101@gmail.com" };
            //alumno1.Nombre = "joel suarez";

            var persona1 = new Persona() { Id = 1, Nombre = "Joel Suarez", Apellido = "suarez", Edad = 36, Telefono = "22333222" };

            persona1 = alumno1;

            Console.ReadLine();
           
        }
    }
}