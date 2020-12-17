namespace Pokemon.Core.State
{
    public class PokemonState
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
    }
}