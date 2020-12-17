using System;
using Pokemon.Core.Sim;

namespace Pokemon.Cli
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var coreSim = new CoreSim();

            while(true)
            {
                coreSim.Load("D:\\Projects\\Git\\Pokemon\\PokemonSource\\GameData\\Pokemon");
                Console.Write(coreSim.PokemonDatabase.ToString());
                Console.ReadKey();
            }
        }
    }
}