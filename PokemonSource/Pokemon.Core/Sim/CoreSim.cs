namespace Pokemon.Core.Sim
{
    public class CoreSim
    {
        public PokemonDatabase PokemonDatabase { get; } = new PokemonDatabase();
        

        public void Load(string pokemonDatabasePath)
        {
            PokemonDatabase.Load(pokemonDatabasePath);
        }
    }
}