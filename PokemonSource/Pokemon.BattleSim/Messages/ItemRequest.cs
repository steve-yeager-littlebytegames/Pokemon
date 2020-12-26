namespace Pokemon.BattleSim.Messages
{
    public class ItemRequest : BattleRequestMessage
    {
        public string ItemId { get; }
        public int TargetPokemonId { get; }

        public ItemRequest(int trainerId, string itemId, int targetPokemonId)
            : base(trainerId)
        {
            ItemId = itemId;
            TargetPokemonId = targetPokemonId;
        }
    }
}