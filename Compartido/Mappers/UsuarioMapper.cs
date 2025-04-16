using Compartido.DTOs;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Mappers
{
    public class UsuarioMapper
    {
        public static Usuario UsuarioFromUsuarioDTO(UsuarioDTO usuarioDTO)
        {
            if(usuarioDTO == null)
            {
                throw new ArgumentNullException("Datos incorrectos.");
            }
            return new Usuario(usuarioDTO.NombreUsuario, usuarioDTO.Password , usuarioDTO.Rol);
        }
    }
}
