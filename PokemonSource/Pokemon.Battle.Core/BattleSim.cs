using System;
using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;
using Pokemon.Combat.Core.Responses;
using Pokemon.Combat.Core.Services;

namespace Pokemon.Combat.Core
{
    public class BattleSim
    {
        private readonly PriorityDecider priorityDecider = new PriorityDecider();

        public StepResult StepBattle(Battle battle, TurnRequest trainer1Request, TurnRequest trainer2Request)
        {
            // TODO: Get priority.
            // TODO: Execute in order.
            // TODO: Create and return result.
            throw new NotImplementedException();
        }
    }
}