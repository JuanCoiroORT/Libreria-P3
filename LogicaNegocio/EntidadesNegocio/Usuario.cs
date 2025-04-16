using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Usuario
    {
        public int Id { get; set; }
        private int s_ultId;
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public Usuario() { }

        public Usuario(string nombreUsuario, string password, string rol)
        {
            Id = s_ultId;
            s_ultId++;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
            Validar(NombreUsuario, Password);
        }

        private void Validar(string nombreUsuario, string Password)
        {
            if (string.IsNullOrEmpty(nombreUsuario)) 
            {
                throw new UsuarioException("El nombre de usuario no puede ser nulo.");
            }
            if (string.IsNullOrEmpty(Password))
            {
                throw new UsuarioException("La password no puede ser nula.");
            }
        }

        public bool Equals(Usuario? other)
        {
            return NombreUsuario == other.NombreUsuario;
        }
    }
}
