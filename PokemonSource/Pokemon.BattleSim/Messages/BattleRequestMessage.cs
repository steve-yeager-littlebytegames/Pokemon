namespace Pokemon.BattleSim.Messages
{
    public abstract class BattleRequestMessage
    {
        protected int TrainerId { get; }

        protected BattleRequestMessage(int trainerId)
        {
            TrainerId = trainerId;
        }
    }
}