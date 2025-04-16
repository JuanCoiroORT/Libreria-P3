using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuario
    {
        private static List<Usuario> Usuarios = new List<Usuario>();

        public void Add(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
            }
            else
            {
                throw new UsuarioException("Ya existe ese nombre de usuario.");
            }
        }
    }
}
