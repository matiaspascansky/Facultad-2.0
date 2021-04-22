using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Exceptions
{
    class EmpleadoExistente : Exception
    {
        public EmpleadoExistente(String message) : base(message) { 
        }
    }
}
