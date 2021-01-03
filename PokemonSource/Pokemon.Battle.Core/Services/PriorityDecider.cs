using System;
using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;

namespace Pokemon.Combat.Core.Services
{
    internal class PriorityDecider
    {
        public TurnRequest[] GetTurnOrder(Battle battle, TurnRequest trainer1Request, TurnRequest trainer2Request)
        {
            if(trainer1Request is AbilityTurnRequest turnRequest1 && trainer2Request is AbilityTurnRequest turnRequest2)
            {
                var turnOrder = new TurnRequest[2];
                var source1 = battle.GetMonster(turnRequest1.SourceMonsterId);
                var source2 = battle.GetMonster(turnRequest2.SourceMonsterId);

                // TODO: Replace with stats.
                if(source1.DataId > source2.DataId)
                {
                    turnOrder[0] = trainer1Request;
                    turnOrder[1] = trainer2Request;
                }
                else
                {
                    turnOrder[0] = trainer2Request;
                    turnOrder[1] = trainer1Request;
                }

                return turnOrder;
            }

            throw new NotSupportedException("Currently only support Abilities");
        }
    }
}