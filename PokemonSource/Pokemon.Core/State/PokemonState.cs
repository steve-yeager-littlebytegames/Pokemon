using System;
using Pokemon.Core.Data;

namespace Pokemon.Core.State
{
    public class PokemonState
    {
        public Guid Id { get; set; }
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public AbilityState[] Abilities { get; set; } = new AbilityState[4];
    }
}