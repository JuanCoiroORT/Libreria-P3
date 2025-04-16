using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Compra
    {
        public int Id { get; set; }
        private static int s_ultId;
        public List<PublicacionComprada> publicacionesCompradas { get; set; }
        public Usuario Cliente { get; set; }

        public Compra() { }

        public Compra(List<PublicacionComprada> publicacionesCompradas, Usuario cliente)
        {
            Id = s_ultId;
            s_ultId++;
            this.publicacionesCompradas = publicacionesCompradas;
            Cliente = cliente;
        }
    }
}
