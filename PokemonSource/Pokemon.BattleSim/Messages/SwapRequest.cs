using System;

namespace Pokemon.BattleSim.Messages
{
    public class SwapRequest : BattleRequestMessage
    {
        public Guid TargetPokemonId { get; }

        public SwapRequest(Guid trainerId, Guid targetPokemonId)
            : base(trainerId)
        {
            TargetPokemonId = targetPokemonId;
        }
    }
}