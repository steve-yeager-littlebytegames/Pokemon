using System;

namespace Pokemon.Combat.Core.Requests
{
    internal class AbilityTurnRequest : TurnRequest
    {
        public Guid SourceMonsterId { get; }
        public Guid TargetPokemonId { get; }
        public Guid AbilityId { get; }

        public AbilityTurnRequest(Guid trainerId, Guid sourceMonsterId, Guid targetPokemonId, Guid abilityId)
            : base(trainerId)
        {
            SourceMonsterId = sourceMonsterId;
            TargetPokemonId = targetPokemonId;
            AbilityId = abilityId;
        }
    }
}