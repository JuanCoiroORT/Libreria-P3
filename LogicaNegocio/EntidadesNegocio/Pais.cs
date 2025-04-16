using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Pais
    {
        public int Id { get; set; }
        private static int s_ultId;
        public string Nombre { get; set; }
        
        public Pais() { }
        public Pais(string nombre)
        {
            Id = s_ultId;
            s_ultId++;
            Nombre = nombre;
        }
    }
}
