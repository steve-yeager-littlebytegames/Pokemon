using System;
using Pokemon.Core.State;

namespace Pokemon.BattleSim.Data
{
    public class Trainer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ActivePokemon { get; set; }
        public PokemonState[] Pokemon { get; set; }
    }
}