using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;
using Pokemon.Combat.Core.Responses;
using Pokemon.Combat.Core.Services;
using Pokemon.Gamedata;

namespace Pokemon.Combat.Core
{
    public class BattleSim
    {
        private readonly PriorityDecider priorityDecider = new();
        private readonly ProcessorFactory processorFactory = new();

        public StepResult StepBattle(Battle battle, TurnRequest trainer1Request, TurnRequest trainer2Request, GameData gameData)
        {
            var turnOrder = priorityDecider.GetTurnOrder(battle, trainer1Request, trainer2Request);

            foreach(var turnRequest in turnOrder)
            {
                var processor = processorFactory.CreateProcessor(turnRequest);
                var isValid = processor.IsRequestValid(turnRequest, battle, gameData);
                if(isValid)
                {
                    processor.ProcessRequest(turnRequest, battle, gameData);
                }
            }

            return StepResult.Create(battle);
        }
    }
}