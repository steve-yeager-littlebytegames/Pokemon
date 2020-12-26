using System;
using System.Text.Json;

namespace Pokemon.Core.Data
{
    [Serializable]
    public class Pokemon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public PokemonType Element { get; set; }
        public Stats Stats { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}