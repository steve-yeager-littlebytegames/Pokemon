using System;

namespace Pokemon.BattleSim.Messages
{
    public class AbilityRequest : BattleRequestMessage
    {
        public Guid SourcePokemonId { get; }
        public Guid TargetPokemonId { get; }
        public Guid AbilityId { get; }

        public AbilityRequest(Guid trainerId, Guid sourcePokemonId, Guid targetPokemonId, Guid abilityId)
            : base(trainerId)
        {
            SourcePokemonId = sourcePokemonId;
            TargetPokemonId = targetPokemonId;
            AbilityId = abilityId;
        }
    }
}