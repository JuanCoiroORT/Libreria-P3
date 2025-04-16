using Compartido.DTOs;
using Compartido.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosUso.UsuarioCU
{
    public class AltaUsuario
    {
        private RepositorioUsuario RepoUsuario;

        public AltaUsuario(RepositorioUsuario repoUsuario)
        {
            RepoUsuario = repoUsuario;
        }

        public void Ejecutar(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                throw new ArgumentNullException("Datos incorrectos.");
            }
            // CONVERTIR DTO A OBJETO USUARIO
            Usuario usuario = UsuarioMapper.UsuarioFromUsuarioDTO(usuarioDTO);
            // PASAR ESTE OBJETO USUARIO A LOGICAACCESODATOS
            RepoUsuario.Add(usuario);
        }
    }
}
