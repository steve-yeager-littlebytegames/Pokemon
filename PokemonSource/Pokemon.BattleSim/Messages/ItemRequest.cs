using System;

namespace Pokemon.BattleSim.Messages
{
    public class ItemRequest : BattleRequestMessage
    {
        public int ItemId { get; }
        public Guid TargetPokemonId { get; }

        public ItemRequest(Guid trainerId, int itemId, Guid targetPokemonId)
            : base(trainerId)
        {
            ItemId = itemId;
            TargetPokemonId = targetPokemonId;
        }
    }
}