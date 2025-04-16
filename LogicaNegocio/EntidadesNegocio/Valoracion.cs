using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Valoracion
    {
        public string Comentario { get; set; }
        public int Puntaje { get; set; }
        public string Alias { get; set; }
        public string Lineas { get; set; }

        public Valoracion(string comentario, int puntaje, string alias, string lineas)
        {
            Comentario = comentario;
            Puntaje = puntaje;
            Alias = alias;
            Lineas = lineas;
        }
    }
}
