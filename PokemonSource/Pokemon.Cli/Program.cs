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

            return Parser.Default.ParseArguments<PokemonDatabaseArg>(args)
                .MapResult(arg => arg.Run(coreSim), errors => 1);

            //var coreSim = new CoreSim("D:\\Projects\\Git\\Pokemon\\PokemonSource\\GameData");

            //while(true)
            //{
            //    coreSim.Load();
            //    coreSim.Save();
            //    Console.Write(coreSim.PokemonDatabase.ToString());
            //    Console.ReadKey();
            //}
        }
    }
}