using System;

namespace Pokemon.Combat.Core.Requests
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