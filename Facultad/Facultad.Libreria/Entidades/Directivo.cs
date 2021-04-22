using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Entidades
{
    public class Directivo : Empleado
    {
        public override string getCredencial()
        {
            return "Sr. Director" + this.apellido;
        }
    }
}
