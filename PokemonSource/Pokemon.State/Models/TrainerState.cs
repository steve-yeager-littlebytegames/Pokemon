using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Pokemon.State.Models
{
    public class TrainerState
    {
        public Guid TrainerId { get; set; }
        public string TrainerName { get; set; }
        public Guid[] Party { get; set; }
        public List<PokemonState> PokemonCollection { get; set; } = new(0);

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true});
        }

        public static TrainerState CreateDefault()
        {
            var starterId = Guid.NewGuid();

            return new TrainerState
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