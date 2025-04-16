using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Libro : Publicacion
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }

        public Libro(Tema tema, double precioSugerido, Editorial editorial, int cantPaginas, DateTime fechaPublicacion, string imagenPortada, int stock, int stockMinimo, List<Autor> autores, List<Valoracion> valoraciones, string isbn, string titulo) : base(tema, precioSugerido, editorial, cantPaginas, fechaPublicacion, imagenPortada, stock, stockMinimo, autores, valoraciones)
        {
            Isbn = isbn;
            Titulo = titulo;
        }
    }
}
