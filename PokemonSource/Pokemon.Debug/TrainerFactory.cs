using System;
using System.Collections.Generic;
using Pokemon.State.Models;

namespace Pokemon.Debug
{
    public static class TrainerFactory
    {
        public static PlayerState Create(string trainerName)
        {
            var pokemonId = Guid.NewGuid();

            var trainerState = new PlayerState
            {
                Id = Guid.NewGuid(),
                TrainerName = trainerName,
                Party = new[] {pokemonId},
                PokemonCollection = new List<PokemonState>
                {
                    new()
                    {
                        Id = pokemonId,
                        Name = "pokemon friend",
                        Health = 100,
                        Abilities = new[]
                        {
                            new AbilityState
                            {
                                Id = Guid.NewGuid(),
                                AbilityId = 0,
                                Points = 100,
                            }
                        }
                    }
                },
            };
            return trainerState;
        }
    }
}