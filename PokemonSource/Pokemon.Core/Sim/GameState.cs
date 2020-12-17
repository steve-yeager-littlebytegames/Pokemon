using System.Collections.Generic;
using System.Text.Json;
using Pokemon.Core.State;

namespace Pokemon.Core.Sim
{
    public class GameState
    {
        public string TrainerName { get; set; }
        public int[] Party { get; set; }
        public List<PokemonState> PokemonCollection { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public static GameState CreateDefault()
        {
            return new GameState
            {
                TrainerName = "Ash",
                Party = new[]
                {
                    0, -1, -1, -1, -1, -1
                },
                PokemonCollection = new List<PokemonState>
                {
                    new PokemonState
                    {
                        Id = 0,
                        PokemonId = 0,
                        Name = "Bulby",
                        Health = 100,
                    }
                }
            };
        }
    }
}