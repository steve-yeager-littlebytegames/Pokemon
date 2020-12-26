using System;

namespace Pokemon.Core.Data
{
    public class Ability
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int MaxPoints { get; set; }
        public PokemonType PokemonType { get; set; }
        public AbilityCategory AbilityCategory { get; set; }
        public int Damage { get; set; }
    }
}