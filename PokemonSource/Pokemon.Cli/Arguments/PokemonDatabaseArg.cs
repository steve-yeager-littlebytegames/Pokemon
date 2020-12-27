using System;
using CommandLine;
using Pokemon.Core;

namespace Pokemon.Cli.Arguments
{
    [Verb("pokemon", HelpText = "Show Pokemon database.")]
    public class PokemonDatabaseArg
    {
        public int Run(CoreSim coreSim)
        {
            Console.WriteLine(coreSim.GameData.ToString());
            return 0;
        }
    }
}