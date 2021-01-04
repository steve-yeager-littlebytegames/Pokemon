using System;
using Pokemon.Combat.Core.Processors;
using Pokemon.Combat.Core.Requests;

namespace Pokemon.Combat.Core.Services
{
    public class ProcessorFactory
    {
        public IAbilityProcessor CreateProcessor(TurnRequest turnRequest)
        {
            if(turnRequest is AbilityTurnRequest)
            {
                return new AbilityProcessor();
            }

            throw new NotSupportedException($"Only support {nameof(AbilityTurnRequest)}.");
        }
    }
}