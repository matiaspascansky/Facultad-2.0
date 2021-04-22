using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria.Entidades;


namespace Facultad
{
    class Program
    {
        private static FacultadController facultad = new FacultadController();

        enum Tipos
        {
            Bedel = 1,
            Docente = 2,
            Directivo = 3
        }

        static void Main()
        {


            mostrarConsola();
           

        }

        public static void opcionAlumno()
        {
            Console.Clear();
            Console.WriteLine("Opcion elegida: Agregar alumno");

            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese codigo");
            int codigo = int.Parse(Console.ReadLine());
            
            facultad.agregarAlumno(nombre, codigo);

            Main();

        }

        public static void mostrarAlumnos()
        {
            List<Alumno> alumnos = facultad.traerAlumnos();
            foreach (Alumno a in alumnos)
            {
                Console.WriteLine("Nombre: " + a.getNombreCompleto());
                Console.WriteLine("codigo: " + a.getCodigo());


            }

            Main();
        }

        public static void mostrarConsola() {

            bool valido = false;
            int opcion;
            do
            {
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1) Agregar Alumno");
                Console.WriteLine("2) Agregar Empleado");
                Console.WriteLine("3) Eliminar Alumno");
                Console.WriteLine("4) Eliminar Empleado");
                Console.WriteLine("5) Modificar Empleado");
                Console.WriteLine("6) Traer Alumnos");
                Console.WriteLine("7) Traer Empleado por legajo");
                Console.WriteLine("8) Traer Empleados");
                Console.WriteLine("9) Traer Empleados por nombre");

                string op = Console.ReadLine();
                if (int.TryParse(op, out opcion))
                {
                    valido = true;
                }


            } while (!valido);



            switch (opcion)
            {
                case 1:
                    opcionAlumno();
                    break;
                case 2:
                    throw new NotImplementedException();
                case 3:
                    throw new NotImplementedException();
                case 4:
                    throw new NotImplementedException();

                case 5:
                    throw new NotImplementedException();

                case 6:
                    mostrarAlumnos();
                    break;

                case 7:
                    throw new NotImplementedException();

                case 8:
                    throw new NotImplementedException();

                case 9:
                    throw new NotImplementedException();

                default:
                    throw new NotImplementedException();

            }
        }
    }
}
