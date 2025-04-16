using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.DTOs
{
    public class UsuarioDTO
    {
        public string NombreUsuario {  get; set; }
        public string Password { get; set; }
        public string Rol {  get; set; }

    }
}
