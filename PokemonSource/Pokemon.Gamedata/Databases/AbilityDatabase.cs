using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Pokemon.Gamedata.Models;

namespace Pokemon.Gamedata.Databases
{
    public class AbilityDatabase
    {
        public IReadOnlyList<Ability> AbilityDefinitions { get; private set; } = Array.Empty<Ability>();

        public Ability this[int abilityId] => AbilityDefinitions.First(a => a.Id == abilityId);

        public void Load(string abilityDatabasePath)
        {
            var allAbilityData = Directory.GetFiles(abilityDatabasePath);
            var abilityDefinitions = new List<Ability>(allAbilityData.Length);

            foreach(var abilityDataPath in allAbilityData)
            {
                var abilityJson = File.ReadAllText(abilityDataPath);
                var ability = JsonSerializer.Deserialize<Ability>(abilityJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    }
                });
                abilityDefinitions.Add(ability!);
            }

            AbilityDefinitions = abilityDefinitions;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(var abilityDefinition in AbilityDefinitions)
            {
                builder.AppendLine(abilityDefinition.ToString());
            }

            return builder.ToString();
        }
    }
}