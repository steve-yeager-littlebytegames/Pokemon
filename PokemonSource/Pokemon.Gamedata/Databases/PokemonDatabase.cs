using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pokemon.Gamedata.Databases
{
    public class PokemonDatabase
    {
        public IReadOnlyList<Models.Pokemon> PokemonDefinitions { get; private set; } = Array.Empty<Models.Pokemon>();

        public void Load(string pokemonDatabasePath)
        {
            var allPokemonData = Directory.GetFiles(pokemonDatabasePath);
            var pokemonDefinitions = new List<Models.Pokemon>(allPokemonData.Length);

            foreach(var pokemonDataPath in allPokemonData)
            {
                var pokemonJson = File.ReadAllText(pokemonDataPath);
                var pokemon = JsonSerializer.Deserialize<Models.Pokemon>(pokemonJson, new JsonSerializerOptions
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