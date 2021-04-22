using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Libreria.Exceptions;

namespace Facultad.Libreria.Entidades
{
    public class FacultadController
    {
        private int cantSedes;
        private String nombre;
        private List<Alumno> alumnos;
        private List<Empleado> empleados;


        public FacultadController()
        {
            this.empleados = new List<Empleado>();
            this.alumnos = new List<Alumno>();
        }

        public void agregarEmpleado(Empleado e)
        {
            foreach (Empleado emp in empleados)
            {
                if(emp.Equals(e))
                {
                    throw new EmpleadoExistente("Ingrese un empleado válido");
                }
            }

            empleados.Add(e);
        }

        public void agregarAlumno(String nombre, int codigo)
        {
            foreach(Alumno alu in alumnos)
            {
                if(alu.getCodigo().Equals(codigo))
                {
                    throw new AlumnoExistente("Ingrese un alumno válido");
                }
            }
            Alumno alumnito = new Alumno(codigo, nombre);
            alumnos.Add(alumnito);
        }

        public void eliminarEmpleado(int legajo)
        {
            foreach(Empleado e in empleados)
            {
                if(legajo == e.getLegajo())
                {
                    empleados.Remove(e);
                }
            }

        }

        public void eliminarAlumno(int codigo)
        {
            foreach (Alumno a in alumnos)
            {
                if(codigo == a.getCodigo())
                {
                    alumnos.Remove(a);
                }
            }
        }

        public List<Alumno> traerAlumnos()
        {
            return this.alumnos;
        }

        public Empleado traerEmpleadoPorLegajo(int legajo)
        {
           Empleado empleado = empleados.Where(e => e.getLegajo().Equals(legajo)).First();
            return empleado;
        }

        public List<Empleado> traerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> empleaditos = empleados.Where(e => e.getLegajo().Equals(nombre)).ToList();
            return empleaditos;
        }

        public List<Empleado> traerEmpleados()
        {
            return this.empleados;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getCantidadSedes()
        {
            return this.cantSedes;
            
            
        }

        


    }

    
}
