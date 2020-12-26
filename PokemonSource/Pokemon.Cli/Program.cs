using CommandLine;
using Pokemon.Cli.Arguments;
using Pokemon.Core.Sim;

namespace Pokemon.Cli
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            var coreSim = new CoreSim("D:\\Projects\\Git\\Pokemon\\PokemonSource\\GameData");
            coreSim.Load();

            return Parser.Default.ParseArguments<PokemonDatabaseArg, GameStateArg>(args)
                .MapResult(
                    (PokemonDatabaseArg arg) => arg.Run(coreSim),
                    (GameStateArg arg) => arg.Run(coreSim),
                    _ => 1);
        }
    }
}