using CommandLine;
using Pokemon.Combat.Core;
using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Responses;
using Pokemon.Combat.Debug;
using Pokemon.Core;
using Pokemon.Gamedata;

namespace Pokemon.Cli.Arguments
{
    [Verb("battle", HelpText = "Run a battle.")]
    public class BattleArg
    {
        public int Run(CoreSim coreSim)
        {
            var trainer1 = TrainerFactory.Create("Ash");
            var trainer2 = TrainerFactory.Create("Garry");

            var battleId = coreSim.StartBattle(trainer1.Id, trainer2.Id);

            // TODO: Load gamedata path.
            var gameData = GameData.Load("");
            var battleSim = new BattleSim();
            StepResult stepResult;
            var battle = new Battle(battleId, trainer1, trainer2);

            do
            {
                var request1 = AbilityTurnRequestFactory.Create();
                var request2 = AbilityTurnRequestFactory.Create();
                stepResult = battleSim.StepBattle(battle, request1, request2, gameData);
            } while(!stepResult.IsBattleOver);

            return 0;
        }
    }
}