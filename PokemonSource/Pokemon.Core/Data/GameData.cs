using System.IO;

namespace Pokemon.Core.Data
{
    public class GameData
    {
        public PokemonDatabase PokemonDefinitions { get; }
        public AbilityDatabase AbilityDefinitions { get; }

        private GameData(PokemonDatabase pokemonDefinitions, AbilityDatabase abilityDefinitions)
        {
            PokemonDefinitions = pokemonDefinitions;
            AbilityDefinitions = abilityDefinitions;
        }

        public static GameData Load(string folderPath)
        {
            var pokemon = new PokemonDatabase();
            pokemon.Load(Path.Combine(folderPath, "Pokemon"));

            var abilities = new AbilityDatabase();
            abilities.Load(Path.Combine(folderPath, "Abilities"));

            return new GameData(pokemon, abilities);
        }
    }
}