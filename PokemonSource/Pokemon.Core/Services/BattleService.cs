using System;
using System.Linq;
using Pokemon.Combat.Core.Requests;
using Pokemon.Combat.State.Contexts;
using Pokemon.Combat.State.Models;
using Pokemon.State.Models;

namespace Pokemon.Core.Services
{
    public class BattleService
    {
        private readonly BattleStateDb battleStateDb = new BattleStateDb();

        public BattleMetadata CreateBattle(TrainerState trainer1, TrainerState trainer2)
        {
            var battleId = Guid.NewGuid();

            var battleState = new BattleState
            {
                Id = battleId,
                Trainer1 = trainer1,
                Trainer2 = trainer2,
            };

            var battleMetadata = new BattleMetadata
            {
                Id = battleId,
            };

            battleStateDb.Add(battleState);
            battleStateDb.Add(battleMetadata);
            // TODO: Make async.
            battleStateDb.SaveChanges();

            return battleMetadata;
        }

        public BattleMetadata QueueTurn(Guid battleId, TurnRequest request)
        {
            /*
             * load metadata
             * add turn
             * save
             * if neither are null
             * then return ready
             */
            var battleMetadata = battleStateDb.BattleMetadata.Find(battleId);
            // add turn
            battleStateDb.SaveChanges();
            //var turnIsReady = battleMetadata
            #error fill out steps

            throw new NotImplementedException();
        }
    }
}