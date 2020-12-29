using System;

namespace Pokemon.Battle.Core.Messages
{
    public abstract class TurnRequest
    {
        public Guid TrainerId { get; }

        protected TurnRequest(Guid trainerId)
        {
            TrainerId = trainerId;
        }
    }
}