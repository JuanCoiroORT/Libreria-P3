using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Tema
    {
        public int Id { get; set; }
        private int s_ultId;
        public string Nombre { get; set; }

        public Tema(string nombre)
        {
            Id = s_ultId;
            s_ultId++;
            Nombre = nombre;
        }
    }
}
