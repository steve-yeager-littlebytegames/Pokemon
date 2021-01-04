using System;
using System.IO;
using System.Text.Json;
using Pokemon.Combat.State.Models;
using Pokemon.Gamedata;
using Pokemon.State.Models;

namespace Pokemon.Core
{
    public class CoreSim
    {
        private const string GameStatePath = "game_state.json";
        private readonly string dataPath;

        public GameData GameData { get; }
        public PlayerState TrainerState { get; private set; } = null!;

        private CoreSim(string dataPath, GameData gameData)
        {
            GameData = gameData;
            this.dataPath = dataPath;
        }

        public static CoreSim Create(string dataPath)
        {
            var gameData = GameData.Load(Path.Combine(dataPath, "GameData"));
            var coreSim = new CoreSim(dataPath, gameData);
            coreSim.Load();
            return coreSim;
        }

        public void Load()
        {
            LoadGameState();

            void LoadGameState()
            {
                string path = Path.Combine(dataPath, GameStatePath);
                if(File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    TrainerState = JsonSerializer.Deserialize<PlayerState>(json)!;
                }
                else
                {
                    TrainerState = PlayerState.CreateDefault();
                }
            }
        }

        public void Save()
        {
            string filePath = Path.Combine(dataPath, GameStatePath);
            var gameStateJson = JsonSerializer.Serialize(TrainerState, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(filePath, gameStateJson);
        }

        public Guid StartBattle(Guid trainer1Id, Guid trainer2Id)
        {
            // TODO: Create battle.
            return Guid.Empty;
        }

        public void FightRound(Guid battleId)
        {
        }
    }
}