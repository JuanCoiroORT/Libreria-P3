using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades
{
    public class AutorException : Exception
    {
        public AutorException() { }

        public AutorException(string? message) : base(message) { }

        public AutorException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
