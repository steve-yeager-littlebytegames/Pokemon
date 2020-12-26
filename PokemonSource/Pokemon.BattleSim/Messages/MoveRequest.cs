using System;

namespace Pokemon.BattleSim.Messages
{
    public class MoveRequest : BattleRequestMessage
    {
        public Guid SourcePokemonId { get; }
        public Guid TargetPokemonId { get; }
        public Guid MoveId { get; }

        public MoveRequest(Guid trainerId, Guid sourcePokemonId, Guid targetPokemonId, Guid moveId)
            : base(trainerId)
        {
            SourcePokemonId = sourcePokemonId;
            TargetPokemonId = targetPokemonId;
            MoveId = moveId;
        }
    }
}