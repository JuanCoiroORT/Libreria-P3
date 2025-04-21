using Compartido.DTOs;
using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Mappers
{
    public class RevistaMapper
    {
        public static Revista RevistaFromRevistaDTO(RevistaDTO revistaDTO)
        {
            if(revistaDTO == null)
            {
                throw new ArgumentNullException("Datos incorrectos.");
            }
            return new Revista(revistaDTO.Tema, revistaDTO.PrecioSugerido, revistaDTO.Editorial, revistaDTO.CantPaginas, revistaDTO.FechaPublicacion, revistaDTO.ImagenPortada, revistaDTO.Stock,
                revistaDTO.StockMinimo, revistaDTO.Autores, revistaDTO.Valoraciones, revistaDTO.Nombre, revistaDTO.Numero, revistaDTO.Anio, revistaDTO.Contenido);
        }

        public static List<ListadoRevistaDTO> ListadoRevistaToListadoRevistaDTO(List<Revista> revistas)
        {
            if( revistas == null)
            {
                throw new ArgumentNullException("Datos incorrectos.");
            }
            List<ListadoRevistaDTO> revistasDTO = new List<ListadoRevistaDTO> ();
            revistasDTO = revistas.Select(c => new ListadoRevistaDTO()
            {
                Id = c.Id,
                Nombre = c.Nombre
            }).ToList();
            return revistasDTO;
        }
    }
}
