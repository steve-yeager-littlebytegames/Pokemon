using Pokemon.Combat.Core.Models;
using Pokemon.Combat.Core.Requests;
using Pokemon.Gamedata;

namespace Pokemon.Combat.Core.Processors
{
    public abstract class TurnRequestProcessor<TMessage> : IAbilityProcessor where TMessage : TurnRequest
    {
        protected abstract bool InternalIsMessageValid(TMessage request, Battle battle, GameData gameData);
        protected abstract void InternalProcessMessage(TMessage request, Battle battle, GameData gameData);

        public bool IsRequestValid(TurnRequest request, Battle battle, GameData gameData) => InternalIsMessageValid((TMessage)request, battle, gameData);

        public void ProcessRequest(TurnRequest request, Battle battle, GameData gameData) => InternalProcessMessage((TMessage)request, battle, gameData);
    }
}