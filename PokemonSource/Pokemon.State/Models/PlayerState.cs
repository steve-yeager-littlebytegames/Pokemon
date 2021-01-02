using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Pokemon.State.Models
{
    public class PlayerState
    {
        public Guid Id { get; set; }
        public string TrainerName { get; set; }
        public Guid[] Party { get; set; }
        public List<PokemonState> PokemonCollection { get; set; } = new(0);

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true});
        }

        public static PlayerState CreateDefault()
        {
            var starterId = Guid.NewGuid();

            return new PlayerState
            {
                TrainerName = "Ash",
                Party = new[]
                {
                    starterId, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty,
                },
                PokemonCollection = new List<PokemonState>
                {
                    new PokemonState
                    {
                        Id = starterId,
                        PokemonId = 0,
                        Name = "Bulby",
                        Health = 100,
                    }
                }
            };
        }
    }
}