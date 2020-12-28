using System;
using System.Linq;
using Pokemon.State.Models;

namespace Pokemon.BattleSim.Data
{
    public class BattleState
    {
        public int TurnNumber { get; set; }
        public Trainer Trainer1 { get; set; }
        public Trainer Trainer2 { get; set; }

        public Trainer GetTrainer(Guid trainerId) => Trainer1.Id == trainerId ? Trainer1 : Trainer2;

        public PokemonState GetPokemon(Guid pokemonId)
        {
            var pokemon = Trainer1.Pokemon.FirstOrDefault(p => p.Id == pokemonId);
            return pokemon ?? Trainer2.Pokemon.FirstOrDefault(p => p.Id == pokemonId);
        }
    }
}