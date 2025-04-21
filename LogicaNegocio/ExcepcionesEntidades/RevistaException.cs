using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades
{
    public class RevistaException : Exception
    {
        public RevistaException() { }
        public RevistaException(string message) : base(message){ }
        public RevistaException (string message, Exception innerException) : base(message, innerException) { }
    }
}
