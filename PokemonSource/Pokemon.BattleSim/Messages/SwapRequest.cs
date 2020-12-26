namespace Pokemon.BattleSim.Messages
{
    public class SwapRequest : BattleRequestMessage
    {
        public int TargetPokemonId { get; }

        public SwapRequest(int trainerId, int targetPokemonId)
            : base(trainerId)
        {
            TargetPokemonId = targetPokemonId;
        }
    }
}