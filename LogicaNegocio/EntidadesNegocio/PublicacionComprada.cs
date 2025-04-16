using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class PublicacionComprada
    {
        public int Cantidad { get; set; }
        public Publicacion Publicacion { get; set; }

        public PublicacionComprada() { }
        public PublicacionComprada(int cantidad, Publicacion publicacion)
        {
            Cantidad = cantidad;
            Publicacion = publicacion;
        }
    }
}
