using System;

namespace Pokemon.Combat.Core.Requests
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