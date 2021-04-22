using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Docente : Empleado
    {
        public override string getCredencial()
        {
            return "Docente" + this.nombre;
        }
    }
}
