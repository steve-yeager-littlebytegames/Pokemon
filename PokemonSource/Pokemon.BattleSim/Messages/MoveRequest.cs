namespace Pokemon.BattleSim.Messages
{
    public class MoveRequest : BattleRequestMessage
    {
        public int SourcePokemonId { get; }
        public int TargetPokemonId { get; }
        public int MoveId { get; }

        public MoveRequest(int trainerId, int sourcePokemonId, int targetPokemonId, int moveId)
            : base(trainerId)
        {
            SourcePokemonId = sourcePokemonId;
            TargetPokemonId = targetPokemonId;
            MoveId = moveId;
        }
    }
}