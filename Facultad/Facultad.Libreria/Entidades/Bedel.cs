using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Bedel : Empleado
    {
        private String apodo;

        public String getApodo()
        {
            return this.apodo;
        }

        public override string getCredencial()
        {
            return "Bedel: " + this.apodo;
        }
    }
}
