using System;
using CommandLine;
using Pokemon.Core.Sim;

namespace Pokemon.Cli.Arguments
{
    [Verb("state", HelpText = "Show game state.")]
    public class GameStateArg
    {
        public int Run(CoreSim coreSim)
        {
            Console.WriteLine(coreSim.GameState.ToString());
            return 0;
        }
    }
}