using System;

namespace Pokemon.BattleSim.Messages
{
    public abstract class BattleRequestMessage
    {
        public Guid TrainerId { get; }

        protected BattleRequestMessage(Guid trainerId)
        {
            TrainerId = trainerId;
        }
    }
}