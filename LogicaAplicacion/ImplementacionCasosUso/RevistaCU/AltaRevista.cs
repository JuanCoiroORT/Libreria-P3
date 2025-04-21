using Compartido.DTOs;
using Compartido.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosUso.RevistaCU
{
    public class AltaRevista
    {
        private RepositorioRevista RepoRevista = new RepositorioRevista();

        public void Ejecutar(RevistaDTO revistaDTO)
        {
            if(revistaDTO == null)
            {
                throw new ArgumentNullException("Datos incorrectos.");
            }
            Revista revista = RevistaMapper.RevistaFromRevistaDTO(revistaDTO);
            RepoRevista.Add(revista);
        }
    }
}
