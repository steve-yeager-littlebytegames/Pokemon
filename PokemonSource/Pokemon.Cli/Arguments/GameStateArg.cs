using System;
using CommandLine;
using Pokemon.Core;

namespace Pokemon.Cli.Arguments
{
    [Verb("state", HelpText = "Show game state.")]
    public class GameStateArg
    {
        public int Run(CoreSim coreSim)
        {
            Console.WriteLine(coreSim.TrainerState.ToString());
            return 0;
        }
    }
}