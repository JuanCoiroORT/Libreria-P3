using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Editorial
    {
        public int Id { get; set; }
        private static int s_ultId;
        public string Nombre { get; set; }
        public Pais Pais { get; set; }

        public Editorial() { }

        public Editorial(string nombre, Pais pais)
        {
            Id = s_ultId;
            s_ultId++;
            Pais = pais;
        }
    }
}
