using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public abstract class Empleado : Persona
    {
        protected int legajo;
        private DateTime fechaIngreso;
        private List<Salario> salarios;


        public override string getCredencial()
        {
            return $"{this.legajo} - {this.getNombreCompleto()} salario $ 0";
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public override bool Equals(object obj)
        {
          if (obj == null)
            {
                return false;
            }

          if (!(obj is Empleado))
            {
                return false;
            }

            Empleado e = (Empleado)obj;
            
            if (e.legajo != this.legajo)
            {
                return false;
            }
            return true;
        }
    }
}
