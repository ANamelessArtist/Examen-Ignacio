using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ignacio
{
    internal class Program
    {
        public enum menu { Agregar = 1, Mostrar, Actualizar, Eliminar }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (Menu())
                {
                    case menu.Agregar:
                        acciones.AgregarPokemon();
                        break;
                    case menu.Mostrar:
                        acciones.Pokedex();
                        break;
                    case menu.Actualizar:
                        Console.WriteLine("ACTUALIZANDO POKEDEX");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();
                        Console.WriteLine("VIEJO ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("NUEVO ID: ");
                        int Id2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("NUEVO NOMBRE: ");
                        string Nom2 = Console.ReadLine();
                        Console.WriteLine("NUEVO TIPO: ");
                        string Tipo2 = Console.ReadLine();
                        Console.WriteLine("NUEVA HABILIDAD: ");
                        string Hab2 = Console.ReadLine();
                        Console.WriteLine("SHINY?: ");
                        bool Shiny2 = Convert.ToBoolean(Console.ReadLine());
                        acciones.ActualizarPokedex(id, Id2, Nom2, Tipo2, Hab2, Shiny2);
                        break;

                    case menu.Eliminar:
                        Console.WriteLine("ELIMINANDO ENTRADA EN LA POKEDEX");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();
                        Console.WriteLine("ID DEL POKEMON QUE DESEAS ELIMINAR: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        acciones.EliminarPokedex(Id);
                        break;
                }
            }
        }
        static menu Menu()
        {
            Console.WriteLine("Pokedex UNINTER V1.01");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine("1) Agregar Pokémon");
            Console.WriteLine("2) Mostrar Pokedex");
            Console.WriteLine("3) Actualizar Pokedex");
            Console.WriteLine("4) Eliminar entrada");
            menu opc = (menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
