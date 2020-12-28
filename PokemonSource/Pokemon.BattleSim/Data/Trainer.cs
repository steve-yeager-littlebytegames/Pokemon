using System;
using System.Linq;
using Pokemon.State.Models;

namespace Pokemon.BattleSim.Data
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ActivePokemonId { get; set; }
        public PokemonState[] Pokemon { get; set; }

        public PokemonState ActivePokemon => Pokemon.First(p => p.Id == ActivePokemonId);
    }
}