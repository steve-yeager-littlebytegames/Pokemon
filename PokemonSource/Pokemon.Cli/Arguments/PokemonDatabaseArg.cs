using System;
using CommandLine;
using Pokemon.Core.Sim;

namespace Pokemon.Cli.Arguments
{
    [Verb("pokemon", HelpText = "Show Pokemon database.")]
    public class PokemonDatabaseArg
    {
        public int Run(CoreSim coreSim)
        {
            Console.WriteLine(coreSim.PokemonDatabase.ToString());
            return 0;
        }
    }
}