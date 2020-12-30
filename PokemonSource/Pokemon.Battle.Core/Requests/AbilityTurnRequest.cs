using System;

namespace Pokemon.Combat.Core.Requests
{
    internal class AbilityTurnRequest : TurnRequest
    {
        public Guid SourcePokemonId { get; }
        public Guid TargetPokemonId { get; }
        public Guid AbilityId { get; }

        public AbilityTurnRequest(Guid trainerId, Guid sourcePokemonId, Guid targetPokemonId, Guid abilityId)
            : base(trainerId)
        {
            SourcePokemonId = sourcePokemonId;
            TargetPokemonId = targetPokemonId;
            AbilityId = abilityId;
        }
    }
}