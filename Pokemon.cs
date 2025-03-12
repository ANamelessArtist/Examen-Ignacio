using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ignacio
{
    internal class Pokemon
    {
        public Pokemon() { }
        public Pokemon(int id, string nombre, string tipo, string habilidad, bool shiny)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Habilidad = habilidad;
            Shiny = shiny;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Habilidad { get; set; }
        public bool Shiny { get; set; }
    }
}
