using Pokemon.Combat.Core.Models;

namespace Pokemon.Combat.Core.Responses
{
    public class StepResult
    {
        public bool IsBattleOver { get; }

        private StepResult(bool isBattleOver)
        {
            IsBattleOver = isBattleOver;
        }

        public static StepResult Create(Battle battle)
        {
            var result = new StepResult(!battle.Trainer1.HasAliveMonsters && !battle.Trainer2.HasAliveMonsters);
            return result;
        }
    }
}