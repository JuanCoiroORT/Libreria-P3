using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
