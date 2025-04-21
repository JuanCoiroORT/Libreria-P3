using LogicaNegocio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesNegocio
{
    public class Autor
    {
        public int Id;
        private static int s_ultId;
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaDefuncion { get; set; }
        public Pais Nacionalidad { get; set; }
        public Nombre Nombre { get; set; }

        public Autor() { }

        public Autor(DateTime fechaNacimiento, DateTime fechaDefuncion, Pais nacionalidad, string primerNombre, string apellido)
        {
            Id = s_ultId;
            s_ultId++;
            FechaNacimiento = fechaNacimiento;
            FechaDefuncion = fechaDefuncion;
            Nacionalidad = nacionalidad;
            Nombre = new Nombre(primerNombre, apellido);
        }
    }
}
