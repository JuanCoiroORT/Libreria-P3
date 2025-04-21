using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObject
{
    public class Nombre
    {
        private string NombrePila { get; }
        private string Apellido { get; }
        public Nombre(string nombrePila, string apellido)
        {
            NombrePila = nombrePila;
            Apellido = apellido;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(NombrePila))
            {
                throw new AutorException("El nombre es obligatorio.");
            }
            if(string.IsNullOrWhiteSpace(Apellido))
            {
                throw new AutorException("El apellido es obligatorio.");
            }
        }
    }
}
