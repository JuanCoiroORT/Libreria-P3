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
    public class ListadoRevista
    {
        private RepositorioRevista RepoRevista = new RepositorioRevista();
        public List<ListadoRevistaDTO> Ejecutar()
        {
            List<ListadoRevistaDTO> revistasDTO = new List<ListadoRevistaDTO>();
            List<Revista> revistas = RepoRevista.FindAll();
            revistasDTO = RevistaMapper.ListadoRevistaToListadoRevistaDTO(revistas);
            return revistasDTO;
        }
    }
}
