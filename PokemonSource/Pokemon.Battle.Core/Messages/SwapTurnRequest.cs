using System;

namespace Pokemon.Battle.Core.Messages
{
    public class SwapTurnRequest : TurnRequest
    {
        public Guid TargetPokemonId { get; }

        public SwapTurnRequest(Guid trainerId, Guid targetPokemonId)
            : base(trainerId)
        {
            TargetPokemonId = targetPokemonId;
        }
    }
}