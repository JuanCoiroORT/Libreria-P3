using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Publicacion : IEquatable<Publicacion>
    {
        public int Id { get; set; }
        private static int s_ultId;
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

        public Publicacion() { }

        public Publicacion(string tema, double precioSugerido, Editorial editorial, int cantPaginas, DateTime fechaPublicacion, string imagenPortada, int stock, int stockMinimo, List<Autor> autores, List<Valoracion> valoraciones)
        {
            Id = s_ultId;
            s_ultId++;
            Tema = tema;
            PrecioSugerido = precioSugerido;
            Editorial = editorial;
            CantPaginas = cantPaginas;
            FechaPublicacion = fechaPublicacion;
            ImagenPortada = imagenPortada;
            Stock = stock;
            StockMinimo = stockMinimo;
            Autores = autores;
            Valoraciones = valoraciones;
        }

        public bool Equals(Publicacion? other)
        {
            return Id == other.Id;
        }
    }
}
