using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        private DateTime fechaNac;

        public abstract String getCredencial();
        public virtual string getNombreCompleto()
        {
            return $"{this.nombre} {this.apellido}";
        }

    }
}
