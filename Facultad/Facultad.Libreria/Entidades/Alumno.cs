using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public sealed class Alumno : Persona
    {
        private int codigo;
        //Sobrecarga de constructores
        //1
        public Alumno(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
        //2
        public Alumno(int codigo)
        {
            this.codigo = codigo;
        }
        public override string getCredencial()
        {
            return "codigo: " + this.codigo + "apellido " + this.apellido + "nombre " + this.nombre;
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public override string ToString()
        {
            return getCredencial();
        }

        public bool igualCodigo(int cod)
        {
            return cod == this.codigo;
        }
    }
}
