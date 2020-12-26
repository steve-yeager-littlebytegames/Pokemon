using System.IO;
using System.Text.Json;

namespace Pokemon.Core.Sim
{
    public class CoreSim
    {
        private const string PokemonDatabasePath = "Pokemon";
        private const string GameStatePath = "game_state.json";
        private readonly string dataPath;

        public PokemonDatabase PokemonDatabase { get; } = new PokemonDatabase();
        public TrainerState TrainerState { get; private set; } = new TrainerState();

        public CoreSim(string dataPath)
        {
            this.dataPath = dataPath;
        }

        public void Load()
        {
            LoadPokemonDatabase();
            LoadGameState();

            void LoadPokemonDatabase()
            {
                var path = Path.Combine(dataPath, PokemonDatabasePath);
                PokemonDatabase.Load(path);
            }

            void LoadGameState()
            {
                string path = Path.Combine(dataPath, GameStatePath);
                if(File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    TrainerState = JsonSerializer.Deserialize<TrainerState>(json)!;
                }
                else
                {
                    TrainerState = TrainerState.CreateDefault();
                }
            }
        }

        public void Save()
        {
            string filePath = Path.Combine(dataPath, GameStatePath);
            var gameStateJson = JsonSerializer.Serialize(TrainerState, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(filePath, gameStateJson);
        }
    }
}