using System;
using System.IO;
using System.Text.Json;
using Pokemon.Battle.State.Contexts;
using Pokemon.Battle.State.Models;
using Pokemon.Gamedata;
using Pokemon.State.Models;

namespace Pokemon.Core
{
    public class CoreSim
    {
        private const string GameStatePath = "game_state.json";
        private readonly string dataPath;
        private readonly StateDb battleStateDb;

        public GameData GameData { get; }
        public TrainerState TrainerState { get; private set; } = null!;

        private CoreSim(string dataPath, GameData gameData)
        {
            GameData = gameData;
            this.dataPath = dataPath;
            battleStateDb = new StateDb();
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

        public void StartBattle(Guid trainer1Id, Guid trainer2Id)
        {
            var battleId = Guid.NewGuid();

            var battleState = new BattleState
            {
                Id = battleId,
                Trainer1 = trainer1,
                Trainer2 = trainer2,
                TurnNumber = 0,
            };

            var battleMetadata = new BattleMetadata
            {
                Id = battleId,
            };

            battleStateDb.Add(battleState);
            battleStateDb.Add(battleMetadata);
            // TODO: Make async.
            battleStateDb.SaveChanges();
        }

        public void FightRound(BattleState battleState)
        {

        }
    }
}