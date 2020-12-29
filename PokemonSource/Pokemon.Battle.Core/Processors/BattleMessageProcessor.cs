using Pokemon.Battle.Core.Messages;
using Pokemon.Gamedata;

namespace Pokemon.Battle.Core.Processors
{
    public abstract class BattleMessageProcessor<TMessage> : IBattleMessageProcessor where TMessage : TurnRequest
    {
        protected abstract bool InternalIsMessageValid(TMessage request, BattleState state, GameData gameData);
        protected abstract void InternalProcessMessage(TMessage request, BattleState state, GameData gameData);

        public bool IsMessageValid(TurnRequest message, BattleState state, GameData gameData) => InternalIsMessageValid((TMessage)message, state, gameData);

        public void ProcessMessage(TurnRequest message, BattleState state, GameData gameData) => InternalProcessMessage((TMessage)message, state, gameData);
    }
}