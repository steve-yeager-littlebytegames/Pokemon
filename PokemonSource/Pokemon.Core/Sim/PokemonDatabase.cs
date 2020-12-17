using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pokemon.Core.Sim
{
    public class PokemonDatabase
    {
        public IReadOnlyList<Data.Pokemon> PokemonDefinitions { get; private set; } = Array.Empty<Data.Pokemon>();

        public void Load(string pokemonDatabasePath)
        {
            var allPokemonData = Directory.GetFiles(pokemonDatabasePath);
            var pokemonDefinitions = new List<Data.Pokemon>(allPokemonData.Length);

            foreach(var pokemonDataPath in allPokemonData)
            {
                var pokemonJson = File.ReadAllText(pokemonDataPath);
                var pokemon = JsonSerializer.Deserialize<Data.Pokemon>(pokemonJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    }
                });
                pokemonDefinitions.Add(pokemon!);
            }

            PokemonDefinitions = pokemonDefinitions;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(var pokemonDefinition in PokemonDefinitions)
            {
                builder.AppendLine(pokemonDefinition.ToString());
            }

            return builder.ToString();
        }
    }
}