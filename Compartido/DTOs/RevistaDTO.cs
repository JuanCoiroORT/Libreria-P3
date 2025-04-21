using LogicaNegocio.EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.DTOs
{
    public class RevistaDTO
    {
        public string Tema { get; set; }
        public double PrecioSugerido { get; set; }
        public Editorial Editorial { get; set; }
        public int CantPaginas { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string ImagenPortada { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public List<Autor> Autores { get; set; }
        public List<Valoracion> Valoraciones { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public int Anio { get; set; }
        public string Contenido { get; set; }
    }
}
