using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Revista : Publicacion
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public int Anio { get; set; }
        public string Contenido { get; set; }

        public Revista(string tema, double precioSugerido, Editorial editorial, int cantPaginas, DateTime fechaPublicacion, string imagenPortada, int stock, int stockMinimo, List<Autor> autores, List<Valoracion> valoraciones, string nombre, int numero, int anio, string contenido) : base(tema, precioSugerido, editorial, cantPaginas, fechaPublicacion, imagenPortada, stock, stockMinimo, autores, valoraciones)
        {
            Nombre = nombre;
            Numero = numero;
            Anio = anio;
            Contenido = contenido;

        }
    }
}
