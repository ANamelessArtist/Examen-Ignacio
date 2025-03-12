using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Ignacio
{
    internal class Acciones
    {
        public List<Pokemon> listapokedex = new List<Pokemon> ();
        Pokemon poke = new Pokemon();

        public void AgregarPokemon()
        {
            Console.WriteLine("Numero de ID: ");
            poke.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de Pokemon: ");
            poke.Nombre = Console.ReadLine();
            Console.WriteLine("Tipo de Pokemon: ");
            poke.Tipo = Console.ReadLine();
            Console.WriteLine("Habilidad del Pokemon: ");
            poke.Habilidad = Console.ReadLine();
            Console.WriteLine("Es shiny?");
            poke.Shiny = Convert.ToBoolean(Console.ReadLine());

            listapokedex.Add(new Pokemon(poke.Id,poke.Nombre,poke.Tipo,poke.Habilidad,poke.Shiny));
        }

        public void Pokedex()
        {
            Console.WriteLine("POKEDEX");
            Console.WriteLine("-------");
            Console.WriteLine();
            foreach (var poke in listapokedex)
            {
                Console.WriteLine($"ID: {poke.Id}");
                Console.WriteLine($"NOMBRE: {poke.Nombre}");
                Console.WriteLine($"TIPO: {poke.Tipo}");
                Console.WriteLine($"HABILIDAD: {poke.Habilidad}");
                Console.WriteLine($"SHINY: {poke.Shiny}");
                Console.WriteLine();
            }
        }
        public void ActualizarPokedex(int id, int Id2, string Nom2, string Tipo2, string Hab2, bool Shiny2)
        {
            var pokemon = listapokedex.Find(x => x.Id == id);
            if (pokemon != null)
            {
                pokemon.Id = Id2;
                pokemon.Nombre = Nom2;
                pokemon.Tipo = Tipo2;
                pokemon.Habilidad = Hab2;
                pokemon.Shiny = Shiny2;
            }
            else
            {
                Console.WriteLine("POKEMON 404");
            }
        }
        public void EliminarPokedex(int Id)
        {
            var pokemon = listapokedex.Find(x => x.Id == Id);
            if ( pokemon != null )
            {
                listapokedex.Remove(pokemon);
            }
            else
            {
                Console.WriteLine("MISSING.NO");
            }
        }
    }
}
