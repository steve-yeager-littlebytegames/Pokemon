using System;

namespace Pokemon.Battle.Core.Messages
{
    public class ItemTurnRequest : TurnRequest
    {
        public int ItemId { get; }
        public Guid TargetPokemonId { get; }

        public ItemTurnRequest(Guid trainerId, int itemId, Guid targetPokemonId)
            : base(trainerId)
        {
            ItemId = itemId;
            TargetPokemonId = targetPokemonId;
        }
    }
}