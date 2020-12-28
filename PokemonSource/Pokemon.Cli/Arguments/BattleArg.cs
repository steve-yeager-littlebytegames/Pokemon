using CommandLine;
using Pokemon.Core;
using Pokemon.Debug;

namespace Pokemon.Cli.Arguments
{
    [Verb("battle", HelpText = "Run a battle.")]
    public class BattleArg
    {
        public int Run(CoreSim coreSim)
        {
            var trainer1 = TrainerFactory.Create("Ash");
            var trainer2 = TrainerFactory.Create("Garry");

            coreSim.FightBattle(trainer1, trainer2);

            return 0;
        }
    }
}