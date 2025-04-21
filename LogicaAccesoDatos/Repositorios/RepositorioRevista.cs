using LogicaNegocio.EntidadesNegocio;
using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioRevista
    {
        private static List<Revista> Revistas = new List<Revista>();

        public void Add(Revista revista)
        {
            if (!Revistas.Contains(revista))
            {
                Revistas.Add(revista);
            }
            else
            {
                throw new RevistaException("Ya existe esta revista.");
            }
        }
        public List<Revista> FindAll()
        {
            return Revistas;
        }
    }
}
