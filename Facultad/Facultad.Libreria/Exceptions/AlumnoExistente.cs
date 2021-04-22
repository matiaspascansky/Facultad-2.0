using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Libreria.Exceptions
{
    class AlumnoExistente : Exception
    {
        public AlumnoExistente(String message) : base(message)
        {
        
        }
    }
}
